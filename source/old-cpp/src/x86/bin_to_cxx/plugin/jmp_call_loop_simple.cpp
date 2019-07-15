#include <sstream>
#include <exo/exception.hpp>
#include "x86/bin_to_cxx.hpp" // write_addr_with_check_known_definitions
#include "x86/bin_to_cxx/plugin_base.hpp"
#include "x86/bin_to_cxx/plugin/jmp_call_loop_simple.hpp"

namespace raw_program {
namespace x86 {
namespace plugin {


/** jmp call loop relative or
  * calld_abs(memd_a32(ds, 0x101be1c8)) */

jmp_call_loop_simple::jmp_call_loop_simple(bin_to_cxx & obj_)
: plugin_base(obj_)
{
    register_on_instruction_decoded( exo::util::delegate_unsafe<void (cmd_info &)>::create(this, &jmp_call_loop_simple::on_instruction_decoded) );
}

// +
void jmp_call_loop_simple::on_instruction_decoded(cmd_info & cmd)
{
    struct ud_operand & op = cmd.operand[0];
    addr_type to_addr;

    if ((cmd.is_any_jump || cmd.is_any_loop || cmd.is_call)
            && (op.type == UD_OP_JIMM))
    {
        switch (op.size)
        {
        case 8: op.lval.sqword = op.lval.sbyte; break;
        case 16: op.lval.sqword = op.lval.sword; break;
        case 32: op.lval.sqword = op.lval.sdword; break;
        default:
            throw exo::exception::not_implemented();
            break;
        }

        to_addr = static_cast<addr_type>(cmd.end + op.lval.sqword);
    }
    else if ((cmd.is_call || cmd.mnemonic == UD_Ijmp)
            && cmd.br_far == false
            && op.type == UD_OP_MEM
            && op.base == UD_NONE
            && op.index == UD_NONE
            && op.offset != 0)
    {
        addr_type where;
        switch (op.offset)
        {
        case 8: where = op.lval.sbyte; break;
        case 16: where = op.lval.sword; break;
        case 32: where = op.lval.sdword; break;
        default:
            throw exo::exception::not_implemented();
            break;
        }


        switch (cmd.get_effective_segment_of_operand(0))
        {
        case UD_R_CS:
            where += cs_base();
            break;
        case UD_R_DS:
            where += ds_base();
            break;
        case UD_R_SS:
            return;

        default:
            throw exo::exception::not_implemented();
            break;
        }


        switch (op.size)
        {
        case 16:
            to_addr = mem(where, 2).get<uint16_t>();
            break;
        case 32:
            to_addr = mem(where, 4).get<uint32_t>();
            break;

        default:
            throw exo::exception::not_implemented();
            break;
        }

        to_addr += cs_base();


        if (to_addr == 0)
            return;


        std::ostringstream os;
        os << std::hex << std::showbase;
        os << "Вызов '";
        write_addr_with_check_known_definitions(os, to_addr, true, false /* лучше true, но комментарий в комментарие.. */);
        os << "'.";
        cmd.comments.push_back(os.str());
    }
    else
        return;


    addr_type _eip = to_addr - cs_base();
    if (mode() == 16)
        _eip &= 0xffff;
    to_addr = cs_base() + _eip;


    bool not_suppressed = ! suppress_decode().contains(to_addr, false);

    if (not_suppressed)
        addr_to_decode().insert(to_addr);

    if (cmd.is_call || op.type != UD_OP_JIMM)
    {
        if (not_suppressed)
            new_detected_funcs().insert(detected_func(to_addr)); // create if not exist.
    }
    else
    {
        jmp_to_known_addr()[cmd.begin].to.insert(to_addr);
        cmd.write_cmd = decltype(cmd.write_cmd)::create(this, &jmp_call_loop_simple::on_cmd_write);
    }
}

// +
void jmp_call_loop_simple::on_cmd_write(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> & comments_in_current_func)
{
    auto cur_jmp = jmp_to_known_addr().find(df.instr[cmd_index].first -> begin);
    if (cur_jmp == jmp_to_known_addr().end())
        throw exo::exception::logic_error();

    if (cur_jmp -> second.to.size() != 1)
        throw exo::exception::logic_error();

    addr_type to = *(cur_jmp -> second.to.begin());

    std::string func_suffix;
    if (df.labels.find(to) == df.labels.end())
    {
        func_suffix =  "_func";

        //if (df.begin <= to && to < df.end)  // внутренняя ошибка компилятора: в push_access_scope, в cp/pt.c:219
        if (df.begin.get() <= to.get() && to.get() < df.end.get())
            comments_in_current_func.push_back("Адрес перехода делит инструкцию в этой функции пополам.");
    }

    df.instr[cmd_index].first -> write_simple(os, func_suffix);
}


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */
