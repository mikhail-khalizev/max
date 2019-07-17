using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Kaitai;
using MikhailKhalizev.Max.Dos;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;

namespace MikhailKhalizev.Max.Program
{
    public class RawProgramMain : BridgeProcessor
    {
        public new Processor.x86.FullSimulate.Processor Implementation { get; }
        public ConfigurationDto Configuration { get; }
        public MethodInfos MethodInfos { get; private set; }

        public Memory DosMemory { get; }
        public Interrupt DosInterrupt { get; }
        public Timer DosTimer { get; }

        public MultiValueDictionary<Address, MyMethodInfo> funcs_by_pc = new MultiValueDictionary<Address, MyMethodInfo>();

        public bool extra_log { get; set; } = true;

        public const ushort image_load_seg = 0x1a2; // Const from dosbox.
        public const ushort pspseg = image_load_seg - 16; // 0x192

        public RawProgramMain(ConfigurationDto configuration)
            : this(new Processor.x86.FullSimulate.Processor(), configuration)
        { }

        public RawProgramMain(Processor.x86.FullSimulate.Processor implementation, ConfigurationDto configuration)
            : base(implementation)
        {
            Implementation = implementation;
            Configuration = configuration;

            DosMemory = new Memory(implementation);
            DosInterrupt = new Interrupt(implementation);
            DosTimer = new Timer(implementation);

            implementation.run_func += run_func;
        }

        public void Start()
        {
            MethodInfos = MethodInfos.Load(Configuration.BinToCSharp);
            
            foreach (var bridgeProcessor in GetType().Assembly.GetTypes().Where(x => typeof(BridgeProcessor).IsAssignableFrom(x)))
            {
                object instance = null;

                foreach (var methodInfo in bridgeProcessor.GetMethods(BindingFlags.Instance | BindingFlags.Public))
                {
                    var a = methodInfo.GetCustomAttribute<MethodInfoAttribute>();
                    if (a == null)
                        continue;

                    var mi = MethodInfos.GetByGuid(a.Guid);

                    if (instance == null)
                        instance = Activator.CreateInstance(bridgeProcessor, Implementation);

                    var fi = new MyMethodInfo();
                    fi.MethodInfo = mi;
                    fi.Name = methodInfo.Name;
                    fi.Action = () => methodInfo.Invoke(instance, Array.Empty<object>());

                    foreach (var address in mi.Addresses)
                        funcs_by_pc.Add(address, fi);
                }
            }
            
            init_x86_dos_prog();
            Implementation.correct_function_position(0);
        }

