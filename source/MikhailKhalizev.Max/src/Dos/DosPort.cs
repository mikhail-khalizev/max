using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using System;

namespace MikhailKhalizev.Max.Dos
{
    // http://bochs.sourceforge.net/techspec/PORTS.LST

    public class DosPort : BridgeProcessor
    {
        public new Processor.x86.Core.Processor Implementation { get; }
        public RawProgramMain RawProgramMain { get; }

        public enum kbd_keys
        {
            none = 0,

            esc = 1,
            _1 = 2,
            _2 = 3,
            _3 = 4,
            _4 = 5,
            _5 = 6,
            _6 = 7,
            _7 = 8,
            _8 = 9,
            _9 = 10,
            _0 = 11,
            period = 52,
            minus = 12,
            equals = 13,

            q = 16,
            w = 17,
            e = 18,
            r = 19,
            t = 20,
            y = 21,
            u = 22,
            i = 23,
            o = 24,
            p = 25,

            a = 30,
            s = 31,
            d = 32,
            f = 33,
            g = 34,
            h = 35,
            j = 36,
            k = 37,
            l = 38,

            z = 44,
            x = 45,
            c = 46,
            v = 47,
            b = 48,
            n = 49,
            m = 50,

            backspace = 14,
            tab = 15,
            leftbracket = 26,
            rightbracket = 27,
            enter = 28,

            leftalt = 56,
            leftctrl = 29,
            leftshift = 42,
            rightshift = 54,

            semicolon = 39,
            quote = 40,
            grave = 41,
            backslash = 43,
            comma = 51,
            slash = 53,
            space = 57,
            capslock = 58,
            numlock = 69,
            scrolllock = 70,

            f1 = 59,
            f2 = 60,
            f3 = 61,
            f4 = 62,
            f5 = 63,
            f6 = 64,
            f7 = 65,
            f8 = 66,
            f9 = 67,
            f10 = 68,
            f11 = 87,
            f12 = 88,

            kp0 = 82,
            kp1 = 79,
            kp2 = 80,
            kp3 = 81,
            kp4 = 75,
            kp5 = 76,
            kp6 = 77,
            kp7 = 71,
            kp8 = 72,
            kp9 = 73,

            kpminus = 74,
            kpplus = 78,
            kpmultiply = 55,
            kpperiod = 83,

            extra_lt_gt = 86,

            /*
             * kpenter,
             * rightctrl,
             * kpdivide,
             * rightalt,
             * home,
             * up,
             * pageup,
             * left,
             * right,
             * end,
             * down,
             * pagedown,
             * insert,
             * delete,
             * pause,
             * printscreen
             */
        };

        private kbd_keys key_pressed = kbd_keys.none;
        private int p61data = 0;
        private int pal_index;
        private int pal_rgb;
        private int sb_mixer_index = 0;
        private int sb_master_volume = 0xff;
        private int sb_unknown_3f = 0xff;
        private int sb_freq = 0;
        private byte[] dsp_data = new byte[64];
        private int dsp_wr_index = 0;
        private int dsp_rd_index = 0;
        private int dsp_last_rd_val = 0;
        private int dsp_cmd = 0;
        private int dsp_cmd_len = 0;
        private int dsp_cmd_data = 0;

        public DosPort(Processor.x86.Core.Processor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            Implementation = implementation;
            RawProgramMain = rawProgramMain;
        }

