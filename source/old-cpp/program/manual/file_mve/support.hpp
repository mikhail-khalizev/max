#ifndef SUPPORT_HPP_
#define SUPPORT_HPP_

#include <exo/exception.hpp>
#include "x86/instructions.hpp"


namespace raw_program {

using namespace x86;
using namespace dos;


static void mov_dyn(uint16_t op)
{
    switch (op)
    {
    case 0xc48a:
        mov(al, ah);                           /* mov al, ah */
        break;
    case 0xc38a:
        mov(al, bl);                           /* mov al, bl */
        break;
    case 0xc78a:
        mov(al, bh);                           /* mov al, bh */
        break;
    case 0xc18a:
        mov(al, cl);                           /* mov al, cl */
        break;
    case 0xc58a:
        mov(al, ch);                           /* mov al, ch */
        break;

    case 0xe08a:
        mov(ah, al);                           /* mov ah, al */
        break;
    case 0xe38a:
        mov(ah, bl);                           /* mov ah, bl */
        break;
    case 0xe78a:
        mov(ah, bh);                           /* mov ah, bh */
        break;
    case 0xe18a:
        mov(ah, cl);                           /* mov ah, cl */
        break;
    case 0xe58a:
        mov(ah, ch);                           /* mov ah, ch */
        break;

    case 0xd98a:
        mov(bl, cl);
        break;

    case 0xf98a:
        mov(bh, cl);
        break;

    case 0xd58a:
        mov(dl, ch);
        break;

    case 0xf18a:
        mov(dh, cl);
        break;

    case 0x0789:
        mov(memd_a32(ds, edi), eax);           /* mov [edi], eax */
        break;
    case 0xe88b:
        mov(ebp, eax);
        break;

    default:
        std::cerr << std::hex << op << std::endl;
        throw exo::exception::not_implemented();
        break;
    }
}

static void mov_dyn3(uint32_t op)
{
    op &= 0xffffff;

    switch (op)
    {
    case 0xc58b66:
        mov(ax, bp);
        break;
    case 0xc38b66:
        mov(ax, bx);
        break;
    case 0xc28b66:
        mov(ax, dx);
        break;
    case 0xc18b66:
        mov(ax, cx);
        break;

    case 0x044789:
        mov(memd_a32(ds, edi + 0x4), eax);     /* mov [edi+0x4], eax */
        break;
    case 0x24048b:
        mov(eax, memd_a32(ss, esp));           /* mov eax, [esp] */
        break;
    case 0x3a0489:
        mov(memd_a32(ds, edx + edi), eax);     /* mov [edx+edi], eax */
        break;

    default:
        std::cerr << std::hex << op << std::endl;
        throw exo::exception::not_implemented();
        break;
    }
}


#define clear(eip_, size)                                \
    for (int i = 0; i < size; i++)                        \
    {                                                    \
        code_curr    [eip_ - code_pc_start + i] = 0;    \
        code_template[eip_ - code_pc_start + i] = 0;    \
    }

#define __mov__(d, s)                                            \
    if (eip + 2 == eip_next)                                    \
        mov_dyn(mem_seg_pg_raw(cs, eip, 2).get<uint16_t>());    \
    else if (eip + 3 == eip_next)                                \
        mov_dyn3(mem_seg_pg_raw(cs, eip, 4).get<uint32_t>());    \
    else        \
        throw exo::exception::not_implemented()

#define __retd__()    \
    if (memcmp(code_template, code_curr, sizeof(code_curr)) != 0)        \
        throw std::logic_error("Функции не полностью эквивалентны.");    \
    retd()


} /* namespace raw_program */

#endif /* SUPPORT_HPP_ */