        public void init_x86_dos_prog()
        {
            var exeBytes = File.ReadAllBytes(Path.Combine(Configuration.Max.InstalledPath, Configuration.Max.ExeFileName));
            var dosMz = new DosMz(exeBytes);


            if (!dosMz.IsCorrect)
                throw new Exception();

            DosMemory.dos_mem_init();

            // Alloc dos - dummy.

            bx = pspseg - 2; // internal alloc logic
            DosMemory.dos_mem_alloc();
            if (eflags.cf)
                throw new Exception();

            // Alloc image.

            var exe_image_off = dosMz.ExeDataStart;
            var image_size = dosMz.ExeDataLength;

            bx = (image_size + 15) / 16 + 16; // psp_size
            DosMemory.dos_mem_alloc();
            if (eflags.cf)
                throw new Exception();

            if (ax.UInt16 != pspseg)
                throw new Exception();

            ds.Load(image_load_seg);

            var image = Implementation.Memory.GetFixSize(ds, 0, image_size);

            // Upload image of program.

            exeBytes.AsSpan().Slice(exe_image_off, image_size).CopyTo(image);

            // Apply realoc.

            foreach (var relocation in dosMz.Relocations)
            {
                var addr = relocation.Seg * 16 + relocation.Ofs;

                if (image_size <= addr + 1)
                    throw new Exception();

                var val = image.GetUInt16(addr);
                image.SetUInt16(val + image_load_seg, addr);
            }

            // set psp

            var evnseg = pspseg - 0xa; // 0x188
            var evn_init = new byte[]
            {
                // PATH=Z:\\
                0x50, 0x41, 0x54, 0x48, 0x3d, 0x5a, 0x3a, 0x5c, 0x0,

                // COMSPEC=Z:\\COMMAND.COM
                0x43, 0x4f, 0x4d, 0x53, 0x50, 0x45, 0x43, 0x3d, 0x5a, 0x3a, 0x5c, 0x43,
                0x4f, 0x4d, 0x4d, 0x41, 0x4e, 0x44, 0x2e, 0x43, 0x4f, 0x4d, 0x0,

                // BLASTER=A220 I7 D1 H5 T6 // Port Address - 220, Interrupt - 7, DMA Channel - 1, "High" DMA Channel - 5, Type of Card - 6.
                0x42, 0x4c, 0x41, 0x53, 0x54, 0x45, 0x52, 0x3d, 0x41, 0x32, 0x32,
                0x30, 0x20, 0x49, 0x37, 0x20, 0x44, 0x31, 0x20, 0x48, 0x35, 0x20,
                0x54, 0x36, 0x0,

                0x0, 0x1, 0x0,

                // C:\\MAXRUN.EXE
                0x43, 0x3a, 0x5c, 0x4d, 0x41, 0x58, 0x52, 0x55, 0x4e, 0x2e, 0x45,
                0x58, 0x45, 0x0
            };

            ds.Load(evnseg);
            evn_init.CopyTo(
                Implementation.Memory
                    .GetFixSize(ds, 0, evn_init.Length)
                    .AsSpan());

            ds.Load(pspseg); // 0x192
            memb_a16[ds, 0x81] = 0xd; // Empty command-line (terminated by a 0x0D).
            memw_a16[ds, 0x2c] = evnseg;

            // Terminate address of previous program.
            // memw_a16(ds, 0xa) = 0x20c8;
            // memw_a16(ds, 0xa + 2) = 0xf000;

            ds.Load(evnseg - 1); // 0x187
            memb_a16[ds, 0] = 0x4d; // Не знаю, что это.
            memw_a16[ds, 1] = pspseg;
            memw_a16[ds, 3] = 0x9;

            ds.Load(pspseg - 1); // 0x191
            // memw_a16(ds, 0x3) = 0x1346 - 0x191;
            memw_a16[ds, 0x3] = 0xc02 - 0x191;


            DosInterrupt.install_std_ints();


            // Устанавливаем начальные значения в регистры.

            ds.Load(pspseg);
            es = ds;

            ss.Load(image_load_seg + dosMz.Hdr.InitialSs);
            sp = dosMz.Hdr.InitialSp;

            cs.Load(image_load_seg + dosMz.Hdr.InitialCs);
            eip = dosMz.Hdr.InitialIp;
            CurrentInstructionAddress = dosMz.Hdr.InitialIp;

            eax = 0;
            ebx = 0;
            ecx = 0xff;
            edx = pspseg;

            esi = 0x2382;
            edi = 0x340;
            ebp = 0x91c;

            eflags.UInt32 = 0x7202;


            DosTimer.timers_init();
        }

        public void run_func(object sender, EventArgs e)
        {
            var run = cs[eip];

            // "--on-run-func={none, dump-reg}"
            var on_run_func__dump_reg = true;

            if (on_run_func__dump_reg)
            {
                Console.WriteLine(
                    $"before run 0x{run:x}" +
                    $", eax: 0x{eax.UInt32:x}" +
                    $", ebx: 0x{ebx.UInt32:x}" +
                    $", ecx: 0x{ecx.UInt32:x}" +
                    $", edx: 0x{edx.UInt32:x}" +
                    $", esi: 0x{esi.UInt32:x}" +
                    $", edi: 0x{edi.UInt32:x}" +
                    $", esp: 0x{esp.UInt32:x}" +
                    $", ebp: 0x{ebp.UInt32:x}" +
                    $", ds: 0x{ds.Selector:x}" +
                    $", es: 0x{es.Selector:x}" +
                    $", cs: 0x{cs.Selector:x}" +
                    $", ss: 0x{ss.Selector:x}" +
                    $", fs: 0x{fs.Selector:x}" +
                    $", gs: 0x{gs.Selector:x}");
            }

            var info = get_func(cs, eip);

            if (extra_log)
                Console.WriteLine($"run {info.Name} {{{info.MethodInfo.Guid}}}");

            Implementation.CSharpFunctionDelta = (int)(cs.Descriptor.Base + eip - info.MethodInfo.Address);
            Implementation.CSharpEmulateMode = (int)info.MethodInfo.Mode;
            Implementation.check_mode();

            add_to_used_func_list(run, (cs.db ? 32 : 16));
            info.Action();

            if (on_run_func__dump_reg)
            {
                Console.WriteLine(
                    $"after run 0x{run:x}" +
                    $", eax: 0x{eax.UInt32:x}" +
                    $", ebx: 0x{ebx.UInt32:x}" +
                    $", ecx: 0x{ecx.UInt32:x}" +
                    $", edx: 0x{edx.UInt32:x}" +
                    $", esi: 0x{esi.UInt32:x}" +
                    $", edi: 0x{edi.UInt32:x}" +
                    $", esp: 0x{esp.UInt32:x}" +
                    $", ebp: 0x{ebp.UInt32:x}" +
                    $", ds: 0x{ds.Selector:x}" +
                    $", es: 0x{es.Selector:x}" +
                    $", cs: 0x{cs.Selector:x}" +
                    $", ss: 0x{ss.Selector:x}" +
                    $", fs: 0x{fs.Selector:x}" +
                    $", gs: 0x{gs.Selector:x}");
            }
        }

        private MyMethodInfo get_func(SegmentRegister seg, Address addr)
        {
            if (seg[addr] == 0)
                throw new InvalidOperationException("Запрос функции по нулевому указателю.");

            var ret = find_func_exact(seg, addr);
            if (ret != null)
                return ret;

            ret = find_func_from_known_and_remember_it(seg, addr);
            if (ret != null)
                return ret;

            // Всё-таки декодируем.
            decode_function(seg, addr);
            
            // TODO Update comment: Use in bash:  ERR=5 ; while [ $ERR == 5 ] ; do make -j8 && { rm /tmp/*.png ; time ./openmax ; } ; ERR=$? ; done
            Environment.Exit(5);

            // Просто так. На всякий случай.
            throw new InvalidOperationException("Функция не найдена.");
        }

        private MyMethodInfo find_func_exact(SegmentRegister seg, Address addr)
        {
            var infos = funcs_by_pc.GetValues(seg[addr], false);
            if (infos == null)
                return null;

            foreach (var info in infos)
            {
                if ((int)info.MethodInfo.Mode != (cs.db ? 32 : 16))
                    continue;

                if (Implementation.Memory.Equals(seg[addr], info.MethodInfo.RawBytes))
                    return info;
            }

            return null;
        }

        private MyMethodInfo find_func_from_known_and_remember_it(SegmentRegister seg, Address addr)
        {
            // Попробуем найти её среди известных.

            var infos = funcs_by_pc
                .SelectMany(x => x.Value)
                .Where(
                    info =>
                    {
                        var code = info.MethodInfo.RawBytes;
                        if (code.Length == 0)
                            return false;
                        if ((int)info.MethodInfo.Mode != (cs.db ? 32 : 16))
                            return false;
                        return true;
                    })
                .OrderByDescending(x => x.MethodInfo.RawBytes.Length);

            foreach (var info in infos)
            {
                if (string.IsNullOrEmpty(info.Name))
                    throw new InvalidOperationException("Код у функции есть, а его имя неизвестно.");
                
                var segAddr = seg[addr];
                if (!Implementation.Memory.Equals(segAddr, info.MethodInfo.RawBytes))
                    continue;
                
                // Всё хорошо. Запомним её, а затем сохраним в файл, чтоб в следующий раз не пришлось искать.

                funcs_by_pc.Add(segAddr, info);

                info.MethodInfo.Addresses.Add(segAddr);
                MethodInfos.Save();

                return info;
            }

            return null;
        }

        private void add_to_used_func_list(Address full_addr, int mode)
        {
            // TODO

            //static std::map<uint_<32>, uint_<8>> used_funcs; // <addr, bit mode>

            //if (used_funcs.empty())
            //    for (auto i = std::begin(used_funcs_known); i != std::end(used_funcs_known); i++)
            //        used_funcs.insert(std::make_pair(i->first, i->second));

            //auto ret = used_funcs.insert(std::make_pair(full_addr, mode));
            //ret.first->second = mode;
            //if (ret.second)
            //{
            //    std::fstream file("program/info/funcs_any_time_runs.hpp", std::ios_base::out);
            //    file << std::hex << std::showbase;
            //    for (auto & i : used_funcs)
            //    {
            //        file << "INFO(";
            //        /*bin_to_cxx::*/
            //        write_addr(file, i.first);
            //        file << ", " << static_cast < uint_ < 32 >> (i.second) << ")\n";
            //    }
            //}
        }

