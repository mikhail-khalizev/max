#include <string>
#include <sstream>
#include <iomanip>
#include <iostream>
#include <string.h>

#include <errno.h>
#include <fcntl.h>
#include <unistd.h>
#include <sys/vfs.h>
#include <sys/types.h>

#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Weffc++"
#pragma GCC diagnostic ignored "-Wold-style-cast"
#include <gtkmm.h>
#pragma GCC diagnostic pop

#include <exo/linux.hpp>
#include <exo/exception.hpp>
#include <exo/math/round.hpp>
#include <exo/util/count_of.hpp>

#include "x86/registers.hpp"
#include "x86/instructions.hpp"
#include "dos/pic.hpp"
#include "dos/ports.hpp"
#include "dos/memory.hpp"
#include "dos/interrupt.hpp"
#include "program/raw_program.hpp"


namespace raw_program {

extern bool extra_log;

namespace dos {

using namespace exo;
using namespace x86;


static void syscall_iretww()
{
    bool cf_save = cf;
    iret_(16);
    cf = cf_save;
}


struct mode_info
{
    uint_<16> ModeAttributes;
    uint_<8> WinAAttributes;
    uint_<8> WinBAttributes;
    uint_<16> WinGranularity;
    uint_<16> WinSize;
    uint_<16> WinASegment;
    uint_<16> WinBSegment;
    uint_<32> WinFuncPtr;
    uint_<16> BytesPerScanLine;
    uint_<16> XResolution;
    uint_<16> YResolution;
    uint_<8> XCharSize;
    uint_<8> YCharSize;
    uint_<8> NumberOfPlanes;
    uint_<8> BitsPerPixel;
    uint_<8> NumberOfBanks;
    uint_<8> MemoryModel;
    uint_<8> BankSize;
    uint_<8> NumberOfImagePages;
    uint_<8> Reserved_page;
    uint_<8> RedMaskSize;
    uint_<8> RedMaskPos;
    uint_<8> GreenMaskSize;
    uint_<8> GreenMaskPos;
    uint_<8> BlueMaskSize;
    uint_<8> BlueMaskPos;
    uint_<8> ReservedMaskSize;
    uint_<8> ReservedMaskPos;
    uint_<8> DirectColorModeInfo;
    uint_<32> PhysBasePtr;
    uint_<32> OffScreenMemOffset;
    uint_<16> OffScreenMemSize;
    uint_<8>::type Reserved[206];
};

static void callback_setwindow() {}

void int_08()
{
    const uint_<32> BIOS_TIMER = 0x46c;

    // Update time

    memory_space bios_timer_ms = mem_phys_raw(BIOS_TIMER, 4);
    if (bios_timer_ms.size() < 4)
        throw std::logic_error("Недостаточно памяти.");

    uint_<32> & bios_timer_value = bios_timer_ms.get<uint_<32>>();


//    if (bios_timer_value == 0)
//    {
//        using namespace exo::linux;
//        calendar_time loctime = calendar_time::localtime(time::get_clock_time(clock_id::realtime));
//
//        bios_timer_value = static_cast<uint_<32>>(loctime.hour * 3600 + loctime.min * 60 + loctime.sec) * 1193182 / 65536;
//    }
//    else
        bios_timer_value++;


    uint_<8> mode = (cs.get_db() ? 32 : 16);
    int_(0x1c);

    outb(0x20, 0x20);
    iret_(16);
}

// +
void int_10()
{
    const uint_<32> vga_vmemsize = 0x200000;

    switch (ah)
    {
    case 0x0f:
        ah = 0x50; // width in char
        al = 0x3; // video mode
        bh = 0; // page
        break;

    case 0x4f: // VESA Calls
        switch (al)
        {
        case 0x01: // Get SVGA Mode Information
            if (cx != 0x101)
                throw exception::not_implemented();

            al = 0x4f;
            ah = 0; // success

            {
                uint_<32> page_size = 640 * 480;
                page_size = page_size & (~15);

                uint_<16> mode_attr = 0x9b;

                mode_info & mi = mem_seg_pg_raw(es, di, sizeof(mi)).get<mode_info>();
                memset(&mi, 0, sizeof(mi));

                mi.BytesPerScanLine = 640;
                mi.NumberOfPlanes = 1;
                mi.BitsPerPixel = 8;
                mi.MemoryModel = 4;
                mi.WinAAttributes = 7;

                if (vga_vmemsize < page_size)
                {
                    throw exception::not_implemented();
                }
                else
                {
                    mi.ModeAttributes = mode_attr;
                    mi.NumberOfImagePages = (vga_vmemsize / page_size) - 1;
                }

                mi.WinGranularity = 64;
                mi.WinSize = 64;
                mi.WinASegment = 0xa000;
                mi.XResolution = 640;
                mi.YResolution = 480;

                static bool added = false;
                if (added == false)
                {
                    raw_program::add_internal_dyn_func(callback_setwindow, 16, 0xf0001320u);
                    added = true;
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
                throw exception::not_implemented();

            al = 0x4f;
            ah = 0; // success

            // /* mode  ,type     ,sw  ,sh  ,tw ,th ,cw,ch ,pt,pstart  ,plength,htot,vtot,hde,vde special flags */
            //{ 0x101  ,M_LIN8   ,640 ,480 ,80 ,30 ,8 ,16 ,1 ,0xa0000 ,0x10000,100 ,525 ,80 ,480 ,0    },

            break;

        case 0x05:
            if (bh != 0)
                throw exception::not_implemented();

            // ah = SetCPUWindow(bl, dl); (window, address)

            if (bl != 0)
                ah = 1;
            else
            {
                if (dl * 0x10000 < vga_vmemsize)
                {
                    ah = 0;
                    // out(0x3d4, 0x6a)
                    // out(0x3d5, dl)
//std::cerr << static_cast<uint_<32>>(dl) << std::endl;

                    // 640 * 480 = 0x4b000

                    const int buf_width = 640;
                    const int buf_height = 480;

                    static uint_<8> curr_bank_num = 0; // @todo uint_o ?
                    static uint_<8>::type img_data[3 * buf_width * buf_height];


                    exo::memory_space curr_bank = mem_phys_raw(0xa0000, 0x10000).sub_space(0, 0x10000);


                    const int offset = 3 * curr_bank_num * 0x10000;
                    for (int i = 0; i < 0x10000; i++)
                    {
                        if (exo::util::count_of(img_data) <= offset + 3 * i + 2)
                            break;

                        uint_<8> c = curr_bank.get<uint_<8>>(i);

#if 0
                        img_data[offset + 3 * i + 0] = c;
                        img_data[offset + 3 * i + 1] = c;
                        img_data[offset + 3 * i + 2] = c;
#else
                        img_data[offset + 3 * i + 0] = pal[c].rgb[0];
                        img_data[offset + 3 * i + 1] = pal[c].rgb[1];
                        img_data[offset + 3 * i + 2] = pal[c].rgb[2];
#endif
                    }


                    if (dl == 0)
                    {
                        int height = 480;
                        int width = 640;

#if 0
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

                        Glib::RefPtr<Gdk::Pixbuf> img =
                                Gdk::Pixbuf::create_from_data(
                                        reinterpret_cast<guint8*>(&img_data[3 * ((buf_width - width) / 2)]),
                                        Gdk::COLORSPACE_RGB,
                                        false, 8,
                                        width,
                                        height,
                                        buf_width * 3);


                        static uint_<32> num = 0;
                        num++;

                        std::stringstream path;
                        path.fill('0');
                        path << "/tmp/img" << std::setw(4) << num << ".png";

                        img -> save(path.str(), "png");
                        std::cout << "draw " << std::dec << num << ".png" << std::endl;

                        extra_log = (124 <= num); /* Движение единиц. */
                    }


                    static uint_<8>::type all_banks[exo::math::round_up(buf_width * buf_height, 0x10000)];

                    bool need_cpy = (curr_bank_num * 0x10000 < sizeof(all_banks));

                    if (need_cpy)
                        curr_bank.copy_to(&all_banks[curr_bank_num * 0x10000]);

                    curr_bank_num = dl;

                    if (need_cpy)
                        curr_bank.copy_from(&all_banks[curr_bank_num * 0x10000]);
                }
                else
                    ah = 1;
            }

            al = 0x4f;
            break;

        default:
            throw exception::not_implemented();
            break;
        }

        break;

    default:
        throw exception::not_implemented();
        break;
    }

    syscall_iretww();
}

// +
/* int_sys_srv */
void int_15()
{
    switch (ah)
    {
    case 0xbf:
        ah = 0x86; // from dosbox.
        cf = true;
        break;

    case 0xc0:

        ah = 0;
        bx = 0;
        es = 0xc8c3; /* from dosbox */

        memw_a16(es, bx + 0x2) = 0xfc; // model id
        cf = false;

        break;

    case 0x88: /* Extended memory size. */
        ax = 0;
        cf = false;
        break;

    default:
        throw exception::not_implemented();
        break;
    }

    syscall_iretww();
}

void int_16()
{
    switch (ah)
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
        throw exception::not_implemented();
        break;
    }

    syscall_iretww();
}

void int_1c()
{
    iret_(16);
}

static std::string get_path()
{
    std::string path = reinterpret_cast<char*>(&memb_a16(ds, dx));

    for (char & val: path)
        if (val == '\\')
            val = '/';

    if (strncmp(path.c_str(), "C:/", 3) == 0)
        path.erase(0, 3);

    if (path[0] != '/')
    {
        for (char & val: path)
            if ('a' <= val && val <= 'z')
                val += 'A' - 'a';

        path = "../orig_max/" + path;
    }

    return path;
}

// +
/* int_dos */
void int_21()
{
    switch (ah)
    {
    case 0x06:
        if (dl == 0xff)
            throw exception::not_implemented();
        else
        {
            std::cout << dl;
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
            throw exception::not_implemented();

        int_set(al, ds, dx);;
    }
        break;

    case 0x2a:              /* Get System Date */
        {
            using namespace exo::linux;

            calendar_time ct(time::get_clock_time(clock_id::realtime));

            cx = ct.get_year();
            dh = ct.month + 1;
            dl = ct.mday;
            al = ct.wday;
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
        static bool on = false;

        if (al == 0)
            dl = on ? 1 : 0;
        else
            on = (dl != 0);
    }
        break;

    case 0x34:
        es = 0xb2; // SDA seg
        bx = 1;
        break;

    case 0x35: // get interrupt vector
    {
        // al <- int num. es:bx >- addr of int
        if (cr0.pe)
            throw exception::not_implemented();

        int_get(al, es, bx);
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
            throw exception::not_implemented();

        ax = 1;
        bx = 1;
        break;

    case 0x3c: // create_file
    {
        std::string path = get_path();

        // @todo
        std::cerr << "\tCreate: " << path << std::endl;

        int fd = open(path.c_str(), O_CLOEXEC | O_CREAT | O_TRUNC, 0644);
        if (0 <= fd)
        {
            cf = false;
            if (0x7FFF < fd)
                std::exception();

            ax = fd;
        }
        else
            throw exception::not_implemented();
    }
        break;

    case 0x3d: // open_file
    {
        std::string path = get_path();

        // @todo
        std::cerr << "\tOpen: " << path << std::endl;

        int flag = O_CLOEXEC;

        switch (al)
        {
        case 0:
            flag |= O_RDONLY;
            break;
        case 2:
            flag |= O_RDWR;
            break;
        default:
            throw exception::not_implemented();
            break;
        }

        const char * path_c_str = path.c_str();
        int fd = open(path_c_str, flag);

        raw_program::debug_breakpoint(); // @todo remove?

        if (0 <= fd)
        {
            cf = false;
            if (0x7fff < fd)
                std::exception();

            ax = fd;
        }
        else
        {
            cf = true;
            switch (errno)
            {
            case EACCES: ax = 5; break;
            case ENOENT: ax = 2; break;
            default: ax = 1; break;
            }
        }
    }
        break;

    case 0x3e: // close_file
        if (bx <= 0x7FFF)
        {
            int fd = close(bx);
            if (fd == 0)
            {
                cf = false;
                break;
            }
        }

        cf = true;
        ax = 6;
        break;

    case 0x3f: // read
    {
        ssize_t readed = read(bx, mem_seg_pg_raw(ds, dx, cx).data(), cx);
        if (0 <= readed)
        {
            cf = false;
            if (0x7FFF < readed)
                throw std::exception();
            ax = readed;
        }
        else
        {
            cf = true;
            ax = 6;
        }
    }
        break;

    case 0x40: // write
    {
        ssize_t writed = write(bx, mem_seg_pg_raw(ds, dx, cx).data(), cx);
        if (0 <= writed)
        {
            cf = false;
            if (0x7fff < writed)
                throw std::exception();
            ax = writed;
        }
        else
        {
            cf = true;
            ax = 6;
        }
    }
        break;

    case 0x41: // delete
    {
        std::string path = get_path();
        // @todo
        std::cerr << "\tDelete: " << path << std::endl;

        int ok = unlink(path.c_str());
        if (ok == 0)
        {
            cf = false;
        }
        else
        {
            cf = true;
            ax = 2;
        }
    }
        break;

    case 0x42: // lseek
    {
        int whence;
        switch (al)
        {
        case 0:
            whence = SEEK_SET;
            break;
        case 1:
            whence = SEEK_CUR;
            break;
        case 2:
            whence = SEEK_END;
            break;
        default:
            throw exception::not_implemented();
            break;
        }

        sint_<32> to_seek(cx, dx);

        off_t new_off = lseek(bx, to_seek, whence);
        if (new_off != static_cast<off_t>(-1))
        {
            cf = false;
            ax = new_off;
            dx = new_off >> 16;
        }
        else
        {
            cf = true;
            ax = 6;
        }
    }
        break;

    case 0x43:
    {
        std::string path = get_path();
        if (al != 0)
            throw exception::not_implemented();

        cf = true;

        try
        {
            cx = 0;

            if (linux::stat::file(path.c_str()).get_type() == linux::file_type::directory)
                cx |= 16;

            cf = false;
        }
        catch (linux::exception::no_such_file_or_directory &)
        {
            ax = 2;
        }
        catch (linux::exception::general &)
        {
            ax = 1;
        }
    }
        break;

    case 0x44: // ioctl
        if (bx <= 4) // "CON"
            if (al == 0)
            {
                cf = false;
                ax = dx = 0x80d3; // No key available.
                break;
            }

        ax = dx = 0x2;
        // throw exception::not_implemented();
        break;

    case 0x48:
        dos_mem_alloc();
        break;

    case 0x49:
        dos_mem_free();
        break;

    case 0x4a:
        dos_mem_resize();
        break;

    case 0x4c:
        // exit(al);
        throw std::logic_error("Exit");
        break;

    case 0x50: // seg psp
        if (bx != raw_program::pspseg)
            throw exception::not_implemented();
        break;

    case 0x51: // get psp
        bx = raw_program::pspseg;
        break;

    case 0x5a:
    {
        char * const path = reinterpret_cast<char*>(&memb_a16(ds, dx));
        if (strcmp(path, ".\\") != 0)
            throw exception::not_implemented();

        char * path_edit = path;
        strcpy(path_edit, "/tmp/");
        path_edit += 5;


        srand(time(NULL));


        for (int i = 0; i < 8; i++)
            path_edit[i] = (rand() % 26) + 'A';
        path_edit[8] = '\0';


        // @todo
        std::cerr << "\tCreate temp: " << path << std::endl;

        int fd = open(path, O_CLOEXEC | O_CREAT | O_EXCL, 0644);
        if (fd < 0 || 0xffff < fd)
            throw std::exception();

        cf = false;
        ax = fd;
    }
        break;

    default:
        throw exception::not_implemented();
        break;
    }

    syscall_iretww();
}

// +
void int_2f()
{
    switch (ax)
    {
    case 0x1600:
    case 0x1687:
        break;

    case 0x4300:
        al = 0x80; // XMS driver installed (HIMEM.SYS).
        break;

    case 0x4310:
    {
        es = 0xc83f;
        bx = 0x10;

        static bool added = false;
        if (added == false)
        {
            raw_program::add_internal_dyn_func(xms_handler, 16, es.get_base() + bx);
            added = true;
        }
    }
        break;

    default:
        throw exception::not_implemented();
        break;
    }

    syscall_iretww();
}

void int_31()
{
    cf = true;
    if (ax == 0x6)
    {
        seg_reg tmp = bx;
        dx = tmp.get_base();
        cx = tmp.get_base() >> 16;
        cf = false;
    }
    else if (ax == 0x7)
    {
        seg_reg::get_orig_desc_ref(bx).set_base((cx << 16) + dx);
        cf = false;
    }
    else
        throw exception::not_implemented();

    syscall_iretww();
}

// +
/** Mouse. */
void int_33()
{
    switch (ax)
    {
    case 0x0: // reset driver and read status
        pic.set_irq_mask(12, false);

        /* fall-through */

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
        throw exception::not_implemented();
        break;
    }

    syscall_iretww();
}

// +
void int_67()
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
        throw exception::not_implemented();

    syscall_iretww();
}

// +
static void int_unknown()
{
    throw exception::not_implemented();
}

// +
void install_std_ints()
{
    struct
    {
        uint_<8> num;
        void (*func)();
    } int_func[] = {
            {0x08, int_08},
            {0x10, int_10},
            {0x15, int_15},
            {0x16, int_16},
            {0x1c, int_1c},
            {0x21, int_21},
            {0x2f, int_2f},
            {0x31, int_31},
            {0x33, int_33},
            {0x67, int_67}
    };

    /* Взято из dosbox. */
    uint_<16>::type int_vec[] = {
            /* ip, cs, */
            0x1060, 0xf000,    // 0x00
            0x8, 0x70,    // 0x01
            0x8, 0x70,    // 0x02
            0x8, 0x70,    // 0x03
            0x8, 0x70,    // 0x04
            0x1060, 0xf000,    // 0x05
            0x1060, 0xf000,    // 0x06
            0x1060, 0xf000,    // 0x07
            0xfea5, 0xf000,    // 0x08
            0xe987, 0xf000,    // 0x09
            0xff55, 0xf000,    // 0x0a
            0x1060, 0xf000,    // 0x0b
            0x1060, 0xf000,    // 0x0c
            0x1060,    0xf000,    // 0x0d
            0x1080, 0xf000,    // 0x0e
            0x1060, 0xf000,    // 0x0f
            0x1300, 0xf000,    // 0x10
            0x1100, 0xf000,    // 0x11
            0x1120, 0xf000,    // 0x12
            0x1140, 0xf000,    // 0x13
            0x11a0, 0xf000,    // 0x14
            0x12cc, 0x5db,    // 0x15
            0x11e0, 0xf000,    // 0x16
            0x1220, 0xf000,    // 0x17
            0x12c0, 0xf000,    // 0x18
            0x12c0, 0xf000,    // 0x19
            0x1240,    0xf000,    // 0x1a
            0x1168, 0x5db,    // 0x1b
            0x1260, 0xf000,    // 0x1c
            0xf0a4, 0xf000,    // 0x1d
            0x1060, 0xf000,    // 0x1e
            0x500, 0xc000,    // 0x1f
            0x1480, 0xf000,    // 0x20
            0x14a0, 0xf000,    // 0x21
            0x20c8, 0xf000,    // 0x22
            0x1188, 0x5db,    // 0x23
            0x118c, 0x5db,    // 0x24
            0x14c0, 0xf000,    // 0x25
            0x14e0, 0xf000,    // 0x26
            0x1500,    0xf000,    // 0x27
            0x1520, 0xf000,    // 0x28
            0x1540, 0xf000,    // 0x29
            0x15c0, 0xf000,    // 0x2a
            0x1060, 0xf000,    // 0x2b
            0x1060, 0xf000,    // 0x2c
            0x1060, 0xf000,    // 0x2d
            0x1060, 0xf000,    // 0x2e
            0x15a0, 0xf000,    // 0x2f
            0x1060, 0xf000,    // 0x30
            0x1060, 0xf000,    // 0x31
            0x1060, 0xf000,    // 0x32
            0x10, 0xc7ff,    // 0x33
            0x1060,    0xf000,    // 0x34
            0x1060, 0xf000,    // 0x35
            0x1060, 0xf000,    // 0x36
            0x1060, 0xf000,    // 0x37
            0x1060, 0xf000,    // 0x38
            0x1060, 0xf000,    // 0x39
            0x1060, 0xf000,    // 0x3a
            0x1060, 0xf000,    // 0x3b
            0x1060, 0xf000,    // 0x3c
            0x1060, 0xf000,    // 0x3d
            0x1060, 0xf000,    // 0x3e
            0x1060, 0xf000,    // 0x3f
            0x1060, 0xf000,    // 0x40
            0x1160,    0xf000,    // 0x41
            0x1060, 0xf000,    // 0x42
            0x1700, 0xc000,    // 0x43
            0x1060, 0xf000,    // 0x44
            0x1060, 0xf000,    // 0x45
            0x1180, 0xf000,    // 0x46
            0x1060, 0xf000,    // 0x47
            0x1060, 0xf000,    // 0x48
            0x1060, 0xf000,    // 0x49
            0x1060, 0xf000,    // 0x4a
            0x1600, 0xf000,    // 0x4b
            0x1060, 0xf000,    // 0x4c
            0x1060, 0xf000,    // 0x4d
            0x1060,    0xf000,    // 0x4e
            0x1060, 0xf000,    // 0x4f
            0x1060, 0xf000,    // 0x50
            0x1060, 0xf000,    // 0x51
            0x1060, 0xf000,    // 0x52
            0x1060, 0xf000,    // 0x53
            0x1060, 0xf000,    // 0x54
            0x1060, 0xf000,    // 0x55
            0x1060, 0xf000,    // 0x56
            0x1060, 0xf000,    // 0x57
            0x1060, 0xf000,    // 0x58
            0x1060, 0xf000,    // 0x59
            0x1060, 0xf000,    // 0x5a
            0x1060,    0xf000,    // 0x5b
            0x1060, 0xf000,    // 0x5c
            0x1060, 0xf000,    // 0x5d
            0x1060, 0xf000,    // 0x5e
            0x1060, 0xf000    // 0x5f
    };

    for (unsigned int i = 0; i < sizeof(int_func) / sizeof(int_func[0]); i++)
        raw_program::add_internal_dyn_func(int_func[i].func, 16, int_vec[2 * int_func[i].num + 1] * 16 + int_vec[2 * int_func[i].num]);

    for (unsigned int i = 0; i < (sizeof(int_vec) / sizeof(int_vec[0])) / 2; i++)
    {
        uint_<32> func_addr = int_vec[2 * i + 1] * 16 + int_vec[2 * i];

        if (func_addr == 0)
            continue;

        raw_program::add_internal_dyn_func_if_free(int_unknown, 16, func_addr);
    }

    exo::memory_space ms = mem_pg_raw(0, sizeof(int_vec));
    memcpy(ms.data(), int_vec, sizeof(int_vec));
}


} /* namespace dos */
} /* namespace raw_program */
