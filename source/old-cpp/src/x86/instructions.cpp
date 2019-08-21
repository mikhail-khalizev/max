#include <math.h>
#include <memory>
#include <iomanip>

#include <exo/exception.hpp>

#include "x86/memory.hpp"
#include "x86/registers.hpp"
#include "x86/instructions.hpp"
#include "program/raw_program.hpp"


namespace raw_program {

extern bool extra_log;

namespace x86 {

/* fpu */

enum class fpu_precision
{
    /* 24 bit */
    single,
    /* 53 bit */
    double_,
    /* 64 bit */
    double_extended
};

//static fpu_precision get_precision()
//{
//    uint_<8> p = (FPUControlWord >> 8) & 3;
//    switch (p)
//    {
//    case 0:
//        return fpu_precision::single;
//    case 2:
//        return fpu_precision::double_;
//    case 3:
//        return fpu_precision::double_extended;
//    default:
//        throw std::exception();
//    }
//}

void fnsavew_a16(seg_reg & seg, uint_<16> off)
{
    if (cr0.pe == false)
    {
        memw_a16(seg, off) = FPUControlWord;
        memw_a16(seg, off + 2) = FPUStatusWord;
        memw_a16(seg, off + 4) = FPUTagWord;
        memw_a16(seg, off + 6) = FPUInstructionPointer_off;
        memw_a16(seg, off + 8) = ((FPUInstructionPointer_off >> 16) << 12) | FPULastInstructionOpcode;
        memw_a16(seg, off + 10) = FPUDataPointer_off;
        memw_a16(seg, off + 12) = ((FPUDataPointer_off >> 16) << 12);
    }
    else
        throw exo::exception::not_implemented();

    for (int i = 0; i < 8; i++)
        mem_seg_pg_raw(seg, off + 14 + i * 10, 10).get<__float80>() = ST(i);

    fninit();
}

void fldl2e()
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = M_LOG2El;
    set_tag(0, 0);
}

void fld(uint_<32> & val)
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = reinterpret_cast<float&>(val);
    set_tag(0, 0);
}

void fld(uint_<64> & val)
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = reinterpret_cast<double&>(val);
    set_tag(0, 0);
}

void fld(uint_<80> &)
{
    throw exo::exception::not_implemented();
}

void fdiv(uint_<64> & val_)
{
    double val = reinterpret_cast<double&>(val_);

    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    ST(0) /= val;
}

void fdivr(int a, int b)
{
    if (get_tag(a) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(b) == 3)
        throw exo::exception::not_implemented();
    ST(a) = ST(b) / ST(a);
}

void fdivrp(int a, int b)
{
    fdivr(a, b);
    fpu_pop();
}

void fmul(uint_<32> &)
{
    throw exo::exception::not_implemented();
}

void fmul(uint_<64> & x)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    double val = reinterpret_cast<double&>(x);

    ST(0) *= val;
}

void fsubr(uint_<64> & x_)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    double x = reinterpret_cast<double&>(x_);

    ST(0) = x - ST(0);
}

void ftst()
{
    double val = 0;
    fcom(reinterpret_cast<uint_<64>&>(val));
}


/**
 * @brief Store Integer.
 * Store ST(0) in <...> and pop register stack.
 */
void fistp(uint_<64> & x_)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    int64_t & x = reinterpret_cast<int64_t &>(x_); // from unsigned to signed

    x = ST(0);
    if (static_cast<__float80>(x) != ST(0))
        throw exo::exception::not_implemented();

    fpu_pop();
}

/**
 * @brief Store Real.
 * Copy ST(0) to <...> and pop register stack.
 */
void fstp(uint_<80> &)
{
    throw exo::exception::not_implemented();
}

/**
 * @brief Store Real.
 * Copy ST(0) to ST(s) and pop register stack.
 */
void fstp(int s)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    if (s != 0)
    {
        ST(s) = ST(0);
        set_tag(s, get_tag(0));
    }

    fpu_pop();
}

void fyl2x()
{
    // ST(1) ← ST(1) ∗ log2ST(0);

    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(1) == 3)
        throw exo::exception::not_implemented();

    __float80 x = ST(0);
    __float80 y = ST(1);
    __float80 result;
    asm ("fyl2x" : "=t" (result) : "0" (x), "u" (y) : "st(1)");
    ST(1) = result;

    fpu_pop();
}

void fprem()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(1) == 3)
        throw exo::exception::not_implemented();

    __float80 x = ST(0);
    __float80 y = ST(1);
    __float80 result;
    asm ("fprem" : "=t" (result) : "0" (x), "u" (y));
    ST(0) = result;
}

void fscale()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(1) == 3)
        throw exo::exception::not_implemented();

    ST(0) = ldexpl(ST(0), ST(1));
}

void f2xm1()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    __float80 x = ST(0);
    __float80 result;
    asm ("f2xm1" : "=t" (result) : "0" (x));
    ST(0) = result;
}


} /* namespace x86 */
} /* namespace raw_program */
