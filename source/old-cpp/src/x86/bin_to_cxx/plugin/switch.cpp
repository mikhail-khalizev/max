#include <iomanip>
#include <sstream>
#include <algorithm>

#include <exo/exception.hpp>
#include <exo/memory_space.hpp>

#include "x86/memory.hpp"
#include "x86/bin_to_cxx.hpp" // write_addr
#include "x86/bin_to_cxx/plugin_base.hpp"
#include "x86/bin_to_cxx/plugin/switch.hpp"


using namespace exo;


namespace raw_program {
namespace x86 {
namespace plugin {


static reg_base get_reg_base(enum ud_type base)
{
    if (base == UD_R_AL
            || base == UD_R_AX
            || base == UD_R_EAX)
        return reg_base::a;

    if (base == UD_R_BL
            || base == UD_R_BX
            || base == UD_R_EBX)
        return reg_base::b;

    if (base == UD_R_CL
            || base == UD_R_CX
            || base == UD_R_ECX)
        return reg_base::c;

    if (base == UD_R_DL
            || base == UD_R_DX
            || base == UD_R_EDX)
        return reg_base::d;

    return reg_base::none;
}

static uint8_t get_reg_base_size(enum ud_type base)
{
    if (base == UD_R_EAX
            || base == UD_R_EBX
            || base == UD_R_ECX
            || base == UD_R_EDX)
        return 32;

    if (base == UD_R_AX
            || base == UD_R_BX
            || base == UD_R_CX
            || base == UD_R_DX)
        return 16;

    if (base == UD_R_AL
            || base == UD_R_BL
            || base == UD_R_CL
            || base == UD_R_DL)
        return 8;

    throw exo::exception::not_implemented();
}


switch_::switch_(bin_to_cxx & obj_)
: plugin_base(obj_)
, state(0)
, op()
, size_of_addr_area()
, reg(reg_base::none)
{
    register_on_instruction_decoded( exo::util::delegate_unsafe<void (cmd_info &)>::create(this, &switch_::on_instruction_decoded) );
}

// +
void switch_::add_switch_at(cmd_info & cmd)
{
    if (cmd.br_far)
        return;

    addr_type addr_of_addrs = cs_base() + cmd.operand[0].lval.udword;

    if ((addr_of_addrs & (mode() / 8 - 1)) == 0)
        aligment()[addr_of_addrs] = mode() / 8;

    std::ostringstream os;
    os << std::hex << std::showbase;
    os << "Служебная область с абсолютными адресами переходов. {";

    auto iter_jmp = jmp_to_known_addr().insert(std::make_pair(cmd.begin, jtka()));
    bool not_first = false;
    for (addr_type i = 0; i < size_of_addr_area; i += (mode() / 8))
    {
        addr_type to;
        switch(mode())
        {
            case 16:
                to = mem_pg_raw(addr_of_addrs + i, 2).get<uint16_t>();
                break;
            case 32:
                to = mem_pg_raw(addr_of_addrs + i, 4).get<uint32_t>();
                break;
            default:
                throw exo::exception::not_implemented();
        }

        to += cs_base();

        if (not_first)
             os << ", ";
        not_first = true;
        write_addr(os, to);

        iter_jmp.first -> second.to.insert(to);
        addr_to_decode().insert(to);
    }

    os << "}.";

    code().insert(cmd_info(addr_of_addrs, addr_of_addrs + size_of_addr_area, os.str()));

    cmd.write_cmd = decltype(cmd.write_cmd)::create(this, &switch_::on_cmd_write);
}

// +
void switch_::on_instruction_decoded(cmd_info & cmd)
{
#if 0
    /* Pattern for: */

    II(0x10122c34, 0x4)   cmp(memb_a32(ss, ebp - 0x3c), 0x4);   /* cmp byte [ebp-0x3c], 0x4 */
2    II(0x10122c38, 0x2)   jad(0x10122c14, -0x26);               /* ja 0x10122c14 */
    II(0x10122c3a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10122c3c, 0x3)   mov(al, memb_a32(ss, ebp - 0x3c));    /* mov al, [ebp-0x3c] */
    II(0x10122c3f, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6    II(0x10122c42, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x10122c18)); /* jmp dword near [cs:eax+0x10122c18] */

    II(0x10070886, 0x5)   cmp(memw_a32(ss, ebp - 0x2c), 0x3);   /* cmp word [ebp-0x2c], 0x3 */
2    II(0x1007088b, 0x2)   jad_func(0x1007086c, -0x21);          /* ja 0x1007086c */
    II(0x1007088d, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1007088f, 0x4)   mov(ax, memw_a32(ss, ebp - 0x2c));    /* mov ax, [ebp-0x2c] */
    II(0x10070893, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6    II(0x10070896, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x10070870)); /* jmp dword near [cs:eax+0x10070870] */

    II(0x1010fc44, 0x4)   cmp(memd_a32(ss, ebp - 0xc), 0x6);    /* cmp dword [ebp-0xc], 0x6 */
2    II(0x1010fc48, 0x2)   jad(0x1010fc24, -0x26);               /* ja 0x1010fc24 */
    II(0x1010fc4a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1010fc4d, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
6    II(0x1010fc50, 0x7)   jmpd_abs(memd_a32(cs, eax + 0x1010fc28)); /* jmp dword near [cs:eax+0x1010fc28] */


    II(0x10172cc4, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
7    II(0x10172cc7, 0x2)   jad(0x10172d26, 0x5d);                /* ja 0x10172d26 */
8    II(0x10172cc9, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x10172ca4)); /* jmp dword near [cs:eax*4+0x10172ca4] */

    II(0x10196425, 0x2)   cmp(al, 0x3);                         /* cmp al, 0x3 */
7    II(0x10196427, 0x6)   jad(0x101964bc, 0x8f);                /* ja dword 0x101964bc */
8    II(0x1019642d, 0x3)   movzx(eax, al);                       /* movzx eax, al */
    II(0x10196430, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x10196408)); /* jmp dword near [cs:eax*4+0x10196408] */

    II(0x10196098, 0x3)   cmp(cl, 0x8);                         /* cmp cl, 0x8 */
7    II(0x1019609b, 0x2)   jad_func(0x10196078, -0x25);          /* ja 0x10196078 */
8    II(0x1019609d, 0x3)   movzx(ecx, cl);                       /* movzx ecx, cl */
    II(0x101960a0, 0x3)   shl(ecx, 0x2);                        /* shl ecx, 0x2 */
6    II(0x101960a3, 0x7)   jmpd_abs(memd_a32(cs, ecx + 0x10195f48)); /* jmp dword near [cs:ecx+0x10195f48] */


      II(0x1017bab3, 0x3)   mov(ah, memb_a32(ss, ebp - 0xe));     /* mov ah, [ebp-0xe] */
      II(0x1017bab6, 0x3)   mov(memd_a32(ss, ebp - 0xc), esi);    /* mov [ebp-0xc], esi */
    II(0x1017bab9, 0x3)   cmp(ah, 0x11);                        /* cmp ah, 0x11 */
7    II(0x1017babc, 0x2)   jad(0x1017ba97, -0x27);               /* ja 0x1017ba97 */
8    II(0x1017babe, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1017bac0, 0x3)   mov(al, memb_a32(ss, ebp - 0xe));     /* mov al, [ebp-0xe] */
    II(0x1017bac3, 0x8)   jmpd_abs(memd_a32(cs, eax * 0x4 + 0x1017b9e8)); /* jmp dword near [cs:eax*4+0x1017b9e8] */


    II(0x0015bae0, 0x3)   cmp(ax, 0x8);                         /* cmp ax, 0x8 */
7    II(0x0015bae3, 0x2)   jaw_func(0x0015bad9, -0xc);           /* ja 0x15bad9 */
8    II(0x0015bae5, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
11    II(0x0015bae7, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
6    II(0x0015bae8, 0x5)   jmpw_abs(memw_a16(cs, bx + 0x66cd));  /* jmp word near [cs:bx+0x66cd] */

    II(0x001577d5, 0x3)   cmp(ax, 0x18);                        /* cmp ax, 0x18 */
7    II(0x001577d8, 0x2)   jbew(0x001577dd, 0x3);                /* jbe 0x1577dd */
12    II(0x001577da, 0x3)   jmpw_func(0x00157817, 0x3a);          /* jmp 0x157817 */
l_0x001577dd:
8    II(0x001577dd, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x001577df, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
    II(0x001577e0, 0x5)   jmpw_abs(memw_a16(cs, bx + 0x23c5));  /* jmp word near [cs:bx+0x23c5] */
#endif


    switch (state)
    {
    case 2:
        if (cmd.mnemonic == UD_Ija)
            state++;
        else
            state = 0;
        break;

    case 3:
        if (cmd.mnemonic == UD_Ixor
                && cmd.operand[0].type == UD_OP_REG
                && cmd.operand[1].type == UD_OP_REG
                && cmd.operand[0].base == cmd.operand[1].base)
        {
            reg = get_reg_base(cmd.operand[1].base);
            if (reg != reg_base::none)
                state++;
        }
        else if (cmd.mnemonic == UD_Imov
                && cmd.operand[0].type == UD_OP_REG)
        {
            reg = get_reg_base(cmd.operand[0].base);
            if (reg != reg_base::none
                    && get_reg_base_size(cmd.operand[0].base) == 32
                    && cmd.operand[1] == op)
                state = 5;
        }

        if (state == 3)
            state = 0;

        break;

    case 4:
        if (cmd.mnemonic == UD_Imov
                && cmd.operand[0].type == UD_OP_REG
                && get_reg_base(cmd.operand[0].base) == reg
                && cmd.operand[1] == op)
            state++;
        else
            state = 0;
        break;

    case 5:
        if (cmd.mnemonic == UD_Ishl
                && cmd.operand[0].type == UD_OP_REG
                && get_reg_base(cmd.operand[0].base) == reg
                && (cmd.operand[1].type == UD_OP_IMM)
                && cmd.operand[1].lval.uqword == mode() / 16)
            state++;
        else
            state = 0;
        break;

    case 6:
        if (cmd.mnemonic == UD_Ijmp
                && cmd.operand[0].type == UD_OP_MEM
                && get_reg_base(cmd.operand[0].base) == reg)
            add_switch_at(cmd);

        state = 0;
        break;


    case 7:
        if (cmd.mnemonic == UD_Ija)
            state++;
        else if (cmd.mnemonic == UD_Ijbe)
            state = 12;
        else
            state = 0;
        break;

    case 8:
        if (cmd.mnemonic == UD_Ijmp
                && cmd.operand[0].type == UD_OP_MEM
//                && get_reg_base(cmd.operand[0].index) == reg
                && cmd.operand[0].scale == 4)
        {
            add_switch_at(cmd);
            state = 0;
        }
        else if (cmd.mnemonic == UD_Imovzx
                && cmd.operand[0].type == UD_OP_REG
                && cmd.operand[1].type == UD_OP_REG
//                && get_reg_base(cmd.operand[0].base) == reg
//                && get_reg_base(cmd.operand[1].base) == reg
                )
        {
            state++;
        }
        else if (cmd.mnemonic == UD_Ixor
                && cmd.operand[0].type == UD_OP_REG
                && cmd.operand[1].type == UD_OP_REG
                && cmd.operand[0].base == cmd.operand[1].base
//                && get_reg_base(cmd.operand[0].base) == reg
                )
        {
            state = 10;
        }
        else if (cmd.mnemonic == UD_Ishl
                && cmd.operand[0].type == UD_OP_REG
                && get_reg_base(cmd.operand[0].base) == reg
                && (cmd.operand[1].type == UD_OP_CONST)
                && cmd.operand[1].lval.uqword == mode() / 16)
        {
            state = 11;
        }
        else
            state = 0;

        break;

    case 9:
        if (cmd.mnemonic == UD_Ijmp
                && cmd.operand[0].type == UD_OP_MEM
//                && get_reg_base(cmd.operand[0].index) == reg
                && cmd.operand[0].scale == 4)
        {
            add_switch_at(cmd);
            state = 0;
        } else if (cmd.mnemonic == UD_Ishl
                && cmd.operand[0].type == UD_OP_REG
//                && get_reg_base(cmd.operand[0].base) == reg
                && (cmd.operand[1].type == UD_OP_IMM)
                && cmd.operand[1].lval.uqword == mode() / 16)
            state = 6;
        else
            state = 0;
        break;

    case 10:
        if (cmd.mnemonic == UD_Imov
                && cmd.operand[0].type == UD_OP_REG
//                && get_reg_base(cmd.operand[0].base) == reg
                )
            state = 9;
        else
            state = 0;
        break;

    case 11:
        if (cmd.mnemonic == UD_Ixchg
                && get_reg_base(cmd.operand[1].base) == reg)
        {
            reg = get_reg_base(cmd.operand[0].base);
            state = 6;
        }
        else
            state = 0;
        break;

    case 12:
        if (cmd.mnemonic == UD_Ijmp)
            state = 8;
        else
            state = 0;
        break;

    default:
        state = 0;
        break;
    }


    if (state == 0
            && cmd.mnemonic == UD_Icmp
            && cmd.operand[1].type == UD_OP_IMM
            && cmd.operand[1].size <= 16)
    {
        size_of_addr_area = (cmd.operand[1].lval.uword + 1) * (mode() / 8);

        if (cmd.operand[0].type == UD_OP_MEM)
        {
            op = cmd.operand[0]; // memb_a32(ss, ebp - 0x3c)
            state = 2;
        }
        else if (cmd.operand[0].type == UD_OP_REG)
        {
            reg = get_reg_base(cmd.operand[0].base);
            state = 7;
        }
    }
}

// +
void switch_::on_cmd_write(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> &)
{
    auto cur_jmp = jmp_to_known_addr().find(df.instr[cmd_index].first -> begin);
    if (cur_jmp == jmp_to_known_addr().end())
        throw exo::exception::logic_error();

    std::ostringstream func_add_arg;

    for (addr_type to : cur_jmp -> second.to)
        if (df.labels.find(to) != df.labels.end())
        {
            func_add_arg << '(';
            write_addr(func_add_arg, to);
            func_add_arg << ')';
        }

    std::string func_suffix;
    if (func_add_arg.str().size() != 0)
        func_suffix =  "_switch";

    df.instr[cmd_index].first -> write_simple(os, func_suffix, func_add_arg.str());
}


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */
