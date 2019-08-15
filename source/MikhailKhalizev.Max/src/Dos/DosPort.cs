using System;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86.Core.Abstractions;

namespace MikhailKhalizev.Max.Dos
{
    // http://bochs.sourceforge.net/techspec/PORTS.LST

    public class DosPort : BridgeProcessor
    {
        int cmos_reg;
        bool cmos_nmi;
        public RawProgramMain RawProgramMain { get; }

        public DosPort(IProcessor implementation, RawProgramMain rawProgramMain)
            : base(implementation)
        {
            RawProgramMain = rawProgramMain;
        }

        public void MyInb(Value value, Value port)
        {
            value.UInt32 = 0;
            switch (port.UInt32)
            {
                case 0x00:
                case 0x01:
                case 0x02:
                case 0x03:
                case 0x04:
                case 0x05:
                case 0x06:
                case 0x07:
                case 0x08:
                case 0x09:
                case 0x0a:
                case 0x0b:
                case 0x0c:
                case 0x0d:
                case 0x0e:
                case 0x0f:
                    throw new NotImplementedException();
                    // d = dma_controllers[0].read_controller_reg(port);
                    //break;

                case 0x81:
                case 0x82:
                case 0x83:
                case 0x89:
                case 0x8a:
                case 0x8b:
                    throw new NotImplementedException();
                    // d = dma_read_p8x(port);
                    //break;

                case 0xc0:
                case 0xc2:
                case 0xc4:
                case 0xc6:
                case 0xc8:
                case 0xca:
                case 0xcc:
                case 0xce:
                case 0xd0:
                case 0xd2:
                case 0xd4:
                case 0xd6:
                case 0xd8:
                case 0xda:
                case 0xdc:
                case 0xde:
                    throw new NotImplementedException();
                    //d = dma_controllers[1].read_controller_reg((port - 0xc0) / 2);
                    //break;

                case 0x20:
                    value.UInt16 = (ushort)RawProgramMain.DosPic.read_command(port.UInt16);
                    break;

                case 0x21:
                    throw new NotImplementedException();
                    //d = pic.read_data(port);
                    //break;

                case 0x40:
                case 0x41:
                case 0x42:
                    throw new NotImplementedException();
                    //d = timer_read_latch(port);
                    //break;

                case 0x60:
                    throw new NotImplementedException();
                    //d = static_cast < typename uint_ < 8 >::type > (key_pressed);
                    //key_pressed = kbd_keys::none;
                    //break;

                case 0x61:
                    throw new NotImplementedException();
                    //p61data ^= 0x30;
                    //d = p61data;
                    //break;

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
                    throw new NotImplementedException();
                    //d = sb_mixer_index;
                    //break;

                case 0x225:
                    throw new NotImplementedException();
                    //switch (sb_mixer_index)
                    //{
                    //    case 0x22:
                    //        d = sb_master_volume; // @todo error
                    //        break;
                    //    case 0x3f:
                    //        d = sb_unknown_3f;
                    //        break;
                    //    default:
                    //        throw exo::exception::not_implemented();
                    //}
                    //break;

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

        public void MyOutb(Value port, Value s)
        {
            switch (port.UInt32)
            {
                case 0x00:
                case 0x01:
                case 0x02:
                case 0x03:
                case 0x04:
                case 0x05:
                case 0x06:
                case 0x07:
                case 0x08:
                case 0x09:
                case 0x0a:
                case 0x0b:
                case 0x0c:
                case 0x0d:
                case 0x0e:
                case 0x0f:
                    throw new NotImplementedException();
                    //dma_controllers[0].write_controller_reg(port, s);
                    //break;

                case 0x81:
                case 0x82:
                case 0x83:
                case 0x89:
                case 0x8a:
                case 0x8b:
                    throw new NotImplementedException();
                    //dma_write_p8x(port, s);
                    //break;

                case 0xc0:
                case 0xc2:
                case 0xc4:
                case 0xc6:
                case 0xc8:
                case 0xca:
                case 0xcc:
                case 0xce:
                case 0xd0:
                case 0xd2:
                case 0xd4:
                case 0xd6:
                case 0xd8:
                case 0xda:
                case 0xdc:
                case 0xde:
                    throw new NotImplementedException();
                    //dma_controllers[1].write_controller_reg((port - 0xc0) / 2, s);
                    //break;

                case 0x20:
                    RawProgramMain.DosPic.write_command(port.Int32, (int)s.UInt32);
                    break;

                case 0x21:
                    throw new NotImplementedException();
                    //pic.write_data(port, s);
                    //break;

                case 0x40:
                case 0x42:
                    throw new NotImplementedException();
                    //timer_write_latch(port, s);
                    //break;

                case 0x43:
                    throw new NotImplementedException();
                    //timer_write_p43(s);
                    // break;

                case 0x61:
                    throw new NotImplementedException();
                    //if (((p61data ^ s) & 3) != 0 &&
                    //    ((p61data ^ s) & 1) != 0)
                    //    TIMER_SetGate2(0 != (s & 1));
                    //p61data = s;
                    //break;

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
                    cmos_reg = s.Int32 & 0x3f;
                    cmos_nmi = 0 != (s.Int32 & 0x80);
                    break;

                case 0x71:
                    if (cmos_reg != 0xf)
                        throw new NotImplementedException();
                    break;

                case 0x92:
                    ((Processor.x86.Core.Memory)Memory).A20Gate = 0 != (s.Int32 & 0x2);
                    break;


                case 0x94:
                case 0x96:
                    // Ignore.
                    break;

                case 0x224: // Mixer index
                    throw new NotImplementedException();
                    //sb_mixer_index = s;
                    //break;

                case 0x225: // Mixer data
                    throw new NotImplementedException();
                    //switch (sb_mixer_index)
                    //{
                    //    case 0x22:
                    //        sb_master_volume = s; // @todo error
                    //        break;
                    //    case 0x3f:
                    //        sb_unknown_3f = s;
                    //        break;
                    //    case 0x83:
                    //        break;
                    //    default:
                    //        throw exo::exception::not_implemented();
                    //}
                    //break;

                case 0x226:    // DSP_Reset
                    throw new NotImplementedException();
                    //dsp_data[dsp_wr_index] = 0xaa;
                    //dsp_wr_index++;
                    //dsp_wr_index %= count_of(dsp_data);
                    //break;

                case 0x22c:    // DSP_WriteData
                    throw new NotImplementedException();
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

                case 0x3c2:
                    throw new NotImplementedException();
                    //vga_misc_output = s;

                    //        std::cerr << "\tvga_misc_output >> 6: " << static_cast<uint_<32>>(vga_misc_output >> 6) << std::endl;

                    //        if (s & 1)
                    //            std::cout << "base addr 0x3d?";
                    //        else
                    //            std::cout << "base addr 0x3b?"; // this
                    //        std::cout << std::endl;
                    //break;

                case 0x3c8:
                    throw new NotImplementedException();
                    //pal_index = s;
                    //pal_rgb = 0;
                    //break;

                case 0x3c9:
                    throw new NotImplementedException();
                    //s &= 0x3f; // 6 bit color
                    //pal[pal_index].rgb[pal_rgb] = (s << 2) | (s >> 4); // round color to 8 bit
                    //pal_rgb++;
                    //if (3 <= pal_rgb)
                    //{
                    //    pal_index++;
                    //    pal_rgb = 0;
                    //}
                    //break;

                case 0x3d4:
                    throw new NotImplementedException();
                    //vga_crtc_index = s;
                    //break;

                case 0x214:
                case 0x215:
                    // TODO Пока игнорируем.
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}