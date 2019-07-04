#ifndef OPENMAX_X86_MEMORY_HPP_INCLUDED
#define OPENMAX_X86_MEMORY_HPP_INCLUDED

#include <type_traits>
#include <exo/global.hpp>
#include <exo/memory_space.hpp>
#include "registers.hpp"


namespace exo {
namespace math {

template<>
class uint_<80>
{
    typename uint_<8>::type val[10];
};

static_assert(sizeof(uint_<80>) == 10, "Компилятор неправильно упаковал структуру.");

} /* namespace math */
} /* namespace exo */


namespace raw_program {
namespace x86 {


extern bool a20_gate;
constexpr uint_<32> mem_limit = 32 * 1024 * 1024; /* 32Mb = 0x2000000 */


/** no seg, no pg    may return size more, then input size  */
exo::memory_space mem_phys_raw(uint_<32> addr, uint_<32> size);

/** no seg, yes pg   may return size more, then input size  */
exo::memory_space mem_pg_raw(uint_<32> addr, uint_<32> size);

/** yes seg, yes pg  may rerurn size more, then input size  */
exo::memory_space mem_seg_pg_raw(const seg_reg & seg, uint_<32> addr, uint_<32> size);

/** @note На самом деле это внутренняя функция. Она сделана "публичной" в целях отладки. */
uint_<32> mem_pg_raw_get_phys_addr(uint_<32> addr);

uint_<8>  & memb_a16(const seg_reg & seg, uint_<16> addr);
uint_<16> & memw_a16(const seg_reg & seg, uint_<16> addr);
uint_<32> & memd_a16(const seg_reg & seg, uint_<16> addr);
uint_<64> & memq_a16(const seg_reg & seg, uint_<16> addr);
uint_<80> & memt_a16(const seg_reg & seg, uint_<16> addr);

uint_<8>  & memb_a32(const seg_reg & seg, uint_<32> addr);
uint_<16> & memw_a32(const seg_reg & seg, uint_<32> addr);
uint_<32> & memd_a32(const seg_reg & seg, uint_<32> addr);
uint_<64> & memq_a32(const seg_reg & seg, uint_<32> addr);
uint_<80> & memt_a32(const seg_reg & seg, uint_<32> addr);

template<typename T>
typename std::add_lvalue_reference<T>::type mem(const seg_reg & seg, uint_<32> addr)
{
    return mem_seg_pg_raw(seg, addr, sizeof(T)).get<T>();
}

bool mem_pg_equals(uint_<32> addr, exo::memory_space_const sp);


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

