#ifndef OPENMAX_X86_BIN_TO_CXX_PLUGIN_BASE_HPP_INCLUDED
#define OPENMAX_X86_BIN_TO_CXX_PLUGIN_BASE_HPP_INCLUDED

#include "x86/bin_to_cxx.hpp"
#include "x86/bin_to_cxx/plugin_base_fwd.hpp"

namespace raw_program {
namespace x86 {


inline void plugin_base::register_on_instruction_decoded(exo::util::delegate_unsafe<void (cmd_info &)> d)
{
    obj.on_instruction_decoded.push_back(d);
}

inline std::map<addr_type, uint_<8>> & plugin_base::aligment()
{
    return obj.aligment;
}

inline std::map<addr_type, jtka> & plugin_base::jmp_to_known_addr()
{
    return obj.jmp_to_known_addr;
}

inline std::set<addr_type> & plugin_base::addr_to_decode()
{
    return obj.addr_to_decode;
}

inline decoded_code & plugin_base::code()
{
    return obj.code;
}

inline std::set<detected_func> & plugin_base::new_detected_funcs()
{
    return obj.new_detected_funcs;
}

inline addr_type plugin_base::cs_base()
{
    return obj.cs_base;
}

inline addr_type plugin_base::ds_base()
{
    return obj.ds_base;
}

inline uint_<8> plugin_base::mode()
{
    return obj.mode;
}

inline exo::memory_space plugin_base::mem(addr_type addr, addr_type size)
{
    return obj.mem(addr, size);
}

inline exo::util::used_space<addr_type> & plugin_base::suppress_decode()
{
    return obj.suppress_decode;
}


} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_BIN_TO_CXX_PLUGIN_BASE_HPP_INCLUDED */
