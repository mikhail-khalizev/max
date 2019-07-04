#ifndef OPENMAX_X86_BIN_TO_CXX_PLUGIN_BASE_FWD_HPP_INCLUDED
#define OPENMAX_X86_BIN_TO_CXX_PLUGIN_BASE_FWD_HPP_INCLUDED

#include <set>
#include <map>

#include <exo/abstract_base.hpp>
#include <exo/util/delegate.hpp>
#include <exo/util/used_space.hpp>

#include "x86/bin_to_cxx/types.hpp"

namespace raw_program {
namespace x86 {


class bin_to_cxx;

class plugin_base : public exo::abstract_base
{
    friend class bin_to_cxx;
    bin_to_cxx & obj;

public:

    plugin_base(bin_to_cxx & obj_)
    : obj(obj_)
    {}

    plugin_base(const plugin_base &) = delete;             // because in high level constructor may be registered delegate_unsafe.
    plugin_base & operator=(const plugin_base &) = delete; // because in high level constructor may be registered delegate_unsafe.

protected:

    void register_on_instruction_decoded(exo::util::delegate_unsafe<void (cmd_info &)>);

    std::map<addr_type, uint_<8>> & aligment();
    std::map<addr_type, jtka> & jmp_to_known_addr();
    std::set<addr_type> & addr_to_decode();
    decoded_code & code();
    std::set<detected_func> & new_detected_funcs();
    addr_type cs_base();
    addr_type ds_base();
    uint_<8> mode();
    inline exo::memory_space mem(addr_type addr, addr_type size);
    exo::util::used_space<addr_type> & suppress_decode();
};


} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_BIN_TO_CXX_PLUGIN_BASE_FWD_HPP_INCLUDED */
