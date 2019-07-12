#ifndef DETECTED_FUNC_HPP_
#define DETECTED_FUNC_HPP_

#include <set>
#include "x86/bin_to_cxx/addr_type.hpp"

namespace raw_program {
namespace x86 {


class cmd_info;

// +
struct detected_func
{
    const addr_type begin; // 0 if unknown
    addr_type end; // 0 if unknown
    std::set<addr_type> labels;
    std::vector< std::pair<cmd_info*, bool /* have_label */> > instr;

//    typedef typename decltype(instr)::iterator instr_iterator;
//    typedef typename std::vector< std::pair<cmd_info*, bool /* have_label */> >::iterator instr_iterator;

//        addr_type count_call_to_this;
//        std::string[] reason_to_add; // @todo Условие добавления (для отладки).

    detected_func(addr_type begin_)
    : begin(begin_)
    , end()
    , labels()
    , instr()
    {}
};

inline bool operator<(const detected_func & a, const detected_func & b)
{
    return a.begin < b.begin;
}


} /* namespace x86 */
} /* namespace raw_program */

#endif /* DETECTED_FUNC_HPP_ */
