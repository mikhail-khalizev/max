using System;
using System.IO;
using MikhailKhalizev.Max.Dos;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Utils;

namespace MikhailKhalizev.Max
{
    public class RawProgram : BridgeProcessor
    {
        public string Directory { get; }
        public string ExeFileName { get; }
        public Dos.Memory DosMemory { get; }

        public const ushort image_load_seg = 0x1a2; // Const from dosbox.
        public const ushort pspseg = image_load_seg - 16; // 0x192

        public RawProgram(IProcessor implementation, string directory, string exeFileName) 
            : base(implementation)
        {
            Directory = directory;
            ExeFileName = exeFileName;
            DosMemory = new Memory(implementation);
        }

        public void init_x86_dos_prog()
        {
            var exeBytes = File.ReadAllBytes(Path.Combine(Directory, ExeFileName));

            var exe = exeBytes.GetStructure<Exe16BitHeader>();

            if (!exe.is_correct())
                throw new Exception();

            DosMemory.dos_mem_init();
            
            // Alloc dos - dummy.

            bx = pspseg - 2; // internal alloc logic
            DosMemory.dos_mem_alloc();
            if (eflags.cf)
                throw new Exception();

            // Alloc image.

            var exe_image_off = exe.exe_data_start();
            var image_size = exe.extra_data_start() - exe_image_off;

            bx = (image_size + 15) / 16 + 16; // psp_size
            DosMemory.dos_mem_alloc();
            if (eflags.cf)
                throw new Exception();

            if (ax.UInt16 != pspseg)
                throw new Exception();

            ds.Load(image_load_seg);

            var processor = (Processor.x86.FullSimulate.Processor)Implementation;
            var memory = processor.Memory;
            var image = memory.mem_seg_pg_raw(ds, 0, image_size);

            // Upload image of program.

            exeBytes.AsSpan().Slice(exe_image_off, image_size)
                .CopyTo(image.Slice(0, image_size));
            
            // Read relocations.
            
            var reallocs = new ArraySegment<byte>(exeBytes).Slice(exe.reloc_table_offset, 4 * exe.num_relocs);

            // Apply realoc.

            for (var i = 0; i < exe.num_relocs; i++)
            {
                var offset = reallocs.GetUInt16(4 * i);
                var segment = reallocs.GetUInt16(4 * i + 3);

                var addr = segment * 16 + offset;

                if (image_size <= addr + 1)
                    throw new Exception();

                var val = image.GetUInt16(addr);
                image.SetUInt16(val + image_load_seg);
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
                memory
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


            throw new NotImplementedException();
            // install_std_ints();


            // Устанавливаем начальные значения в регистры.

            ds.Load(pspseg);
            es = ds;

            ss.Load(image_load_seg + exe.ss);
            sp = exe.sp;

            cs.Load(image_load_seg + exe.cs);
            processor.eip = exe.ip;
            processor.CurrentInstructionAddress = exe.ip;

            eax = 0;
            ebx = 0;
            ecx = 0xff;
            edx = pspseg;

            esi = 0x2382;
            edi = 0x340;
            ebp = 0x91c;

            eflags.UInt32 = 0x7202;


            throw new NotImplementedException();
            //timers_init();
        }
    }
}
