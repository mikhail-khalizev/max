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


void int_internal(uint_<8> num,
        bool software_interrupt, bool in_interrupt_int_n,
        bool fault_with_error_code, uint_<32> error_code);

void jmp_far_prepare(uint_<16> seg, uint_<32> off);
void call_far_prepare(uint_<8> op_size, uint_<16> seg, uint_<32> off);
bool correct_function_position(uint_<32> ret_addr);

void ret_far(uint_<8> op_size);
void iret_(uint_<8> op_size);


#define CASE_DECLARE(z, data, elem)        \
    case elem :                            \
        goto BOOST_PP_CAT(l_, elem);


#define jaw_func(...)    \
    jmpw_func_if(cf == false && zf == false, __VA_ARGS__)

#define jad_func(...)    \
    jmpd_func_if(cf == false && zf == false, __VA_ARGS__)


// +
#define jaew_func(...)   \
    jmpw_func_if(cf == false, __VA_ARGS__)

#define jaed_func(...)   \
    jmpd_func_if(cf == false, __VA_ARGS__)

#define jbd_func(...)    \
    jmpd_func_if(cf == true, __VA_ARGS__)

#define jbew_func(...)   \
    jmpw_func_if(cf == true || zf == true, __VA_ARGS__)

#define jbed_func(...)   \
    jmpd_func_if(cf == true || zf == true, __VA_ARGS__)

// +
#define jzw_func(...)    \
    jmpw_func_if(zf == true, __VA_ARGS__)

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

// +
#define jlew_func(...)   \
    jmpw_func_if(zf == true || sf != of, __VA_ARGS__)

#define jled_func(...)   \
    jmpd_func_if(zf == true || sf != of, __VA_ARGS__)

// +
#define jcxzw_func(...)  \
    jmpw_func_if(cx == 0, __VA_ARGS__)

#define jecxzd_func(...) \
    jmpd_func_if(ecx == 0, __VA_ARGS__)

// +
#define jbw_func(...)    \
    jmpw_func_if(cf == true, __VA_ARGS__)

#define jsw_func(...)    \
    jmpw_func_if(sf == true, __VA_ARGS__)

// +
#define jaw(...)    \
    jmpw_if(cf == false && zf == false, __VA_ARGS__)

#define jad(...)    \
    jmpd_if(cf == false && zf == false, __VA_ARGS__)

// +
#define jaew(...)   \
    jmpw_if(cf == false, __VA_ARGS__)

#define jaed(...)   \
    jmpd_if(cf == false, __VA_ARGS__)

#define jbw(...)    \
    jmpw_if(cf == true, __VA_ARGS__)

#define jbd(...)    \
    jmpd_if(cf == true, __VA_ARGS__)

// +
#define jbew(...)   \
    jmpw_if(cf == true || zf == true, __VA_ARGS__)

#define jbed(...)   \
    jmpd_if(cf == true || zf == true, __VA_ARGS__)

// +
#define jgw(...)    \
    jmpw_if(zf == false && sf == of, __VA_ARGS__)

#define jgd(...)    \
    jmpd_if(zf == false && sf == of, __VA_ARGS__)

// +
#define jgew(...)   \
    jmpw_if(sf == of, __VA_ARGS__)

#define jged(...)   \
    jmpd_if(sf == of, __VA_ARGS__)

// +
#define jlw(...)    \
    jmpw_if(sf != of, __VA_ARGS__)

#define jld(...)    \
    jmpd_if(sf != of, __VA_ARGS__)

// +
#define jlew(...)   \
    jmpw_if(zf == true || sf != of, __VA_ARGS__)

#define jled(...)   \
    jmpd_if(zf == true || sf != of, __VA_ARGS__)

// +
#define jzw(...)    \
    jmpw_if(zf == true, __VA_ARGS__)

#define jzd(...)    \
    jmpd_if(zf == true, __VA_ARGS__)

// +
#define jnzw(...)   \
    jmpw_if(zf == false, __VA_ARGS__)

#define jnzd(...)   \
    jmpd_if(zf == false, __VA_ARGS__)

#define jow(...)    \
    jmpw_if(of == true, __VA_ARGS__)

#define jnow(...)   \
    jmpw_if(of == false, __VA_ARGS__)

#define jod(...)    \
    jmpd_if(of == true, __VA_ARGS__)

#define jnod(...)   \
    jmpd_if(of == false, __VA_ARGS__)

#define jpd(...)    \
    jmpd_if(pf == true, __VA_ARGS__)

// +
#define jcxzw(...)  \
    jmpw_if(cx == 0, __VA_ARGS__)

#define jcxzd(...)  \
    jmpd_if(cx == 0, __VA_ARGS__)

#define jecxzd(...) \
    jmpd_if(ecx == 0, __VA_ARGS__)

// +
#define jnsw(...)   \
    jmpw_if(sf == false, __VA_ARGS__)

#define jnsd(...)   \
    jmpd_if(sf == false, __VA_ARGS__)

// +
#define jsw(...)    \
    jmpw_if(sf == true, __VA_ARGS__)

#define jsd(...)    \
    jmpd_if(sf == true, __VA_ARGS__)


#define loopnzw_a16(...)            \
    if (--cx != 0 && zf == false)   \
        jmpw(__VA_ARGS__)

#define loopnew_a16 loopnzw_a16

#define loopzw_a16(...)             \
    if (--cx != 0 && zf == true)    \
        jmpw(__VA_ARGS__)

#define loopew_a16 loopzw_a16

// +
#define loopw_a16(...)        \
    if (--cx != 0)            \
        jmpw(__VA_ARGS__)

#define loopd_a32(...)        \
    if (--ecx != 0)           \
        jmpd(__VA_ARGS__)


#define loopw_a16_func(...)       \
    if (--cx != 0)                \
        jmpw_func(__VA_ARGS__) /* Один раз отработает, потом return, что правильно. */

#define loopd_a32_func(...)       \
    if (--ecx != 0)               \
        jmpd_func(__VA_ARGS__) /* Один раз отработает, потом return, что правильно. */


