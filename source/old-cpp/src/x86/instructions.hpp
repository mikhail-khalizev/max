#ifndef OPENMAX_X86_INSTRUCTIONS_HPP_INCLUDED
#define OPENMAX_X86_INSTRUCTIONS_HPP_INCLUDED

#include <utility>
#include <boost/preprocessor/seq/for_each.hpp>
#include <exo/global.hpp>
#include <exo/exception.hpp>

#include "dos/pic.hpp"
#include "dos/ports.hpp"
#include "x86/memory.hpp"


namespace raw_program {
namespace x86 {

#define CASE_DECLARE(z, data, elem)        \
    case elem :                            \
        goto BOOST_PP_CAT(l_, elem);


#define jaw_func(...)    \
    jmpw_func_if(cf == false && zf == false, __VA_ARGS__)

#define jad_func(...)    \
    jmpd_func_if(cf == false && zf == false, __VA_ARGS__)



#define jaed_func(...)   \
    jmpd_func_if(cf == false, __VA_ARGS__)

#define jbd_func(...)    \
    jmpd_func_if(cf == true, __VA_ARGS__)

#define jbew_func(...)   \
    jmpw_func_if(cf == true || zf == true, __VA_ARGS__)

#define jbed_func(...)   \
    jmpd_func_if(cf == true || zf == true, __VA_ARGS__)


#define jzd_func(...)    \
    jmpd_func_if(zf == true, __VA_ARGS__)

#define jnzw_func(...)   \
    jmpw_func_if(zf == false, __VA_ARGS__)

#define jnzd_func(...)   \
    jmpd_func_if(zf == false, __VA_ARGS__)

#define jod_func(...)    \
    jmpd_func_if(of == true, __VA_ARGS__)

#define jnod_func(...)   \
    jmpd_func_if(of == false, __VA_ARGS__)

#define jnsw_func(...)   \
    jmpw_func_if(sf == false, __VA_ARGS__)

#define jgd_func(...)    \
    jmpd_func_if(zf == false && sf == of, __VA_ARGS__)

#define jgew_func(...)   \
    jmpw_func_if(sf == of, __VA_ARGS__)

#define jged_func(...)   \
    jmpd_func_if(sf == of, __VA_ARGS__)

#define jlw_func(...)    \
    jmpw_func_if(sf != of, __VA_ARGS__)

#define jld_func(...)    \
    jmpd_func_if(sf != of, __VA_ARGS__)

#define jled_func(...)   \
    jmpd_func_if(zf == true || sf != of, __VA_ARGS__)

#define jecxzd_func(...) \
    jmpd_func_if(ecx == 0, __VA_ARGS__)

#define jsw_func(...)    \
    jmpw_func_if(sf == true, __VA_ARGS__)

#define jad(...)    \
    jmpd_if(cf == false && zf == false, __VA_ARGS__)

#define jaed(...)   \
    jmpd_if(cf == false, __VA_ARGS__)

#define jbw(...)    \
    jmpw_if(cf == true, __VA_ARGS__)

#define jbd(...)    \
    jmpd_if(cf == true, __VA_ARGS__)

#define jbed(...)   \
    jmpd_if(cf == true || zf == true, __VA_ARGS__)

#define jgd(...)    \
    jmpd_if(zf == false && sf == of, __VA_ARGS__)

#define jged(...)   \
    jmpd_if(sf == of, __VA_ARGS__)

#define jld(...)    \
    jmpd_if(sf != of, __VA_ARGS__)

#define jled(...)   \
    jmpd_if(zf == true || sf != of, __VA_ARGS__)

#define jzd(...)    \
    jmpd_if(zf == true, __VA_ARGS__)

#define jnzd(...)   \
    jmpd_if(zf == false, __VA_ARGS__)

#define jow(...)    \
    jmpw_if(of == true, __VA_ARGS__)

#define jnow(...)   \
    jmpw_if(of == false, __VA_ARGS__)

#define jod(...)    \
    jmpd_if(of == true, __VA_ARGS__)

#define jpd(...)    \
    jmpd_if(pf == true, __VA_ARGS__)

#define jcxzd(...)  \
    jmpd_if(cx == 0, __VA_ARGS__)

#define jecxzd(...) \
    jmpd_if(ecx == 0, __VA_ARGS__)

#define jnsd(...)   \
    jmpd_if(sf == false, __VA_ARGS__)

#define jsd(...)    \
    jmpd_if(sf == true, __VA_ARGS__)


#define loopnzw_a16(...)            \
    if (--cx != 0 && zf == false)   \
        jmpw(__VA_ARGS__)

#define loopzw_a16(...)             \
    if (--cx != 0 && zf == true)    \
        jmpw(__VA_ARGS__)

#define loopew_a16 loopzw_a16

#define loopd_a32(...)        \
    if (--ecx != 0)           \
        jmpd(__VA_ARGS__)


#define loopw_a16_func(...)       \
    if (--cx != 0)                \
        jmpw_func(__VA_ARGS__) /* Один раз отработает, потом return, что правильно. */

#define loopd_a32_func(...)       \
    if (--ecx != 0)               \
        jmpd_func(__VA_ARGS__) /* Один раз отработает, потом return, что правильно. */




#define jmpd_abs(off)                                                   \
    do {                                                                \
        eip = off;                                                      \
        if (cs.fail_limit_check(eip))                                   \
            throw exo::exception::not_implemented();                    \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
        return;                                                         \
    } while(0)

#define jmpd_abs_switch(off, addrs)                                     \
    do {                                                                \
        eip = off;                                                      \
        if (cs.fail_limit_check(eip))                                   \
            throw exo::exception::not_implemented();                    \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
                                                                        \
        switch (cs.get_base() + eip - func_delta)                       \
        {                                                               \
        BOOST_PP_SEQ_FOR_EACH(CASE_DECLARE,,addrs)                      \
        default:                                                        \
            return;                                                     \
        }                                                               \
    } while(0)

#define calld_abs(off)                                    \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        eip = off;                                        \
        pushd(eip_next);                                  \
        if (cs.fail_limit_check(eip))                     \
            throw exo::exception::not_implemented();      \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
    } while(0)


#define calld_far_abs(seg, off)                           \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        call_far_prepare(32, seg, off);                   \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
    } while(0)

