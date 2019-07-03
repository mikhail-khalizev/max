#include <exo/global.hpp>
#include <exo/exception.hpp>

#include "dos/dma.hpp"
#include "dos/pic.hpp"
#include "dos/timer.hpp"
#include "dos/ports.hpp"
#include "x86/memory.hpp"


namespace raw_program {
namespace dos {

using namespace x86;

/* Keyboard. */
/*
enum class KeyCommands
{
    None,
    SetOutPort
};

static KeyCommands keyb_cmd = KeyCommands::None;
static uint_<8> p60;
static bool p60_change;
*/

static uint_<8> cmos_reg;
static bool cmos_nmi;



pal_struct pal[256];

static uint_<8> pal_index = 0;
static uint_<8> pal_rgb = 0;

static uint_<16> vga_seq_index = 0;
static uint_<16> vga_crtc_index = 0;
uint_<8> vga_misc_output = 0;
static uint_<8> vga_crtc_vertical_retrace_end = 0;
static uint_<8> vga_crtc_end_horizontal_blanking = 0;
static uint_<8> vga_crtc_overflow = 0;
static uint_<8> vga_crtc_maximum_scan_line = 0;


kbd_keys key_pressed = kbd_keys::none;
static uint_<8> p61data = 0;


static uint_<8> sb_mixer_index = 0;
static uint_<8> sb_master_volume = 0xff;
static uint_<8> sb_unknown_3f = 0xff;
static uint_<16> sb_freq = 0;

static uint_<8>::type dsp_data[64];
static uint_<8> dsp_wr_index = 0;
static uint_<8> dsp_rd_index = 0;
static uint_<8> dsp_last_rd_val = 0;

static uint_<8> dsp_cmd = 0;
static uint_<8> dsp_cmd_len = 0;
static uint_<32> dsp_cmd_data = 0;


static uint_<8>::type dsp_cmd_lens[256] = {
  0,0,0,0, 1,2,0,0, 1,0,0,0, 0,0,2,1,  // 0x00
  1,0,0,0, 2,2,2,2, 0,0,0,0, 0,0,0,0,  // 0x10
  0,0,0,0, 2,0,0,0, 0,0,0,0, 0,0,0,0,  // 0x20
  0,0,0,0, 0,0,0,0, 1,0,0,0, 0,0,0,0,  // 0x30

  1,2,2,0, 0,0,0,0, 2,0,0,0, 0,0,0,0,  // 0x40
  0,0,0,0, 0,0,0,0, 0,0,0,0, 0,0,0,0,  // 0x50
  0,0,0,0, 0,0,0,0, 0,0,0,0, 0,0,0,0,  // 0x60
  0,0,0,0, 2,2,2,2, 0,0,0,0, 0,0,0,0,  // 0x70

  2,0,0,0, 0,0,0,0, 0,0,0,0, 0,0,0,0,  // 0x80
  0,0,0,0, 0,0,0,0, 0,0,0,0, 0,0,0,0,  // 0x90
  0,0,0,0, 0,0,0,0, 0,0,0,0, 0,0,0,0,  // 0xa0
  3,3,3,3, 3,3,3,3, 3,3,3,3, 3,3,3,3,  // 0xb0

  3,3,3,3, 3,3,3,3, 3,3,3,3, 3,3,3,3,  // 0xc0
  0,0,0,0, 0,0,0,0, 0,0,0,0, 0,0,0,0,  // 0xd0
  1,0,1,0, 1,0,0,0, 0,0,0,0, 0,0,0,0,  // 0xe0
  0,0,0,0, 0,0,0,0, 0,1,0,0, 0,0,0,0   // 0xf0
};


void inb(uint_<8> & d, uint_<16> port)
{
    d = 0;
    switch (port)
    {
    case 0x00 ... 0x0f:
        d = dma_controllers[0].read_controller_reg(port);
        break;

    case 0x81 ... 0x83:
    case 0x89 ... 0x8b:
        d = dma_read_p8x(port);
        break;

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
        d = dma_controllers[1].read_controller_reg((port - 0xc0) / 2);
        break;

    case 0x20:
        d = pic.read_command(port);
        break;

    case 0x21:
        d = pic.read_data(port);
        break;

    case 0x40:
    case 0x41:
    case 0x42:
        d = timer_read_latch(port);
        break;

    case 0x60:
        d = static_cast<typename uint_<8>::type>(key_pressed);
        key_pressed = kbd_keys::none;
        break;

    case 0x61:
        p61data ^= 0x30;
        d = p61data;
        break;

/*    case 0x64: // Keyboard Controller
        d = 0x1c | (p60_change ? 0x1 : 0);
        break;
*/
    case 0x92:
        d = a20_gate ? 0x2 : 0;
        break;

    case 0x215:
        al = 0xff;
        break;

    case 0x224:
        d = sb_mixer_index;
        break;

    case 0x225:
        switch (sb_mixer_index)
        {
        case 0x22:
            d = sb_master_volume; // @todo error
            break;
        case 0x3f:
            d = sb_unknown_3f;
            break;
        default:
            throw exo::exception::not_implemented();
        }
        break;

    case 0x22a: // sb read_data
        if (dsp_rd_index != dsp_wr_index)
        {
            dsp_last_rd_val = dsp_data[dsp_rd_index];
            dsp_rd_index++;
            dsp_rd_index %= count_of(dsp_data);
        }
        d = dsp_last_rd_val;
        break;

    case 0x22c: // sb write_data
        d = 0x7f; // ?
        break;

    case 0x22e: // sb read_status
        d = 0xff; // ?
        break;

    case 0x22f:
        d = 0xff;
        break;

    case 0x3cc:
        d = vga_misc_output;
        break;

    case 0x3d5:
        switch (vga_crtc_index)
        {
        case 0x3:
            d = vga_crtc_end_horizontal_blanking;
            break;
        case 0x7:
            d = vga_crtc_overflow;
            break;
        case 0x9:
            d = vga_crtc_maximum_scan_line;
            break;
        case 0x11:
            d = vga_crtc_vertical_retrace_end;
            break;
        default:
            throw exo::exception::not_implemented();
            break;
        }
        break;

    case 0x214:
        // @todo Пока игнорируем.
        break;

    default:
        throw exo::exception::not_implemented();
        break;
    }
}

void outb(uint_<16> port, uint_<8> s)
{
    switch (port)
    {
    case 0x00 ... 0x0f:
        dma_controllers[0].write_controller_reg(port, s);
        break;

    case 0x81 ... 0x83:
    case 0x89 ... 0x8b:
        dma_write_p8x(port, s);
        break;

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
        dma_controllers[1].write_controller_reg((port - 0xc0) / 2, s);
        break;

    case 0x20:
        pic.write_command(port, s);
        break;

    case 0x21:
        pic.write_data(port, s);
        break;

    case 0x40:
    case 0x42:
        timer_write_latch(port, s);
        break;

    case 0x43:
        timer_write_p43(s);
        break;

    case 0x61:
        if (((p61data ^ s) & 3) != 0 &&
            ((p61data ^ s) & 1) != 0)
                TIMER_SetGate2(0 != (s & 1));
        p61data = s;
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
            throw exo::exception::not_implemented();
            break;
        }
        break;
*/
    case 0x70:
        cmos_reg = s & 0x3f;
        cmos_nmi = 0 != (s & 0x80);
        break;

    case 0x71:
        if (cmos_reg != 0xf)
            throw exo::exception::not_implemented();
        break;

    case 0x92:
        a20_gate = 0 != (s & 0x2);
        break;

    case 0x224: // Mixer index
        sb_mixer_index = s;
        break;

    case 0x225: // Mixer data
        switch (sb_mixer_index)
        {
        case 0x22:
            sb_master_volume = s; // @todo error
            break;
        case 0x3f:
            sb_unknown_3f = s;
            break;
        case 0x83:
            break;
        default:
            throw exo::exception::not_implemented();
        }
        break;

    case 0x226:    // DSP_Reset
        dsp_data[dsp_wr_index] = 0xaa;
        dsp_wr_index++;
        dsp_wr_index %= count_of(dsp_data);
        break;

    case 0x22c:    // DSP_WriteData
        if (dsp_cmd == 0)
        {
            dsp_cmd = s;
            dsp_cmd_len = dsp_cmd_lens[dsp_cmd];
            dsp_cmd_data = 0;
        }
        else if (dsp_cmd_len != 0)
        {
            dsp_cmd_data = (dsp_cmd_data << 8) | s;
            dsp_cmd_len--;
        }

        if (dsp_cmd_len == 0) // Команда прочитана полностью.
        {
            switch (dsp_cmd)
            {
            case 0x41: // Set output sample rate
                sb_freq = dsp_cmd_data;
//                std::cout << "sb_freq: " << sb_freq << std::endl;
                break;

                // b4 30ff0f - sign, DSP_DMA_16, 0x1000, 1, 1
                // DSP_PrepareDMA_New(DMA_MODES mode, uint_<32> length, bool autoinit, bool stereo)
            case 0xb4:
            {
                if (dsp_cmd_data != 0x30ff0f)
                    throw exo::exception::not_implemented();

                dma_channel & chan = dma_get_channel(5);
                if (chan.masked)
                    throw exo::exception::not_implemented();

                uint_<16> buf[0x1000];
                chan.read(buf, 0x1000);
                pic.activate_irq(7);
                break;
            }

            default:
                throw exo::exception::not_implemented();
            }

            dsp_cmd = 0;
            dsp_cmd_data = 0;
        }
        break;

    case 0x3c2:
        vga_misc_output = s;
//        std::cerr << "\tvga_misc_output >> 6: " << static_cast<uint_<32>>(vga_misc_output >> 6) << std::endl;

//        if (s & 1)
//            std::cout << "base addr 0x3d?";
//        else
//            std::cout << "base addr 0x3b?"; // this
//        std::cout << std::endl;
        break;

    case 0x3c8:
        pal_index = s;
        pal_rgb = 0;
        break;

    case 0x3c9:
        s &= 0x3f; // 6 bit color
        pal[pal_index].rgb[pal_rgb] = (s << 2) | (s >> 4); // round color to 8 bit
        pal_rgb++;
        if (3 <= pal_rgb)
        {
            pal_index++;
            pal_rgb = 0;
        }
        break;

    case 0x3d4:
        vga_crtc_index = s;
        break;

    case 0x214:
    case 0x215:
        // @todo Временно игнорируем.
        break;

    default:
        throw exo::exception::not_implemented();
        break;
    }
}

void outw(uint_<16> port, uint_<16> s)
{
    switch (port)
    {
//    case 0x00 ... 0x07:
//        dma_controllers[0].write_controller_reg(port, s);
//        break;
//
//    case 0xc0:
//    case 0xc2:
//    case 0xc4:
//    case 0xc6:
//    case 0xc8:
//    case 0xca:
//    case 0xcc:
//    case 0xce:
//        dma_controllers[1].write_controller_reg((port - 0xc0) / 2, s);
//        break;

    case 0x3c4:
        vga_seq_index = s;
        break;

    case 0x3d4:
        vga_crtc_index = s;
        break;

    default:
        throw exo::exception::not_implemented();
        break;
    }
}

void outd(uint_<16> port, uint_<32> /* s */)
{
    switch (port)
    {
    default:
        throw exo::exception::not_implemented();
        break;
    }
}

} /* namespace dos */
} /* namespace raw_program */