// +
#define rep_a16    \
    for (; cx != 0; cx--)

// +
#define rep_a32    \
    for (; ecx != 0; ecx--)

// +
#define repe_a16   \
    for (zf = true; cx != 0 && zf; cx--)

#define repe_a32   \
    for (zf = true; ecx != 0 && zf; ecx--)

// +
#define repne_a16  \
    for (zf = false; cx != 0 && !zf; cx--)

#define repne_a32  \
    for (zf = false; ecx != 0 && !zf; ecx--)


// + in jmpw_if
#define jmpw(to, off)                                   \
    do {                                                \
        eip = eip_next + (off);                         \
        eip &= 0xffff;                                  \
        if (cs.fail_limit_check(eip))                   \
            throw exo::exception::not_implemented();    \
        if (cs.get_base() + eip != to + func_delta)     \
            throw exo::exception::not_implemented();    \
        eip_next = eip;                                 \
        dos::pic.run_irqs();                            \
        goto l_ ## to;                                  \
    } while (0)

#define jmpd(to, off)                                   \
    do {                                                \
        eip = eip_next + (off);                         \
        if (cs.fail_limit_check(eip))                   \
            throw exo::exception::not_implemented();    \
        if (cs.get_base() + eip != to + func_delta)     \
            throw exo::exception::not_implemented();    \
        eip_next = eip;                                 \
        dos::pic.run_irqs();                            \
        goto l_ ## to;                                  \
    } while (0)


// +
#define jmpw_func(to, off)                                              \
    do {                                                                \
        eip = eip_next + (off);                                         \
        eip &= 0xffff;                                                  \
        if (cs.fail_limit_check(eip))                                   \
            throw exo::exception::not_implemented();                    \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
        return;                                                         \
    } while(0)

#define jmpd_func(to, off)                                              \
    do {                                                                \
        eip = eip_next + (off);                                         \
        if (cs.fail_limit_check(eip))                                   \
            throw exo::exception::not_implemented();                    \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
        return;                                                         \
    } while(0)


// +
#define jmpw_if(cond, to, off)   \
    if (cond)                    \
        jmpw(to, off)

#define jmpd_if(cond, to, off)   \
    if (cond)                    \
        jmpd(to, off)


// +
#define jmpw_func_if(cond, to, off)   \
    if (cond)                         \
        jmpw_func(to, off)

#define jmpd_func_if(cond, to, off)   \
    if (cond)                         \
        jmpd_func(to, off)

// +
#define jmpw_abs(off)                                                   \
    do {                                                                \
        eip = (off) & 0xffff;                                           \
        if (cs.fail_limit_check(eip))                                   \
            throw exo::exception::not_implemented();                    \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
        return;                                                         \
    } while(0)

#define jmpw_abs_switch(off, addrs)                                     \
    do {                                                                \
        eip = (off) & 0xffff;                                           \
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

#define jmpw_far_abs jmpd_far_abs

// +
#define jmpd_far_abs(seg, off)                                          \
    do {                                                                \
        jmp_far_prepare(seg, off);                                      \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
        return;                                                         \
    } while(0)

// +
#define jmpw_a16_far_ind(mem_seg, mem_off)                              \
    do {                                                                \
        jmp_far_prepare(                                                \
                memw_a16(mem_seg, mem_off + 2),                         \
                memw_a16(mem_seg, mem_off));                            \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
        return;                                                         \
    } while(0)

#define jmpd_a16_far_ind(mem_seg, mem_off)                              \
    do {                                                                \
        jmp_far_prepare(                                                \
                memw_a16(mem_seg, mem_off + 4),                         \
                memd_a16(mem_seg, mem_off));                            \
        eip_next = eip;                                                 \
        dos::pic.run_irqs();                                            \
        return;                                                         \
    } while(0)

// +
#define check_mode()                                                \
    if (ia32_efer.lma && cs.get_l() && cs.get_db() == false)        \
        throw exo::exception::not_implemented(); /* 64bit mode*/    \
    if (mode != (cs.get_db() ? 32 : 16))                            \
        throw std::logic_error("Bad mode")


/* call*(to, off)
 * off может быть mem*(ss, *), т.е. браться из стека.
 * Поэтому push* надо делать после чтения off. */

// +
#define callw(to, off)                                    \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        eip = eip_next + (off);                           \
        eip &= 0xffff;                                    \
        pushw(eip_next);                                  \
        if (cs.fail_limit_check(eip))                     \
            throw exo::exception::not_implemented();      \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
    } while(0)

#define calld(to, off)                                    \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        eip = eip_next + (off);                           \
        pushd(eip_next);                                  \
        if (cs.fail_limit_check(eip))                     \
            throw exo::exception::not_implemented();      \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
    } while(0)

// +
#define callw_abs(off)                                    \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        eip = (off) & 0xffff;                             \
        pushw(eip_next);                                  \
        if (cs.fail_limit_check(eip))                     \
            throw exo::exception::not_implemented();      \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
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

// +
#define callw_far_abs(seg, off)                           \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        call_far_prepare(16, seg, (off) & 0xffff);        \
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

// +
#define callw_a16_far_ind(mem_seg, mem_off)               \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        call_far_prepare(16,                              \
                memw_a16(mem_seg, mem_off + 2),           \
                memw_a16(mem_seg, mem_off));              \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
    } while(0)

// +
#define calld_a16_far_ind(mem_seg, mem_off)               \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        call_far_prepare(32,                              \
                memw_a16(mem_seg, mem_off + 4),           \
                memd_a16(mem_seg, mem_off));              \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
    } while(0)

#define calld_a32_far_ind(mem_seg, mem_off)               \
    do {                                                  \
        uint_<32> ret_addr = cs.get_base() + eip_next;    \
        call_far_prepare(32,                              \
                memw_a32(mem_seg, mem_off + 4),           \
                memd_a32(mem_seg, mem_off));              \
        eip_next = eip;                                   \
        dos::pic.run_irqs();                              \
        if (correct_function_position(ret_addr))          \
            return;                                       \
        check_mode();                                     \
    } while(0)

// +
#define int_(num)                                        \
    do {                                                 \
        uint_<32> ret_addr = cs.get_base() + eip_next;   \
        int_internal(num, true, true, false, 0);         \
        eip_next = eip;                                  \
        dos::pic.run_irqs();                             \
        if (correct_function_position(ret_addr))         \
            return;                                      \
        check_mode();                                    \
    } while(0)

#define int3()    throw exo::exception::not_implemented();

// +
inline void __plus_sp() {}
inline void __plus_sp(uint_<16> s)
{
    if (ss.get_db())
        esp += s;
    else
        sp += s;
}

// +
#define retw(...)                                    \
    popw(eip);                                       \
    if (cs.fail_limit_check(eip))                    \
        throw exo::exception::not_implemented();     \
    __plus_sp(__VA_ARGS__);                          \
    return

#define retd(...)                                    \
    popd(eip);                                       \
    if (cs.fail_limit_check(eip))                    \
        throw exo::exception::not_implemented();     \
    __plus_sp(__VA_ARGS__);                          \
    return

#define retfw(...)           \
    ret_far(16);             \
    __plus_sp(__VA_ARGS__);  \
    return

#define retfd(...)           \
    ret_far(32);             \
    __plus_sp(__VA_ARGS__);  \
    return


#define iretw()    iret_(16); return
#define iretd()    iret_(32); return

// +
template<abstract_int L>
void set_sf_zf_pf(uint_<L> x)
{
    sf = (sint_<L>(x) < 0);
    zf = (x == 0);

    // pf -  Сумма единиц в младшем байте + 1.

    pf = true;
    for (int i = 0; i < 8; i++)
    {
        pf ^= (0 != (x & 1));
        x >>= 1;
    }
}

// +
#define mov(d, s)  d = s

// +
#define lea(d, s)  d = s

// +
#define movzx(d, s)  d = s

// +
template<abstract_int L1, abstract_int L2>
void movsx(uint_<L1> & d, uint_<L2> s)
{
    d = sint_<L2>(s);
}

// +
inline void nop()
{}

// +
inline void cbw()
{
    ah = sint_<8>(al) < 0 ? -1 : 0;
}

// +
inline void cwd()
{
    dx = sint_<16>(ax) < 0 ? -1 : 0;
}

// +
inline void cdq()
{
    edx = sint_<32>(eax) < 0 ? -1 : 0;
}

// +
inline void cwde()
{
    movsx(eax, ax);
}

// +
template<exo::abstract_int L, typename T>
void sar(uint_<L> & d, T s_)
{
    uint_<8>::type s = s_; // @todo Должно быть "uint_<8> s(s_)", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.

    if (s == 1)
        of = false;

    if (s != 0)
    {
        cf = 0 != ((sint_<L>(d) >> (s - 1)) & 1);
        d = sint_<L>(d) >> s;
        set_sf_zf_pf(d);
    }
}

// +
template<exo::abstract_int L, typename T>
void shl(uint_<L> & d, T s_)
{
    uint_<8>::type s = s_; // @todo Должно быть "uint_<8> s(s_)", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.

    uint_<L> mask = ~ (uint_<L>(-1) >> 1); // 0x8000

    if (s != 0)
    {
        cf = 0 != ((d << (s - 1)) & mask);
        d <<= s;
        set_sf_zf_pf(d);
    }

    if (s == 1)
        of = (0 < (d & mask)) ^ cf;
}

// +
template<exo::abstract_int L, typename T>
void shr(uint_<L> & d, T s_)
{
    uint_<8>::type s = s_; // @todo Должно быть "uint_<8> s(s_)", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.

    uint_<L> mask = ~ (uint_<L>(-1) >> 1); // 0x8000

    if (s == 1)
        of = 0 < (d & mask);

    if (s != 0)
    {
        cf = 0 != ((d >> (s - 1)) & 1);
        d >>= s;
        set_sf_zf_pf(d);
    }
}

// +
template<exo::abstract_int L, typename T>
void shrd(uint_<L> & d, uint_<L> s, T c_)
{
    uint_<8> c(c_);

    if (L == 64)
        c = c % 64;
    else
        c = c % 32;

    if (c != 0 && c <= L)
    {
        cf = ((d >> (c - 1)) & 1) != 0;

        uint_<2 * L> total(s, d);
        d = total >> c;
    }
}

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

// +
template<exo::abstract_int L, typename T>
void rcl(uint_<L> & d, T COUNT_)
{
    uint_<8>::type COUNT = COUNT_; // @todo Должно быть "uint_<8> COUNT(COUNT_)", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.

    uint_<8> tempCOUNT;

    switch (L)
    {
    case  8: tempCOUNT = (COUNT & 0x1f) % 9; break;
    case 16: tempCOUNT = (COUNT & 0x1f) % 17; break;
    case 32: tempCOUNT = COUNT & 0x1f; break;
    case 64: tempCOUNT = COUNT & 0x3f; break;
    default: throw exo::exception::not_implemented(); break;
    }

    uint_<L> mask = ~ (uint_<L>(-1) >> 1); // 0x8000

    if (tempCOUNT != 0)
    {
        bool new_cf = 0 != ((d << (tempCOUNT - 1)) & mask);

        d = (d << tempCOUNT)
                | (uint_ge<L + 1>(d) >> (L - tempCOUNT.get() + 1)).get();

        if (cf)
            d |= uint_<L>(1) << (tempCOUNT - 1);

        cf = new_cf;
    }

    if (COUNT == 1)
        of = (0 < (d & mask)) ^ cf;
}

