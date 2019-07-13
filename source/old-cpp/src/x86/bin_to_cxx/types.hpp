#ifndef OPENMAX_X86_BIN_TO_CXX_TYPES_HPP_INCLUDED
#define OPENMAX_X86_BIN_TO_CXX_TYPES_HPP_INCLUDED

#include <set>
#include <utility>
#include <exo/util/used_space.hpp>
#include "x86/bin_to_cxx/addr_type.hpp"
#include "x86/bin_to_cxx/cmd_info.hpp"

namespace raw_program {
namespace x86 {


class decoded_code
{
private:

    /* Инструкции могут перекрываться. */
    std::set<cmd_info> cmds;
    exo::util::used_space<addr_type> area;

public:

    decoded_code()
    : cmds()
    , area()
    {}


// +
    std::pair<decltype(cmds.begin()), bool> insert(cmd_info && cmd)
    {
        auto ret = cmds.insert(std::move(cmd));
        if (ret.second)
            area.add(ret.first -> begin, ret.first -> end);

        return ret;
    }


    decltype(area.begin()) area_begin()
    {
        return area.begin();
    }

    decltype(area.begin()) area_end()
    {
        return area.end();
    }

// +
    decltype(area.begin()) area_find(const addr_type val, bool with_rigth_bound = true)
    {
        return area.find(val, with_rigth_bound);
    }


    decltype(cmds.begin()) cmd_end()
    {
        return cmds.end();
    }

    // +
    decltype(cmds.begin()) cmd_get(addr_type addr)
    {
        return cmds.find(cmd_info(addr));
    }

// -
    decltype(cmds.begin()) cmd_get(addr_type addr, decltype(cmds.begin()) iter_near)
    {
        if (iter_near == cmds.end())
            return cmd_get(addr);


        bool direction = (iter_near -> begin < addr);

        while (iter_near != cmds.end())
        {
            if (iter_near -> begin == addr)
                return iter_near;

            if (direction != (iter_near -> begin < addr))
                break;

            if (direction)
                iter_near++;
            else
                iter_near--;
        }

        return cmds.end();
    }

// +
    /**
     * @brief Возвращает инструкцию, следующую за заданной.
     * @param i Инструкция, для которой необходимо определить следующую инструкцию.
     */
    decltype(cmds.begin()) cmd_get_next_logical(decltype(cmds.begin()) i)
    {
        if (i == cmds.end())
            return cmds.end();

        /* Инструкции могут пересекаться. */

        addr_type to_find = i -> end;

        while (i != cmds.end())
            if (i -> begin < to_find)
                i++;
            else
                return i;

        return cmds.end();
    }

    bool contains(addr_type addr, decltype(cmds.begin()) iter_near)
    {
        return cmd_get(addr, iter_near) != cmds.end();
    }

    bool contains(addr_type addr)
    {
        return cmd_get(addr) != cmds.end();
    }
};

struct jtka // jmp_to_known_addr
{
    std::set<addr_type> to;
//    std::string prefix; // @todo rename to suffix

    jtka()
    : to()
    {}
};


} /* namespace x86 */
} /* namespace raw_program */

#endif /* OPENMAX_X86_BIN_TO_CXX_TYPES_HPP_INCLUDED */
