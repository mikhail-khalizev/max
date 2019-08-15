using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Kaitai;
using MikhailKhalizev.Max.Dos;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Core;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using ConfigurationDto = MikhailKhalizev.Max.Configuration.ConfigurationDto;

namespace MikhailKhalizev.Max.Program
{
    public class RawProgramMain : BridgeProcessor, IMethodCollection
    {
        public new Processor.x86.Core.Processor Implementation { get; }
        public ConfigurationDto Configuration { get; }
        public DefinitionCollection DefinitionCollection { get; } = new DefinitionCollection();
        public MethodsInfo MethodsInfo { get; private set; }

        public DosMemory DosMemory { get; }
        public DosInterrupt DosInterrupt { get; }
        public DosTimer DosTimer { get; }
        public DosPort DosPort { get; }
        public DosDma DosDma { get; }
        public DosPic DosPic { get; }

        public MultiValueDictionary<Address, MyMethodInfo> funcs_by_pc = new MultiValueDictionary<Address, MyMethodInfo>();

        public bool extra_log { get; set; } = false;

        public const ushort image_load_seg = 0x1a2; // Const from dosbox.
        public const ushort pspseg = image_load_seg - 16; // 0x192

        public RawProgramMain(ConfigurationDto configuration)
            : this(new Processor.x86.Core.Processor(configuration.Processor), configuration)
        { }

        public RawProgramMain(Processor.x86.Core.Processor implementation, ConfigurationDto configuration)
            : base(implementation)
        {
            Implementation = implementation;
            Configuration = configuration;

            DosMemory = new DosMemory(implementation, this);
            DosInterrupt = new DosInterrupt(implementation, this);
            DosTimer = new DosTimer(implementation, this);
            DosPort = new DosPort(implementation, this);
            DosDma = new DosDma(implementation, this);
            DosPic = new DosPic(implementation, this);

            implementation.MethodCollection = this;
            implementation.runInb += (sender, args) => DosPort.MyInb(args.value, args.port);
            implementation.runOutb += (sender, args) => DosPort.MyOutb(args.port, args.value);
            implementation.runIrqs += (sender, args) => DosPic.RunIrqs();
        }

        public void Start()
        {
            MethodsInfo = MethodsInfo.Load(Configuration.BinToCSharp);
            DefinitionCollection.AddDefinitionsClass<Definitions>();
            DefinitionCollection.AddDefinitionsClass<StringDefinitions>();
            Implementation.MethodsInfo = MethodsInfo;

            LoadDecodedMethods();
            DosInterrupt.Initialize();
            InitializeX86DosProgram();
            DosTimer.InitializeAndStart();

            Implementation.CorrectMethodPosition(0);
        }

        private void LoadDecodedMethods()
        {
            foreach (var bridgeProcessorType in GetType().Assembly.GetTypes().Where(x => typeof(BridgeProcessor).IsAssignableFrom(x)))
            {
                object instance = null;

                foreach (var methodInfo in bridgeProcessorType.GetMethods(BindingFlags.Instance | BindingFlags.Public))
                {
                    var a = methodInfo.GetCustomAttribute<MethodInfoAttribute>();
                    if (a == null)
                        continue;

                    var mi = MethodsInfo.GetByGuid(a.Guid);

                    if (instance == null)
                    {
                        instance = Activator.CreateInstance(bridgeProcessorType, Implementation);
                        foreach (var pi in bridgeProcessorType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(x => x.PropertyType == typeof(RawProgramMain)))
                            pi.SetValue(instance, this);
                    }

                    var fi = new MyMethodInfo();
                    fi.MethodInfo = mi;
                    fi.Action = (Action)methodInfo.CreateDelegate(typeof(Action), instance);

                    foreach (var address in mi.Addresses)
                        funcs_by_pc.Add(address, fi);
                }
            }
        }

        public void InitializeX86DosProgram()
        {
            cr0.UInt32 = 0x0010;

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

            ds.Selector = (image_load_seg);

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

            ds.Selector = (evnseg);
            evn_init.CopyTo(
                Implementation.Memory
                    .GetFixSize(ds, 0, evn_init.Length)
                    .AsSpan());

            ds.Selector = (pspseg); // 0x192
            memb_a16[ds, 0x81] = 0xd; // Empty command-line (terminated by a 0x0D).
            memw_a16[ds, 0x2c] = evnseg;

            // Terminate address of previous program.
            // memw_a16(ds, 0xa) = 0x20c8;
            // memw_a16(ds, 0xa + 2) = 0xf000;

            ds.Selector = (evnseg - 1); // 0x187
            memb_a16[ds, 0] = 0x4d; // Не знаю, что это.
            memw_a16[ds, 1] = pspseg;
            memw_a16[ds, 3] = 0x9;

            ds.Selector = (pspseg - 1); // 0x191
            // memw_a16(ds, 0x3) = 0x1346 - 0x191;
            memw_a16[ds, 0x3] = 0xc02 - 0x191;



            // Устанавливаем начальные значения в регистры.

            ds.Selector = (pspseg);
            es = ds;

            ss.Selector = (image_load_seg + dosMz.Hdr.InitialSs);
            sp = dosMz.Hdr.InitialSp;

            cs.Selector = (image_load_seg + dosMz.Hdr.InitialCs);
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
        }

        /// <inheritdoc />
        public void GetMethod(out MethodInfoDto methodInfo, out Action method)
        {
            var info = get_func(cs, eip);
            methodInfo = info.MethodInfo;
            method = info.Action;
        }