// +
template<exo::abstract_int L, typename T>
void rcr(uint_<L> & d, T COUNT_)
{
    uint_<8>::type COUNT = COUNT_; // @todo Должно быть "uint_<8> COUNT(COUNT_)", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.

    uint_<8> tempCOUNT;

    switch (L)
    {
    case  8: tempCOUNT = (COUNT & 0x1F) % 9; break;
    case 16: tempCOUNT = (COUNT & 0x1F) % 17; break;
    case 32: tempCOUNT = COUNT & 0x1F; break;
    case 64: tempCOUNT = COUNT & 0x3F; break;
    default: throw exo::exception::not_implemented(); break;
    }

    if (tempCOUNT != 0)
    {
        bool new_cf = 0 != ((d >> (tempCOUNT - 1)) & 1);

        d = (d >> tempCOUNT)
                | (uint_ge<L + 1>(d) << (L - tempCOUNT.get() + 1)).get();
        if (cf)
            d |= uint_<L>(1) << (L - tempCOUNT);

        cf = new_cf;
    }

    uint_<L> mask = ~ (uint_<L>(-1) >> 1); // 0x8000

    if (COUNT == 1)
        of = (0 < (d & mask)) ^ cf;
}

// +
template<exo::abstract_int L, typename T>
void rol(uint_<L> & d, T COUNT_)
{
    uint_<8>::type COUNT = COUNT_; // @todo Должно быть "uint_<8> COUNT(COUNT_)", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.

    uint_<8>::type COUNTMASK; // @todo Должно быть "uint_<8>", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.
    if (L == 64)
        COUNTMASK = 0x3F;
    else
        COUNTMASK = 0x1F;

    uint_<8> tempCOUNT = (COUNT & COUNTMASK) % L;


    uint_<L> mask = ~ (uint_<L>(-1) >> 1); // 0x8000

    if (tempCOUNT != 0)
    {
        bool new_cf = 0 != ((d << (tempCOUNT - 1)) & mask);
        d = (d << tempCOUNT) | (d >> (L - tempCOUNT));
        cf = new_cf;
    }

    if ((COUNT & COUNTMASK) == 1)
        of = (0 < (d & mask)) ^ cf;
}

// +
template<exo::abstract_int L, typename T>
void ror(uint_<L> & d, T COUNT_)
{
    uint_<8>::type COUNT = COUNT_; // @todo Должно быть "uint_<8> COUNT(COUNT_)", но оно вызывает ошибку сегментирования во время компилирования gcc 4.7.3.
//    uint_<8> COUNT(COUNT_);

    uint_<8>::type COUNTMASK;
    if (L == 64)
        COUNTMASK = 0x3F;
    else
        COUNTMASK = 0x1F;

    uint_<8> tempCOUNT = (COUNT & COUNTMASK) % L;


    if (tempCOUNT != 0)
    {
        bool new_cf = 0 != ((d >> (tempCOUNT - 1)) & 1);
        d = (d >> tempCOUNT) | (d << (L - tempCOUNT));
        cf = new_cf;
    }

    uint_<L> mask = ~ (uint_<L>(-1) >> 1); // 0x8000


    if ((COUNT & COUNTMASK) == 1)
        of = (0 < (d & mask)) ^ cf;
}

// +
inline void pushw(uint_<16> s)
{
    if (ss.get_db())
    {
        esp -= 2;
        if (ss.fail_limit_check(esp, 2))
            throw exo::exception::not_implemented(); // #SS(0)
        memw_a32(ss, esp) = s;
    }
    else
    {
        sp -= 2;
        if (ss.fail_limit_check(sp, 2))
            throw exo::exception::not_implemented(); // #SS(0)
        memw_a16(ss, sp) = s;
    }
}

// +
inline void pushd(uint_<32> s)
{
    if (ss.get_db())
    {
        esp -= 4;
        if (ss.fail_limit_check(esp, 4))
            throw exo::exception::not_implemented(); // #SS(0)
        memd_a32(ss, esp) = s;
    }
    else
    {
        sp -= 4;
        if (ss.fail_limit_check(sp, 4))
            throw exo::exception::not_implemented(); // #SS(0)
        memd_a16(ss, sp) = s;
    }
}

// +
template<typename T>
void popw(T & d)
{
    if (ss.get_db())
    {
        esp += 2;
        d = memw_a32(ss, esp - 2);
    }
    else
    {
        sp += 2;
        d = memw_a16(ss, sp - 2);
    }
}

