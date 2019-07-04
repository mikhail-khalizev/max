#include <map>
#include <utility>
#include <sstream>
#include <iostream>
#include <algorithm>

#include <exo/exception.hpp>
#include <exo/util/value_of_pointer_iterator.hpp>

#include "x86/memory.hpp"
#include "x86/bin_to_cxx.hpp"

using namespace exo;


namespace raw_program {
namespace x86 {


void bin_to_cxx::decode(addr_type addr)
{
    addr_to_decode.insert(addr);
    decode_processing();
}

void bin_to_cxx::decode_func(addr_type addr)
{
    decode_func(addr, "Функция определена пользователем.");
}

void bin_to_cxx::decode_func(addr_type addr, std::string /* reason */)
{
    auto ret = new_detected_funcs.insert(detected_func(addr)); // create if not exist.
    if (ret.second == false) // Уже добавили.
        return;

    decode(addr);
}


void bin_to_cxx::decode_area(addr_type begin, addr_type end)
{
    throw exo::exception::not_implemented();


    addr_type start = begin;

    while (start < end)
    {
        addr_to_decode.insert(start);

        decode_processing();
// @todo Учитывать выравнивание aligment. и sizeof(addr_type)

        auto iter = code.area_find(start);
        if (iter == code.area_end())
            start++;
        else
            start = std::max(start + 1, iter.get_end());
    }
}

bool bin_to_cxx::already_decoded_funcs_check(decltype(already_decoded_funcs_)::iterator iter)
{
    if (iter -> second.second == 0)
    {
        if (mem_pg_equals(iter -> first, iter -> second.first))
            iter -> second.second = 1;
        else
            iter -> second.second = 2;
    }

    return (iter -> second.second == 1);
}

decltype(bin_to_cxx::already_decoded_funcs_)::iterator bin_to_cxx::already_decoded_funcs_try_find(addr_type addr, addr_type size)
{
    for (auto i = already_decoded_funcs_.begin(); i != already_decoded_funcs_.end(); i++)
        if (size == i -> second.first.size())
            if (mem_pg_equals(addr, i -> second.first))
                return i;

    return already_decoded_funcs_.end();
}

// @todo Проверять suppress_decode.
int bin_to_cxx::inp_code_hook(struct ud * ud_obj)
{
    try
    {
        bin_to_cxx & base = * reinterpret_cast<bin_to_cxx *>(ud_obj -> inp_buff);

        if (base.pc_used_in_input_hook < base.cs_base)
            throw exo::exception::logic_error();

        if (base.mode == 16 && 0xffff < base.pc_used_in_input_hook - base.cs_base)
            throw exo::exception::not_implemented();

        int ret = base.mem(base.pc_used_in_input_hook, 1).get<uint8_t>();
        base.pc_used_in_input_hook++;
        return ret;
    }
    catch(...)
    {
        return -1;
    }
}

void bin_to_cxx::decode_processing()
{
    while (addr_to_decode.size() != 0)
    {
        addr_type addr = * addr_to_decode.begin();
        addr_to_decode.erase(addr_to_decode.begin());

        decode_processing(addr);
    }
}

void bin_to_cxx::decode_processing(addr_type addr_cur_func)
{
    if (code.contains(addr_cur_func))
        return; // Код включающий этот адрес уже декодирован.

    if (addr_cur_func < cs_base)
        return;

    addr_type near_suppress_decode = static_cast<addr_type>(-1);
    {
        auto i = suppress_decode.lower_bound(addr_cur_func, false);
        if (i != suppress_decode.end())
            near_suppress_decode = i.get_begin();
    }

    if (near_suppress_decode <= addr_cur_func)
        return;

    auto near_already_decoded_iter = already_decoded_funcs_.lower_bound(addr_cur_func);


    // Decode.

    mem(addr_cur_func, 1); // Попробуем прочитать хоть один байт - вдруг чтение недоступно.


    ud_t ud_obj;
    ud_init(&ud_obj);

    ud_obj.inp_buff = reinterpret_cast<uint8_t*>(this);
    ud_set_input_hook(&ud_obj, inp_code_hook);

    ud_set_syntax(&ud_obj, UD_SYN_INTEL);
    ud_set_mode(&ud_obj, mode);

    pc_used_in_input_hook = addr_cur_func;
    ud_set_pc(&ud_obj, addr_cur_func);


    addr_type near_force_end = static_cast<addr_type>(-1); // По умолчанию устанавливаем на максимум.
    {
        /* Специально upper_bound, чтобы функция, начинающаяся с точного совпадения с force_end_funcs_ смогла начать декодироваться. */
        auto near_force_end_iter = force_end_funcs_.upper_bound(addr_cur_func);

        if (near_force_end_iter != force_end_funcs_.end())
            near_force_end = * near_force_end_iter;
    }


    for(;;)
    {
        if (near_force_end <= ud_obj.pc || near_suppress_decode <= ud_obj.pc)
            return;

        while (near_already_decoded_iter != already_decoded_funcs_.end())
        {
            if (near_already_decoded_iter -> first < ud_obj.pc)
                near_already_decoded_iter++;
            else if (near_already_decoded_iter -> first == ud_obj.pc)
            {
                if (already_decoded_funcs_check(near_already_decoded_iter))
                    return; // Нашли среди декодированных.

                near_already_decoded_iter++;
            }
            else
                break;
        }


        if (ud_disassemble(&ud_obj) == 0)
            throw std::logic_error("Преждевременное завершение функции из-за нехватки кода.");


        cmd_info cmd(ud_obj);

// Бывают случаи, когда ud_obj незнаком с инструкцией, хотя в документации x86 она есть.
//        if (cmd.mnemonic == UD_Iinvalid)
//            throw exo::exception::not_implemented();


        auto cmd_iter = code.insert(std::move(cmd));

        for (auto & event : on_instruction_decoded)
            event(const_cast<cmd_info&>(*cmd_iter.first));

        if (cmd_iter.first -> is_jmp_or_ret /* Потенциальный конец функции. */
                || code.contains(cmd_iter.first -> end, cmd_iter.first) /* Следующая часть кода уже декодирована. */)
            return;
    }
}

void bin_to_cxx::add_aligment_as_instructions()
{
    for (auto & a : aligment)
    {
        auto iter_area = code.area_find(a.first, false);
        if (iter_area == code.area_end())
            throw exo::exception::logic_error();

        if (iter_area.get_begin() < a.first)
            continue; // Выравнивание не требуется, т.к. до нас уже что-то есть.

        if (iter_area != code.area_begin())
        {
            auto i = iter_area;
            i--;
            addr_type prev_addr = i.get_end();

            if (a.first < prev_addr + a.second)
                code.insert(cmd_info(prev_addr, a.first, "Выравнивание."));
        }
    }
}

void bin_to_cxx::layout_funcs()
{
    add_aligment_as_instructions();

    bool not_all_end_of_function_determine = true;
    while (not_all_end_of_function_determine)
    {
        size_t success_count = 0;

        for (auto iter_func = new_detected_funcs.begin(); iter_func != new_detected_funcs.end(); iter_func++)
        {
            detected_func & func = const_cast<detected_func&>(*iter_func);
            const addr_type addr_func = func.begin;


            // Следует ли вычислять конец этой функции или он уже вычислен.
            if (func.end != 0)
            {
                auto next = iter_func;
                next++;

                if (next != new_detected_funcs.end())
                    if (func.end <= next -> begin)
                    {
                        success_count++;
                        continue;
                    }

                func.end = 0;
            }


            if (code.contains(addr_func) == false)
            {
                // Вообще не декодировали этот адрес. Видимо он либо alredy_decoded или suppress.
                iter_func = new_detected_funcs.erase(iter_func);
                if (iter_func == new_detected_funcs.end())
                    break;
                else
                    continue;
            }


            // --- Вычисляем... ---


            const auto first_cmd = code.cmd_get(addr_func);

            if (first_cmd == code.cmd_end())
            {
                /* Начало функции делит инструкцию пополам.  */
                throw exo::exception::logic_error();
            }


            // --- Посчитаем min_end - адрес конца функции, дальше которого функция точно уже не может продолжаться. ---

            addr_type min_end = static_cast<addr_type>(-1);

            {
                auto iter_near_force_func = force_end_funcs_.upper_bound(addr_func);
                if (iter_near_force_func != force_end_funcs_.end())
                    min_end = std::min(min_end, *iter_near_force_func);
            }

            // Учтём, что инструкции в decoded_code могут пересекаться. Найдём 'верную дорожку'.
            std::vector<cmd_info*> instr;
            addr_type last_instr_end = first_cmd -> begin;
            std::vector<addr_type> may_be_end_of_func;

            auto iter_next_func = iter_func;
            iter_next_func++;

            auto iter_next_already_decoded = already_decoded_funcs_.upper_bound(addr_func);

            for (auto cmd = first_cmd; cmd != code.cmd_end(); cmd = code.cmd_get_next_logical(cmd))
            {
                if (min_end <= cmd -> begin)
                    break;


                if (2 * (last_instr_end - first_cmd -> begin) < cmd -> begin - last_instr_end)
                    break; // Не допускаем большие "дыры".


                bool is_prev_end = false; // Являлась ли предыдущая инструкция концом функции.

                /* Проверим на принадлежность к new_detected_funcs. */

                while (iter_next_func != new_detected_funcs.end())
                    if (iter_next_func -> begin < cmd -> begin)
                        iter_next_func++;
                    else
                    {
                        if (iter_next_func -> begin == cmd -> begin)
                            is_prev_end = true;  /* Т.к. эта инструкция является new_detected_funcs, то предыдущая - конец функции. */
                        break;
                    }

                /* Проверим на принадлежность к already_decoded_funcs_. */

                while (iter_next_already_decoded != already_decoded_funcs_.end())
                {
                    if (iter_next_already_decoded -> first < cmd -> begin)
                        iter_next_already_decoded++;
                    else if (iter_next_already_decoded -> first == cmd -> begin)
                    {
                        if (already_decoded_funcs_check(iter_next_already_decoded))
                        {
                            is_prev_end = true; // Нашли среди декодированных.
                            break;
                        }

                        iter_next_already_decoded++;
                    }
                    else
                        break;
                }


                if (is_prev_end)
                    break;

                if (cmd -> is_jmp_or_ret)
                    may_be_end_of_func.push_back(cmd -> end);

                instr.push_back(const_cast<cmd_info*>(&(*cmd)));
                last_instr_end = cmd -> end;
            }


            /* Убираем конечные закомментированные инструкции. */

            while (instr.empty() == false)
            {
                if (instr[instr.size() - 1] -> comment_this == false)
                    break;

                instr.pop_back();
            }

            min_end = instr[instr.size() - 1] -> end;


            // Заполняем label.

            func.labels.clear();

            for (auto i = jmp_to_known_addr.lower_bound(addr_func); i != jmp_to_known_addr.end(); i++)
            {
                if (min_end <= i -> first)
                    break;

                for (addr_type to : i -> second.to)
                    if (addr_func <= to && to < min_end)
                    {
                        // Ссылка внутрь функции.

                        if (std::binary_search(
                                exo::util::value_of_pointer_worker(instr.begin()),
                                exo::util::value_of_pointer_worker(instr.end()),
                                to))
                            func.labels.insert(to);
                        else
                        {
                            std::cerr << "Предупреждение: Метка '";
                            write_addr(std::cerr, to);
                            std::cerr << "' делит инструкцию пополам." << std::endl;

                            // @todo Улучшить.
                            new_detected_funcs.insert(detected_func(to)); // create if not exist.
                        }
                    }
                    else
                    {
                        if (code.contains(to))
                            new_detected_funcs.insert(detected_func(to)); // create if not exist.
                    }
            }


            if (min_end != 0)
            {
                func.instr.clear();
                for (auto cmd_ptr : instr)
                {
                    if (min_end < cmd_ptr -> end)
                        break;
                    func.instr.push_back(std::make_pair(cmd_ptr, func.labels.find(cmd_ptr -> begin) != func.labels.end())); // @todo Оптимизировать.
                }

                func.end = min_end;
                success_count++;
            }
        }

        not_all_end_of_function_determine = (success_count != new_detected_funcs.size());
    }


//    if (equal_spaces(all_func_space, decoded_areas) == false)
//        throw std::logic_error("Не все функции были определены.");
}

} /* namespace x86 */
} /* namespace raw_program */

