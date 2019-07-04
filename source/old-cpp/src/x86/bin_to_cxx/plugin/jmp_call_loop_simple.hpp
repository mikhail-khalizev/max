#ifndef JMP_CALL_LOOP_RELATIVE_HPP_
#define JMP_CALL_LOOP_RELATIVE_HPP_

#include "x86/bin_to_cxx/plugin_base_fwd.hpp"

namespace raw_program {
namespace x86 {
namespace plugin {


class jmp_call_loop_simple : public plugin_base
{
public:

    jmp_call_loop_simple(bin_to_cxx & obj_);

private:

    void on_instruction_decoded(cmd_info & cmd);
    void on_cmd_write(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> & comments_in_current_func);
};


} /* namespace plugin */
} /* namespace x86 */
} /* namespace raw_program */

#endif /* JMP_CALL_LOOP_RELATIVE_HPP_ */
