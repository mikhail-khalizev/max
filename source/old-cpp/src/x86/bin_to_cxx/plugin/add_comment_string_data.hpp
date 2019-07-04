#ifndef ADD_COMMENT_STRING_DATA_HPP_
#define ADD_COMMENT_STRING_DATA_HPP_

#include "x86/bin_to_cxx/plugin_base_fwd.hpp"

namespace raw_program {
namespace x86 {
namespace plugin {


class add_comment_string_data : public plugin_base
{
    addr_type string_data_area_begin;
    addr_type string_data_area_end;

public:

    add_comment_string_data(bin_to_cxx & obj_);

    void set_string_data_area(addr_type begin, addr_type end)
    {
        string_data_area_begin = begin;
        string_data_area_end = end;
    }

private:

    void on_instruction_decoded(cmd_info & cmd);
};


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */

#endif /* ADD_COMMENT_STRING_DATA_HPP_ */
