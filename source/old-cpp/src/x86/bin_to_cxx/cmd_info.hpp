#ifndef CMD_INFO_HPP_
#define CMD_INFO_HPP_

#include <vector>
#include <string>

#include <exo/memory_space.hpp>
#include <exo/util/delegate.hpp>

#include <udis86.h>

#include "x86/bin_to_cxx/addr_type.hpp"
#include "x86/bin_to_cxx/detected_func.hpp"

namespace raw_program {
namespace x86 {


class detected_func;

struct cmd_info
{
    const addr_type begin;
    const addr_type end;

    /** Write only cmd. Not code position, not comments. */
    exo::util::delegate_unsafe<void (
            /* inputs: */ std::ostream &, detected_func &, size_t cmd_index,
            /* outputs: */ std::vector<std::string> & comments_in_current_func)> write_cmd;

    std::vector<std::string> comments;
    bool comment_this; // Закомментировать всю напечатанную строку.

    uint8_t addr_mode; // 16 32 64
    uint8_t opr_mode; // 16 32 64
    enum ud_mnemonic_code mnemonic;
    struct ud_operand operand[3];
    uint8_t pfx_seg;
    bool br_far;
    bool pfx_rep;
    bool pfx_repne;
    bool pfx_lock;

    bool is_call;
    bool is_any_loop;
    bool is_any_jump;
    bool is_any_ret;
    bool is_jmp_or_ret;


    cmd_info(addr_type begin);
    cmd_info(addr_type begin, addr_type end, std::string comment);
    cmd_info(ud_t & ud_obj);

    enum ud_type get_effective_segment_of_operand(uint8_t num) const;


    void write_simple(std::ostream & os, std::string cmd_suffix = std::string(), std::string func_add_arg = std::string()) const;

    static void write_cmd__default(std::ostream & os, detected_func & df, size_t cmd_index, std::vector<std::string> & comments_in_current_func);
};

inline bool operator<(const cmd_info & a, const cmd_info & b)
{
    return a.begin < b.begin;
}

inline bool operator<(addr_type addr_begin, const cmd_info & b)
{
    return addr_begin < b.begin;
}

inline bool operator==(const struct ud_operand & a, const struct ud_operand & b)
{
    return exo::memory_space_const(&a, sizeof(a)) == exo::memory_space_const(&b, sizeof(b));
}


} /* namespace x86 */
} /* namespace raw_program */

#endif /* CMD_INFO_HPP_ */
