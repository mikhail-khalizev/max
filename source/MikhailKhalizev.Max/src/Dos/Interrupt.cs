using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;

namespace MikhailKhalizev.Max.Dos
{
    public class Interrupt : BridgeProcessor
    {
        public RawProgramMain RawProgramMain { get; }

        public Interrupt(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }

        public void int_08() { throw new NotImplementedException(); }
        public void int_10() { throw new NotImplementedException(); }

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
                    es.Load(0xc8c3); /* from dosbox */

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

        public void int_16() { throw new NotImplementedException(); }
        public void int_1c() { throw new NotImplementedException(); }


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
                        // al <- int num, ds:dx <- addr of int
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
                    throw new NotImplementedException();
                    // TODO es = 0xb2; // SDA seg
                    bx = 1;
                    break;

                case 0x35: // get interrupt vector
                    {
                        // al <- int num. es:bx >- addr of int
                        if (cr0.pe)
                            throw new NotImplementedException();

                        var v = Memory.GetStruct<int>(al.UInt32 * 4);

                        es.Load(v >> 16);
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

                case 0x3c: // create_file
                    {
                        var path = get_path();

                        // @todo
                        Console.Error.WriteLine("\tCreate: " + path);

                        var file = File.Open(path, FileMode.OpenOrCreate | FileMode.Truncate);
                        fileHandels.Add(file);
                        var fd = fileHandels.Count - 1;

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

                case 0x3d: // open_file
                    {
                        var path = get_path();

                        Console.Error.WriteLine("\tOpen: " + path);

                        var fileMode = FileMode.Open;
                        FileAccess fileAccess;

                        switch (al.UInt32)
                        {
                            case 0:
                                fileAccess = FileAccess.Read;
                                break;
                            case 2:
                                fileAccess = FileAccess.ReadWrite;
                                break;
                            default:
                                throw new NotImplementedException();
                        }

                        try
                        {
                            var file = File.Open(path, fileMode, fileAccess);
                            fileHandels.Add(file);
                            var fd = fileHandels.Count - 1;

                            eflags.cf = false;
                            if (0x7fff < fd)
                                throw new InvalidOperationException();

                            ax = fd;
                        }
                        catch
                        {
                            eflags.cf = true;
                            //switch (errno)
                            //{
                            //    case EACCES: ax = 5; break;
                            //    case ENOENT: ax = 2; break;
                            //    default: ax = 1; break;
                            //}

                            throw;
                        }
                    }
                    break;

                case 0x3e: // close_file
                    if (bx.UInt32 <= 0x7FFF)
                    {
                        fileHandels[bx.Int32].Dispose();

                        //int fd = close(bx);
                        //if (fd == 0)
                        {
                            eflags.cf = false;
                            break;
                        }
                    }

                    eflags.cf = true;
                    ax = 6;
                    break;

                case 0x3f: // read
                    {
                        var ms = Memory.GetFixSize(ds, dx, cx.Int32);

                        var readed = fileHandels[bx.Int32].Read(ms.AsSpan());
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

                        fileHandels[bx.Int32].Write(ms.AsSpan());
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
                        Console.Error.WriteLine("\tDelete: " + path);

                        File.Delete(path);

                        var ok = 0;
                        if (ok == 0)
                        {
                            eflags.cf = false;
                        }
                        else
                        {
                            eflags.cf = true;
                            ax = 2;
                        }
                    }
                    break;

                case 0x42: // lseek
                    {
                        var to_seek = (int)((cx.UInt32 << 16) + dx.UInt32);

                        var file = fileHandels[bx.Int32];

                        switch (al.UInt32)
                        {
                            case 0:
                                file.Position = to_seek;
                                break;
                            case 1:
                                file.Position += to_seek;
                                break;
                            case 2:
                                file.Position = file.Length + to_seek;
                                break;
                            default:
                                throw new NotImplementedException();
                        }

                        var new_off = file.Position;
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

                case 0x43:
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
                    if (bx.UInt32 <= 4) // "CON"
                        if (al == 0)
                        {
                            eflags.cf = false;
                            ax = dx = 0x80d3; // No key available.
                            break;
                        }

                    ax = dx = 0x2;
                    // throw exception::not_implemented();
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

                        var p2 = Path.GetTempPath();

                        Console.Error.WriteLine("\tCreate temp: " + p2);

                        var file = File.Open(path, FileMode.OpenOrCreate | FileMode.Truncate);
                        fileHandels.Add(file);
                        var fd = fileHandels.Count - 1;
                        
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

        private void syscall_iretww()
        {
            bool cf_save = eflags.cf;
            iretw();
            eflags.cf = cf_save;
        }

        public void int_2f() { throw new NotImplementedException(); }
        public void int_31() { throw new NotImplementedException(); }
        public void int_33() { throw new NotImplementedException(); }
        public void int_67() { throw new NotImplementedException(); }

        private void int_unknown()
        {
            throw new NotImplementedException();
        }


        private string get_path()
        {
            // RawProgramMain.Configuration.Max.InstalledPath;

            var path = Memory.ReadCString(ds[dx]);
            
            if (path.StartsWith("C:/"))
                path = path.Substring(3);

            if (path[0] != '/')
            {
                //for (char & val: path)
                //    if ('a' <= val && val <= 'z')
                //        val += 'A' - 'a';

                path = Path.Combine(RawProgramMain.Configuration.Max.InstalledPath, path);
            }

            return path;
        }

        private List<FileStream> fileHandels = new List<FileStream>();

        public void install_std_ints()
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
                0x67, 0x0, // 0x67
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