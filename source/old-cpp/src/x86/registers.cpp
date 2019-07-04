#include <exo/exception.hpp>
#include "registers.hpp"


namespace raw_program {
namespace x86 {


uint_<32> eax, ebx, edx, ecx;
uint_<32> esi, edi;
uint_<32> ebp, esp;

seg_reg cs, ds, es, ss, fs, gs;

uint_<32> eip, eip_next;


bool id, vip, vif, ac, vm, rf, nt, of, df, if_, tf, sf, zf, af, pf, cf;
uint_<8> iopl;
eflag_reg eflags;

ia32_efer_reg ia32_efer;


cr0_reg cr0;
uint_<64> cr2, cr3;
cr4_reg cr4;


uint_<64> gdtr_base = 0;
uint_<16> gdtr_limit = 0xffff;

uint_<64> idtr_base = 0;
uint_<16> idtr_limit = 0xffff;

seg_reg lldr, tr;


eflag_reg::operator uint_<16>() const
{
    uint_<16> ret = 0;

    ret |= cf ? 0x01 : 0;
    ret |= 0x02; // Always set.
    ret |= pf ? 0x04 : 0;

    ret |= af ? 0x10 : 0;
    ret |= zf ? 0x40 : 0;
    ret |= sf ? 0x80 : 0;

    ret |= tf ? 0x0100 : 0;
    ret |= if_ ? eflag_mask::if_ : eflag_mask::none;
    ret |= df ? 0x0400 : 0;
    ret |= of ? 0x0800 : 0;

    ret |= (iopl & 0x3) << 12;
    ret |= nt ? 0x4000 : 0;

    return ret;
}

eflag_reg::operator uint_<32>() const
{
    uint_<32> ret = operator uint_<16>();

    ret |= rf ? 0x10000 : 0;
    ret |= vm ? 0x20000 : 0;
    ret |= ac ? 0x40000 : 0;
    ret |= vif ? 0x80000 : 0;

    ret |= vip ? 0x100000 : 0;
    ret |= id ? 0x200000 : 0;

    return ret;
}

eflag_reg & eflag_reg::operator=(uint_<32> val)
{
    cf = val & 0x01;
    pf = val & 0x04;

    af = val & 0x10;
    zf = val & 0x40;
    sf = val & 0x80;

    tf = val & 0x0100;
    if_ = val & 0x0200;
    df = val & 0x0400;
    of = val & 0x0800;

    iopl = (val >> 12) & 0x3;
    nt = val & 0x4000;

    rf = val & 0x10000;
    vm = val & 0x20000;
    ac = val & 0x40000;
    vif = val & 0x80000;

    vip = val & 0x100000;
    id = val & 0x200000;
    return *this;
}



cr0_reg::operator uint_<16>() const
{
    uint_<16> ret = 0;

    ret |= pe ? 0x1 : 0;
    ret |= mp ? 0x2 : 0;
    ret |= em ? 0x4 : 0;
    ret |= ts ? 0x8 : 0;
    ret |= et ? 0x10 : 0;
    ret |= ne ? 0x20 : 0;

    return ret;
}

cr0_reg::operator uint_<32>() const
{
    uint_<32> ret = operator uint_<16>();

    ret |= wp ? (1 << 16) : 0;
    ret |= am ? (1 << 18) : 0;

    ret |= nw ? (1 << 29) : 0;
    ret |= cd ? (1 << 30) : 0;
    ret |= pg ? (1 << 31) : 0;

    return ret;
}

cr0_reg & cr0_reg::operator=(uint_<32> val)
{
    pe = val & 0x1;
    mp = val & 0x2;
    em = val & 0x4;
    ts = val & 0x8;
    et = val & 0x10;
    ne = val & 0x20;

    wp = val & (1 << 16);
    am = val & (1 << 18);

    nw = val & (1 << 29);
    cd = val & (1 << 30);
    pg = val & (1 << 31);

    return *this;
}


} /* namespace x86 */
} /* namespace raw_program */
