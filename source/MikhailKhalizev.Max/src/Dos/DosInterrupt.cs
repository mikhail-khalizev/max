using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace MikhailKhalizev.Max.Dos
{
    public class DosInterrupt : BridgeProcessor
    {
        public new Processor.x86.Core.Processor Implementation { get; }
        public RawProgramMain RawProgramMain { get; }

        public DosInterrupt(Processor.x86.Core.Processor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            Implementation = implementation;
            RawProgramMain = rawProgramMain;

            fileHandlers.Add(null); // in
            fileHandlers.Add(null); // out
            fileHandlers.Add(null); // err
            fileHandlers.Add(null); // dummy (from dosbox)
            fileHandlers.Add(null); // dummy (from dosbox)
            fileHandlersPreserve = 5;

            Directory.CreateDirectory(RawProgramMain.Configuration.Dos.PngOutput);
        }

        public void int_08()
        {
            var BIOS_TIMER = 0x46c;

            var bios_timer_ms = Implementation.Memory.mem_phys_raw(BIOS_TIMER, 4);

            var bios_timer_value = bios_timer_ms.GetInt32();
            bios_timer_value++;
            bios_timer_ms.SetInt32(bios_timer_value);

            @int(0x1c);

            outb(0x20, 0x20);
            iretw();
        }

        public unsafe void int_10()
        {
            const int vga_vmemsize = 0x200000;

            switch (ah.UInt16)
            {
                case 0x0f:
                    ah = 0x50; // width in char
                    al = 0x3; // video mode
                    bh = 0; // page
                    break;

                case 0x4f: // VESA Calls
                    switch (al.UInt16)
                    {
                        case 0x01: // Get SVGA Mode Information
                            if (cx != 0x101)
                                throw new NotImplementedException();

                            al = 0x4f;
                            ah = 0; // success

                            {
                                var page_size = 640 * 480;
                                page_size = page_size & (~15);

                                ushort mode_attr = 0x9b;

                                var ms = Memory.GetFixSize(es, di, Marshal.SizeOf<mode_info>());
                                Array.Clear(ms.Array, ms.Offset, ms.Count);

                                ref var mi = ref Memory.GetStruct<mode_info>(es[di]);

                                mi.BytesPerScanLine = 640;
                                mi.NumberOfPlanes = 1;
                                mi.BitsPerPixel = 8;
                                mi.MemoryModel = 4;
                                mi.WinAAttributes = 7;

                                if (vga_vmemsize < page_size)
                                {
                                    throw new NotImplementedException();
                                }
                                else
                                {
                                    mi.ModeAttributes = mode_attr;
                                    mi.NumberOfImagePages = (byte)((vga_vmemsize / page_size) - 1);
                                }

                                mi.WinGranularity = 64;
                                mi.WinSize = 64;
                                mi.WinASegment = 0xa000;
                                mi.XResolution = 640;
                                mi.YResolution = 480;

                                if (added_callback_setwindow == false)
                                {
                                    RawProgramMain.add_internal_dyn_func(callback_setwindow, 16, 0xf0001320);
                                    added_callback_setwindow = true;
                                }

                                mi.WinFuncPtr = 0xf0001320;
                                mi.NumberOfBanks = 1;
                                mi.Reserved_page = 1;
                                mi.XCharSize = 8;
                                mi.YCharSize = 16;
                                mi.PhysBasePtr = 0;
                            }

                            break;

                        case 0x02: // Set videomode
                            if (bx != 0x101)
                                throw new NotImplementedException();

                            al = 0x4f;
                            ah = 0; // success

                            // /* mode  ,type     ,sw  ,sh  ,tw ,th ,cw,ch ,pt,pstart  ,plength,htot,vtot,hde,vde special flags */
                            //{ 0x101  ,M_LIN8   ,640 ,480 ,80 ,30 ,8 ,16 ,1 ,0xa0000 ,0x10000,100 ,525 ,80 ,480 ,0    },

                            break;

                        case 0x05:
                            if (bh != 0)
                                throw new NotImplementedException();

                            // ah = SetCPUWindow(bl, dl); (window, address)

                            if (bl != 0)
                                ah = 1;
                            else
                            {
                                if (dl.Int32 * 0x10000 < vga_vmemsize)
                                {
                                    ah = 0;
                                    // out(0x3d4, 0x6a)
                                    // out(0x3d5, dl)
                                    // std::cerr << static_cast<uint>(dl) << std::endl;


                                    var curr_bank = ((Processor.x86.Core.Memory)Memory)
                                        .mem_phys_raw(0xa0000, 0x10000)
                                        .Slice(0, 0x10000);


                                    var offset = 3 * curr_bank_num * 0x10000;
                                    for (var i = 0; i < 0x10000; i++)
                                    {
                                        if (img_data.Length <= offset + 3 * i + 2)
                                            break;

                                        var c = curr_bank[i];

#if false
                                        img_data[offset + 3 * i + 0] = c;
                                        img_data[offset + 3 * i + 1] = c;
                                        img_data[offset + 3 * i + 2] = c;
#else
                                        img_data[offset + 3 * i + 2] = pal[c].rgb[2];
                                        img_data[offset + 3 * i + 1] = pal[c].rgb[1];
                                        img_data[offset + 3 * i + 0] = pal[c].rgb[0];
#endif
                                    }

                                    if (dl == 0)
                                    {
                                        //var width = 640;
                                        //var height = 480;

#if false
                        const int line_y1 = 15; // Вписан.
                        const int line_y2 = 334; // Вписан
                        const int line_x1 = 32; // Вписан
                        const int line_x2 = 603; // Вписан

                        // -> total_height = 320, total_width = 572

                        for (int i = line_x1; i <= line_x2; i++)
                        {
                            // Граница заданной области - красная.
                            img_data[3 * buf_width * line_y1 + 3 * i + 0] = 255;
                            img_data[3 * buf_width * line_y1 + 3 * i + 1] = 0;
                            img_data[3 * buf_width * line_y1 + 3 * i + 2] = 0;

                            img_data[3 * buf_width * line_y2 + 3 * i + 0] = 255;
                            img_data[3 * buf_width * line_y2 + 3 * i + 1] = 0;
                            img_data[3 * buf_width * line_y2 + 3 * i + 2] = 0;


                            // Граница всего изображения - зелёная.
//                            img_data[3 * i + 0] = 0;
//                            img_data[3 * i + 1] = 255;
//                            img_data[3 * i + 2] = 0;
//
//                            img_data[3 * buf_width * (buf_height - 1) + 3 * i + 0] = 0;
//                            img_data[3 * buf_width * (buf_height - 1) + 3 * i + 1] = 255;
//                            img_data[3 * buf_width * (buf_height - 1) + 3 * i + 2] = 0;
                        }

                        for (int i = line_y1; i <= line_y2; i++)
                        {
                            // Граница заданной области - красная.
                            img_data[3 * line_x1 + 3 * buf_width * i + 0] = 255;
                            img_data[3 * line_x1 + 3 * buf_width * i + 1] = 0;
                            img_data[3 * line_x1 + 3 * buf_width * i + 2] = 0;

                            img_data[3 * line_x2 + 3 * buf_width * i + 0] = 255;
                            img_data[3 * line_x2 + 3 * buf_width * i + 1] = 0;
                            img_data[3 * line_x2 + 3 * buf_width * i + 2] = 0;


                            // Граница всего изображения - зелёная.
//                            img_data[3 * buf_width * i + 0] = 0;
//                            img_data[3 * buf_width * i + 1] = 255;
//                            img_data[3 * buf_width * i + 2] = 0;
//
//                            img_data[3 * (buf_width - 1) + 3 * buf_width * i + 0] = 0;
//                            img_data[3 * (buf_width - 1) + 3 * buf_width * i + 1] = 255;
//                            img_data[3 * (buf_width - 1) + 3 * buf_width * i + 2] = 0;
                        }
#endif

                                        fileNum++;
                                        var pngOutput = RawProgramMain.Configuration.Dos.PngOutput;
                                        var filePath = Path.Combine(pngOutput, $"img-{fileNum:D4}.png");


                                        var nimg = Image.LoadPixelData<Rgb24>(img_data, buf_width, buf_height);
                                        nimg.Save(filePath);

                                        NonBlockingConsole.WriteLine($"draw {fileNum}.png");

                                        //extra_log = (124 <= fileNum); /* Движение единиц. */
                                    }


                                    var need_cpy = (curr_bank_num * 0x10000 < all_banks.Length);

                                    if (need_cpy)
                                        curr_bank.CopyTo(all_banks, curr_bank_num * 0x10000);

                                    curr_bank_num = dl.UInt16;

                                    if (need_cpy)
                                        all_banks.AsSpan().Slice(curr_bank_num * 0x10000, 0x10000).CopyTo(curr_bank.AsSpan());
                                }
                                else
                                    ah = 1;
                            }

                            al = 0x4f;
                            break;

                        default:
                            throw new NotImplementedException();
                    }

                    break;

                default:
                    throw new NotImplementedException();
            }

            syscall_iretww();
        }


        public pal_struct[] pal = new pal_struct[256];

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct pal_struct
        {
            public fixed byte rgb[3];
        }

        uint fileNum;

        // 640 * 480 = 0x4b000
        const int buf_width = 640;
        const int buf_height = 480;

        int curr_bank_num = 0;
        byte[] img_data = new byte[3 * buf_width * buf_height];

        byte[] all_banks = new byte[((buf_width * buf_height + 0x10000 - 1) / 0x10000) * 0x10000];


        private bool added_callback_setwindow = false;
        private static void callback_setwindow() { }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct mode_info
        {
            public ushort ModeAttributes;
            public byte WinAAttributes;
            public byte WinBAttributes;
            public ushort WinGranularity;
            public ushort WinSize;
            public ushort WinASegment;
            public ushort WinBSegment;
            public uint WinFuncPtr;
            public ushort BytesPerScanLine;
            public ushort XResolution;
            public ushort YResolution;
            public byte XCharSize;
            public byte YCharSize;
            public byte NumberOfPlanes;
            public byte BitsPerPixel;
            public byte NumberOfBanks;
            public byte MemoryModel;
            public byte BankSize;
            public byte NumberOfImagePages;
            public byte Reserved_page;
            public byte RedMaskSize;
            public byte RedMaskPos;
            public byte GreenMaskSize;
            public byte GreenMaskPos;
            public byte BlueMaskSize;
            public byte BlueMaskPos;
            public byte ReservedMaskSize;
            public byte ReservedMaskPos;
            public byte DirectColorModeInfo;
            public uint PhysBasePtr;
            public uint OffScreenMemOffset;
            public ushort OffScreenMemSize;
            public fixed byte Reserved[206];
        };



        // int_sys_srv
        public void int_15()
        {
            switch (ah.UInt32)
            {
                case 0xbf:
                    ah = 0x86; // from dosbox.
                    eflags.cf = true;
                    break;

                case 0xc0:
                    ah = 0;
                    bx = 0;
                    es.Selector = 0xc8c3; /* from dosbox */

                    memw_a16[es, bx + 0x2] = 0xfc; // model id
                    eflags.cf = false;
                    break;

                case 0x88: /* Extended memory size. */
                    ax = 0;
                    eflags.cf = false;
                    break;

                default:
                    throw new NotImplementedException();
            }

            syscall_iretww();
        }

        public void int_16()
        {
            switch (ah.UInt32)
            {
                case 0x2: // Get shift flags
                    /* 0x01 - right shift
                     * 0x02 - left shift
                     * 0x04 - ctrl
                     * 0x08 - alt
                     * 0x10 - scroll lock
                     * 0x20 - num lock
                     * 0x40 - caps lock
                     * 0x80 - insert */
                    al = 0;
                    // al = mem_pg_raw(0x417, 1).get<uint_<8>>();
                    break;

                default:
                    throw new NotImplementedException();
            }

            syscall_iretww();
        }

        public void int_1c()
        {
            iretw();
        }


        /* ctrl-break control */
        private bool on = false;

        // int_dos
        public void int_21()
        {
            switch (ah.UInt32)
            {
                case 0x06:
                    if (dl == 0xff)
                        throw new NotImplementedException();
                    else
                    {
                        Console.Write((char)dl.Int32);
                        al = dl;
                    }

                    break;

                case 0x19:
                    al = 2; // C:
                    break;

                case 0x1a:
                    // ds:dx - now address of DTA
                    break;

                case 0x25: // set interrupt vector
                    {
                        // al <- int fileNum, ds:dx <- addr of int
                        if (cr0.pe)
                            throw new NotImplementedException();

                        Memory.GetStruct<int>(al.UInt32 * 4) = (ds.Selector << 16) + dx.UInt16;
                    }
                    break;

                case 0x2a:              /* Get System Date */
                    {
                        var now = DateTime.Now;

                        cx = now.Year;
                        dh = now.Month + 1;
                        dl = now.Day;
                        al = (int)now.DayOfWeek;
                    }
                    break;

                case 0x30:
                    if (al == 0)
                        bh = 0xff;
                    if (al == 1)
                        bh = 0x10;
                    bl = 0;
                    ax = 5;
                    cx = 0;
                    break;

                case 0x33: /* ctrl-break control */
                    {
                        if (al == 0)
                            dl = on ? 1 : 0;
                        else
                            on = (dl != 0);
                    }
                    break;

                case 0x34:
                    es.Selector = 0xb2; // SDA seg
                    bx = 1;
                    break;

                case 0x35: // get interrupt vector
                    {
                        // al <- int fileNum. es:bx >- addr of int
                        if (cr0.pe)
                            throw new NotImplementedException();

                        var v = Memory.GetStruct<int>(al.UInt32 * 4);

                        es.Selector = (v >> 16);
                        bx = v;
                    }
                    break;

                case 0x36:
                    {
                        /*
                                struct statfs buf;
                                int ret = statfs(".", &buf);
                                if (ret != 0)
                                    throw std::exception();

                                ax = 1;
                                cx = buf.f_bsize;
                                dx = buf.f_blocks;
                                bx = buf.f_bavail;
                        */

                        ax = 1;
                        cx = 512;
                        dx = 0x8fff;
                        bx = 0x4fff;
                    }
                    break;

                case 0x38:
                    if (al != 0)
                        throw new NotImplementedException();

                    ax = 1;
                    bx = 1;
                    break;

                case 0x3c: // create file
                    {
                        var path = get_path();

                        NonBlockingConsole.WriteLine($"    Create: '{path}'.");

                        var file = File.Open(path, FileMode.OpenOrCreate);
                        file.SetLength(0);
                        fileHandlers.Add(file);
                        var fd = fileHandlers.Count - 1;

                        if (0 <= fd)
                        {
                            eflags.cf = false;
                            if (0x7FFF < fd)
                                throw new InvalidOperationException();

                            ax = fd;
                        }
                        else
                            throw new NotImplementedException();
                    }
                    break;

                case 0x3d: // open file
                    {
                        var path = get_path();

                        FileMode fileMode;
                        FileAccess fileAccess;
                        FileShare fileShare;

                        switch (al.UInt32)
                        {
                            case 0:
                                fileMode = FileMode.Open;
                                fileAccess = FileAccess.Read;
                                fileShare = FileShare.Read;
                                break;
                            case 2:
                                fileMode = FileMode.Open;
                                fileAccess = FileAccess.ReadWrite;
                                fileShare = FileShare.Read;
                                break;
                            default:
                                throw new NotImplementedException();
                        }

                        try
                        {
                            var file = File.Open(path, fileMode, fileAccess, fileShare);

                            var fd = fileHandlers.IndexOf(null, fileHandlersPreserve);
                            if (fd < 0)
                            {
                                fileHandlers.Add(file);
                                fd = fileHandlers.Count - 1;
                            }
                            else
                                fileHandlers[fd] = file;

                            NonBlockingConsole.WriteLine($"    Open: '{path}', Access: {fileAccess}, Handle: {fd}.");

                            eflags.cf = false;
                            if (0x7fff < fd)
                                throw new InvalidOperationException();

                            ax = fd;
                        }
                        catch (FileNotFoundException)
                        {
                            NonBlockingConsole.WriteLine($"    Open: '{path}', File not found.");

                            eflags.cf = true;
                            ax = 2;
                        }
                        catch (UnauthorizedAccessException)
                        {
                            NonBlockingConsole.WriteLine($"    Open: '{path}', Access denied (hint: check read attribute on file).");

                            eflags.cf = true;
                            ax = 5;
                        }
                        catch
                        {
                            NonBlockingConsole.WriteLine($"    Open: '{path}', Unknown exception.");

                            eflags.cf = true;
                            ax = 1;

                            throw;
                        }
                    }
                    break;

                case 0x3e: // close file
                    NonBlockingConsole.WriteLine($"    Close. Handle: {bx.Int32}.");

                    if (bx.UInt32 <= 0x7FFF)
                    {
                        if (fileHandlers[bx.Int32] != null)
                        {
                            fileHandlers[bx.Int32].Dispose();
                            fileHandlers[bx.Int32] = null;
                        }

                        eflags.cf = false;
                    }
                    else
                    {
                        eflags.cf = true;
                        ax = 6;
                    }
                    break;

                case 0x3f: // read
                    {
                        var ms = Memory.GetFixSize(ds, dx, cx.Int32);

                        var readed = fileHandlers[bx.Int32].Read(ms.AsSpan());
                        if (0 <= readed)
                        {
                            eflags.cf = false;
                            if (0x7FFF < readed)
                                throw new InvalidOperationException();
                            ax = readed;
                        }
                        else
                        {
                            eflags.cf = true;
                            ax = 6;
                        }
                    }
                    break;

                case 0x40: // write
                    {
                        var ms = Memory.GetFixSize(ds, dx, cx.Int32);

                        if (bx.Int32 == 1 || bx.Int32 == 2)
                            Console.Write(ms.Select(x => (char)x).ToArray());
                        else
                            fileHandlers[bx.Int32].Write(ms.AsSpan());

                        var writed = cx.Int32;
                        if (0 <= writed)
                        {
                            eflags.cf = false;
                            if (0x7fff < writed)
                                throw new InvalidOperationException();
                            ax = writed;
                        }
                        else
                        {
                            eflags.cf = true;
                            ax = 6;
                        }
                    }
                    break;

                case 0x41: // delete
                    {
                        var path = get_path();
                        NonBlockingConsole.WriteLine($"    Delete: '{path}'.");

                        try
                        {
                            File.Delete(path);
                            eflags.cf = false;
                        }
                        catch (Exception)
                        {
                            eflags.cf = true;
                            ax = 2;
                        }
                    }
                    break;

                case 0x42: // lseek
                    {
                        var to_seek = (int)((cx.UInt32 << 16) + dx.UInt32);

                        // if (bx.Int32 <= 4)
                        // {
                        //     eflags.cf = false;
                        //     ax = 0;
                        //     dx = 0;
                        //     break;
                        // }

                        var file = fileHandlers[bx.Int32];
                        if (file == null)
                        {
                            NonBlockingConsole.WriteLine($"    Lseek. Handle: {bx.Int32} (already closed), to_seek: {to_seek}, whence: {al.UInt32}.");

                            eflags.cf = true;
                            ax = 6;
                            break;
                        }

                        // NonBlockingConsole.WriteLine($"    Lseek. Handle: {bx.Int32}."); // Noisily.

                        long new_off;

                        switch (al.UInt32)
                        {
                            case 0:
                                new_off = to_seek;
                                break;
                            case 1:
                                new_off = file.Position + to_seek;
                                break;
                            case 2:
                                new_off = file.Length + to_seek;
                                break;
                            default:
                                throw new NotImplementedException();
                        }

                        if (new_off < 0 || file.Length < new_off)
                            throw new InvalidOperationException();

                        file.Position = new_off;

                        if (new_off != -1)
                        {
                            eflags.cf = false;
                            ax = new_off;
                            dx = new_off >> 16;
                        }
                        else
                        {
                            eflags.cf = true;
                            ax = 6;
                        }
                    }
                    break;

                case 0x43: // dir exists
                    {
                        var path = get_path();
                        if (al != 0)
                            throw new NotImplementedException();

                        eflags.cf = true;

                        //try
                        //{
                        cx = 0;

                        if (Directory.Exists(path))
                        {
                            cx |= 16;
                            eflags.cf = false;
                        }
                        else
                        {
                            ax = 2;
                            eflags.cf = true;
                        }
                        //}
                        //catch
                        //{
                        //    ax = 1;
                        //}
                    }
                    break;

                case 0x44: // ioctl
                    // NonBlockingConsole.WriteLine($"    Ioctl. Handle: {bx.Int32}."); // Noisily.

                    if (bx.UInt32 <= 4) // "CON"
                        if (al == 0)
                        {
                            eflags.cf = false;
                            ax = dx = 0x80d3; // No key available.
                            break;
                        }

                    ax = dx = 0x2;
                    break;

                case 0x48:
                    RawProgramMain.DosMemory.dos_mem_alloc();
                    break;

                case 0x49:
                    RawProgramMain.DosMemory.dos_mem_free();
                    break;

                case 0x4a:
                    RawProgramMain.DosMemory.dos_mem_resize();
                    break;

                case 0x4c:
                    throw new Exception($"Exit with code {al.Int32}");

                case 0x50: // seg psp
                    if (bx.UInt16 != RawProgramMain.pspseg)
                        throw new NotImplementedException();
                    break;

                case 0x51: // get psp
                    bx = RawProgramMain.pspseg;
                    break;

                case 0x5a:
                    {
                        var path = Memory.ReadCString(ds[dx]);
                        if (path != ".\\")
                            throw new NotImplementedException();

                        var tempFileName = Path.Combine(Path.GetTempPath(), $"max-{tmpNum++}.tmp");

                        Console.Error.WriteLine("    Create temp: " + tempFileName);

                        var file = File.Open(tempFileName, FileMode.OpenOrCreate);
                        file.SetLength(0);
                        fileHandlers.Add(file);
                        var fd = fileHandlers.Count - 1;

                        if (fd < 0 || 0xffff < fd)
                            throw new InvalidOperationException();

                        eflags.cf = false;
                        ax = fd;
                    }
                    break;

                default:
                    throw new NotImplementedException();
            }

            syscall_iretww();
        }

        private int tmpNum = 0;

        private void syscall_iretww()
        {
            bool cf_save = eflags.cf;
            iretw();
            eflags.cf = cf_save;
        }

        public void int_2f()
        {
            switch (ax.UInt16)
            {
                case 0x1600:
                case 0x1687:
                    break;

                case 0x4300:
                    al = 0x80; // XMS driver installed (HIMEM.SYS).
                    break;

                case 0x4310:
                    {
                        es.Selector = 0xc83f;
                        bx = 0x10;

                        if (xms_handler_added == false)
                        {
                            RawProgramMain.add_internal_dyn_func(RawProgramMain.DosMemory.xms_handler, 16, es[bx]);
                            xms_handler_added = true;
                        }
                    }
                    break;

                default:
                    throw new NotImplementedException();
            }

            syscall_iretww();
        }

        private bool xms_handler_added = false;

        public void int_31() { throw new NotImplementedException(); }

        // Mouse
        public void int_33()
        {
            if (ax.UInt16 == 0)
                RawProgramMain.DosPic.set_irq_mask(12, false);

            switch (ax.UInt16)
            {
                case 0x0: // reset driver and read status ( fall-through )
                case 0x21: // software reset
                    ax = 0xffff;
                    bx = 3;
                    // ...
                    break;


                case 0x3: // return position and button status
                    bx = 0;
                    cx = 0; // pos_x
                    dx = 0; // pos_y
                    break;

                case 0xb: // read motion data
                    cx = 0; // x
                    dx = 0; // y
                    break;

                case 0x15: // get driver storage space requirements
                    bx = 0x1f0;
                    break;

                default:
                    throw new NotImplementedException();
            }

            syscall_iretww();
        }

        public void int_67()
        {
            if (ax == 0xde00) /* VCPI installation check. */
            {
                ah = 0x84; /* emm_func_nosup. */
            }
            else if (ah == 0x43) /* Get handle and allocate pages. */
            {
                /* @todo emm_allocate_memory(bx, dx); */
                ah = 0x0;
                dx = 0x1;
            }
            else if (ah == 0x45) /* Release handle and free pages. */
            {
                /* @todo emm_release_memory(dx); */
                ah = 0;
            }
            else
                throw new NotImplementedException();

            syscall_iretww();
        }

        private void int_unknown()
        {
            throw new NotImplementedException();
        }


        private string get_path()
        {
            // RawProgramMain.Configuration.Max.InstalledPath;

            var path = Memory.ReadCString(ds[dx]);

            if (path.StartsWith("C:\\"))
                path = path.Substring(3);

            //if (path[0] != '/')
            //{
                path = Path.GetFullPath(path, RawProgramMain.Configuration.Max.InstalledPath);
            //}

            return path;
        }

        private int fileHandlersPreserve;
        private List<Stream> fileHandlers = new List<Stream>();

        public void Initialize()
        {
            var intFunc = new (int num, Action func)[]
            {
                (0x08, int_08),
                (0x10, int_10),
                (0x15, int_15),
                (0x16, int_16),
                (0x1c, int_1c),
                (0x21, int_21),
                (0x2f, int_2f),
                (0x31, int_31),
                (0x33, int_33),
                (0x67, int_67)
            };

            // Взято из dosbox.
            var intVec = new ushort[]
            {
                /* ip, cs, */
                0x1060, 0xf000, // 0x00
                0x8, 0x70, // 0x01
                0x8, 0x70, // 0x02
                0x8, 0x70, // 0x03
                0x8, 0x70, // 0x04
                0x1060, 0xf000, // 0x05
                0x1060, 0xf000, // 0x06
                0x1060, 0xf000, // 0x07
                0xfea5, 0xf000, // 0x08
                0xe987, 0xf000, // 0x09
                0xff55, 0xf000, // 0x0a
                0x1060, 0xf000, // 0x0b
                0x1060, 0xf000, // 0x0c
                0x1060, 0xf000, // 0x0d
                0x1080, 0xf000, // 0x0e
                0x1060, 0xf000, // 0x0f
                0x1300, 0xf000, // 0x10
                0x1100, 0xf000, // 0x11
                0x1120, 0xf000, // 0x12
                0x1140, 0xf000, // 0x13
                0x11a0, 0xf000, // 0x14
                0x12cc, 0x5db, // 0x15
                0x11e0, 0xf000, // 0x16
                0x1220, 0xf000, // 0x17
                0x12c0, 0xf000, // 0x18
                0x12c0, 0xf000, // 0x19
                0x1240, 0xf000, // 0x1a
                0x1168, 0x5db, // 0x1b
                0x1260, 0xf000, // 0x1c
                0xf0a4, 0xf000, // 0x1d
                0x1060, 0xf000, // 0x1e
                0x500, 0xc000, // 0x1f
                0x1480, 0xf000, // 0x20
                0x14a0, 0xf000, // 0x21
                0x20c8, 0xf000, // 0x22
                0x1188, 0x5db, // 0x23
                0x118c, 0x5db, // 0x24
                0x14c0, 0xf000, // 0x25
                0x14e0, 0xf000, // 0x26
                0x1500, 0xf000, // 0x27
                0x1520, 0xf000, // 0x28
                0x1540, 0xf000, // 0x29
                0x15c0, 0xf000, // 0x2a
                0x1060, 0xf000, // 0x2b
                0x1060, 0xf000, // 0x2c
                0x1060, 0xf000, // 0x2d
                0x1060, 0xf000, // 0x2e
                0x15a0, 0xf000, // 0x2f
                0x1060, 0xf000, // 0x30
                0x1060, 0xf000, // 0x31
                0x1060, 0xf000, // 0x32
                0x10, 0xc7ff, // 0x33
                0x1060, 0xf000, // 0x34
                0x1060, 0xf000, // 0x35
                0x1060, 0xf000, // 0x36
                0x1060, 0xf000, // 0x37
                0x1060, 0xf000, // 0x38
                0x1060, 0xf000, // 0x39
                0x1060, 0xf000, // 0x3a
                0x1060, 0xf000, // 0x3b
                0x1060, 0xf000, // 0x3c
                0x1060, 0xf000, // 0x3d
                0x1060, 0xf000, // 0x3e
                0x1060, 0xf000, // 0x3f
                0x1060, 0xf000, // 0x40
                0x1160, 0xf000, // 0x41
                0x1060, 0xf000, // 0x42
                0x1700, 0xc000, // 0x43
                0x1060, 0xf000, // 0x44
                0x1060, 0xf000, // 0x45
                0x1180, 0xf000, // 0x46
                0x1060, 0xf000, // 0x47
                0x1060, 0xf000, // 0x48
                0x1060, 0xf000, // 0x49
                0x1060, 0xf000, // 0x4a
                0x1600, 0xf000, // 0x4b
                0x1060, 0xf000, // 0x4c
                0x1060, 0xf000, // 0x4d
                0x1060, 0xf000, // 0x4e
                0x1060, 0xf000, // 0x4f
                0x1060, 0xf000, // 0x50
                0x1060, 0xf000, // 0x51
                0x1060, 0xf000, // 0x52
                0x1060, 0xf000, // 0x53
                0x1060, 0xf000, // 0x54
                0x1060, 0xf000, // 0x55
                0x1060, 0xf000, // 0x56
                0x1060, 0xf000, // 0x57
                0x1060, 0xf000, // 0x58
                0x1060, 0xf000, // 0x59
                0x1060, 0xf000, // 0x5a
                0x1060, 0xf000, // 0x5b
                0x1060, 0xf000, // 0x5c
                0x1060, 0xf000, // 0x5d
                0x1060, 0xf000, // 0x5e
                0x1060, 0xf000, // 0x5f
                0x60, 0x0, // 0x60
                0x61, 0x0, // 0x61
                0x62, 0x0, // 0x62
                0x63, 0x0, // 0x63
                0x64, 0x0, // 0x64
                0x65, 0x0, // 0x65
                0x66, 0x0, // 0x66
                0x4, 0xc84b, // 0x67
            };

            for (var i = 0; i < intFunc.Length; i++)
            {
                Address address = intVec[2 * intFunc[i].num + 1] * 16 + intVec[2 * intFunc[i].num];
                RawProgramMain.add_internal_dyn_func(intFunc[i].func, 16, address);
            }

            for (var i = 0; i < intVec.Length / 2; i++)
            {
                Address address = intVec[2 * i + 1] * 16 + intVec[2 * i];

                if (address == 0)
                    continue;

                RawProgramMain.add_internal_dyn_func_if_free(int_unknown, 16, address);
            }

            var ms = Memory.GetFixSize(0, intVec.Length * 2);
            Marshal.Copy(
                Marshal.UnsafeAddrOfPinnedArrayElement(intVec, 0),
                ms.Array,
                ms.Offset,
                ms.Count);
        }
    }
}