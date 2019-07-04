#include <exo/exception.hpp>
#include "x86/memory.hpp"
#include "x86/segment.hpp"
#include "x86/registers.hpp"

namespace raw_program {
namespace x86 {


bool seg_desc::is_compatibility_mode()
{
    return (ia32_efer.lma && get_l() == false);
}

bool seg_desc::is_type_64bit_call_gate()
{
    return ia32_efer.lma && get_l() && get_db() == false && get_s_and_type() == 0x0c;
}

bool seg_desc::is_type_code()
{
    return (get_s_and_type() | 0x7) == 0x1f;
}

bool seg_desc::is_type_conforming_code()
{
    return (get_s_and_type() | 0x3) == 0x1f;
}

bool seg_desc::is_type_non_conforming_code()
{
    return (get_s_and_type() | 0x3) == 0x1b;
}

bool seg_desc::is_type_tss()
{
    // @todo only 32-Bit Mode?
    return (get_s_and_type() | 0xa) == 0x0b;
}

bool seg_desc::is_type_call_gate()
{
    // @todo only 32-Bit Mode?
    return (get_s_and_type() | 0x8) == 0x0c;
}

bool seg_desc::is_type_task_gate()
{
    // @todo only 32-Bit Mode?
    return get_s_and_type() == 0x05;
}

bool seg_desc::is_type_trap_gate()
{
    // @todo only 32-Bit Mode?
    return (get_s_and_type() | 0x8) == 0x0f;
}

bool seg_desc::is_type_interrupt_gate()
{
    // @todo only 32-Bit Mode?
    return (get_s_and_type() | 0x8) == 0x0e;
}

bool seg_desc::is_type_32_interrupt_gate()
{
    // @todo only 32-Bit Mode?
    return get_s_and_type() == 0x0e;
}

bool seg_desc::is_type_32_tss()
{
    // @todo only 32-Bit Mode?
    return (get_s_and_type() | 0x2) == 0x0b;
}

bool seg_desc::is_type_ldt()
{
    return get_s_and_type() == 0x2;
}

bool seg_desc::is_tss_busy()
{
    return ((get_s_and_type() >> 1) & 0x1) != 0;
}

void seg_desc::set_tss_busy(bool val)
{
    if (val)
        desc[5] |= 0x2;
    else
        desc[5] &= ~0x2;
}

uint_<16> seg_desc::get_gate_selector()
{
    return desc[2] + (desc[3] << 8);
}


// +
seg_desc & seg_desc::get_desc_ref(uint_<64> dt_base, uint_<16> dt_limit, uint_<16> selector)
{
    if (cr0.pe == false)
        throw std::exception();

    if (dt_limit < (selector & 0xfff8) + 7)
        throw exo::exception::not_implemented(); // #GP(selector) or #GP(error_code(vector_number,1,EXT)) in interrupt

    return mem_pg_raw(dt_base + (selector & 0xfff8), 8).get<seg_desc>();
}


seg_reg::seg_reg()
: desc()
, base(0)
, limit(0xffff)
, val(0)
, rpl(0)
, present(true)
, l()
, db()
{}

seg_reg::seg_reg(uint_<16> val_)
: desc()
, base(0)
, limit(0xffff)
, val(0)
, rpl(0)
, present(true)
, l()
, db()
{
    *this = val_;
}

// +
seg_desc & seg_reg::get_orig_desc_ref() const
{
    return get_orig_desc_ref(val);
}

// +
seg_desc & seg_reg::get_orig_desc_ref(uint_<16> selector)
{
    if ((selector & 0x7) != 0)
        throw exo::exception::not_implemented();

    return seg_desc::get_desc_ref(gdtr_base, gdtr_limit, selector);
}

// +
seg_reg & seg_reg::operator=(uint_<16> val_)
{
    val = val_;

    if (cr0.pe == false)
        base = val * 16;
    else
    {
        if (is_null())
        {
            desc = seg_desc();
            base = 0;
            limit = 0;
            present = false;
        }
        else
        {
            rpl = val & 0x3;
            desc = get_orig_desc_ref();
            base = desc.get_base();
            limit = desc.get_limit();
            present = desc.is_present();
            l = desc.get_l();
            db = desc.get_db();
        }
    }

    return *this;
}

// +
bool seg_reg::fail_limit_check(uint_<32> addr, uint_<8> size) const
{
    if (limit < addr + (size == 0 ? uint_<32>(0) : uint_<32>(size - 1)))
        return true;
    return false;
}

} /* namespace x86 */
} /* namespace raw_program */