        private MyMethodInfo get_func(SegmentRegister seg, Address address)
        {
            var fullAddress = seg[address];
            if (fullAddress == 0)
                throw new InvalidOperationException("Запрос метода по нулевому указателю.");

            var ret = find_func_exact(fullAddress);
            if (ret != null)
                return ret;

            ret = find_func_from_known_and_remember_it(fullAddress);
            if (ret != null)
                return ret;

            // Всё-таки декодируем.
            DecodeNewMethod(seg, address);

            (Implementation as IDisposable)?.Dispose();
            Environment.Exit(5);

            // Просто так. На всякий случай.
            throw new InvalidOperationException("Метод не найдена.");
        }

        private MyMethodInfo find_func_exact(Address fullAddress)
        {
            var infos = funcs_by_pc.GetValues(fullAddress, false);
            if (infos == null)
                return null;

            foreach (var info in infos)
            {
                if ((int)info.MethodInfo.Mode != (cs.db ? 32 : 16))
                    continue;

                if (Implementation.Memory.Equals(fullAddress, info.MethodInfo.RawBytes))
                    return info;
            }

            return null;
        }

        private MyMethodInfo find_func_from_known_and_remember_it(Address fullAddress)
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
                if (!Implementation.Memory.Equals(fullAddress, info.MethodInfo.RawBytes))
                    continue;

                // Всё хорошо. Запомним её, а затем сохраним в файл, чтоб в следующий раз не пришлось искать.

                funcs_by_pc.Add(fullAddress, info);

                info.MethodInfo.Addresses.Add(fullAddress);
                MethodsInfo.Save();

                return info;
            }

            return null;
        }

        private void DecodeNewMethod(SegmentRegister seg, Address address)
        {
            //    exit(1); // TODO "--on-unknown-func={decode-and-exit, exit}"

            var fullAddress = seg[address];

            var to_cxx = new Engine(
                Configuration.BinToCSharp,
                DefinitionCollection,
                Implementation.Memory,
                seg.db ? ArchitectureMode.x86_32 : ArchitectureMode.x86_16,
                seg.Descriptor.Base,
                ds.Descriptor.Base,
                MethodsInfo);

            to_cxx.AddMethodInfoJumpsToDecode =
                false; // Код активно загружается в процессе работы, поэтому преждевременное декодирование приводит к ошибкам.
                // 32 <= Implementation.CSharpEmulateMode && cs.Descriptor.Base == 0; // Flat 32bit+ mode.

            if (seg.Descriptor.Base != 0)
                to_cxx.SuppressDecode.Add(0, seg.Descriptor.Base);

            if (seg.Descriptor.Base + seg.Descriptor.Limit + 1 != 0)
                to_cxx.SuppressDecode.Add(seg.Descriptor.Base + seg.Descriptor.Limit + 1 + 1, 0);

            to_cxx.SuppressDecode.Add(0x14f0_0000, 0);
            //    to_cxx.add_region_to_suppress_decode(0x10289000, 0); // Чтоб не выходил за пределы MAXRUN.EXE

            /* Аргументы следующим методам установлены опытным путём. */

            to_cxx.SetCStringDataArea(0x101a0003, 0x101b384d);

            to_cxx.AddForceEndFuncs(0xbb03);
            to_cxx.AddForceEndFuncs(0xbb6f);
            to_cxx.AddForceEndFuncs(0xbb73);
            to_cxx.AddForceEndFuncs(0x14_f4c7);
            to_cxx.AddForceEndFuncs(0x14_b5b5);
            to_cxx.AddForceEndFuncs(0x14_edfc);
            to_cxx.AddForceEndFuncs(0x14_f88b);
            to_cxx.AddForceEndFuncs(0x14_f8ef);
            to_cxx.AddForceEndFuncs(0x15_8748);


            AddressNameConverter.AddNamespace(new Interval<Address>(0x10165d52, 0x1019c3cd + 1), "sys");


            foreach (var pair in funcs_by_pc)
            foreach (var info in pair.Value)
                to_cxx.AddAlreadyDecodedFunc(info.MethodInfo);
            to_cxx.RemoveAlreadyDecodedFunc(fullAddress); // force decode.

#if false
    // Замечено, что многие функции начинаются со следующих двух команд.

    // {0x68, 0x28, 0, 0, 0,  0xe8, 0x90, 0xa1, 0xb, 0}
    // II(0x100abbb8, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    // II(0x100abbbd, 0x5)   calld(sys_check_available_stack_size, 0xb_a190); /* call 0x10165d52 */

    // Весь код MAXRUN.EXE
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
    }
#endif
            
            Console.WriteLine($"Запуск декодирования кода '{fullAddress}'.");

            to_cxx.DecodeMethod(fullAddress);
            to_cxx.Save();
        }

        public void add_internal_dyn_func(Action func, int mode, Address address)
        {
            var myMethodInfos = funcs_by_pc.GetValues(address, false);

            if (myMethodInfos != null)
            {
                foreach (var myMethodInfo in myMethodInfos)
                    if (myMethodInfo.Action != func)
                        throw new InvalidOperationException();
            }

            funcs_by_pc.Add(
                address,
                new MyMethodInfo
                {
                    Action = func,
                    MethodInfo = new MethodInfoDto
                    {
                        Guid = Guid.NewGuid(),
                        Address = address,
                        Mode = (ArchitectureMode) mode,
                        IgnoreSave = true
                    },
                });
        }

        public void add_internal_dyn_func_if_free(Action func, int mode, Address address)
        {
            if (funcs_by_pc.ContainsKey(address))
                return;

            add_internal_dyn_func(func, mode, address);
        }
    }

    public class MyMethodInfo
    {
        public MethodInfoDto MethodInfo { get; set; }

        public Action Action { get; set; }
    }
}