#ifndef OPENMAX_X86_SEGMENT_HPP_INCLUDED
#define OPENMAX_X86_SEGMENT_HPP_INCLUDED

#include <exo/global.hpp>

namespace raw_program {
namespace x86 {

// @todo Cделать seg_selector.
// selector 16 bit = 13 bit (index) + 1 bit (ti) + 2 bit (req priv)

class seg_desc
{
    uint_<8> desc[8];

public:

    uint_<32> get_base()
    {
        return desc[2] + (desc[3] << 8) + (desc[4] << 16) + (desc[7] << 24);
    }
    void set_base(uint_<32> val)
    {
           desc[2] = val;
           desc[3] = val >> 8;
           desc[4] = val >> 16;
           desc[7] = val >> 24;
    }
    uint_<32> get_limit()
    {
        uint_<32> limit(desc[6] & 0xf, desc[1], desc[0]); // = desc[0] + (desc[1] << 8) + ((desc[6] & 0xf) << 16);

        if ((desc[6] & 0x80) != 0) /* if G set ... */
            limit = (limit << 12) | 0xfff;

        return limit;
    }
    /** Set to true if segment is present */
    bool is_present()
    {
        return (desc[5] & 0x80) != 0;
    }
    /** Default operation size (false = 16-bit segment; true = 32-bit segment)*/
    bool get_db()
    {
        return (desc[6] & 0x40) != 0;
    }
    /** Privilege Level    0 = Highest privilege (OS), 3 = Lowest privilege (User applications) */
    uint_<8> get_dpl()
    {
        return (desc[5] >> 5) & 0x3;
    }
    /** 64-bit code segment (IA-32e mode only) */
    bool get_l()
    {
        return (desc[6] & 0x20) != 0;
    }
    /* Available for use by system software */
//    bool get_avl()
//    {
//        return (desc[6] & 0x10) != 0;
//    }
    uint_<8> get_s_and_type()
    {
        return (desc[5] & 0x1f);
    }

    uint_<8> get_system_segment_size()
    {
        if (((desc[5] >> 3) & 1) != 0)
            return 32;
        else
            return 16;
    }


    bool is_compatibility_mode();
    bool is_type_64bit_call_gate();
    bool is_type_code();
    bool is_type_conforming_code();
    bool is_type_non_conforming_code();
    bool is_type_tss();
    bool is_type_call_gate();
    bool is_type_task_gate();
    bool is_type_trap_gate();
    bool is_type_interrupt_gate();
    bool is_type_32_interrupt_gate();
    bool is_type_32_tss();
    bool is_type_ldt();

    bool is_data_or_code()
    {
        return (desc[5] & 0x10) != 0;
    }

    bool is_tss_busy();
    void set_tss_busy(bool val);

    /** If this is gate descriptor. */
    uint_<16> get_gate_selector();

    uint_<32> get_interrupt_or_trap_eip()
    {
        return desc[0] + (desc[1] << 8) + (desc[6] << 16) + (desc[7] << 24);
    }


    static seg_desc & get_desc_ref(uint_<64> dt_base, uint_<16> dt_limit, uint_<16> selector);
};

class seg_reg
{
    seg_desc desc; // hidden part of segment

    uint_<32> base; // cache
    uint_<32> limit; // cache

    uint_<16> val;
    uint_<8> rpl; // hidden part of segment

    bool present; // cache
    bool l; // cache
    bool db; // cache

public:

    seg_reg();
    seg_reg(uint_<16> val);

    seg_reg & operator=(uint_<16> val);

    seg_desc & get_orig_desc_ref() const;
    static seg_desc & get_orig_desc_ref(uint_<16> selector);

    operator uint_<16>() const
    {
        return val;
    }

    operator uint_<32>() const
    {
        return val;
    }

    uint_<32> get_base() const
    {
        return base;
    }
    // void set_base(uint_<32> base);

    uint_<32> get_limit() const
    {
        return limit;
    }

    seg_desc get_cached_desc() const
    {
        return desc;
    }

    /** @return true if check fail */
    bool fail_limit_check(uint_<32> addr, uint_<8> size = 1) const;


    bool is_null() const
    {
        return (val <= 0x3);
    }

    bool is_present() const
    {
        return present;
    }

    bool get_db() const
    {
        return db;
    }

    uint_<8> get_rpl() const
    {
        return rpl;
    }

    void set_rpl(uint_<8> rpl_)
    {
        rpl = rpl_;
        val = (rpl & 0x3) | (val & (~0x3));
    }

    bool get_l() const
    {
        return l;
    }
};

} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_SEGMENT_HPP_INCLUDED */
