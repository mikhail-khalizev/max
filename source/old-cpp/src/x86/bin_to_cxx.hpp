#ifndef OPENMAX_X86_BIN_TO_CXX_HPP_INCLUDED
#define OPENMAX_X86_BIN_TO_CXX_HPP_INCLUDED

#include <set>
#include <map>
#include <vector>
#include <memory>
#include <iosfwd>

#include <boost/preprocessor/stringize.hpp>

#include <exo/global.hpp>
#include <exo/memory_space.hpp>

#include "x86/bin_to_cxx/types.hpp"
#include "x86/bin_to_cxx/detected_func.hpp"
#include "x86/bin_to_cxx/plugin_base_fwd.hpp"
#include "x86/bin_to_cxx/plugin/switch.hpp"
#include "x86/bin_to_cxx/plugin/comment_idle.hpp"
#include "x86/bin_to_cxx/plugin/jmp_call_loop_simple.hpp"
#include "x86/bin_to_cxx/plugin/add_comment_string_data.hpp"

namespace raw_program {
namespace x86 {


void write_addr(std::ostream & os, addr_type addr);
/**
 * @brief Записывает адрес в поток учитывая пространства имён и известные определения.
 * @param os Поток в который происходит запись.
 * @param val Адрес, который необходимо записать.
 * @param padding true, если необходимо добавить лидирующие нули ...
 *                       ... выровнены по правому краю путем добавления слева нулей до указанной общей длины.
 * @param with_namespace true, если необходимо добавить перед адресом комментарий с пространством имён; иначе - false.
 */
void write_addr_with_check_known_definitions(std::ostream & os, addr_type val, bool padding, bool with_namespace);

// + AddressNameConverter.DefaultNamespaceByAddress
/**
 * @brief Пространство имён по умолчанию, используемое у функций с заданым диапазонов адресов.
 */
extern std::map<addr_type /* begin */, std::pair<addr_type /* end */, std::vector<std::string>>> defualt_namespace_by_addr;


/**
 * Возможно, устарело:
 *
 *  Алгоритм декодирует код по частям. Каждую часть декодирутся последовательно
 * до тех пор пока не встретится потенциальный конец функции (ret или jmp). После
 * чего декодирование части заканчивается и начинается декодирование других частей,
 * выявленных по операциям ветвления (jcc, jmp, loop, call).
 *
 * Алгоритм устроен так, что без необходимости, ничего лишнего он не декодирует.
 */
class bin_to_cxx
{
    friend class plugin_base;

private:

    uint_<8> mode;
    addr_type cs_base;
    addr_type ds_base;

    exo::util::delegate_unsafe< exo::memory_space (addr_type addr, addr_type size) >  mem;

    std::vector< exo::util::delegate_unsafe<void (cmd_info &)> >  on_instruction_decoded;


    // @todo Написать  exo::sorted_vector<>
    const std::set<addr_type> force_end_funcs_; // full_addr   Если force_end делит инструкцию попалам, то эта инструкция относится к функции, расположенной с меньшими адресам.
    std::multimap<addr_type, std::pair<exo::memory_space_const, uint_<8>> > already_decoded_funcs_; // addr, code, 0 - not code checked, 1 - success code, 2 - fail.

    std::set<detected_func> new_detected_funcs;
    std::set<addr_type> addr_to_decode;
    std::map<addr_type, uint_<8>> aligment; // <addr of start, aligment>
    std::map<addr_type, jtka> jmp_to_known_addr; /* <cmd_addr_start, ... */


    decoded_code code;
    exo::util::used_space<addr_type> suppress_decode;

    addr_type pc_used_in_input_hook;


    static const size_t line_cmd_offset = 22;
    static const size_t line_comment_offset = 60;


    // Last variable in class - std patterns.
    plugin::jmp_call_loop_simple plugin_jmp_call_loop_simple;
    plugin::switch_ plugin_switch;
    plugin::add_comment_string_data plugin_add_comment_string_data;
    plugin::comment_idle plugin_comment_idle;


    /** false  check fail, true - check success */
    bool already_decoded_funcs_check(decltype(already_decoded_funcs_)::iterator iter);
    decltype(already_decoded_funcs_)::iterator already_decoded_funcs_try_find(addr_type addr, addr_type size);

    static int inp_code_hook(struct ud * ud_obj);

    void decode_processing();
    void decode_processing(addr_type addr);
    void add_aligment_as_instructions();
    /** Разбивка на функции.
     * - Корректировка end_of_func в new_detected_funcs.
     * - Добавление новых функций в new_detected_funcs на основе correct_jmps_cmd.
     * - Корректировка инструкций по адресам correct_jmps_cmd в decoded_area. */
    void layout_funcs();

    static void write_spaces(std::ostringstream & os, size_t offset);
    static void write_instruction_position(std::ostringstream & os, addr_type begin, addr_type end);
    static void write_instruction_position_and_spaces(std::ostringstream & os, addr_type begin, addr_type end);
    static std::string instruction_to_string(detected_func & df, size_t cmd_index);

    void write_cxx_func_to_stream(std::ostream & output, decltype(new_detected_funcs.begin()) iter);

public:

    bin_to_cxx(uint_<8> mode, exo::util::delegate_unsafe< exo::memory_space(addr_type addr, addr_type size) >  mem_pg_raw, addr_type cs_base = 0, addr_type ds_base = 0);
    bin_to_cxx(const bin_to_cxx &) = delete;
    bin_to_cxx & operator=(const bin_to_cxx &) = delete;

    /** Список адресов на которых происходит принудительное завершение декодирования.
     * Это требуется при декодировании 'странного' кода. Например когда в функции,
     * вызванной call происходит возврат не на один уровень вверх, а на два. В результате
     * требуется принудительно остановить декодирование после данного call. */
    std::set<addr_type> & force_end_funcs()
    {
        return const_cast<std::set<addr_type>&>(force_end_funcs_);
    }

// +
    void already_decoded_funcs_insert(addr_type addr, exo::memory_space_const code_)
    {
        already_decoded_funcs_.insert(std::make_pair(addr, std::make_pair(code_, 0)));
    }

// +
    void already_decoded_funcs_erase(addr_type addr)
    {
        already_decoded_funcs_.erase(addr);
    }

    // +
    void set_string_data_area(addr_type begin, addr_type end)
    {
        plugin_add_comment_string_data.set_string_data_area(begin, end);
    }

    void add_region_to_suppress_decode(addr_type begin, addr_type end)
    {
        suppress_decode.add(begin, end);
    }


    /** reason - by user. */
    void decode_func(addr_type addr);
    void decode_func(addr_type addr, std::string reason);
    void decode(addr_type addr);

    void decode_area(addr_type begin, addr_type end);
    void write_cxx_to_dir(std::string path);
};


} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_BIN_TO_CXX_HPP_INCLUDED */

