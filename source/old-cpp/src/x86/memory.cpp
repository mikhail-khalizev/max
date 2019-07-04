#include <set>
#include <map>
#include <memory>
#include <stdlib.h>

#include <exo/exception.hpp>
#include <exo/linux/exception.hpp>
#include <boost/polygon/interval_data.hpp>

#include "instructions.hpp"
#include "memory.hpp"
#include "registers.hpp"


namespace raw_program {

extern bool extra_log;

namespace x86 {

using namespace exo;


struct pde_mask
{
    enum __ : typename uint_<32>::type
    {
        none = 0,

        p = (1 << 0),
        rw = (1 << 1),
        us = (1 << 2),
        pwt = (1 << 3),
        pcd = (1 << 4),
        a = (1 << 5),
        ps = (1 << 7)
    };
};

struct pte_mask
{
    enum __ : typename uint_<32>::type
    {
        none = 0,

        p = (1 << 0),
        rw = (1 << 1),
        us = (1 << 2),
        pwt = (1 << 3),
        pcd = (1 << 4),
        a = (1 << 5),
        d = (1 << 6),
        pat = (1 << 7),
        g = (1 << 8)
    };
};


bool a20_gate = false;
uint_<8>::type phys_mem[mem_limit.get()]; // @todo Для отладки убрали "static " вначале.

/* Two pages cache. */
uint_<8>::type cache[0x2000];
uint_<32> cache_map[2];
bool cache_ena[2];


// +
memory_space mem_phys_raw(uint_<32> addr, uint_<32> size)
{
    using namespace boost::polygon;

    const memory_space phys_mem_ms(phys_mem, sizeof(phys_mem));


    if (a20_gate == false)
        addr = addr & 0xfffff;


    const interval_data<uint_<32>> input(addr, addr + size);

//    uint_<32> addr_interesting = 0xffffe;
//    interval_data<uint_<32>> interesting(addr_interesting, addr_interesting + 2);
//
//    if (intersects(input, interesting, false))
//    {
//        int a = 4;
//    }


    for (int i = 0; i < 2; i++)
    {
        if (cache_ena[i] == false)
            continue;

        const interval_data<uint_<32>> cache_region(cache_map[i], cache_map[i] + 0x1000);

        if (intersects(cache_region, input, false) == false)
            continue;

        if (contains(cache_region, input))
        {
            // Запрашиваемый регион полностью содержится в кеше.
            return memory_space(
                    & cache[i * 0x1000 + addr - cache_map[i]],
                    0x1000 - (addr - cache_map[i]));
        }
        else
        {
            // Выгружаем страницу обратно.
            memcpy(& phys_mem[cache_map[i]], & cache[i * 0x1000], 0x1000);
            cache_ena[i] = false;
        }
    }


    memory_space ret = phys_mem_ms.remove_prefix(addr);


    if (ret.size() < size)
        throw std::range_error("Доступна только часть памяти.");

    return ret;
}

// +
static void paging_fault(uint_<32> addr)
{
    // Paging Fault
    cr2 = addr;
    auto eip_next_save = eip_next;

    uint_<8> mode = (cs.get_db() ? 32 : 16);
    uint_<32> ret_addr = cs.get_base() + eip;
    int_internal(0xe, true, false, true, 0);
    if (correct_function_position(ret_addr))
        throw exo::exception::not_implemented();
    check_mode();

    eip_next = eip_next_save;
}

// +
uint_<32> mem_pg_raw_get_phys_addr(uint_<32> addr)
{
    if (cr0.pg == false)
        return addr;

    for(;;)
    {
        if (cr4.pae)
            throw exo::exception::not_implemented();

        uint_<32> pdi = addr >> 22;
        uint_<32> pti = (addr >> 12) & 0x3ff;
        uint_<32> off = addr & 0xfff;

        uint_<32> pde = mem_phys_raw((cr3 & 0xfffff000) + 4 * pdi, 4).get<uint_<32>>();

        if (cr4.pse && (pde & pde_mask::ps) != 0) // 4Mb page
            throw exo::exception::not_implemented();

        if ((pde & pde_mask::p) == 0 /* || @todo reserved bits sets */)
        {
            paging_fault(addr);
            continue; // repeat in for(;;)
        }

        uint_<32> pte = mem_phys_raw((pde & 0xfffff000) + 4 * pti, 4).get<uint_<32>>();
        if ((pte & pte_mask::p) == 0 /* || @todo reserved bits sets */)
        {
            paging_fault(addr);
            continue; // repeat in for(;;)
        }

        uint_<32> result_addr = (pte & 0xfffff000) + off;


        if (extra_log)
        {
            uint_<32> addr_interesting = 0xa0000;
            boost::polygon::interval_data<uint_<32>> interesting(addr_interesting, addr_interesting + 0x10000);

            if (contains(interesting, result_addr, false))
            {
                static std::set<uint_<32>> used_addr;

                auto ret = used_addr.insert(eip);
                if (ret.second)
                    std::cout << "access to video memory from eip 0x" << std::hex << eip << std::endl;
            }
        }


        return result_addr;
    }
}

// +
memory_space mem_pg_raw(uint_<32> addr, uint_<32> size)
{
    using namespace boost::polygon;


//    const interval_data<uint_<32>> input(addr, addr + size);
//
//    uint_<32> addr_interesting = 0xffffe;
//    interval_data<uint_<32>> interesting(addr_interesting, addr_interesting + 2);
//
//    if (intersects(input, interesting, false))
//    {
//        int a = 4;
//    }


    if (cr0.pg == false)
        return mem_phys_raw(addr, size);
    else
    {
        uint_<32> phys_addr[2]; /* { current, current + page } */
        phys_addr[0] = mem_pg_raw_get_phys_addr(addr);

        const uint_<32> start_page_part = (phys_addr[0] & (~static_cast<uint_<32>>(0xfff)));
        const uint_<32> end_page_part = ((phys_addr[0] + (size == 0 ? uint_<32>(0) : size - 1)) & (~static_cast<uint_<32>>(0xfff)));

        if (start_page_part != end_page_part) /* Несколько страницы. */
        {
            if (start_page_part + 0x1000 != end_page_part) /* Более двух страницы. */
                throw exo::exception::not_implemented();

            phys_addr[1] = mem_pg_raw_get_phys_addr(addr + 0x1000);

            if (phys_addr[0] + 0x1000 != phys_addr[1])
            {
                /* Не идут последовательно -> загружаем в кэш. */

                if (a20_gate == false)
                    throw exo::exception::not_implemented();

                for (int i = 0; i < 2; i++)
                {
                    if (cache_ena[i] == true) /* Страница кэша занята. */
                    {
                        if ((cache_map[i] | 0xfff) != (phys_addr[i] | 0xfff)) /* И не тем, чем нужно. */
                        {
                            /* Выгружаем страницу обратно. */
                            memcpy(& phys_mem[cache_map[i]], & cache[i * 0x1000], 0x1000);
                            cache_ena[i] = false;
                        }
                    }

                    if (cache_ena[i] == false) /* Страница кэша пуста. */
                    {
                        // Загружаем страницу.
                        cache_map[i] = phys_addr[i] & (~static_cast<uint_<32>>(0xfff));
                        memcpy(& cache[i * 0x1000], & phys_mem[cache_map[i]], 0x1000);
                        cache_ena[i] = true;
                    }
                }

                return memory_space(
                        & cache[phys_addr[0] - cache_map[0]],
                        0x2000 - (phys_addr[0] - cache_map[0]));
            }
        }


        return mem_phys_raw(phys_addr[0], size)
                .sub_space(0, end_page_part + 0x1000 - phys_addr[0]); /* Ограничим размер страницами в которых находится область. */
    }
}

// +
memory_space mem_seg_pg_raw(const seg_reg & seg, uint_<32> addr, uint_<32> size)
{
    if (seg.is_present() == false /* @todo || seg.is_null() */)
        throw exo::exception::not_implemented();

    if (seg.fail_limit_check(addr, size))
        throw exo::exception::not_implemented();

    memory_space ret = mem_pg_raw(seg.get_base() + addr, size);


    // correct size with segment limit

    uint_<32> end = addr + ret.size();

    if (seg.get_limit() + 1 != 0)
    {
        if (end == 0)
            end = seg.get_limit() + 1;
        else
            end = std::min(end, seg.get_limit() + 1);
    }

    if (end <= addr)
        throw exo::exception::not_implemented();

    ret.size() = end - addr;


    return ret;
}

uint_<8> & memb_a16(const seg_reg & seg, uint_<16> addr)
{
    return mem_seg_pg_raw(seg, addr, 1).get<uint_<8>>();
}

uint_<16> & memw_a16(const seg_reg & seg, uint_<16> addr)
{
    return mem_seg_pg_raw(seg, addr, 2).get<uint_<16>>();
}

uint_<32> & memd_a16(const seg_reg & seg, uint_<16> addr)
{
    return mem_seg_pg_raw(seg, addr, 4).get<uint_<32>>();
}

uint_<64> & memq_a16(const seg_reg & seg, uint_<16> addr)
{
    return mem_seg_pg_raw(seg, addr, 8).get<uint_<64>>();
}

uint_<80> & memt_a16(const seg_reg &, uint_<16>)
{
    throw exo::exception::not_implemented();
}

uint_<8> & memb_a32(const seg_reg & seg, uint_<32> addr)
{
    return mem_seg_pg_raw(seg, addr, 1).get<uint_<8>>();
}

uint_<16> & memw_a32(const seg_reg & seg, uint_<32> addr)
{
    return mem_seg_pg_raw(seg, addr, 2).get<uint_<16>>();
}

uint_<32> & memd_a32(const seg_reg & seg, uint_<32> addr)
{
    return mem_seg_pg_raw(seg, addr, 4).get<uint_<32>>();
}

uint_<64> & memq_a32(const seg_reg & seg, uint_<32> addr)
{
    return mem_seg_pg_raw(seg, addr, 8).get<uint_<64>>();
}

uint_<80> & memt_a32(const seg_reg &, uint_<32>)
{
    throw exo::exception::not_implemented();
}

bool mem_pg_equals(uint_<32> addr, exo::memory_space_const left)
{
    uint_<32> proccessed = 0;

    while (left.size() != 0)
    {
        memory_space code = mem_pg_raw(addr + proccessed, 1);

        if (left.size() <= code.size())
            return code.starts_with(left);
        else
        {
            if (left.starts_with(code) == false)
                return false;

            proccessed += code.size();
            left = left.remove_prefix(code.size());
        }
    }

    return true;
}

} /* namespace x86 */
} /* namespace raw_program */
