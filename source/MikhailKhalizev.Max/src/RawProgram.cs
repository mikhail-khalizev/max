using System;
using System.IO;
using System.Net.Mime;
using Kaitai;
using MikhailKhalizev.Max.Dos;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Utils;

namespace MikhailKhalizev.Max
{
    public class RawProgram : BridgeProcessor
    {
        public new Processor.x86.FullSimulate.Processor Implementation { get; }
        public string Directory { get; }
        public string ExeFileName { get; }

        public Memory DosMemory { get; }
        public Interrupt DosInterrupt { get; }
        public Timer DosTimer { get; }

        public bool extra_log { get; set; } = true;

        public const ushort image_load_seg = 0x1a2; // Const from dosbox.
        public const ushort pspseg = image_load_seg - 16; // 0x192

        public RawProgram(Processor.x86.FullSimulate.Processor implementation, string directory, string exeFileName)
            : base(implementation)
        {
            Implementation = implementation;
            Directory = directory;
            ExeFileName = exeFileName;

            DosMemory = new Memory(implementation);
            DosInterrupt = new Interrupt(implementation);
            DosTimer = new Timer(implementation);
        }

        public void init_x86_dos_prog()
        {
            var exeBytes = File.ReadAllBytes(Path.Combine(Directory, ExeFileName));
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

            var image = Implementation.Memory.mem_seg_pg_raw(ds, 0, image_size);

            // Upload image of program.

            exeBytes.AsSpan().Slice(exe_image_off, image_size)
                .CopyTo(image.Slice(0, image_size));

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
                    .mem_seg_pg_raw(ds, 0, evn_init.Length)
                    .Slice(0, evn_init.Length)
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
            var run = cs.Descriptor.Base + eip;

            // "--on-run-func={none, dump-reg}"
            var on_run_func__dump_reg = true;

            if (on_run_func__dump_reg)
            {
                Console.WriteLine(
                    $"before run {run:x}" +
                    $", eax {eax:x}" +
                    $", ebx {ebx:x}" +
                    $", ecx {ecx:x}" +
                    $", edx {edx:x}" +
                    $", esi {esi:x}" +
                    $", edi {edi:x}" +
                    $", esp {esp:x}" +
                    $", ebp {ebp:x}" +
                    $", ds.val {ds.Selector:x}" +
                    $", es.val {es.Selector:x}" +
                    $", cs.val {cs.Selector:x}" +
                    $", ss.val {ss.Selector:x}" +
                    $", fs.val {fs.Selector:x}" +
                    $", gs.val {gs.Selector:x}");
            }

            CurrentInstructionAddress = eip; // Check, is it correct?
            var info = get_func(cs, eip);

            if (extra_log)
                Console.WriteLine($"run {info.func_name}");

            add_to_used_func_list(run, (cs.db ? 32 : 16));
            info.func();
            CurrentInstructionAddress = eip; // Check, is it correct?

            if (on_run_func__dump_reg)
            {
                Console.WriteLine(
                    $"after run {run:x}" +
                    $", eax {eax:x}" +
                    $", ebx {ebx:x}" +
                    $", ecx {ecx:x}" +
                    $", edx {edx:x}" +
                    $", esi {esi:x}" +
                    $", edi {edi:x}" +
                    $", esp {esp:x}" +
                    $", ebp {ebp:x}" +
                    $", ds.val {ds.Selector:x}" +
                    $", es.val {es.Selector:x}" +
                    $", cs.val {cs.Selector:x}" +
                    $", ss.val {ss.Selector:x}" +
                    $", fs.val {fs.Selector:x}" +
                    $", gs.val {gs.Selector:x}");
            }
        }

        public FunctionInfo get_func(SegmentRegister seg, Address addr)
        {
            if (seg.Descriptor.Base + addr == 0)
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

        public FunctionInfo find_func_exact(SegmentRegister seg, Address addr)
        {
            var infos = funcs_by_pc.GetValues(seg.Descriptor.Base + addr, false);
            if (infos == null)
                return null;

            foreach (var info in infos)
            {
                if ((int)info.Model.Mode != (cs.db ? 32 : 16))
                    continue;

                if (Implementation.Memory.mem_pg_equals(seg.Descriptor.Base + addr, info.GetRawBytes()))
                    return info;
            }

            return null;
        }

        public MultiValueDictionary<Address, FunctionInfo> funcs_by_pc;
    }

    public class FunctionInfo
    {
        public FunctionModel Model { get; set; }

        /// <summary>
        /// Имя функции C++ без namespace. Например: "func_0x101354f7".
        /// </summary>
        public string func_name { get; set; }

        /// <summary>
        /// Адрес вызываемой функции (уже декодированной).
        /// </summary>
        public Action func { get; set; }

        public byte[] GetRawBytes() => HexHelper.ToBytes(Model.Raw);
    }
}