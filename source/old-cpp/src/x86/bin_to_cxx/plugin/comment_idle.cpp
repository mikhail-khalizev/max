#include <type_traits>
#include <exo/exception.hpp>
#include <boost/polygon/interval_data.hpp>
#include "x86/bin_to_cxx/plugin_base.hpp"
#include "x86/bin_to_cxx/plugin/comment_idle.hpp"
#include "x86/bin_to_cxx/plugin/switch.hpp" // enum class reg_base

namespace raw_program {
namespace x86 {
namespace plugin {


#define REGS         \
REG(none, UD_NONE, 0, 0)    \
\
REG(al , UD_R_AL , 1, 1)    \
REG(ah , UD_R_AH , 1, 2)    \
REG(ax , UD_R_AX , 1, 3)    \
REG(eax, UD_R_EAX, 1, 0xf)    \
\
REG(bl , UD_R_BL , 2, 1)    \
REG(bh , UD_R_BH , 2, 2)    \
REG(bx , UD_R_BX , 2, 3)    \
REG(ebx, UD_R_EBX, 2, 0xf)    \
\
REG(cl , UD_R_CL , 3, 1)    \
REG(ch , UD_R_CH , 3, 2)    \
REG(cx , UD_R_CX , 3, 3)    \
REG(ecx, UD_R_ECX, 3, 0xf)    \
\
REG(dl , UD_R_DL , 4, 1)    \
REG(dh , UD_R_DH , 4, 2)    \
REG(dx , UD_R_DX , 4, 3)    \
REG(edx, UD_R_EDX, 4, 0xf)    \
\
REG(bpl, UD_R_BPL, 5, 1)    \
REG(bp , UD_R_BP , 5, 3)    \
REG(ebp, UD_R_EBP, 5, 0xf)    \
\
REG(spl, UD_R_SPL, 6, 1)    \
REG(sp , UD_R_SP , 6, 3)    \
REG(esp, UD_R_ESP, 6, 0xf)    \
\
REG(sil, UD_R_SIL, 7, 1)    \
REG(si , UD_R_SI , 7, 3)    \
REG(esi, UD_R_ESI, 7, 0xf)    \
\
REG(dil, UD_R_DIL, 8, 1)    \
REG(di , UD_R_DI , 8, 3)    \
REG(edi, UD_R_EDI, 8, 0xf)    \
\
REG(cs, UD_R_CS,  9, 3)    \
REG(ss, UD_R_SS, 10, 3)    \
REG(ds, UD_R_DS, 11, 3)    \
REG(es, UD_R_ES, 12, 3)    \
REG(gs, UD_R_GS, 13, 3)    \
REG(fs, UD_R_FS, 14, 3)    \
\
REG(cr0, UD_R_CR0, 15, 0xf)    \
REG(cr2, UD_R_CR2, 15, 0xf)    \
REG(cr3, UD_R_CR3, 15, 0xf)


enum class reg_base_v2 : uint32_t
{
#define REG(name, name_ud, mj, mn)   name = (mj << 16) + mn,
REGS
#undef REG
};

static reg_base_v2 convert_reg(enum ud_type base)
{
    switch(base)
    {
#define REG(name, name_ud, mj, mn)  case name_ud: return reg_base_v2:: name;
REGS
#undef REG

    default:
        throw exo::exception::not_implemented();
    }
}

static bool intersects(reg_base_v2 a, reg_base_v2 b)
{
    if (a == reg_base_v2::none || b == reg_base_v2::none)
        return false;

    typedef typename std::underlying_type<reg_base_v2>::type enum_type;
    enum_type ai = static_cast<enum_type>(a);
    enum_type bi = static_cast<enum_type>(b);

    if ((ai | 0xffff) != (bi | 0xffff))
        return false;

    if (((ai & 0xffff) & (bi & 0xffff)) != 0)
        return true;
    else
        return false;
}


comment_idle::comment_idle(bin_to_cxx & obj_)
: plugin_base(obj_)
{
    register_on_instruction_decoded( exo::util::delegate_unsafe<void (cmd_info &)>::create(this, &comment_idle::on_instruction_decoded) );
}

void comment_idle::on_instruction_decoded(cmd_info & cmd)
{
    if (cmd.mnemonic == UD_Inop)
        cmd.comment_this = true;
    else if (cmd.mnemonic == UD_Imov)
    {
        if (cmd.operand[0] == cmd.operand[1])
            cmd.comment_this = true;
        else if (cmd.operand[0].type == UD_OP_REG /* Поддерживаем запись только в регистр. Запись память не поддерживаем - это опасно - неизвестно будет ли всё-таки использоваться значение, записанное в память или нет. */
                    && (cmd.operand[1].type == UD_OP_REG || cmd.operand[1].type == UD_OP_MEM))
            cmd.write_cmd = decltype(cmd.write_cmd)::create(this, &comment_idle::on__cmd_mov_to_reg__write);
    }
    else if (cmd.mnemonic == UD_Ixchg)
    {
        if (cmd.operand[0] == cmd.operand[1])
            cmd.comment_this = true;
    }
}

void comment_idle::on__cmd_mov_to_reg__write(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> &)
{
    cmd_info & cmd_orig = * df.instr[cmd_index].first;

    if (df.instr[cmd_index].second == false) // Если мы не содержим метку.
    {
        reg_base_v2 change_reg = (cmd_orig.operand[0].type == UD_OP_REG) ?
                convert_reg(cmd_orig.operand[0].base) : reg_base_v2::none;

        reg_base_v2 deps_reg[3] = {
                convert_reg(cmd_orig.operand[1].base),
                convert_reg(cmd_orig.operand[1].index),
                convert_reg(cmd_orig.get_effective_segment_of_operand(1))
        };


        // Перебираем все предыдущие команды.
        for (size_t i = cmd_index - 1; i != static_cast<size_t>(-1) /* && i != cmd_index - 4 */; i--)
        {
            cmd_info & cmd_cur = * df.instr[i].first;

            if (cmd_cur.comment_this == false) // Смотрим команду только если она не закоментированна.
            {
                if (cmd_cur.mnemonic != UD_Imov) // Поддерживаем только операции mov.
                    break;


                if (cmd_cur.operand[0].type == UD_OP_REG)
                {
                    reg_base_v2 to = convert_reg(cmd_cur.operand[0].base);

                    if (intersects(to, deps_reg[0]) || intersects(to, deps_reg[1]) || intersects(to, deps_reg[2])) // Изменение регистра от которого мы зависим.
                    {
                        if ((cmd_cur.operand[1].type == UD_OP_REG)
                                && cmd_cur.operand[1] == cmd_orig.operand[0]
                                && cmd_cur.operand[0] == cmd_orig.operand[1])
                            cmd_orig.comment_this = true;

                        break;
                    }

                    if (intersects(to, change_reg)) // Изменение регистра, в который cmd_orig записывает.
                    {
                        if (cmd_cur.operand[1] == cmd_orig.operand[1])
                            cmd_orig.comment_this = true;

                        break;
                    }
                }
                else
                {
                    if (cmd_cur.operand[1] == cmd_orig.operand[0]
                            && cmd_cur.operand[0] == cmd_orig.operand[1])
                    {
                        cmd_orig.comment_this = true;
                        break;
                    }

                    if (cmd_orig.operand[1].type == UD_OP_MEM)
                    {
                        if (cmd_cur.operand[0].base == cmd_orig.operand[1].base
                                && cmd_cur.operand[0].index == cmd_orig.operand[1].index
                                && cmd_cur.operand[0].scale == cmd_orig.operand[1].scale
                                && cmd_cur.operand[0].offset == cmd_orig.operand[1].offset
                                && cmd_cur.operand[0].size != 0
                                && cmd_cur.operand[0].size == cmd_orig.operand[1].size
                                && cmd_cur.pfx_seg == cmd_orig.pfx_seg)
                        {
                            using namespace boost::polygon;
                            const interval_data<uint32_t> ic(cmd_cur.operand[0].lval.udword, cmd_cur.operand[0].lval.udword + cmd_cur.operand[0].size / 8);
                            const interval_data<uint32_t> io(cmd_orig.operand[1].lval.udword, cmd_orig.operand[1].lval.udword + cmd_orig.operand[1].size / 8);

                            if (intersects(ic, io, false))
                                break; // Запись в ту область памяти, из которой cmd_orig будет читать.
                        }
                        else
                            break; // Запись неизвестно куда.
                    }
                }
            }

            if (df.instr[i].second /* have_label */)
                break;
        }
    }

// @todo - Можно ещё просматривать вперёд - т.к. могут встретиться повторная запись в тот же регистр.
    cmd_orig.write_simple(os);
}


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */
