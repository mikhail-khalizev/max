#ifndef EXO_SYNTAX_REPEAT_HPP_INCLUDED
#define EXO_SYNTAX_REPEAT_HPP_INCLUDED

#include <tuple>
#include <memory>
#include <vector>
#include <exo/syntax/base.hpp>
#include <exo/memory_space.hpp>
#include <exo/math/std_types.hpp>

namespace exo {
namespace syntax {


namespace detail {


/**
 * Определяет тип возвращаемого значения (match) правила sequence.
 */
template<class Trule>
class repeat_match_determine
{
private:

    typedef typename std::remove_reference<Trule>::type orig_type;
    typedef typename orig_type::type_match orig_type_match;

public:

    static constexpr bool is_void = std::is_same<void, orig_type_match>::value;

    typedef typename std::conditional<
        is_void,
        void,
        std::vector<orig_type_match>
    >::type type_match;

    typedef typename orig_type::type_iter type_iter;
};


template<class type_match>
struct repeat_helper
{
    template<class type_result, class type_iter, class type_rule>
    static  type_result try_parse(type_iter begin_, type_iter end, int min, int max, type_rule & rule)
    {
        int count = 0;
        type_iter begin = begin_;
        type_match match;


        for (; count < max;)
        {
            auto res = rule.try_parse(begin, end);
            if (!res.success)
                break;

            if (begin == res.begin && min <= count)
                break;

            count++;
            begin = res.begin;
            match.push_back(std::move(res.match));
        }


        if (min <= count && count <= max)
            return type_result(begin, std::move(match));
        else
            return type_result();
    }
};

template<>
struct repeat_helper<void>
{
    template<class type_result, class type_iter, class type_rule>
    static type_result try_parse(type_iter begin_, type_iter end, int min, int max, type_rule & rule)
    {
        int count = 0;
        type_iter begin = begin_;

        for (; count < max;)
        {
            auto res = rule.try_parse(begin, end);
            if (!res.success)
                break;

            if (begin == res.begin && min <= count)
                break;

            count++;
            begin = res.begin;
        }

        if (min <= count && count <= max)
            return type_result(begin);
        else
            return type_result();
    }
};


template<class Trule, class Tmatch = typename detail::repeat_match_determine<Trule>::type_match>
class repeat : public i_rule<typename detail::repeat_match_determine<Trule>::type_iter, Tmatch>
{
private:

    Trule rule;
    int min;
    int max;

    repeat(const repeat &) = delete;
    repeat & operator=(const repeat &) = delete;

public:

    typedef i_rule<typename detail::repeat_match_determine<Trule>::type_iter, Tmatch> inherit_rule;
    typedef typename inherit_rule::type_iter type_iter;
    typedef typename inherit_rule::type_match type_match;
    typedef typename inherit_rule::type_result type_result;


    repeat(repeat && x)
    : rule(std::forward<Trule &&>(x.rule))
    , min(x.min)
    , max(x.max)
    {}

    repeat(Trule && rule_, int min_, int max_)
    : rule(std::forward<Trule &&>(rule_))
    , min(min_)
    , max(max_)
    {}

    virtual type_result _try_parse(type_iter begin, type_iter end) const override
    {
        return detail::repeat_helper<type_match>::template try_parse<type_result>(begin, end, min, max, rule);
    }
};

} /* namespace detail */


template<class Trule>
detail::repeat<Trule> repeat(Trule && rule, int min = 0, int max = math::sint_<32>::max())
{
    return detail::repeat<Trule>(std::forward<Trule>(rule), min, max);
}


} /* namespace syntax */
} /* namespace exo */

#endif /* EXO_SYNTAX_REPEAT_HPP_INCLUDED */
