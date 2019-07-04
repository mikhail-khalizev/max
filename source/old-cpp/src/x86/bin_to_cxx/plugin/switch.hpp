#ifndef OPENMAX_X86_BIN_TO_CXX_PATTERN_HPP_INCLUDED
#define OPENMAX_X86_BIN_TO_CXX_PATTERN_HPP_INCLUDED

#include "x86/bin_to_cxx/plugin_base_fwd.hpp"

namespace raw_program {
namespace x86 {
namespace plugin {


enum class reg_base
{
    none,
    a,
    b,
    c,
    d,
    bp,
    sp,
    di,
    si,
    es,
    cs,
    ds,
    ss,
    gs,
    fs,
    cr0
};

class switch_ : public plugin_base
{
    uint8_t state;
    struct ud_operand op;
    addr_type size_of_addr_area;
    reg_base reg;

public:

    switch_(bin_to_cxx & obj_);

private:

    void add_switch_at(cmd_info & cmd);
    void on_instruction_decoded(cmd_info & cmd);
    void on_cmd_write(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> & comments_in_current_func);
};


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_BIN_TO_CXX_PATTERN_HPP_INCLUDED */
