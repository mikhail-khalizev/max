#include <map>
#include "dos/memory.hpp"
#include "x86/memory.hpp"
#include "x86/instructions.hpp" /* Для retfw(). */


namespace raw_program {
namespace dos {


using namespace exo;
using namespace x86;


// +
void dos_mem_init()
{
    memory_space phys_mem_ms = mem_phys_raw(0, 0x100030);

    for (int addr = 0x100000; addr < 0x100030; addr++)
        phys_mem_ms.get<char>(addr) = rand();

    /* type_of_ibm_pc */
    phys_mem_ms.get<char>(0xffffe) = 0xfc;
    phys_mem_ms.get<char>(0xfffff) = 0x55;

    /* int_67 source. */
    phys_mem_ms.get<char>(0xc841a) = 0x45;
    phys_mem_ms.get<char>(0xc841b) = 0x4d;
    phys_mem_ms.get<char>(0xc841c) = 0x4d;
    phys_mem_ms.get<char>(0xc841d) = 0x58;
    phys_mem_ms.get<char>(0xc841e) = 0x58;
    phys_mem_ms.get<char>(0xc841f) = 0x58;
    phys_mem_ms.get<char>(0xc8421) = 0x30;
}

std::map<uint_<32> /* phys_addr */, uint_<32> /* size */> maps;

// +
void dos_mem_alloc()
{
    cf = true;

    // search first largest block

    bx += 1; // Как бы на внутренние нужды.
    if (bx == 0)
        throw exo::exception::not_implemented();

    uint_<16> find_par = 0;
    for (auto iter = maps.begin(); iter != maps.end(); iter++)
    {
        if (iter -> first / 16 - find_par < bx)
        {
            find_par = (iter -> first + iter -> second + 15) / 16;
            continue;
        }

        cf = false;
        break;
    }

    if (cf == true)
    {
        auto iter = maps.end();
        if (iter != maps.begin())
        {
            iter--;
            find_par = (iter -> first + iter -> second + 15) / 16;
            if (bx <= uint_<16>(0xffff) - find_par)
                cf = false;
        }
        else
        {
            find_par = 0;
            cf = false;
        }
    }

    if (cf == false)
    {
        ax = find_par;

        if (mem_limit < (bx + ax) * 16u)
            throw std::bad_alloc();

        bx -= 1;
        ax += 1;

        maps.insert(std::make_pair(ax * 16, bx * 16));
    }
    else
    {
        ax = 7;
        bx = 0; // Лень считать.
        throw std::exception();
    }
}

// +
void dos_mem_free()
{
    auto iter = maps.find(es.get_base());
    if (iter != maps.end())
    {
        cf = false;
        maps.erase(iter);
    }
    else
    {
        cf = true;
        ax = 9;
    }
}

// +
void dos_mem_resize()
{
    cf = true;

    auto iter = maps.find(es.get_base());
    if (iter == maps.end())
    {
        ax = 9;
        return;
    }

    auto next = iter;
    next++;

    uint_<16> next_par = 0xffff;
    if (next != maps.end())
        next_par = next -> first / 16;

    if (next_par * 16 - es.get_base() < bx * 16)
    {
        ax = 8;
        bx = 0; // Лень считать.
        throw std::exception();
        return;
    }

    if (mem_limit < bx * 16 + iter -> first)
        throw std::bad_alloc();

    cf = false;
    ax = es; /* Не обязятельно, но более реалистично. */
    iter -> second = bx * 16;
}


static bool handle_1_use = false;
static uint_<32> handle_1_size = 0;
static decltype(maps.begin()) handle_iter = maps.end();

// +
void xms_handler()
{
    switch(ah)
    {
    case 0x0:
        ax = 0x300;
        bx = 0x301;
        dx = 0;
        break;

    case 0x8:
        ax = 0x3b40;
        bl = 0x0;
        dx = ax;
        break;

    case 0x9: // allocate
    {
        if (handle_1_use)
            throw exo::exception::not_implemented();

        handle_1_use = true;
        handle_1_size = dx * 1024; // dx is size in kb
        dx = 1; // handle
        ax = 1; // success

        if (mem_limit < handle_1_size + 0x130000)
            throw std::bad_alloc();

        auto ret = maps.insert(std::make_pair(0x130000, handle_1_size));
        handle_iter = ret.first;
    }
        break;

    case 0xa: // free.
        if (handle_1_use && dx == 1)
        {
            maps.erase(handle_iter);
            handle_iter = maps.end();
            handle_1_use = false;
            handle_1_size = 0;
            ax = 1; // success
        }
        else
            throw exo::exception::not_implemented();

        break;

    case 0xc: // lock
        ax = 1; // success
        bx = 0; // addr
        dx = 0x13; // addr >> 16
        break;

    case 0xd: // unlock
        if (handle_1_use && dx == 1)
            ax = 1; // success
        else
            throw exo::exception::not_implemented();
        break;

    default:
        throw exo::exception::not_implemented();
        break;
    }

    retfw();
}


} /* namespace dos */
} /* namespace raw_program */
