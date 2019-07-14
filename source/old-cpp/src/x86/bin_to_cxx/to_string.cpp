#include <sstream>
#include <fstream>
#include <iostream>
#include <string.h>
#include <algorithm>

#include <exo/exception.hpp>
#include <boost/functional/hash.hpp>

#include "x86/bin_to_cxx.hpp"


using namespace exo;


namespace raw_program {
namespace x86 {


// + Address ToString
void write_addr(std::ostream & os, addr_type addr)
{
    auto sf_ = os.setf(std::ios_base::fmtflags(), std::ios_base::showbase);

    os << "0x";

    auto ow = os.width(sizeof(addr_type) * 2);
    auto of_ = os.fill('0');
    os << std::hex << addr;
    os.width(ow);
    os.fill(of_);
    os.setf(sf_);
}

// + see AddressNameConverter
std::map<addr_type /* begin */, std::pair<addr_type /* end */, std::vector<std::string>>> defualt_namespace_by_addr;

// + AddressNameConverter.GetNamespace
static const std::vector<std::string> * get_namespaces_of_addr(addr_type addr)
{
    auto iter = defualt_namespace_by_addr.lower_bound(addr);
    if (iter == defualt_namespace_by_addr.end())
    {
        if (! defualt_namespace_by_addr.empty())
            iter--;
    }
    else
    {
        if (iter -> first != addr)
        {
            if (iter != defualt_namespace_by_addr.begin())
                iter--;
            else
                iter = defualt_namespace_by_addr.end();
        }
    }


    if (iter != defualt_namespace_by_addr.end())
        if (addr < iter -> second.first)
            return & iter -> second.second;

    return NULL;
}

// + AddressNameConverter.KnownDefinitions
static exo::memory_space_const get_known_definition(addr_type addr)
{
    static std::map<addr_type, exo::memory_space_const> known_definitions;

    if (known_definitions.empty())
    {
#define CALL(addr, name)    \
        known_definitions.insert(std::make_pair(addr, exo::memory_space_const( BOOST_PP_STRINGIZE(name) )));
#define VARIABLE CALL

#include "program/known_definitions.hpp"

#undef VARIABLE
#undef CALL
    }


    auto iter_def = known_definitions.find(addr);
    if (iter_def != known_definitions.end())
        return iter_def -> second;
    else
        return exo::memory_space_const();
}

// + AddressNameConverter.GetResultName
void write_addr_with_check_known_definitions(std::ostream & os, addr_type val, bool padding, bool with_namespace)
{
    auto kd = get_known_definition(val);
    if (kd.is_not_empty())
        os << kd;
    else
    {
        if (with_namespace)
        {
            auto ns = get_namespaces_of_addr(val);
            if (ns != NULL)
            {
                os << "/* ";

                bool is_not_first = false;
                for (auto & item : * ns)
                {
                    if (is_not_first)
                    {
                        os << "::";
                        is_not_first = true;
                    }
                    os << item;
                }

                os << " */ ";
            }
        }

        if (padding)
            write_addr(os, val);
        else
            os << std::hex << std::showbase << val;
    }
}

// +
void bin_to_cxx::write_spaces(std::ostringstream & os, size_t offset)
{
    size_t str_length = os.str().length();
    if (offset <= str_length)
        return;

    size_t need_extra_space = offset - str_length;

    char spaces[need_extra_space + 1];
    memset(spaces, ' ', need_extra_space);
    spaces[need_extra_space] = '\0';

    os << spaces;
}

// +
void bin_to_cxx::write_instruction_position(std::ostringstream & os, addr_type begin, addr_type end)
{
    os << std::hex << std::showbase;
    os << "II(";
    write_addr(os, begin);
    os << ", " << static_cast<addr_type>(end - begin) << ")";
}

// +
void bin_to_cxx::write_instruction_position_and_spaces(std::ostringstream & os, addr_type begin, addr_type end)
{
    write_instruction_position(os, begin, end);
    write_spaces(os, line_cmd_offset - 1);
    os << ' ';
}

// +
std::string bin_to_cxx::instruction_to_string(detected_func & df, size_t cmd_index)
{
    std::ostringstream os;

    cmd_info & cmd = *(df.instr[cmd_index].first);

    write_instruction_position(os, cmd.begin, cmd.end);
    write_spaces(os, line_cmd_offset - 1);

    std::vector<std::string> comments_in_current_func;

    if (cmd.write_cmd.is_not_empty())
    {
        os << ' ';
        cmd.write_cmd(os, df, cmd_index, comments_in_current_func);

        if (cmd.comments.empty() == false || comments_in_current_func.empty() == false)
            write_spaces(os, line_comment_offset - 1);
    }

    for (auto s : cmd.comments)
        os << " /* " << s << " */";

    for (auto s : comments_in_current_func)
        os << " /* " << s << " */";

    return os.str();
}

// +
void bin_to_cxx::write_cxx_func_to_stream(std::ostream & output, decltype(new_detected_funcs.begin()) iter_func)
{
    const addr_type addr_func = iter_func -> begin;
    const addr_type addr_func_end = iter_func -> end;


    auto const first_cmd = const_cast<detected_func&>(*iter_func).instr.begin();


    output << std::hex << std::showbase;
    output << "FUNC_BEGIN(";
    write_addr_with_check_known_definitions(output, addr_func, true, true);

    // hash compute

    {
        size_t hash = 0;

        for (addr_type i = addr_func; i < addr_func_end;)
        {
            memory_space_const avail_space = mem(i, 1).sub_space(0, addr_func_end - i);
            hash_value(hash, avail_space);
            i += avail_space.size();
        }

        output << ", " << hash;
    }

    output << ", " << static_cast<uint16_t>(mode) << ", ({";

    {
        memory_space_const avail_space = mem(addr_func, 1);

        for (addr_type i = addr_func; i < addr_func_end - 1; i++)
        {
            if (avail_space.is_empty())
                avail_space = mem(i, 1);

            output << avail_space.get<uint8_t, addr_type>(0) << ", ";

            avail_space = avail_space.remove_prefix(1);
        }

        output << avail_space.get<uint8_t, addr_type>(0);
    }


    output << "}))\n";


    bool skip = false; // Если нашли недостижимый код устанавливаем в true.
    bool last_instr_jmp_or_ret = false;
    addr_type last_instr_end = first_cmd -> first -> begin;

    for (size_t cmd_index = 0; cmd_index < iter_func -> instr.size(); cmd_index++)//   cmd = first_cmd; cmd != iter_func -> instr.end(); cmd++)
    {
        cmd_info & cmd = * (iter_func -> instr[cmd_index].first);
        bool have_label = iter_func -> instr[cmd_index].second;

        const addr_type addr_of_line = cmd.begin;

        if (addr_func_end <= addr_of_line)
            break;


        if (last_instr_end != cmd.begin) // Обнаружен не декодированный код.
        {
            if (last_instr_jmp_or_ret == false)
                throw exo::exception::not_implemented(); // Случай когда перед недостижимым кодом нет ret или jmp. Пока достаточно генерировать исключение.

            output << "//  ";
            std::ostringstream os;
            write_instruction_position_and_spaces(os, last_instr_end, cmd.begin);
            output << os.str() << "/* Недостижимый код. */\n";
        }


        if (have_label)
        {
            output << "l_";
            write_addr(output, addr_of_line);
            output << ":\n";
            skip = false;
        }


        // instruction_to_string может изменить comment_this. Поэтому вызывается раньше.
        std::string instr = instruction_to_string(const_cast<detected_func&>(*iter_func), cmd_index);


        if (skip || cmd.comment_this)
            output << "//"; // Комментируем недостижимый код.

        if (cmd.is_jmp_or_ret)
            skip = true;


        output << "    " << instr << '\n';

        last_instr_end = cmd.end;
        last_instr_jmp_or_ret = cmd.is_jmp_or_ret;
    }

    if (last_instr_jmp_or_ret == false)
    {
        /* Функция не заканчивается на jmp или ret.  Возможно её разбивает другая функция в неудобном месте. */

        std::ostringstream os;
        write_instruction_position_and_spaces(os, addr_func_end, addr_func_end);
        os << "jmpd_func(";
        write_addr_with_check_known_definitions(os, addr_func_end, true, true);
        os << ", 0);";
        write_spaces(os, line_comment_offset - 1);
        os << " /* Принудительное завершение функции. */";

        output << "    " << os.str() << '\n';
    }

    output << "FUNC_END\n\n";
}

// +
void bin_to_cxx::write_cxx_to_dir(std::string path)
{
    layout_funcs();

    for (auto iter_func = new_detected_funcs.begin(); iter_func != new_detected_funcs.end(); iter_func++)
    {
        addr_type func_start = iter_func -> begin;
        addr_type func_end = iter_func -> end;

        if (func_start == func_end)
            continue; // skip empty function.

// @todo Бывает среди _вновь_ декодированных встречаются абсолютно одинаковые функции. Надо их исключить.
        auto iter = already_decoded_funcs_try_find(func_start, func_end - func_start);
        if (iter != already_decoded_funcs_.end())
        {
            std::cout << "Декодированная функция '";
            write_addr(std::cout, func_start);
            std::cout << "' эквивалентна уже существующей '";
            write_addr(std::cout, iter -> first);
            std::cout << "'." << std::endl;

            continue; // Уже есть среди декодированных, правда находится по другому адресу.
        }

        {
            std::cout << "Сохранение функции '";
            write_addr(std::cout, func_start);
            std::cout << "' в файл." << std::endl;
        }


        std::ostringstream func_stream;
        write_cxx_func_to_stream(func_stream, iter_func); // В случае исключения в файл ничего не запишется.


        std::ostringstream os;
        os << path;

        auto ns = get_namespaces_of_addr(func_start);
        if (ns != NULL)
            for (auto & str : * ns)
                os << '/' << str;

        os << "/func_";
        write_addr(os, func_start);

        auto kd = get_known_definition(func_start);
        if (kd.is_not_empty())
            os << '_' << kd;

        os << ".cpp";
        std::fstream file(os.str().c_str(), std::ios_base::app | std::ios_base::out);
        if (file.is_open() == false)
            throw exo::exception::not_implemented();
        file << func_stream.str();
    }
}

} /* namespace x86 */
} /* namespace raw_program */

