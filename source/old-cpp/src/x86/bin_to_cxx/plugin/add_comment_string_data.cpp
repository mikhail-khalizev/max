#include <sstream>
#include <exo/memory_space.hpp>
#include "x86/bin_to_cxx/plugin_base.hpp"
#include "x86/bin_to_cxx/plugin/add_comment_string_data.hpp"

namespace raw_program {
namespace x86 {
namespace plugin {


add_comment_string_data::add_comment_string_data(bin_to_cxx & obj_)
: plugin_base(obj_)
, string_data_area_begin(0)
, string_data_area_end(0)
{
    register_on_instruction_decoded( exo::util::delegate_unsafe<void (cmd_info &)>::create(this, &add_comment_string_data::on_instruction_decoded) );
}

// +
void add_comment_string_data::on_instruction_decoded(cmd_info & cmd)
{
    for (int i = 0; i < 3; i++)
        if ((cmd.operand[i].type == UD_OP_IMM)
                && string_data_area_begin <= cmd.operand[i].lval.uqword
                && cmd.operand[i].lval.uqword < string_data_area_end)
        {
            std::ostringstream os;
            os << '"';

             exo::memory_space_const avail_space;

             for (addr_type ptr = cmd.operand[i].lval.uqword; true; ptr++)
             {
                 if (avail_space.is_empty())
                     avail_space = mem(ptr, 1);

                 char c = avail_space.get<char>();
                 avail_space = avail_space.remove_prefix(1);

                 if (c == '\0')
                     break;

                 switch (c)
                 {
                 case '\\':
                     os << "\\\\";
                     break;
                 case '\t':
                     os << "\\t";
                     break;
                 case '\n':
                     os << "\\n";
                     break;
                 case '\r':
                     os << "\\r";
                     break;

                 default:
                     os << c;
                     break;
                 }
             }
             os << '"';

             cmd.comments.push_back(os.str());
        }
}


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */
