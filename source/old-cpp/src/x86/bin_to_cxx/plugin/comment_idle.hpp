#ifndef OPENMAX_X86_BIN_TO_CXX_PATTERN_HPP_INCLUDED_
#define OPENMAX_X86_BIN_TO_CXX_PATTERN_HPP_INCLUDED_

#include "x86/bin_to_cxx/plugin_base_fwd.hpp"

namespace raw_program {
namespace x86 {
namespace plugin {


class comment_idle : public plugin_base
{
public:

    comment_idle(bin_to_cxx & obj_);

    comment_idle(const comment_idle &) = delete;
    comment_idle & operator=(const comment_idle &) = delete;

private:

    void on_instruction_decoded(cmd_info & cmd);
    void on__cmd_mov_to_reg__write(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> & comments_in_current_func);
};


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_BIN_TO_CXX_PATTERN_HPP_INCLUDED_ */
