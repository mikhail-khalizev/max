#include <stdexcept>
#include <exo/exception.hpp>

#include "dos/dma.hpp"
#include "x86/memory.hpp"


namespace raw_program {
namespace dos {

using namespace exo;
using namespace x86;


dma_controller dma_controllers[2] = {0, 1};
static uint_<32> dma_wrapping = 0xffff;


dma_channel::dma_channel(uint_<8> num, bool dma16)
: callback(NULL)
, pagebase(0)
, curraddr(0)
, baseaddr(0)
, basecnt(0)
, currcnt(0)
, channum(0)
, pagenum(0)
, DMA16(0)
//, trantype(0)
, increment(false)
, autoinit(false)
, masked(true)
, tcount(false)
, request(false)
{
    if (num == 4)
        return;

    channum = num;
    DMA16 = dma16 ? 0x1 : 0x0;
    increment = true;
}

void dma_channel::do_callback(dma_event event)
{
    if (callback)
        (*callback)(this, event);
}

void dma_channel::set_mask(bool _mask)
{
    masked = _mask;
    do_callback(masked ? dma_event::masked : dma_event::unmasked);
}

void dma_channel::register_callback(dma_callback _cb)
{
    callback = _cb;
    set_mask(masked);

    if (callback != NULL)
        raise_request();
    else
        clear_request();
}

void dma_channel::reached_tc(void)
{
    tcount = true;
    do_callback(dma_event::reached_tc);
}

void dma_channel::set_page(uint_<8> val)
{
    pagenum = val;

    pagebase = val & (~DMA16);
    pagebase <<= 16;
}

void dma_channel::raise_request(void)
{
    request = true;
}

void dma_channel::clear_request(void)
{
    request = false;
}


/* read a block from physical memory */
static void dma_block_read(uint_<8> * write, uint_<32> base, uint_<32> offset, uint_<32> size, uint_<8> dma16)
{
    if (dma_wrapping < offset + size)
        throw exo::exception::not_implemented();


    size <<= dma16;
    offset <<= dma16;
    const uint_<32> dma_wrap = ((0xffff << dma16) + dma16) | dma_wrapping;


    const uint_<32> size_p1 = std::min<uint_<32>>(size, dma_wrap + 1 - offset);

    mem_phys_raw(base + offset, size_p1).sub_space(0, size_p1).copy_to(write);


    const uint_<32> size_p2 = size - size_p1;
    if (size_p2 != 0)
        mem_phys_raw(base, size_p2).sub_space(0, size_p2).copy_to(&write[size_p1]);
}

/* write a block into physical memory */
static void dma_block_write(uint_<8> * read, uint_<32> base, uint_<32> offset, uint_<32> size, uint_<8> dma16)
{
    if (dma_wrapping < offset + size)
        throw exo::exception::not_implemented();


    size <<= dma16;
    offset <<= dma16;
    const uint_<32> dma_wrap = ((0xffff << dma16) + dma16) | dma_wrapping;


    const uint_<32> size_p1 = std::min<uint_<32>>(size, dma_wrap + 1 - offset);

    mem_phys_raw(base + offset, size_p1).sub_space(0, size_p1).copy_from(read);


    const uint_<32> size_p2 = size - size_p1;
    if (size_p2 != 0)
        mem_phys_raw(base, size_p2).sub_space(0, size_p2).copy_from(&read[size_p1]);
}


uint_<32> dma_channel::read(void * _buffer, uint_<32> want)
{
    uint_<8> * buffer = reinterpret_cast<uint_<8>*>(_buffer);

    uint_<32> done = 0;
    curraddr &= dma_wrapping;

again:

    uint_<16> left = currcnt + 1;
    if (want < left)
    {
        dma_block_read(buffer, pagebase, curraddr, want, DMA16);
        done += want;
        curraddr += want;
        currcnt -= want;
    }
    else
    {
        dma_block_read(buffer, pagebase, curraddr, left, DMA16);

        buffer += left << DMA16;
        want -= left;
        done += left;
        reached_tc();

        if (autoinit)
        {
            currcnt = basecnt;
            curraddr = baseaddr;
            if (want != 0)
                goto again;
        }
        else
        {
            curraddr += left;
            currcnt = 0xffff;
            masked = true;
            do_callback(dma_event::transferend);
        }
    }

    return done;
}

uint_<32> dma_channel::write(uint_<8> * buffer, uint_<32> want)
{
    uint_<32> done= 0;
    curraddr &= dma_wrapping;

again:

    uint_<16> left = (currcnt + 1);
    if (want < left)
    {
        dma_block_write(buffer, pagebase, curraddr, want, DMA16);
        done += want;
        curraddr += want;
        currcnt -= want;
    }
    else
    {
        dma_block_write(buffer, pagebase, curraddr, left, DMA16);
        buffer += left << DMA16;
        want -= left;
        done += left;
        reached_tc();

        if (autoinit)
        {
            currcnt = basecnt;
            curraddr = baseaddr;
            if (want != 0)
                goto again;
        }
        else
        {
            curraddr += left;
            currcnt = 0xffff;
            masked = true;
            do_callback(dma_event::transferend);
        }
    }

    return done;
}


dma_controller::dma_controller(int num)
: dma_channels({
    dma_channel(num * 4 + 0, num == 1),
    dma_channel(num * 4 + 1, num == 1),
    dma_channel(num * 4 + 2, num == 1),
    dma_channel(num * 4 + 3, num == 1)
})
, ctrlnum(num)
, flipflop(false)
{}

dma_channel & dma_controller::get_channel(uint_<8> chan)
{
    if (4 <= chan)
        throw std::invalid_argument("channal number");

    return dma_channels[chan];
}

void dma_controller::write_controller_reg(uint_<32> reg, uint_<32> val)
{
    switch (reg)
    {
    case 0x0:    /* set base address of DMA transfer (1st byte low part, 2nd byte high part) */
    case 0x2:
    case 0x4:
    case 0x6:
    {
        dma_channel & chan = get_channel(reg >> 1);
        flipflop = !flipflop;
        if (flipflop)
        {
            chan.baseaddr = (chan.baseaddr & 0xff00) | val;
            chan.curraddr = (chan.curraddr & 0xff00) | val;
        }
        else
        {
            chan.baseaddr = (chan.baseaddr & 0x00ff) | (val << 8);
            chan.curraddr = (chan.curraddr & 0x00ff) | (val << 8);
        }
        break;
    }

    case 0x1:    /* set DMA transfer count (1st byte low part, 2nd byte high part) */
    case 0x3:
    case 0x5:
    case 0x7:
    {
        dma_channel & chan = get_channel(reg >> 1);
        flipflop = !flipflop;
        if (flipflop)
        {
            chan.basecnt = (chan.basecnt & 0xff00) | val;
            chan.currcnt = (chan.currcnt & 0xff00) | val;
        }
        else
        {
            chan.basecnt = (chan.basecnt & 0x00ff) | (val << 8);
            chan.currcnt = (chan.currcnt & 0x00ff) | (val << 8);
        }
        break;
    }

    case 0x8:    /* Comand reg not used */
        throw exo::exception::not_implemented();
        break;

    case 0x9:    /* Request registers, memory to memory */
        throw exo::exception::not_implemented();
        break;

    case 0xa:    /* Mask Register */
        get_channel(val & 3).set_mask((val & 0x4) != 0);
        break;

    case 0xb:    /* Mode Register */
    {
        dma_channel & chan = get_channel(val & 3);
        chan.autoinit = (val & 0x10) != 0;
        chan.increment = (val & 0x20) != 0;
        //TODO Maybe other bits?
        break;
    }

    case 0xc:    /* Clear Flip/Flip */
        flipflop = false;
        break;

    case 0xd:    /* Master Clear/Reset */
        for (int ct = 0; ct < 4; ct++)
        {
            dma_channel & chan = get_channel(ct);
            chan.set_mask(true);
            chan.tcount = false;
        }
        flipflop = false;
        break;

    case 0xe:    /* Clear Mask register */
        for (int ct = 0; ct < 4; ct++)
        {
            dma_channel & chan = get_channel(ct);
            chan.set_mask(false);
        }
        break;

    case 0xf:    /* Multiple Mask register */
        for (int ct = 0; ct < 4; ct++)
        {
            dma_channel & chan = get_channel(ct);
            chan.set_mask(val & 1);
            val >>= 1;
        }
        break;
    }
}

uint_<16> dma_controller::read_controller_reg(uint_<16> reg)
{
    switch (reg)
    {
    case 0x0:    /* read base address of DMA transfer (1st byte low part, 2nd byte high part) */
    case 0x2:
    case 0x4:
    case 0x6:
    {
        dma_channel & chan = get_channel(reg >> 1);
        flipflop = !flipflop;
        if (flipflop)
            return chan.curraddr & 0xff;
        else
            return (chan.curraddr >> 8) & 0xff;
    }

    case 0x1:    /* read DMA transfer count (1st byte low part, 2nd byte high part) */
    case 0x3:
    case 0x5:
    case 0x7:
    {
        dma_channel & chan = get_channel(reg >> 1);
        flipflop = !flipflop;
        if (flipflop)
            return chan.currcnt & 0xff;
        else
            return (chan.currcnt >> 8) & 0xff;
    }

    case 0x8:    /* Status Register */
    {
        uint_<16> ret = 0;
        for (int ct = 0; ct < 4; ct++)
        {
            dma_channel & chan = get_channel(ct);

            if (chan.tcount)
                ret |= 1 << ct;

            chan.tcount = false;

            if (chan.request)
                ret |= 1 << (4 + ct);
        }
        return ret;
    }

    default:
        throw exo::exception::not_implemented();
        break;
    }

    return -1;
}


dma_channel & dma_get_channel(uint_<8> chan)
{
    if (chan < 4) /* channel on first DMA controller */
        return dma_controllers[0].get_channel(chan);
    else if (chan < 8) /* channel on second DMA controller */
        return dma_controllers[1].get_channel(chan - 4);

    throw std::invalid_argument("channal number");
}

void dma_write_p8x(uint_<16> port, uint_<16> val)
{
    switch (port)
    {
        /* write DMA page register */
        case 0x81: dma_get_channel(2).set_page(val); break;
        case 0x82: dma_get_channel(3).set_page(val); break;
        case 0x83: dma_get_channel(1).set_page(val); break;
        case 0x89: dma_get_channel(6).set_page(val); break;
        case 0x8a: dma_get_channel(7).set_page(val); break;
        case 0x8b: dma_get_channel(5).set_page(val); break;
        default: throw std::invalid_argument("port number");
    }
}

uint_<16> dma_read_p8x(uint_<16> port)
{
    switch (port)
    {
        /* read DMA page register */
        case 0x81: return dma_get_channel(2).pagenum;
        case 0x82: return dma_get_channel(3).pagenum;
        case 0x83: return dma_get_channel(1).pagenum;
        case 0x89: return dma_get_channel(6).pagenum;
        case 0x8a: return dma_get_channel(7).pagenum;
        case 0x8b: return dma_get_channel(5).pagenum;
        default: throw std::invalid_argument("port number");
    }
}


//static void dma_set_wrapping(uint_<32> wrap)
//{
//    dma_wrapping = wrap;
//}


} /* namespace dos */
} /* namespace raw_program */