        private void decode_function(SegmentRegister seg, Address short_addr)
        {
            //    exit(1); // TODO "--on-unknown-func={decode-and-exit, exit}"

            var address = seg[short_addr];

            var to_cxx = new Engine(
                Configuration.BinToCSharp,
                Implementation.Memory,
                seg.db ? ArchitectureMode.x86_32 : ArchitectureMode.x86_16,
                seg.Descriptor.Base,
                ds.Descriptor.Base,
                MethodInfos);

            if (seg.Descriptor.Base != 0)
                to_cxx.SuppressDecode.Add(0, seg.Descriptor.Base);

            if (seg.Descriptor.Base + seg.Descriptor.Limit + 1 != 0)
                to_cxx.SuppressDecode.Add(seg.Descriptor.Base + seg.Descriptor.Limit + 1 + 1, 0);


            /* Аргументы следующим методам установлены опытным путём. */

            to_cxx.SetCStringDataArea(0x101a0003, 0x101b384d);

            to_cxx.AddForceEndFuncs(0x14b5b5);
            to_cxx.AddForceEndFuncs(0x14edfc);
            to_cxx.AddForceEndFuncs(0x14f88b);
            to_cxx.AddForceEndFuncs(0x14f8ef);
            to_cxx.AddForceEndFuncs(0x158748);

            
            AddressNameConverter.AddNamespace(new Interval<Address>(0x10165d52, 0x1019c3cd + 1), "sys");


            foreach (var pair in funcs_by_pc)
            foreach (var info in pair.Value)
                to_cxx.AddAlreadyDecodedFunc(info.MethodInfo);
            to_cxx.RemoveAlreadyDecodedFunc(address); // force decode.

            // TODO
#if false
    // Замечено, что многие функции начинаются со следующих двух команд.

    // {0x68, 0x28, 0, 0, 0,  0xe8, 0x90, 0xa1, 0xb, 0}
    // II(0x100abbb8, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    // II(0x100abbbd, 0x5)   calld(sys_check_available_stack_size, 0xb_a190); /* call 0x10165d52 */

    const Address code_start = 0x1007_0000;
    const Address code_end = 0x1016_5d52;

    static bool its_first = true;
    if (cs.Descriptor.Base == 0 && cs.db && its_first)
    {
        its_first = false;

        memory_space_const code;
        for (addr_type i = code_start; i < code_end; i++)
        {
            if (code.is_empty())
                code = mem_seg_pg_raw(seg, i, 1);

            if (code.get<uint_<8>>() == 0x68)
            {
                code = mem_seg_pg_raw(seg, i, 10);
                if (code.get<uint_<8>>(0, 5) == 0xe8 && (code.get<uint_<32>>(0, 6) + i + 10 == 0x1016_5d52)
                        && funcs_by_pc.find(i) == funcs_by_pc.end())
                    to_cxx.decode_func(i);
            }

            code = code.remove_prefix(1);
        }

        // extra
        to_cxx.decode_func(0x101481d4);
        to_cxx.decode_func(0x10165d4a);
        to_cxx.decode_func(0x10165eee);
        to_cxx.decode_func(0x1016609c);
        to_cxx.decode_func(0x10166114);
        to_cxx.decode_func(0x10168624);
        to_cxx.decode_func(0x10168690);
        to_cxx.decode_func(0x10168698);
        to_cxx.decode_func(0x1016a21c);
        to_cxx.decode_func(0x1016a320);
        to_cxx.decode_func(0x1016a4c4);
        to_cxx.decode_func(0x1016a4d0);
        to_cxx.decode_func(0x1016a514);
        to_cxx.decode_func(0x1016a568);
        to_cxx.decode_func(0x1016c9d0);
        to_cxx.decode_func(0x1016c9dc);
        to_cxx.decode_func(0x101712d0);
        to_cxx.decode_func(0x101714e0);
        to_cxx.decode_func(0x10171680);
        to_cxx.decode_func(0x10171810);
        to_cxx.decode_func(0x10171834);
        to_cxx.decode_func(0x10171c5c);
        to_cxx.decode_func(0x10172d9c);
        to_cxx.decode_func(0x10179690);
        to_cxx.decode_func(0x10179a00);
        to_cxx.decode_func(0x10179b80);
        to_cxx.decode_func(0x1017de6f);
        to_cxx.decode_func(0x1017df39);
        to_cxx.decode_func(0x10181cc4);
        to_cxx.decode_func(0x10181cc8);
        to_cxx.decode_func(0x10181ce1);
        to_cxx.decode_func(0x10181ce6);
        to_cxx.decode_func(0x10181f92);
        to_cxx.decode_func(0x10181fae);
        to_cxx.decode_func(0x10181fde);
        to_cxx.decode_func(0x101820a9);
        to_cxx.decode_func(0x101820c6);
        to_cxx.decode_func(0x10182113);
        to_cxx.decode_func(0x10182212);
        to_cxx.decode_func(0x1018224d);
        to_cxx.decode_func(0x10187ac2);
        to_cxx.decode_func(0x10187ad4);
        to_cxx.decode_func(0x10187b25);
        to_cxx.decode_func(0x10187b2b);
        to_cxx.decode_func(0x1018c980);
        to_cxx.decode_func(0x1018ca00);
        to_cxx.decode_func(0x1018cda8);
        to_cxx.decode_func(0x1018cdf4);
        to_cxx.decode_func(0x1018d034);
        to_cxx.decode_func(0x1018d304);
        to_cxx.decode_func(0x1018d9dc);
        to_cxx.decode_func(0x1018da9d);
        to_cxx.decode_func(0x1018dc3c);
        to_cxx.decode_func(0x1018dc67);
        to_cxx.decode_func(0x1018dd02);
        to_cxx.decode_func(0x1018dd5b);
        to_cxx.decode_func(0x1018e8dc);
        to_cxx.decode_func(0x1018e8e4);
        to_cxx.decode_func(0x1018e91c);
        to_cxx.decode_func(0x1018e924);
        to_cxx.decode_func(0x1018e928);
        to_cxx.decode_func(0x1018e935);
        to_cxx.decode_func(0x1018e948);
        to_cxx.decode_func(0x1018e95c);
        to_cxx.decode_func(0x1018e96c);
        to_cxx.decode_func(0x1018e9b0);
        to_cxx.decode_func(0x101900c4);
        to_cxx.decode_func(0x10190138);
        to_cxx.decode_func(0x101901f0);
        to_cxx.decode_func(0x1019026c);
        to_cxx.decode_func(0x10190280);
        to_cxx.decode_func(0x10194718);
        to_cxx.decode_func(0x101949bd);
        to_cxx.decode_func(0x10194c19);
        to_cxx.decode_func(0x1019661d);
        to_cxx.decode_func(0x10199a8a);
        to_cxx.decode_func(0x10199bb8);
        to_cxx.decode_func(0x1019a9b3);
        to_cxx.decode_func(0x1019aa71);
        to_cxx.decode_func(0x1019c3cd);
    }
#endif


            //#define PREDICTABLE_DECODE
            //    to_cxx.add_region_to_suppress_decode(0x10289000, 0); // Чтоб не выходил за пределы MAXRUN.EXE
            //    to_cxx.decode_area(code_start, code_end); // Весь код MAXRUN.EXE

            // TODO
#if false // PREDICTABLE_DECODE
            // Функции, когда либо запускавшиеся.
            for (auto i = std::begin(used_funcs_known); i != std::end(used_funcs_known); i++)
                if (i->second == (seg.get_db() ? 32 : 16)
                        && seg.fail_limit_check(i->first, 1) == false)
                {
                    std::cout << "Запуск декодирования функции '" << std::hex << std::showbase << i->first << "'." << std::endl;
                    to_cxx.decode(i->first);
                }
#endif

            Console.WriteLine($"Запуск декодирования функции '{address}'.");

            to_cxx.DecodeMethod(address);
            to_cxx.Save();
        }
    }

    public class MyMethodInfo
    {
        public MethodInfoDto MethodInfo { get; set; }

        public string Name { get; set; }

        public Action Action { get; set; }
    }
}