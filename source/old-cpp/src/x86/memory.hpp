#ifndef OPENMAX_X86_MEMORY_HPP_INCLUDED
#define OPENMAX_X86_MEMORY_HPP_INCLUDED

#include <type_traits>
#include <exo/global.hpp>
#include <exo/memory_space.hpp>
#include "registers.hpp"

namespace raw_program {
namespace x86 {


inline void int_set(uint_<8> num, uint_<16> cs_, uint_<16> ip_)
{
    exo::memory_space ms = mem_pg_raw(num * 4, 4);
    ms.get<uint_<16>>(0) = ip_;
    ms.get<uint_<16>>(1) = cs_;
}

inline void int_get(uint_<8> num, uint_<16> & cs_, uint_<16> & ip_)
{
    exo::memory_space ms = mem_pg_raw(num * 4, 4);
    ip_ = ms.get<uint_<16>>(0);
    cs_ = ms.get<uint_<16>>(1);
}

inline void int_get(uint_<8> num, seg_reg & cs_, uint_<16> & ip_)
{
    exo::memory_space ms = mem_pg_raw(num * 4, 4);
    ip_ = ms.get<uint_<16>>(0);
    cs_ = ms.get<uint_<16>>(1);
}

inline void int_get_idt(uint_<8> num, seg_reg & cs_, uint_<32> & eip_)
{
    exo::memory_space ms = mem_pg_raw(idtr_base + num * 4, 4);
    eip_ = ms.get<uint_<16>>(0);
    cs_ = ms.get<uint_<16>>(1);
}


} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_MEMORY_HPP_INCLUDED */

