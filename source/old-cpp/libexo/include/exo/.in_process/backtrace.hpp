#ifndef EXO__IN_PROCESS_BACKTRACE_HPP_INCLUDED
#define EXO__IN_PROCESS_BACKTRACE_HPP_INCLUDED

#include <string>
#include <memory>

namespace exo {
namespace debug {

struct backtrace_item
{
    void * addr_func;
    void * addr_ip;
   // std::unique_ptr<int> func_demangle;
};

} /* namespace debug */
} /* namespace exo */

#endif /* EXO__IN_PROCESS_BACKTRACE_HPP_INCLUDED */