#define int3()    throw exo::exception::not_implemented();


#define iretw()    iret_(16); return
#define iretd()    iret_(32); return


template<exo::abstract_int L, typename T>
void shld(uint_<L> & d, uint_<L> s, T c_)
{
    uint_<8> c(c_);

    if (L == 64)
        c = c % 64;
    else
        c = c % 32;

    if (c != 0 && c <= L)
    {
        cf = ((d >> (L - c)) & 1) != 0;

        uint_<2 * L> total(d, s);
        d = total >> (L - c);
    }
}

template<typename T>
void popq(T & d)
{
    if (ss.get_db())
    {
        esp += 8;
        d = memq_a32(ss, esp - 8);
    }
    else
    {
        sp += 8;
        d = memq_a16(ss, sp - 8);
    }
}

template<exo::abstract_int L, typename T>
void lss(uint_<L> & d, seg_reg & s, T o)
{
    d = mem<uint_<L>>(s, o);
    o += (L / 8);
    ss = mem<uint_<16>>(s, o);
}

template<exo::abstract_int L, typename T>
void lgs(uint_<L> & d, seg_reg & s, T o)
{
    d = mem<uint_<L>>(s, o);
    o += (L / 8);
    gs = mem<uint_<16>>(s, o);
}

template<exo::abstract_int L, typename T>
void lfs(uint_<L> & d, seg_reg & s, T o)
{
    d = mem<uint_<L>>(s, o);
    o += (L / 8);
    fs = mem<uint_<16>>(s, o);
}


inline void mul(uint_<8> s)
{
    uint_<16> r = uint_<16>(al) * uint_<16>(s);
    ax = r;

    cf = of = ((ax >> 8) != 0);
}

inline void mul(uint_<32> s)
{
    uint_<64> r = uint_<64>(eax) * uint_<64>(s);
    eax = r;
    edx = (r >> 32);

    cf = of = (edx != 0);
}


inline void seta(uint_<8> & d)
{
    if (cf == false && zf == false)
        d = 1;
    else
        d = 0;
}

inline void setbe(uint_<8> & d)
{
    if (cf || zf)
        d = 1;
    else
        d = 0;
}

inline void setl(uint_<8> & d)
{
    if (sf != of)
        d = 1;
    else
        d = 0;
}

inline void bsr(uint_<32> & , uint_<32>)
{
    throw exo::exception::not_implemented();
}

void invalid();

inline void lahf()
{
    throw exo::exception::not_implemented();
}

inline void scasb_a32()
{
    cmp(al, memb_a32(es, edi));
    edi += df ? -1 : 1;
}


inline void lodsd_a16()
{
    eax = memd_a16(ds, si);
    si += df ? -4 : 4;
}

inline void cmpsb_a32()
{
    cmp(memb_a32(ds, esi), memb_a32(es, edi));
    edi += df ? -1 : 1;
    esi += df ? -1 : 1;
}

//inline void lodsdd_a16()
//{
//    eax = memd_a16(ds, si);
//    si += df ? -4 : 4;
//}
//
//inline void lodsdd_a32()
//{
//    eax = memd_a32(ds, esi);
//    esi += df ? -4 : 4;
//}


inline void insb_a16()
{
    // @todo check permission
    dos::inb(memb_a16(es, di), dx);
    di += df ? -1 : 1;
}

} /* namespace x86 */
} /* namespave raw_program */

#endif /* OPENMAX_X86_INSTRUCTIONS_HPP_INCLUDED */
