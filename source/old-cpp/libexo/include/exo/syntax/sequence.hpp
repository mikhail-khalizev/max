#ifndef EXO_SYNTAX_SEQUENCE_HPP_INCLUDED
#define EXO_SYNTAX_SEQUENCE_HPP_INCLUDED

#include <tuple>
#include <memory>
#include <vector>
#include <exo/syntax/base.hpp>
#include <exo/memory_space.hpp>
#include <exo/math/std_types.hpp>
#include <exo/util/type_helper.hpp>

namespace exo {
namespace syntax {


namespace detail {


/**
 * Определяет тип возвращаемого значения (match) правила sequence.
 */
template<class ...Trules>
class sequence_match_determine
{
private:

    typedef typename util::tuple_skip_void_helper<typename Trules::type_match...>::type __tuple_type;

public:

    static constexpr bool is_tuple = (util::tuple_size_helper<__tuple_type>::value != 0);

    typedef typename std::conditional<
        is_tuple,
        __tuple_type,
        void
    >::type type;
};


template<std::size_t Count, std::size_t N, std::size_t R, bool result_match_is_tuple, class Tmatch>
struct sequence_helper3;

template<std::size_t Count, std::size_t N, std::size_t R, bool result_match_is_tuple, class type_iter, class type_match, class Ttuple, class Tres>
static std::tuple<bool /* success */, type_iter> sequence_try_parse3(type_iter begin, type_iter end, type_match & result_match, const Ttuple & rules, const Tres & res)
{
    return sequence_helper3<Count, N, R, result_match_is_tuple, typename Tres::type_match>::try_parse2(begin, end, result_match, rules, res);
}


template<std::size_t Count, std::size_t N, std::size_t R, bool result_match_is_tuple>
struct sequence_helper2
{
    template<class type_iter, class type_match, class Ttuple>
    static std::tuple<bool /* success */, type_iter> try_parse(type_iter begin, type_iter end, type_match & result_match, const Ttuple & rules)
    {
        auto res = std::get<N>(rules) -> try_parse(begin, end);
        return sequence_try_parse3<Count, N, R, result_match_is_tuple>(begin, end, result_match, rules, res);
    }
};

template<std::size_t Count, std::size_t R, bool result_match_is_tuple>
struct sequence_helper2<Count, Count, R, result_match_is_tuple>
{
    template<class type_iter, class type_match, class Ttuple>
    static std::tuple<bool /* success */, type_iter> try_parse(type_iter begin, type_iter, type_match &, const Ttuple &)
    {
        return std::tuple<bool /* success */, type_iter>(true, begin);
    }
};


template<std::size_t Count, std::size_t N, std::size_t R, bool result_match_is_tuple, class Tmatch>
struct sequence_helper3
{
    template<class type_iter, class type_match, class Ttuple, class Tres>
    static std::tuple<bool /* success */, type_iter> try_parse2(type_iter begin, type_iter end, type_match & result_match, const Ttuple & rules, const Tres & res)
    {
        if (!res.success)
            return std::pair<bool /* success */, type_iter>(false, begin);

        std::get<R>(result_match) = std::move(res.match);
        return sequence_helper2<Count, N + 1, R + 1, result_match_is_tuple>::try_parse(res.begin, end, result_match, rules);
    }
};

template<std::size_t Count, std::size_t N, std::size_t R, bool result_match_is_tuple>
struct sequence_helper3<Count, N, R, result_match_is_tuple, void>
{
    template<class type_iter, class type_match, class Ttuple, class Tres>
    static std::tuple<bool /* success */, type_iter> try_parse2(type_iter, type_iter end, type_match & result_match, const Ttuple & rules, const Tres & res)
    {
        return sequence_helper2<Count, N + 1, R, result_match_is_tuple>::try_parse(res.begin, end, result_match, rules);
    }
};


template<class type_match, class type_result, class ...Trules>
struct sequence_helper
{
    template<class type_iter, class Ttuple>
    static type_result try_parse(type_iter begin, type_iter end, const Ttuple & rules)
    {
        type_match match;
        auto res = sequence_helper2<sizeof...(Trules), 0, 0, detail::sequence_match_determine<Trules...>::is_tuple>::try_parse(begin, end, match, rules);

        if (std::get<0>(res))
            return type_result(std::get<1>(res), std::move(match));
        else
            return type_result();
    }
};

template<class type_result, class ...Trules>
struct sequence_helper<void, type_result, Trules...>
{
    template<class type_iter, class Ttuple>
    static type_result try_parse(type_iter begin, type_iter end, const Ttuple & rules)
    {
        void * dummy;
        auto res = sequence_helper2<sizeof...(Trules), 0, 0, detail::sequence_match_determine<Trules...>::is_tuple>::try_parse(begin, end, dummy, rules);

        if (std::get<0>(res))
            return type_result(std::get<1>(res));
        else
            return type_result();
    }
};


} /* namespace detail */


template<class Titer, class ...Trules>
class sequence : public i_rule<Titer, typename detail::sequence_match_determine<Trules...>::type>
{
private:

    std::tuple<const Trules * ...> rules;

    sequence(const sequence &) = delete;
    sequence & operator=(const sequence &) = delete;

public:

    typedef i_rule<Titer, typename detail::sequence_match_determine<Trules...>::type> inherit_rule;
    typedef typename inherit_rule::type_iter type_iter;
    typedef typename inherit_rule::type_match type_match;
    typedef typename inherit_rule::type_result type_result;


    sequence(sequence && x)
    : rules(std::move(x.rules))
    {}

    sequence(const Trules & ... rules_)
    : rules(&rules_...)
    {}

    sequence(std::tuple<const Trules * ...> && rules_)
    : rules(std::move(rules_))
    {}


    virtual type_result _try_parse(type_iter begin, type_iter end) const override
    {
        return detail::sequence_helper<type_match, type_result, Trules...>::try_parse(begin, end, rules);
    }

private:

#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Weffc++"

    template<class Titer2, class Trule2, class ...Trules2>
    friend sequence<Titer2, Trules2..., Trule2> operator>>(sequence<Titer2, Trules2...> && master, const Trule2 & slave);
};


template<class Titer, class Trule, class ...Trules>
sequence<Titer, Trules..., Trule> operator>>(sequence<Titer, Trules...> && master, const Trule & slave)
{
    return sequence<Titer, Trules..., Trule>(std::move(std::tuple_cat(master.rules, std::tuple<const Trule *>(&slave))));
}

template<class Trule1, class Trule2>
sequence<typename Trule1::type_iter, Trule1, Trule2> operator>>(const Trule1 & rule1, const Trule2 & rule2)
{
    return sequence<typename Trule1::type_iter, Trule1, Trule2>(rule1, rule2);
}

#pragma GCC diagnostic pop


} /* namespace syntax */
} /* namespace exo */

#endif // EXO_SYNTAX_SEQUENCE_HPP_INCLUDED
