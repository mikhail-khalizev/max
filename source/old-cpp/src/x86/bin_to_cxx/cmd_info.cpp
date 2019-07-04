#include <exo/exception.hpp>

#include <boost/unordered_map.hpp>

#include "x86/bin_to_cxx.hpp"
#include "x86/bin_to_cxx/cmd_info.hpp"

//#include "/var/tmp/portage/dev-libs/udis86-1.7/work/udis86-1.7/libudis86/decode.h"
extern const char * ud_reg_tab[];


namespace raw_program {
namespace x86 {


cmd_info::cmd_info(addr_type begin_)
: begin(begin_)
, end(begin_)
, write_cmd()
, comments()
, comment_this(true)
, addr_mode()
, opr_mode()
, mnemonic(UD_Inone)
, operand()
, pfx_seg()
, br_far()
, pfx_rep()
, pfx_repne()
, pfx_lock()
, is_call()
, is_any_loop()
, is_any_jump()
, is_any_ret()
, is_jmp_or_ret()
{}

cmd_info::cmd_info(addr_type begin_, addr_type end_, std::string comment_)
: begin(begin_)
, end(end_)
, write_cmd()
, comments()
, comment_this(true)
, addr_mode()
, opr_mode()
, mnemonic(UD_Inone)
, operand()
, pfx_seg()
, br_far()
, pfx_rep()
, pfx_repne()
, pfx_lock()
, is_call()
, is_any_loop()
, is_any_jump()
, is_any_ret()
, is_jmp_or_ret()
{
    comments.push_back(comment_);
}

cmd_info::cmd_info(ud_t & ud_obj)
: begin(ud_obj.insn_offset)
, end(ud_obj.pc)
, write_cmd(write_cmd__default)
, comments()
, comment_this(false)
, addr_mode()
, opr_mode()
, mnemonic(ud_obj.mnemonic)
, operand()
, pfx_seg(ud_obj.pfx_seg)
, br_far(ud_obj.br_far)
, pfx_rep(ud_obj.pfx_rep)
, pfx_repne(ud_obj.pfx_repne)
, pfx_lock(ud_obj.pfx_lock)
, is_call(ud_obj.mnemonic == UD_Icall)
, is_any_loop(strncmp(ud_lookup_mnemonic(ud_obj.mnemonic), "loop", 4) == 0)
, is_any_jump(*ud_lookup_mnemonic(ud_obj.mnemonic) == 'j')
, is_any_ret(mnemonic == UD_Iret || mnemonic == UD_Iretf || mnemonic == UD_Iiretw || mnemonic == UD_Iiretd)
, is_jmp_or_ret(mnemonic == UD_Ijmp || is_any_ret)
{
    if (ud_obj.pfx_rex) // unknown ud_obj.pfx_insn ?
        throw exo::exception::not_implemented();

    for (int i = 0; i < 3; i++)
        operand[i] = ud_obj.operand[i];

    if ((is_any_jump || is_any_loop || is_call) && (operand[0].type == UD_OP_PTR))
        br_far = 1; /* Почему-то cам ud_obj не устанавливает его в 1, хотя это far jump. */

    if (ud_obj.pfx_adr)
        switch (ud_obj.dis_mode)
        {
        case 16:
            addr_mode = 32;
            break;
        case 32:
            addr_mode = 16;
            break;
        case 64:
            addr_mode = 32;
            break;
        default:
            throw exo::exception::not_implemented();
            break;
        }
    else
        addr_mode = ud_obj.dis_mode;

    if (ud_obj.pfx_opr)
        switch (ud_obj.dis_mode)
        {
        case 16:
            opr_mode = 32;
            break;
        case 32:
            opr_mode = 16;
            break;
        case 64:
            opr_mode = 32;
            break;
        default:
            throw exo::exception::not_implemented();
            break;
        }
    else
        opr_mode = ud_obj.dis_mode;

    bool add_asm_in_comment = true;
    if (ud_obj.mnemonic == UD_Iinvalid)
    {
        if (strcmp(ud_obj.insn_hexcode, "0f01e0") == 0)
        {
            mnemonic = UD_Ismsw;
            operand[0].type = UD_OP_REG;
            operand[0].base = UD_R_AX;
            add_asm_in_comment = false;
        }
        else if (strcmp(ud_obj.insn_hexcode, "0f01f0") == 0)
        {
            mnemonic = UD_Ilmsw;
            operand[0].type = UD_OP_REG;
            operand[0].base = UD_R_AX;
            add_asm_in_comment = false;
        }
        else if (strcmp(ud_obj.insn_hexcode, "d9e1") == 0)
        {
            mnemonic = UD_Ifabs;
            add_asm_in_comment = false;
        }
        else if (strcmp(ud_obj.insn_hexcode, "d9f0") == 0)
        {
            mnemonic = UD_If2xm1;
            add_asm_in_comment = false;
        }
    }

    if (add_asm_in_comment)
    {
        std::string instr = ud_obj.insn_buffer;

        // trim
        while (! instr.empty() && instr[instr.length() - 1] == ' ')
            instr.erase(instr.length() - 1);

        comments.push_back(instr);
    }
}

enum ud_type cmd_info::get_effective_segment_of_operand(uint8_t num) const
{
    if (pfx_seg)
        return static_cast<enum ud_type>(pfx_seg);
    else if (operand[num].base == UD_R_BP || operand[num].base == UD_R_SP
            || operand[num].base == UD_R_EBP || operand[num].base == UD_R_ESP)
        return UD_R_SS;
    else
        return UD_R_DS;
}

enum instr_flags : uint8_t
{
    none = 0,
    use_opr_size_inside = 1,
    use_adr_size_inside = 2
};

#define T instr_flags
#include <exo/util/flags.hpp>


struct instr
{
    enum ud_mnemonic_code mnemonic;
    instr_flags flags;
};

static instr known_instr[] = {
        {UD_Istosb, use_adr_size_inside},
        {UD_Istosw, use_adr_size_inside},
        {UD_Istosd, use_adr_size_inside},
        {UD_Iscasb, use_adr_size_inside},
        {UD_Iscasw, use_adr_size_inside},
        {UD_Iscasd, use_adr_size_inside},
        {UD_Ilodsb, use_adr_size_inside},
        {UD_Ilodsw, use_adr_size_inside},
        {UD_Ilodsd, use_adr_size_inside},
        {UD_Imovsb, use_adr_size_inside},
        {UD_Imovsw, use_adr_size_inside},
        {UD_Imovsd, use_adr_size_inside},
        {UD_Icmpsb, use_adr_size_inside},
        {UD_Icmpsw, use_adr_size_inside},
        {UD_Icmpsd, use_adr_size_inside},

        {UD_Ifninit, none},
        {UD_Ifnstsw, none},
        {UD_Ifnstcw, none},
        {UD_Ifnsave, use_opr_size_inside | use_adr_size_inside},
        {UD_Ifrstor, use_opr_size_inside | use_adr_size_inside},
        {UD_Iwait, none},
        {UD_Ifldcw, none},
        {UD_Ifld, none},
        {UD_Ifldz, none},
        {UD_Ifld1, none},
        {UD_Ifldlg2, none},
        {UD_Ifdivp, none},
        {UD_Ifdiv, none},
        {UD_Ifidivr, none},
        {UD_Ifmulp, none},
        {UD_Ifmul, none},
        {UD_Ifimul, none},
        {UD_Ifchs, none},
        {UD_Ifcom, none},
        {UD_Ifcom2, none},
        {UD_Ifcomp, none},
        {UD_Ifcompp, none},
        {UD_Ifxch, none},
        {UD_Ifsubp, none},
        {UD_Ifsub, none},
        {UD_Ifsubr, none},
        {UD_Ifild, none},
        {UD_Ifst, none},
        {UD_Ifstp, none},
        {UD_Ifist, none},
        {UD_Ifistp, none},
        {UD_Ifisttp, none},
        {UD_Iftst, none},
        {UD_Ifrndint, none},
        {UD_Ifprem, none},
        {UD_Ifdivr, none},
        {UD_Ifdivrp, none},
        {UD_Ifldln2, none},
        {UD_Ifyl2x, none},
        {UD_Ifldl2e, none},
        {UD_Ifadd, none},
        {UD_Ifaddp, none},
        {UD_Ifsqrt, none},
        {UD_Ifscale, none},
        {UD_Ifbstp, use_adr_size_inside},
        {UD_Ifisubr, none},
        {UD_Ifabs, none},
        {UD_If2xm1, none},


        {UD_Ipushfw, none},
        {UD_Ipushfd, none},
        {UD_Ipopfw, none},
        {UD_Ipopfd, none},
        {UD_Ipush, use_opr_size_inside},
        {UD_Ipop, use_opr_size_inside},
        {UD_Ipusha, none},
        {UD_Ipopa, none},
        {UD_Ipushad, none},
        {UD_Ipopad, none},

        {UD_Ijmp, use_opr_size_inside},
        {UD_Ijb, use_opr_size_inside},
        {UD_Ijz, use_opr_size_inside},
        {UD_Ijnz, use_opr_size_inside},
        {UD_Ijns, use_opr_size_inside},
        {UD_Ijae, use_opr_size_inside},
        {UD_Ijg, use_opr_size_inside},
        {UD_Ijs, use_opr_size_inside},
        {UD_Ijge, use_opr_size_inside},
        {UD_Ijl, use_opr_size_inside},
        {UD_Ija, use_opr_size_inside},
        {UD_Ijbe, use_opr_size_inside},
        {UD_Ijle, use_opr_size_inside},
        {UD_Ijno, use_opr_size_inside},
        {UD_Ijnp, use_opr_size_inside},
        {UD_Ijcxz, use_opr_size_inside},
        {UD_Ijecxz, use_opr_size_inside},
        {UD_Ijo, use_opr_size_inside},
        {UD_Ijp, use_opr_size_inside},

        {UD_Iloop, use_opr_size_inside | use_adr_size_inside},
        {UD_Iloope, use_opr_size_inside | use_adr_size_inside},
        {UD_Iloopnz, use_opr_size_inside | use_adr_size_inside},

        {UD_Iles, none},
        {UD_Ilds, none},
        {UD_Ilss, none},
        {UD_Ilgs, none},
        {UD_Ilfs, none},

        {UD_Imov, none},
        {UD_Iadd, none},
        {UD_Iadc, none},
        {UD_Icmp, none},
        {UD_Isub, none},
        {UD_Isbb, none},
        {UD_Isar, none},
        {UD_Ishl, none},
        {UD_Ishr, none},
        {UD_Ishrd, none},
        {UD_Ishld, none},
        {UD_Ircl, none},
        {UD_Ircr, none},
        {UD_Iror, none},
        {UD_Irol, none},
        {UD_Iinc, none},
        {UD_Idec, none},
        {UD_Ineg, none},
        {UD_Inot, none},
        {UD_Iint, none},
        {UD_Iinto, none},
        {UD_Iint1, none},
        {UD_Iint3, none},
        {UD_Icld, none},
        {UD_Iand, none},
        {UD_Ior, none},
        {UD_Ixor, none},
        {UD_Itest, none},
        {UD_Icall, use_opr_size_inside},
        {UD_Iret, use_opr_size_inside},
        {UD_Iretf, use_opr_size_inside},
        {UD_Iiretw, none},
        {UD_Iiretd, none},
        {UD_Iiretq, none},
        {UD_Icwd, none},
        {UD_Icbw, none},
        {UD_Istd, none},
        {UD_Ixchg, none},
        {UD_Ilea, none},
        {UD_Iinvalid, none},
        {UD_Ismsw, none},
        {UD_Ilmsw, none},
        {UD_Ienter, use_opr_size_inside},
        {UD_Ileave, use_opr_size_inside},
        {UD_Ibt, none},
        {UD_Ibtc, none},
        {UD_Icpuid, none},

        {UD_Iseta, none},
        {UD_Isetg, none},
        {UD_Isetnb, none},
        {UD_Isetz, none},
        {UD_Isetnz, none},
        {UD_Isetbe, none},
        {UD_Isetge, none},
        {UD_Isetl, none},
        {UD_Isetle, none},

        {UD_Imul, none},
        {UD_Iimul, none},
        {UD_Idiv, none},
        {UD_Iidiv, none},
        {UD_Icli, none},
        {UD_Isti, none},
        {UD_Icmc, none},
        {UD_Imovzx, none},
        {UD_Iclts, none},
        {UD_Illdt, none},
        {UD_Isldt, none},
        {UD_Ilgdt, use_opr_size_inside | use_adr_size_inside},
        {UD_Ilidt, use_opr_size_inside | use_adr_size_inside},
        {UD_Isidt, use_opr_size_inside | use_adr_size_inside},
        {UD_Iltr, none},
        {UD_Ilar, none},
        {UD_Iclc, none},
        {UD_Istc, none},
        {UD_Ibtr, none},
        {UD_Istr, none},
        {UD_Ilsl, none},
        {UD_Ixlatb, use_adr_size_inside},

        {UD_Iin, use_opr_size_inside},
        {UD_Iout, use_opr_size_inside},
        {UD_Iinsb, use_adr_size_inside},
        {UD_Iinsw, use_adr_size_inside},
        {UD_Iinsd, use_adr_size_inside},
        {UD_Ioutsb, use_adr_size_inside},
        {UD_Ioutsw, use_adr_size_inside},
        {UD_Ioutsd, use_adr_size_inside},

        {UD_Isahf, none},
        {UD_Imovsx, none},
        {UD_Icwde, none},
        {UD_Icdq, none},
        {UD_Inop, none},

        {UD_Iaaa, none},
        {UD_Iaad, none},
        {UD_Iaam, none},
        {UD_Iaas, none},
        {UD_Idaa, none},
        {UD_Idas, none},
        {UD_Iarpl, none},
        {UD_Ibound, use_adr_size_inside},
        {UD_Ihlt, none},
        {UD_Ibsr, none},
        {UD_Iverr, none},
        {UD_Ilahf, none},
        {UD_Isalc, none},

//        {UD_Isysenter, none},
//        {UD_Imovups, none},
};

static std::pair<bool, enum instr_flags> get_meta(enum ud_mnemonic_code    mnemonic)
{
    // @todo use initialiser_list ?
    static boost::unordered_map<enum ud_mnemonic_code, enum instr_flags> instr_map;

    if (instr_map.empty())
        for (auto & iter : known_instr) // init
            instr_map.insert(std::make_pair(iter.mnemonic, iter.flags));


    auto iter = instr_map.find(mnemonic);
    if (iter == instr_map.end())
        return std::pair<bool, enum instr_flags>(false, none);

    return std::pair<bool, enum instr_flags>(true, iter -> second);
}


void cmd_info::write_cmd__default(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> &)
{
    df.instr[cmd_index].first -> write_simple(os, std::string(), std::string());
}

void cmd_info::write_simple(std::ostream & os, std::string cmd_suffix, std::string func_add_arg) const
{
    auto meta = get_meta(mnemonic);
    if (meta.first == false)
    {
        std::ostringstream err;
        err << std::hex << std::showbase << "Unknown instruction at ";
        write_addr(err, begin);
        err << ':';
        for (auto s : comments)
            err << " '" << s << '\'';
        err << '.';
        throw std::logic_error(err.str());
    }


    os << std::hex << std::showbase;


    const char * adr_mode_str;
    switch (addr_mode)
    {
    case 16: adr_mode_str = "_a16"; break;
    case 32: adr_mode_str = "_a32"; break;
    case 64: adr_mode_str = "_a64"; break;
    default:
        throw exo::exception::not_implemented();
        break;
    }

    uint8_t eff_opr_size = opr_mode;

    if (mnemonic == UD_Iout)
        if (UD_R_AL <= operand[1].base && operand[1].base <= UD_R_BH)
            eff_opr_size = 8;

    if (       mnemonic == UD_Iin
            || mnemonic == UD_Iimul
            || mnemonic == UD_Imul)
            if (UD_R_AL <= operand[0].base && operand[0].base <= UD_R_BH)
                eff_opr_size = 8;

//    bool aso_affected = P_ASO(ud_obj.itab_entry -> prefix);
//    bool oso_affected = P_OSO(ud_obj.itab_entry -> prefix);


    if (pfx_repne)
        os << "repne" << adr_mode_str << " ";
    else if (pfx_rep)
    {
        if (strncmp(ud_lookup_mnemonic(mnemonic), "cmps", 4) == 0 ||
                strncmp(ud_lookup_mnemonic(mnemonic), "scas", 4) == 0)
            os << "repe";
        else
            os << "rep";
        os << adr_mode_str << " ";
    }

    os << ud_lookup_mnemonic(mnemonic);
    if (       mnemonic == UD_Iint
            || mnemonic == UD_Iand
            || mnemonic == UD_Ior
            || mnemonic == UD_Ixor
            || mnemonic == UD_Istd
            || mnemonic == UD_Inot)
        os << '_'; // Чтоб не конфликтовать с различными ключевыми словами C++ и студии разработки.

    if ((meta.second & use_opr_size_inside) != 0)
    {
        if (eff_opr_size == 8)
            os << 'b';
        else if (eff_opr_size == 16)
            os << 'w';
        else if (eff_opr_size == 32)
            os << 'd';
        else if (eff_opr_size != 0)
            throw std::exception();
    }

    if ((meta.second & use_adr_size_inside) != 0 ||
            ((mnemonic == UD_Icall || mnemonic == UD_Ijmp) && br_far && operand[0].type == UD_OP_MEM))
        os << adr_mode_str;

    if (br_far)
        os << "_far";

    bool need_write_namespace = is_call;
    if (is_any_jump || is_any_loop || is_call)
    {
        if (operand[0].type == UD_OP_PTR)
        {
            os << "_abs";
            need_write_namespace = true;
        }
        else if ((operand[0].type == UD_OP_MEM) || (operand[0].type == UD_OP_REG))
        {
            if (br_far)
                os << "_ind"; // indirect
            else
                os << "_abs";
            need_write_namespace = true;
        }
    }
    else
        need_write_namespace = true;

    if (pfx_lock)
        os << "_lock";

    os << cmd_suffix << '(';


    bool non_first_arg = false;
    bool use_pfx_seg = false; // Использется ли где-то в операндах сегмент?

    for (int i = 0; i < 3; i++)
    {
        struct ud_operand const & op = operand[i];

        if (op.type == UD_NONE)
            break;

        if (non_first_arg)
            os << ", ";
        non_first_arg = true;

        uint8_t opr_size = op.size;
        if (opr_size == 0)
            opr_size = eff_opr_size;

        switch (op.type)
        {
        case UD_NONE:
            break;

        case UD_OP_REG:
            if (UD_R_ST0 <= op.base && op.base <= UD_R_ST7)
                os << (op.base - UD_R_ST0) << " /* " <<  ud_reg_tab[op.base - UD_R_AL] << " */";
            else
                os << ud_reg_tab[op.base - UD_R_AL];
            break;

        case UD_OP_MEM:
        {
            bool mem_inside = /* Обращение к памяти происходит внутри инструкции. */
                    mnemonic == UD_Ilds ||
                    mnemonic == UD_Iles ||
                    mnemonic == UD_Ilss ||
                    mnemonic == UD_Ilgs ||
                    mnemonic == UD_Ilfs ||
                    mnemonic == UD_Ilea ||
                    mnemonic == UD_Ilgdt ||
                    mnemonic == UD_Ilidt ||
                    mnemonic == UD_Isidt ||
                    mnemonic == UD_Ifnsave ||
                    mnemonic == UD_Ifrstor ||
                    mnemonic == UD_Ifbstp ||
                    (mnemonic == UD_Icall && br_far) ||
                    (mnemonic == UD_Ijmp && br_far) ||
                    mnemonic == UD_Ibound;

            if (mem_inside == false)
            {
                if (opr_size == 8)
                    os << "memb";
                else if (opr_size == 16)
                    os << "memw";
                else if (opr_size == 32)
                    os << "memd";
                else if (opr_size == 64)
                    os << "memq";
                else if (opr_size == 80)
                    os << "memt";
                else
                    throw exo::exception::not_implemented();
                os << adr_mode_str << '(';
            }


            if (mnemonic != UD_Ilea /* Эта инструкция не использует сегмент. */)
            {
                os << ud_reg_tab[get_effective_segment_of_operand(i) - UD_R_AL];
                os << ", ";

                if (pfx_seg)
                    use_pfx_seg = true;
            }

            bool op_f = false; // Cтоит ли писать '+' (т.е. 'не первое слагаемое').
            if (op.base != UD_NONE)
            {
                os << ud_reg_tab[op.base - UD_R_AL];
                op_f = true;
            }

            if (op.index != UD_NONE)
            {
                if (op_f)
                    os << " + ";
                op_f = true;

                os << ud_reg_tab[op.index - UD_R_AL];
            }

            if (1 < op.scale)
            {
                if (!op.index)
                    throw exo::exception::not_implemented();

                os << " * " << static_cast<uint16_t>(op.scale);
            }

            if (op.offset != 0)
            {
                int32_t val;
                switch (op.offset)
                {
                case 8: val = op.lval.sbyte; break;
                case 16: val = op.lval.sword; break;
                case 32: val = op.lval.sdword; break;
                default:
                    throw exo::exception::not_implemented();
                    break;
                }

                if (val < 0)
                    os << ((op_f) ? " - " : "-") << - val;
                else
                {
                    os << ((op_f) ? " + " : "");
                    write_addr_with_check_known_definitions(os, val, false, need_write_namespace);
                }
                op_f = true;
            }

            if (mem_inside == false)
                os << ')';
            break;
        }

        case UD_OP_IMM:
            switch (opr_size)
            {
            case 8:
            {
                bool need_sign_extend =
                        mnemonic == UD_Iimul ||
                        mnemonic == UD_Ipush ||
                        mnemonic == UD_Iadc ||
                        mnemonic == UD_Iadd ||
                        mnemonic == UD_Isbb ||
                        mnemonic == UD_Isub ||
                        mnemonic == UD_Icmp;

                if ((UD_R_AL <= operand[0].base && operand[0].base <= UD_R_BH) == false) /* Работа не с 8-байтой инструкцией. */
                    need_sign_extend = need_sign_extend ||
                            mnemonic == UD_Iand ||
                            mnemonic == UD_Ior ||
                            mnemonic == UD_Ixor;

                int16_t val = op.lval.sbyte;

                if (val < 0 && need_sign_extend)
                    os << '-' << -val << " /* " << static_cast<uint16_t>(op.lval.ubyte) << " */";
                else
                    os << static_cast<uint16_t>(op.lval.ubyte);
                break;
            }
            case 16:
                write_addr_with_check_known_definitions(os, op.lval.uword, false, need_write_namespace);
                break;
            case 32:
                write_addr_with_check_known_definitions(os, op.lval.udword, false, need_write_namespace);
                break;
            default:
                throw exo::exception::not_implemented();
                break;
            }
            break;

        case UD_OP_JIMM:
            int32_t val;
            switch (opr_size)
            {
            case 8: val = op.lval.sbyte; break;
            case 16: val = op.lval.sword; break;
            case 32: val = op.lval.sdword; break;
            default:
                throw exo::exception::not_implemented();
                break;
            }

            write_addr_with_check_known_definitions(os, end + val, true, need_write_namespace);
            os << ", ";

            if (val < 0)
                os << '-' << - val;
            else
                os << val;

            break;

        case UD_OP_CONST:
            write_addr_with_check_known_definitions(os, op.lval.udword, false, need_write_namespace);
            break;

        case UD_OP_PTR:
            os << op.lval.ptr.seg << ", " << op.lval.ptr.off;
            break;

        default:
            throw exo::exception::not_implemented();
            break;
        }
    }

    if (use_pfx_seg == false && pfx_seg
            && mnemonic != UD_Imov
            && mnemonic != UD_Ilea)
    {
        // к примеру movsb(es)

        if (non_first_arg)
            os << ", ";
        non_first_arg = true;

        os << ud_reg_tab[pfx_seg - UD_R_AL];
    }

    if (func_add_arg.size() != 0)
    {
        if (non_first_arg)
            os << ", ";
        non_first_arg = true;

        os << func_add_arg;
    }

    os << ");";
}


} /* namespace x86 */
} /* namespace raw_program */
