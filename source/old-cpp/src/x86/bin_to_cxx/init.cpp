#include <exo/exception.hpp>

#include "x86/bin_to_cxx.hpp"


namespace raw_program {
namespace x86 {

// +
bin_to_cxx::bin_to_cxx(uint_<8> mode_, exo::util::delegate_unsafe< exo::memory_space (addr_type addr, addr_type size) >  mem_, addr_type cs_base_, addr_type ds_base_)
: mode(mode_)
, cs_base(cs_base_)
, ds_base(ds_base_)
, mem(mem_)
, on_instruction_decoded()
, force_end_funcs_()
, already_decoded_funcs_()
, new_detected_funcs()
, addr_to_decode()
, aligment()
, jmp_to_known_addr()
, code()
, suppress_decode()
, pc_used_in_input_hook(0)
, plugin_jmp_call_loop_simple(*this)
, plugin_switch(*this)
, plugin_add_comment_string_data(*this)
, plugin_comment_idle(*this)
{
    if (cs_base_ != 0)
        suppress_decode.add(0, cs_base_);
}


} /* namespace x86 */
} /* namespace raw_program */