// +
template<typename T>
void popd(T & d)
{
    if (ss.get_db())
    {
        esp += 4;
        d = memd_a32(ss, esp - 4);
    }
    else
    {
        sp += 4;
        d = memd_a16(ss, sp - 4);
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

// +
inline void pushfw()
{
    pushw(eflags);
}

// +
inline void pushfd()
{
    pushd(eflags);
}

// +
void popf_(uint_<8> OperandSize);
#define popfw() popf_(16)
#define popfd() popf_(32)

// +
inline void pusha()
{
    uint_<16> t = sp;
    pushw(ax);
    pushw(cx);
    pushw(dx);
    pushw(bx);
    pushw(t);
    pushw(bp);
    pushw(si);
    pushw(di);
}

// +
inline void popa()
{
    popw(di);
    popw(si);
    popw(bp);

    if (ss.get_db())
        esp += 2;
    else
        sp += 2;

    popw(bx);
    popw(dx);
    popw(cx);
    popw(ax);
}

// +
inline void pushad()
{
    uint_<32> t = esp;
    pushd(eax);
    pushd(ecx);
    pushd(edx);
    pushd(ebx);
    pushd(t);
    pushd(ebp);
    pushd(esi);
    pushd(edi);
}

// +
inline void popad()
{
    popd(edi);
    popd(esi);
    popd(ebp);

    if (ss.get_db())
        esp += 4;
    else
        sp += 4;

    popd(ebx);
    popd(edx);
    popd(ecx);
    popd(eax);
}

// +
template<exo::abstract_int L, typename T>
void add(uint_<L> & d, T s_)
{
    uint_<L> s(s_);
    uint_<L> r = d + s;

    bool ds_ = 0 <= sint_<L>(d);
    bool ss_ = 0 <= sint_<L>(s);
    bool rs  = 0 <= sint_<L>(r);

    /* d  s  r  of
     * +  +  +   0
     * +  +  -   1
     * +  -  +   0
     * +  -  -   0
     * -  +  +   0
     * -  +  -   0
     * -  -  +   1
     * -  -  -   0
     */

    of = (ds_ == ss_) && (ss_ != rs);
    cf = uint_<L>(-1) < (d + uint_<2 * L>(s));
    set_sf_zf_pf(r);
    // af

    d = r;
}

// +
template<exo::abstract_int L, typename T>
void adc(uint_<L> & d, T s_)
{
    uint_<L> s(s_);
    uint_<L> r = d + s + (cf ? 1 : 0);

    bool ds_ = 0 <= sint_<L>(d);
    bool ss_ = 0 <= sint_<L>(s);
    bool rs  = 0 <= sint_<L>(r);

    of = (ds_ == ss_) && (ss_ != rs);
    cf = uint_<L>(-1) < (d + uint_<L>(s) + (cf ? 1 : 0));
    set_sf_zf_pf(r);
    // af

    d = r;
}

// +
template<exo::abstract_int L, typename T>
void test(uint_<L> d, T s_)
{
    uint_<L> s(s_);
    set_sf_zf_pf(uint_<L>(d & s));
    cf = false;
    of = false;
}

// +
template<exo::abstract_int L, typename T>
void cmp(uint_<L> d, T s_)
{
    uint_<L> s(s_);
    cf = d < s;

    uint_<L> r = d - s;
    bool ds_ = 0 <= sint_<L>(d);
    bool ss_ = 0 <= sint_<L>(s);
    bool rs  = 0 <= sint_<L>(r);

    /* d  s  r  of
     * +  +  +   0
     * +  +  -   0
     * +  -  +   0
     * +  -  -   1
     * -  +  +   1
     * -  +  -   0
     * -  -  +   0
     * -  -  -   0  */

    of = (ds_ != ss_) && (ss_ == rs);
    set_sf_zf_pf(r);
    // af
}

// +
template<exo::abstract_int L, typename T>
void sub(uint_<L> & d, T s_)
{
    cmp(d, s_);
    uint_<L> s(s_);
    d = d - s;
}

// +
template<exo::abstract_int L, typename T>
void sbb(uint_<L> & d, T s_)
{
    uint_<L> s(s_);
    uint_<L> r = d - s - (cf ? 1 : 0);
    bool ds_ = 0 <= sint_<L>(d);
    bool ss_ = 0 <= sint_<L>(s);
    bool rs  = 0 <= sint_<L>(r);

    cf = d < uint_<L * 2>(s) + (cf ? 1 : 0);
    of = (ds_ != ss_) && (ss_ == rs);
    set_sf_zf_pf(r);

    d = r;
}

// +
template<exo::abstract_int L>
void inc(uint_<L> & d)
{
    uint_<L> r = d + 1;

    bool ds_ = 0 <= sint_<L>(d);
    bool ss_ = 0 <= sint_<L>(1);
    bool rs  = 0 <= sint_<L>(r);

    of = (ds_ == ss_) && (ss_ != rs);
    set_sf_zf_pf(r);
    // af

    d = r;
}

// +
template<exo::abstract_int L>
void dec(uint_<L> & d)
{
    uint_<L> r = d - 1;
    bool ds_ = 0 <= sint_<L>(d);
    bool ss_ = 0 <= sint_<L>(1);
    bool rs  = 0 <= sint_<L>(r);

    of = (ds_ != ss_) && (ss_ == rs);
    set_sf_zf_pf(r);
    // af

    d = r;
}

// +
template<exo::abstract_int L>
void neg(uint_<L> & d)
{
    cf = d != 0;
    d = -d;
    set_sf_zf_pf(d);
    // af
    // of = ???
}

// +
template<exo::abstract_int L>
void not_(uint_<L> & d)
{
    d = ~d;
}

// +
template<exo::abstract_int L, typename T>
void lds(uint_<L> & d, seg_reg & s, T o)
{
    d = mem<uint_<L>>(s, o);
    o += (L / 8);
    ds = mem<uint_<16>>(s, o);
}

// +
template<exo::abstract_int L, typename T>
void les(uint_<L> & d, seg_reg & s, T o)
{
    d = mem<uint_<L>>(s, o);
    o += (L / 8);
    es = mem<uint_<16>>(s, o);
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

// +
template<exo::abstract_int L, typename T>
void or_(uint_<L> & d, T s_)
{
    uint_<L> s(s_);
    d |= s;

    cf = false;
    of = false;
    set_sf_zf_pf(d);
}

// +
template<exo::abstract_int L, typename T>
void xor_(uint_<L> & d, T s_)
{
    uint_<L> s(s_);
    d ^= s;

    cf = false;
    of = false;
    set_sf_zf_pf(d);
}

// +
template<exo::abstract_int L, typename T>
void and_(uint_<L> & d, T s_)
{
    uint_<L> s(s_);
    d &= s;

    cf = false;
    of = false;
    set_sf_zf_pf(d);
}


// +
#define xchg std::swap


// +
inline void xlatb_a16()
{
    al = memb_a16(ds, bx + al);
}


// +
inline void sti()
{
    if (cr0.pe == false)
        if_ = true;
    else
    {
        if (vm == false)
        {
            if (get_cpl() <= iopl)
                if_ = true;
            else
            {
                if (iopl < get_cpl() && get_cpl() == 3 && vip == false)
                    vif = true;
                else
                    throw exo::exception::not_implemented(); // #GP(0);
            }
        }
        else
        {
            if (iopl == 3)
                if_ = true;
            else
            {
                if (iopl < 3 && vip == false && cr4.vme)
                    vif = true;
                else
                    throw exo::exception::not_implemented(); // #GP(0);
            }
        }
    }

    dos::pic.run_irqs();
}

// +
inline void cli()
{
    if (cr0.pe == false)
        if_ = false;
    else
    {
        if (vm == false)
        {
            if (get_cpl() <= iopl)
                if_ = false;
            else
            {
                if (iopl < get_cpl() && get_cpl() == 3 && cr4.pvi)
                    vif = false;
                else
                    throw exo::exception::not_implemented(); // #GP(0);
            }
        }
        else
        {
            if (iopl == 3)
                if_ = false;
            else
            {
                if (iopl < 3 && cr4.vme)
                    vif = false;
                else
                    throw exo::exception::not_implemented(); // #GP(0);
            }
        }
    }
}

// +
inline void std_()
{
    df = true;
}

// +
inline void cld()
{
    df = false;
}

inline void stc()
{
    cf = true;
}

// +
inline void clc()
{
    cf = false;
}


inline void mul(uint_<8> s)
{
    uint_<16> r = uint_<16>(al) * uint_<16>(s);
    ax = r;

    cf = of = ((ax >> 8) != 0);
}

// +
inline void mul(uint_<16> s)
{
    uint_<32> r = uint_<32>(ax) * uint_<32>(s);
    ax = r;
    dx = (r >> 16);

    cf = of = (dx != 0);
}

inline void mul(uint_<32> s)
{
    uint_<64> r = uint_<64>(eax) * uint_<64>(s);
    eax = r;
    edx = (r >> 32);

    cf = of = (edx != 0);
}

void mul(uint_<64> s);


void imul(uint_<8> s);

// +
inline void imul(uint_<16> s)
{
    uint_<32> r = sint_<32>(sint_<16>(ax)) * sint_<32>(sint_<16>(s));
    ax = r;
    dx = (r >> 16);

    cf = of = (ax != r);
}
void imul(uint_<32> s);
void imul(uint_<64> s);


template<exo::abstract_int L>
void imul(uint_<L> & d, uint_<L> s)
{
    uint_<2 * L> r = sint_<2 * L>(sint_<L>(d)) * sint_<2 * L>(sint_<L>(s));
    d = r;
    cf = of = (r != d);
}

// +
template<exo::abstract_int L, typename T>
void imul(uint_<L> & d, uint_<L> s, T c_)
{
    sint_<8 * sizeof(T)> c(c_);

    uint_<2 * L> r = sint_<2 * L>(sint_<L>(s)) * c;
    d = r;
    cf = of = (r != d);
}


void idiv(uint_<8> s);

// +
inline void idiv(uint_<16> s)
{
    if (s == 0)
        throw exo::exception::not_implemented(); // #DE

    sint_<32> w(dx, ax);

    sint_<32> t = w / sint_<16>(s);
    if (0x7fff < t || t < sint_<16>(0x8000))
        throw exo::exception::not_implemented(); // #DE

    ax = t;
    dx = w % sint_<16>(s);
}

inline void idiv(uint_<32> s)
{
    if (s == 0)
        throw exo::exception::not_implemented(); // #DE

    sint_<64> w(edx, eax);

    sint_<64> t = w / sint_<32>(s);
    if (0x7fffffff < t || t < sint_<32>(0x80000000))
        throw exo::exception::not_implemented(); // #DE

    eax = t;
    edx = w % sint_<32>(s);
}

void idiv(uint_<64> s);


inline void div(uint_<8> s)
{
    if (s == 0)
        throw exo::exception::not_implemented(); // #DE

    uint_<16> w = ax;

    uint_<16> t = w / s;
    if (0xff < t)
        throw exo::exception::not_implemented(); // #DE

    al = t;
    ah = w % s;
}

inline void div(uint_<16> s)
{
    if (s == 0)
        throw exo::exception::not_implemented(); // #DE

    uint_<32> w(dx, ax);

    uint_<32> t = w / s;
    if (0xffff < t)
        throw exo::exception::not_implemented(); // #DE

    ax = t;
    dx = w % s;
}

inline void div(uint_<32> s)
{
    if (s == 0)
        throw exo::exception::not_implemented(); // #DE

    uint_<64> w(edx, eax);

    uint_<64> t = w / s;
    if (0xffffffff < t)
        throw exo::exception::not_implemented(); // #DE

    eax = t;
    edx = w % s;
}

void div(uint_<64> s);


// +
inline void enterw(uint_<16> d, uint_<8> nesting_level)
{
    if (nesting_level != 0)
        throw exo::exception::not_implemented();

    pushw(bp);

    if (ss.get_db())
    {
        ebp = esp;
        esp -= d;
    }
    else
    {
        bp = sp;
        sp -= d;
    }
}

// +
inline void leavew()
{
    if (ss.get_db())
        esp = ebp;
    else
        sp = bp;
    popw(bp);
}

inline void leaved()
{
    if (ss.get_db())
        esp = ebp;
    else
        sp = bp;
    popd(ebp);
}

// +
inline void cpuid()
{
    if (eax != 1)
        throw exo::exception::not_implemented();

    eax = 0x402; // Intel 486.
    ebx = 0;
    ecx = 0;
    edx = 1;
}


// +
inline void bt(uint_<8> & d, uint_<8> s)
{
    cf = 0 != ((d >> (s % 8)) & 1);
}

// +
inline void bt(uint_<16> & d, uint_<8> s)
{
    cf = 0 != ((d >> (s % 16)) & 1);
}

// +
inline void bt(uint_<32> & d, uint_<8> s)
{
    cf = 0 != ((d >> (s % 32)) & 1);
}


// +
inline void btc(uint_<8> & d, uint_<8> s)
{
    bt(d, s);
    d ^= (1 << (s % 8));
}

// +
inline void btc(uint_<16> & d, uint_<8> s)
{
    bt(d, s);
    d ^= (1 << (s % 16));
}

// +
inline void btc(uint_<32> & d, uint_<8> s)
{
    bt(d, s);
    d ^= (1 << (s % 32));
}

// +
inline void btr(uint_<32> & d, uint_<8> s)
{
    bt(d, s);
    d = d & (~(1 << (s % 32)));
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

inline void setnb(uint_<8> & d)
{
    if (cf == false)
        d = 1;
    else
        d = 0;
}

inline void setz(uint_<8> & d)
{
    if (zf)
        d = 1;
    else
        d = 0;
}

inline void setnz(uint_<8> & d)
{
    if (zf == false)
        d = 1;
    else
        d = 0;
}

inline void setg(uint_<8> & d)
{
    if (sf == of && zf == false)
        d = 1;
    else
        d = 0;
}

inline void setge(uint_<8> & d)
{
    if (sf == of)
        d = 1;
    else
        d = 0;
}

inline void setle(uint_<8> & d)
{
    if (zf || sf != of)
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

// +
inline void clts()
{
    if (get_cpl() != 0)
        throw exo::exception::not_implemented(); // #GP(0)
    cr0.ts = false;
}

// +
inline void cmc()
{
    cf = ! cf;
}

// +
inline void lldt(uint_<16> s)
{
    if (get_cpl() != 0)
        throw exo::exception::not_implemented(); // #GP(0)

    if ((s & 0x4) != 0) // if point to local table
        throw exo::exception::not_implemented(); // #GP(segment selector)

    lldr = s;

    if (lldr.is_null() == false)
    {
        if (lldr.get_cached_desc().is_type_ldt() == false)
            throw exo::exception::not_implemented(); // #GP(segment selector)

        if (lldr.is_present() == false)
            throw exo::exception::not_implemented(); // #NP(segment selector)
    }
}

// +
inline void smsw(uint_<16> & d)
{
    d = cr0;
}

// +
inline void lmsw(uint_<16> s)
{
    uint_<32> t = cr0;
    t = (t & 0xffff0000) | s;
    cr0 = t;
}

// +
inline void lgdtw_a16(seg_reg & seg, uint_<16> off)
{
    if (get_cpl() != 0)
        throw exo::exception::not_implemented(); // #GP(0)

    gdtr_limit = memw_a16(seg, off);
    gdtr_base = memd_a16(seg, off + 2) & 0x00ffffff;
}

// +
inline void lgdtd_a16(seg_reg & seg, uint_<16> off)
{
    if (get_cpl() != 0)
        throw exo::exception::not_implemented(); // #GP(0)

    gdtr_limit = memw_a16(seg, off);
    gdtr_base = memd_a16(seg, off + 2);
}

// +
inline void lidtw_a16(seg_reg & seg, uint_<16> off)
{
    if (get_cpl() != 0)
        throw exo::exception::not_implemented(); // #GP(0)

    idtr_limit = memw_a16(seg, off);
    idtr_base = memd_a16(seg, off + 2) & 0x00ffffff;
}

inline void sidtd_a32(seg_reg &, uint_<32>)
{
    throw exo::exception::not_implemented();
}


template<exo::abstract_int L, typename T>
void lsl(uint_<L> & d, T s)
{
    seg_reg    seg = s;

    zf = true; // zf <-> valid

    if (seg.is_null())
        zf = false;

    if (zf)
    {
        uint_<8> type = seg.get_cached_desc().get_s_and_type();
        if (type == 0 || (4 <= type && type <= 8) || (type == 0xa) || (0xc <= type && type <= 0xf))
            zf = false;
    }

    if (zf)
    {
        if (seg.get_cached_desc().is_type_non_conforming_code()
                && ( (seg.get_cached_desc().get_dpl() < get_cpl())
                    || (seg.get_cached_desc().get_dpl() < seg.get_rpl()) ))
            zf = false;
    }

    if (zf)
        d = seg.get_limit();
}

// +
template<exo::abstract_int L, typename T>
void lar(uint_<L> & d, T s)
{
    seg_reg seg = s;

    zf = true; // zf <-> valid

    if (seg.is_null())
        zf = false;

    if (zf)
    {
        uint_<8> type = seg.get_cached_desc().get_s_and_type();
        if (type == 0 || (6 <= type && type <= 8) || (type == 0xa) || (0xd <= type && type <= 0xf))
            zf = false;
    }

    if (zf)
    {
        if (seg.get_cached_desc().is_type_non_conforming_code()
                && ( (seg.get_cached_desc().get_dpl() < get_cpl())
                    || (seg.get_cached_desc().get_dpl() < seg.get_rpl()) ))
            zf = false;
    }

    if (zf)
    {
        d = reinterpret_cast<uint_<32>*>(& seg.get_orig_desc_ref())[1];

        // 16 - & 0x__ff00
        // 32 - & 0xffff00

        uint_<L> mask = 0xffff;
        mask <<= 8;

        d &= mask;
    }
}

// +
inline void ltr(uint_<16> val)
{
    if ((val & 0x4) != 0)
        throw exo::exception::not_implemented(); // #GP(segment selector)

    tr = val;

    if (tr.is_null())
        throw exo::exception::not_implemented(); // #GP(0)

    if (tr.get_cached_desc().is_type_tss() == false || tr.get_cached_desc().is_tss_busy())
        throw exo::exception::not_implemented(); // #GP(segment selector)
    if (tr.is_present() == false)
        throw exo::exception::not_implemented(); // #NP(segment selector)

    tr.get_orig_desc_ref().set_tss_busy(true);
}

inline void str(uint_<16> & d)
{
    d = tr;
}

void invalid();

inline void lahf()
{
    throw exo::exception::not_implemented();
}

// +
inline void stosb_a16()
{
    memb_a16(es, di) = al;
    di += df ? -1 : 1;
}

// +
inline void stosw_a16()
{
    memw_a16(es, di) = ax;
    di += df ? -2 : 2;
}

inline void stosd_a16()
{
    memd_a16(es, di) = eax;
    di += df ? -4 : 4;
}

inline void stosb_a32()
{
    memb_a32(es, edi) = al;
    edi += df ? -1 : 1;
}

inline void stosw_a32()
{
    memw_a32(es, edi) = ax;
    edi += df ? -2 : 2;
}

inline void stosd_a32()
{
    memd_a32(es, edi) = eax;
    edi += df ? -4 : 4;
}

// +
inline void scasb_a16()
{
    cmp(al, memb_a16(es, di));
    di += df ? -1 : 1;
}

inline void scasb_a32()
{
    cmp(al, memb_a32(es, edi));
    edi += df ? -1 : 1;
}

// +
inline void scasw_a16()
{
    cmp(ax, memw_a16(es, di));
    di += df ? -2 : 2;
}

inline void scasd_a16()
{
    cmp(eax, memd_a16(es, di));
    di += df ? -4 : 4;
}

inline void scasd_a32()
{
    cmp(eax, memd_a32(es, edi));
    edi += df ? -4 : 4;
}

// +
inline void lodsb_a16()
{
    al = memb_a16(ds, si);
    si += df ? -1 : 1;
}

inline void lodsb_a32()
{
    al = memb_a32(ds, esi);
    esi += df ? -1 : 1;
}

// +
inline void lodsw_a16()
{
    ax = memw_a16(ds, si);
    si += df ? -2 : 2;
}

inline void lodsd_a16()
{
    eax = memd_a16(ds, si);
    si += df ? -4 : 4;
}

inline void lodsd_a32()
{
    eax = memd_a32(ds, esi);
    esi += df ? -4 : 4;
}

// +
inline void movsb_a16(seg_reg & seg)
{
    memb_a16(es, di) = memb_a16(seg, si);
    di += df ? -1 : 1;
    si += df ? -1 : 1;
}

// +
inline void movsb_a16()
{
    movsb_a16(ds);
}

inline void movsb_a32(seg_reg & seg)
{
    memb_a32(es, edi) = memb_a32(seg, esi);
    edi += df ? -1 : 1;
    esi += df ? -1 : 1;
}

inline void movsb_a32()
{
    movsb_a32(ds);
}

// +
inline void movsw_a16(seg_reg & seg)
{
    memw_a16(es, di) = memw_a16(seg, si);
    di += df ? -2 : 2;
    si += df ? -2 : 2;
}

// +
inline void movsw_a16()
{
    movsw_a16(ds);
}

inline void movsw_a32(seg_reg & seg)
{
    memw_a32(es, edi) = memw_a32(seg, esi);
    edi += df ? -2 : 2;
    esi += df ? -2 : 2;
}

inline void movsw_a32()
{
    movsw_a32(ds);
}

// +
inline void movsd_a16()
{
    memd_a16(es, di) = memd_a16(ds, si);
    di += df ? -4 : 4;
    si += df ? -4 : 4;
}

// +
inline void movsd_a32(seg_reg & seg)
{
    memd_a32(es, edi) = memd_a32(seg, esi);
    edi += df ? -4 : 4;
    esi += df ? -4 : 4;
}

// +
inline void movsd_a32()
{
    movsd_a32(ds);
}

// +
inline void cmpsb_a16()
{
    cmp(memb_a16(ds, si), memb_a16(es, di));
    di += df ? -1 : 1;
    si += df ? -1 : 1;
}

inline void cmpsb_a32()
{
    cmp(memb_a32(ds, esi), memb_a32(es, edi));
    edi += df ? -1 : 1;
    esi += df ? -1 : 1;
}

// +
inline void cmpsw_a16()
{
    cmp(memw_a16(ds, si), memw_a16(es, di));
    di += df ? -2 : 2;
    si += df ? -2 : 2;
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

inline void outsb_a32()
{
    // @todo check permission
    dos::outb(dx, memb_a32(ds, esi));
    esi += df ? -1 : 1;
}

/**
 * @brief Store AH into Flags.
 * Loads SF, ZF, AF, PF, and CF from AH into EFLAGS register.
 */
inline void sahf()
{
    uint_<32> mod_mask = eflag_mask::sf | eflag_mask::zf | eflag_mask::af | eflag_mask::pf | eflag_mask::cf;
    eflags = (uint_<32>(eflags) & (~mod_mask)) | (ah & mod_mask);
}

inline void aam(uint_<8>)
{
    throw exo::exception::not_implemented();
}

inline void verr(uint_<16>)
{
    throw exo::exception::not_implemented();
}

// +
inline void wait()
{
    // Не нужна.
}

/* uint_<64> & чтоб не перепутать с uint_<32> &  */

void fninit();
void fnstsw(uint_<16> &);
void fnstcw(uint_<16> &);
void fldcw(uint_<16> x);
void fnsavew_a16(seg_reg &, uint_<16>);
void fldz();
void fld1();
void fldln2();
void fldl2e();
void fldlg2();
void fld(int src_n, int dst_n);
void fld(uint_<32> & val);
void fld(uint_<64> & val);
void fld(uint_<80> & val);
void fchs();
void fdiv(uint_<32> &);
void fdiv(uint_<64> &);
void fdiv(uint_<80> &);
void fdiv(int src_n, int dst_n);
void fdivp(int src_n, int dst_n);
void fdivr(uint_<32> &);
void fdivr(uint_<64> &);
void fdivr(uint_<80> &);
void fdivr(int, int);
void fdivrp(int, int);
void fmul(uint_<32> &);
void fmul(uint_<64> &);
void fmul(uint_<80> &);
void fmul(int, int);
void fmulp(int src_n, int dst_n);
void fsub(int src_n, int dst_n);
void fsubp(int src_n, int dst_n);
void fsubr(uint_<32> &);
void fsubr(uint_<64> &);
void fsubr(uint_<80> &);
void fcom();
void fcom(uint_<32> & val);
void fcom(uint_<64> & val);
void fcom(uint_<80> & val);
void fcom(int, int);
void fcomp();
void fcomp(uint_<32> & val);
void fcomp(uint_<64> & val);
void fcomp(uint_<80> & val);
void fcomp(int, int);
void fcompp();
void ftst();
void fxch(int src_n, int dst_n);
void fild(uint_<16> &);
void fild(uint_<32> &);
void fild(uint_<64> &);
void fstp(uint_<32> &);
void fstp(uint_<64> &);
void fstp(uint_<80> &);
void fstp(int);
void fst(uint_<32> &);
void fst(uint_<64> &);
void fst(uint_<80> &);
void fistp(uint_<32> &);
void fistp(uint_<64> &);
void fistp(uint_<80> &);
void frndint();
void fprem();
void fyl2x();
void fadd(uint_<32> &);
void fadd(uint_<64> &);
void fadd(uint_<80> &);
void fadd(int, int);
void faddp(int, int);
void fsqrt();
void fscale();
void fabs();
void f2xm1();


} /* namespace x86 */
} /* namespave raw_program */

#endif /* OPENMAX_X86_INSTRUCTIONS_HPP_INCLUDED */