        public void MyInb(ValueBase value, ValueBase port)
        {
            value.UInt32 = 0;
            switch (port.UInt32)
            {
                //case 0x00:
                //case 0x01:
                //case 0x02:
                //case 0x03:
                //case 0x04:
                //case 0x05:
                //case 0x06:
                //case 0x07:
                //case 0x08:
                //case 0x09:
                //case 0x0a:
                //case 0x0b:
                //case 0x0c:
                //case 0x0d:
                //case 0x0e:
                //case 0x0f:
                //    throw new NotImplementedException();
                // d = dma_controllers[0].read_controller_reg(port);
                //break;

                //case 0x81:
                //case 0x82:
                //case 0x83:
                //case 0x89:
                //case 0x8a:
                //case 0x8b:
                //    throw new NotImplementedException();
                // d = dma_read_p8x(port);
                //break;

                //case 0xc0:
                //case 0xc2:
                //case 0xc4:
                //case 0xc6:
                //case 0xc8:
                //case 0xca:
                //case 0xcc:
                //case 0xce:
                //case 0xd0:
                //case 0xd2:
                //case 0xd4:
                //case 0xd6:
                //case 0xd8:
                //case 0xda:
                //case 0xdc:
                //case 0xde:
                //    throw new NotImplementedException();
                //d = dma_controllers[1].read_controller_reg((port - 0xc0) / 2);
                //break;

                case 0x20:
                    value.UInt16 = (ushort)RawProgramMain.DosPic.read_command(port.UInt16);
                    break;

                case 0x21:
                    value.UInt32 = (uint)RawProgramMain.DosPic.read_data((int)port.UInt32);
                    break;

                case 0x40:
                case 0x41:
                case 0x42:
                    value.UInt32 = (uint)RawProgramMain.DosTimer.timer_read_latch((int)port.UInt32);
                    break;

                case 0x60:
                    throw new NotImplementedException();
                //d = static_cast < typename uint_ < 8 >::type > (key_pressed);
                //key_pressed = kbd_keys::none;
                //break;

                case 0x61:
                    p61data ^= 0x30;
                    value.Int32 = p61data;
                    break;

                case 0x64: // Keyboard Controller
                    value.UInt32 = 0x1c;// TODO | (p60_change ? 0x1 : 0);
                    break;

                case 0x92:
                    value.Int32 = ((Processor.x86.Core.Memory)Memory).A20Gate ? 0x2 : 0;
                    break;

                case 0x215:
                    al = 0xff;
                    break;

                case 0x224:
                    value.Int32 = sb_mixer_index;
                    break;

                case 0x225:
                    switch (sb_mixer_index)
                    {
                        case 0x22:
                            value.Int32 = sb_master_volume; // @todo error
                            break;
                        case 0x3f:
                            value.Int32 = sb_unknown_3f;
                            break;
                        default:
                            throw new NotImplementedException($"sb_mixer_index: {sb_mixer_index}");
                    }
                    break;

                case 0x22a: // sb read_data
                    throw new NotImplementedException();
                //if (dsp_rd_index != dsp_wr_index)
                //{
                //    dsp_last_rd_val = dsp_data[dsp_rd_index];
                //    dsp_rd_index++;
                //    dsp_rd_index %= count_of(dsp_data);
                //}
                //d = dsp_last_rd_val;
                //break;

                case 0x22c: // sb write_data
                    value.UInt32 = 0x7f; // ?
                    break;

                case 0x22e: // sb read_status
                    value.UInt32 = 0xff; // ?
                    break;

                case 0x22f:
                    value.UInt32 = 0xff;
                    break;

                case 0x3cc:
                    throw new NotImplementedException();
                //d = vga_misc_output;
                //break;

                case 0x3d5:
                    throw new NotImplementedException();
                //switch (vga_crtc_index)
                //{
                //    case 0x3:
                //        d = vga_crtc_end_horizontal_blanking;
                //        break;
                //    case 0x7:
                //        d = vga_crtc_overflow;
                //        break;
                //    case 0x9:
                //        d = vga_crtc_maximum_scan_line;
                //        break;
                //    case 0x11:
                //        d = vga_crtc_vertical_retrace_end;
                //        break;
                //    default:
                //        throw exo::exception::not_implemented();
                //        break;
                //}
                //break;

                case 0x214:
                    // @todo Пока игнорируем.
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        public unsafe void MyOutb(ValueBase port, ValueBase s)
        {
            switch (port.UInt32)
            {
                //case 0x00:
                //case 0x01:
                //case 0x02:
                //case 0x03:
                //case 0x04:
                //case 0x05:
                //case 0x06:
                //case 0x07:
                //case 0x08:
                //case 0x09:
                //case 0x0a:
                //case 0x0b:
                //case 0x0c:
                //case 0x0d:
                //case 0x0e:
                //case 0x0f:
                //    throw new NotImplementedException();
                //dma_controllers[0].write_controller_reg(port, s);
                //break;

                //case 0x81:
                //case 0x82:
                //case 0x83:
                //case 0x89:
                //case 0x8a:
                //case 0x8b:
                //    throw new NotImplementedException();
                //dma_write_p8x(port, s);
                //break;

                //case 0xc0:
                //case 0xc2:
                //case 0xc4:
                //case 0xc6:
                //case 0xc8:
                //case 0xca:
                //case 0xcc:
                //case 0xce:
                //case 0xd0:
                //case 0xd2:
                //case 0xd4:
                //case 0xd6:
                //case 0xd8:
                //case 0xda:
                //case 0xdc:
                //case 0xde:
                //    throw new NotImplementedException();
                //dma_controllers[1].write_controller_reg((port - 0xc0) / 2, s);
                //break;

                case 0x20:
                    RawProgramMain.DosPic.write_command((int)port.UInt32, (int)s.UInt32);
                    break;

                case 0x21:
                    RawProgramMain.DosPic.write_data((int)port.UInt32, (int)s.UInt32);
                    break;

                case 0x40:
                case 0x42:
                    RawProgramMain.DosTimer.timer_write_latch((int)port.UInt32, (int)s.UInt32);
                    break;

                case 0x43:
                    RawProgramMain.DosTimer.timer_write_p43((int)s.UInt32);
                    break;

                case 0x61:
                    if (((p61data ^ s) & 3) != 0 && ((p61data ^ s) & 1) != 0)
                        RawProgramMain.DosTimer.TIMER_SetGate2(0 != (s & 1));
                    p61data = (int)s.UInt32;
                    break;

                /*    case 0x60:
                        switch (keyb_cmd)
                        {
                        case KeyCommands::SetOutPort:
                            keyb_cmd = KeyCommands::None;
                            a20_gate = (s & 2);
                            break;
                        default:
                            throw exo::exception::not_implemented();
                            break;
                        }
                        break;


                case 0x64:
                        switch (s)
                        {
                        case 0xd1:
                            keyb_cmd = KeyCommands::SetOutPort;
                            break;
                        case 0xff:
                            // Не известно.
                            break;
                        default:
                            throw new NotImplementedException();
                            break;
                        }
                        break;
                */

                case 0x70:
                case 0x71:
                    // cmos. Ignore.
                    break;

                case 0x92:
                    Implementation.Memory.A20Gate = 0 != (s.Int32 & 0x2);
                    break;


                case 0x94:
                case 0x96:
                    // Ignore.
                    break;

                case 0x224: // Mixer index
                    sb_mixer_index = (int)s.UInt32;
                    break;

                case 0x225: // Mixer data
                    switch (sb_mixer_index)
                    {
                        case 0x22:
                            sb_master_volume = (int)s.UInt32; // @todo error
                            break;
                        case 0x3f:
                            sb_unknown_3f = (int)s.UInt32;
                            break;
                        case 0x83:
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    break;

                case 0x226:    // DSP_Reset
                    dsp_data[dsp_wr_index] = 0xaa;
                    dsp_wr_index++;
                    dsp_wr_index %= dsp_data.Length;
                    break;

                //case 0x22c:    // DSP_WriteData
                //    throw new NotImplementedException();
                //if (dsp_cmd == 0)
                //{
                //    dsp_cmd = s;
                //    dsp_cmd_len = dsp_cmd_lens[dsp_cmd];
                //    dsp_cmd_data = 0;
                //}
                //else if (dsp_cmd_len != 0)
                //{
                //    dsp_cmd_data = (dsp_cmd_data << 8) | s;
                //    dsp_cmd_len--;
                //}

                //if (dsp_cmd_len == 0) // Команда прочитана полностью.
                //{
                //    switch (dsp_cmd)
                //    {
                //        case 0x41: // Set output sample rate
                //            sb_freq = dsp_cmd_data;
                //            //                std::cout << "sb_freq: " << sb_freq << std::endl;
                //            break;

                //        // b4 30ff0f - sign, DSP_DMA_16, 0x1000, 1, 1
                //        // DSP_PrepareDMA_New(DMA_MODES mode, uint_<32> length, bool autoinit, bool stereo)
                //        case 0xb4:
                //            {
                //                if (dsp_cmd_data != 0x30ff0f)
                //                    throw exo::exception::not_implemented();

                //                dma_channel & chan = dma_get_channel(5);
                //                if (chan.masked)
                //                    throw exo::exception::not_implemented();

                //                uint_ < 16 > buf[0x1000];
                //                chan.read(buf, 0x1000);
                //                pic.activate_irq(7);
                //                break;
                //            }

                //        default:
                //            throw exo::exception::not_implemented();
                //    }

                //    dsp_cmd = 0;
                //    dsp_cmd_data = 0;
                //}
                //break;

                //case 0x3c2:
                //    throw new NotImplementedException();
                //vga_misc_output = s;

                //        std::cerr << "\tvga_misc_output >> 6: " << static_cast<uint_<32>>(vga_misc_output >> 6) << std::endl;

                //        if (s & 1)
                //            std::cout << "base addr 0x3d?";
                //        else
                //            std::cout << "base addr 0x3b?"; // this
                //        std::cout << std::endl;
                //break;

                case 0x3c8:
                    pal_index = (int)s.UInt32;
                    pal_rgb = 0;
                    break;

                case 0x3c9:
                    var v = s.UInt32 & 0x3f; // 6 bit color
                    RawProgramMain.DosInterrupt.pal[pal_index].rgb[pal_rgb] = (byte)((v << 2) | (v >> 4)); // round color to 8 bit
                    pal_rgb++;
                    if (3 <= pal_rgb)
                    {
                        pal_index++;
                        pal_rgb = 0;
                    }
                    break;

                //case 0x3d4:
                //    throw new NotImplementedException();
                //vga_crtc_index = s;
                //break;

                case 0x214:
                case 0x215:
                    // TODO Пока игнорируем.
                    break;

                default:
                    throw new NotImplementedException($"Port: 0x{port.UInt64:x}, value: 0x{s.UInt64:x}");
            }
        }
    }
}