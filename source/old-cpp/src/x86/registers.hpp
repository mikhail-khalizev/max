#ifndef OPENMAX_X86_REGISTERS_HPP_INCLUDED
#define OPENMAX_X86_REGISTERS_HPP_INCLUDED

#include <stdexcept>
#include <exo/global.hpp>
#include "x86/segment.hpp"


namespace raw_program {
namespace x86 {


struct eflag_reg
{
    operator uint_<16>() const;
    operator uint_<32>() const;
    eflag_reg & operator=(uint_<32> val);
};

struct eflag_mask
{
    enum __ : uint_<32>::type
    {
        none = 0,
        reserved = 0xffc0802a,

        cf = (1 << 0),
        pf = (1 << 2),
        af = (1 << 4),
        zf = (1 << 6),
        sf = (1 << 7),
        tf = (1 << 8),
        if_ = (1 << 9),
        df = (1 << 10),
        of = (1 << 11),
        iopl = (3 << 12),
        nt = (1 << 14),
        rf = (1 << 16),
        vm = (1 << 17),
        ac = (1 << 18),
        vif = (1 << 19),
        vip = (1 << 20),
        id = (1 << 21)
    };
};

struct cr3_mask
{
    enum __ : uint_<32>::type
    {
        none = 0,

        pwt = (1 << 3),
        pcd = (1 << 4)
    };
};

struct cr0_reg
{
    /** Protected mode. */
    bool pe;
    /** Paging. */
    bool pg;

    bool cd, nw, am, wp, ne, et, ts, em, mp;

    operator uint_<16>() const;
    operator uint_<32>() const;
    cr0_reg & operator=(uint_<32> val);
};

struct ia32_efer_reg
{
    bool sce;
    bool lme;
    bool lma;
    bool nxe;
};

struct cr4_reg
{
    bool smep, osxsave, pcide, fsgsbase, smxe, vmxe, osxmmexcpt, osfxsr, pce, pge, mce, pae, pse, de, tsd, pvi, vme;
};


extern uint_<32> eax, ebx, edx, ecx;
extern uint_<32> esi, edi;
extern uint_<32> ebp, esp;

//#pragma GCC diagnostic push
//#pragma GCC diagnostic ignored "-Wunused-variable"

static uint_<16> & ax = reinterpret_cast<uint_<16>*>(&eax)[0];
static uint_<16> & bx = reinterpret_cast<uint_<16>*>(&ebx)[0];
static uint_<16> & dx = reinterpret_cast<uint_<16>*>(&edx)[0];
static uint_<16> & cx = reinterpret_cast<uint_<16>*>(&ecx)[0];

static uint_<8> & ah = reinterpret_cast<uint_<8>*>(&ax)[1];
static uint_<8> & al = reinterpret_cast<uint_<8>*>(&ax)[0];

static uint_<8> & bh = reinterpret_cast<uint_<8>*>(&bx)[1];
static uint_<8> & bl = reinterpret_cast<uint_<8>*>(&bx)[0];

static uint_<8> & ch = reinterpret_cast<uint_<8>*>(&cx)[1];
static uint_<8> & cl = reinterpret_cast<uint_<8>*>(&cx)[0];

static uint_<8> & dh = reinterpret_cast<uint_<8>*>(&dx)[1];
static uint_<8> & dl = reinterpret_cast<uint_<8>*>(&dx)[0];

static uint_<16> & si = reinterpret_cast<uint_<16>*>(&esi)[0];
static uint_<16> & di = reinterpret_cast<uint_<16>*>(&edi)[0];

static uint_<16> & bp = reinterpret_cast<uint_<16>*>(&ebp)[0];
static uint_<16> & sp = reinterpret_cast<uint_<16>*>(&esp)[0];

//#pragma GCC diagnostic pop


extern seg_reg cs, ds, es, ss, fs, gs;

extern uint_<32> eip, eip_next /*< eip + instr_len */;

/* eflags */
extern bool id, vip, vif, ac, vm, rf, nt, of, df, if_, tf, sf, zf, af, pf, cf;
extern uint_<8> iopl;
extern eflag_reg eflags;

extern ia32_efer_reg ia32_efer;


extern cr0_reg cr0;
extern uint_<64> cr2, cr3;
extern cr4_reg cr4;


extern uint_<64> gdtr_base;
extern uint_<16> gdtr_limit;

extern uint_<64> idtr_base;
extern uint_<16> idtr_limit;

// + lldr -> ldtr
extern seg_reg lldr, tr;


inline uint_<8> get_cpl()
{
    if (cr0.pe)
        return cs.get_rpl();
    else
        return 0;
}


} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_REGISTERS_HPP_INCLUDED */

