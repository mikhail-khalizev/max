#ifndef EXO_SYNTAX_STRING_HPP_INCLUDED
#define EXO_SYNTAX_STRING_HPP_INCLUDED

#include <tuple>
#include <memory>
#include <vector>
#include <exo/syntax/base.hpp>
#include <exo/memory_space.hpp>
#include <exo/math/std_types.hpp>

namespace exo {
namespace syntax {


class cls_string : public i_rule<const char *, memory_space_const>
{
private:

    memory_space_const str;

    cls_string(const cls_string &) = delete;
    cls_string & operator=(const cls_string &) = delete;

public:

    typedef i_rule<const char *, memory_space_const> inherit_rule;
    typedef typename inherit_rule::type_iter type_iter;
    typedef typename inherit_rule::type_match type_match;
    typedef typename inherit_rule::type_result type_result;


    cls_string(cls_string && x)
    : str(x.str)
    {}

    cls_string(memory_space_const str_)
    : str(str_)
    {}

    virtual type_result _try_parse(type_iter begin, type_iter end) const override
    {
        memory_space_const input(begin, end);

        if (input.starts_with(str))
            return type_result(begin + str.size(), memory_space_const(begin, str.size()));
        else
            return type_result();
    }
};


template<class Tmatch>
class cls_string_value : public i_rule<const char *, Tmatch>
{
private:

    memory_space_const str;
    Tmatch value;

    cls_string_value(const cls_string_value &) = delete;
    cls_string & operator=(const cls_string_value &) = delete;

public:

    typedef i_rule<const char *, Tmatch> inherit_rule;
    typedef typename inherit_rule::type_iter type_iter;
    typedef typename inherit_rule::type_match type_match;
    typedef typename inherit_rule::type_result type_result;


    cls_string_value(cls_string_value && x)
    : str(x.str)
    , value(x.value)
    {}

    cls_string_value(memory_space_const str_, const Tmatch & value_)
    : str(str_)
    , value(value_)
    {}

    cls_string_value(memory_space_const str_, Tmatch && value_)
    : str(str_)
    , value(std::move(value_))
    {}

    virtual type_result _try_parse(type_iter begin, type_iter end) const override
    {
        memory_space_const input(begin, end);

        if (input.starts_with(str))
            return type_result(begin + str.size(), value);
        else
            return type_result();
    }
};


inline cls_string string(memory_space_const str)
{
    return cls_string(str);
}

template<class Tmatch>
inline cls_string_value<Tmatch> string(memory_space_const str, Tmatch value)
{
    return cls_string_value<Tmatch>(str, value);
}


} /* namespace syntax */
} /* namespace exo */

#endif // EXO_SYNTAX_STRING_HPP_INCLUDED
