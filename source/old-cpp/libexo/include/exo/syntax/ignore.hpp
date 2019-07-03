#ifndef EXO_SYNTAX_IGNORE_HPP_INCLUDED
#define EXO_SYNTAX_IGNORE_HPP_INCLUDED

#include <tuple>
#include <memory>
#include <vector>
#include <exo/syntax/base.hpp>
#include <exo/memory_space.hpp>
#include <exo/math/std_types.hpp>

namespace exo {
namespace syntax {


template<class Titer, class Trule>
class ignore : public i_rule<Titer, void>
{
private:

    const Trule & rule;

    ignore(const ignore &) = delete;
    ignore & operator=(const ignore &) = delete;

public:

    typedef i_rule<Titer, void> inherit_rule;
    typedef typename inherit_rule::type_iter type_iter;
    typedef typename inherit_rule::type_match type_match;
    typedef typename inherit_rule::type_result type_result;


    ignore(const Trule & rule_)
    : rule(rule_)
    {}

    ignore(ignore && x)
    : rule(x.rule)
    {}

    virtual type_result _try_parse(type_iter begin, type_iter end) const override
    {
        auto res = rule.try_parse(begin, end);

        type_result ret;
        ret.success = res.success;
        ret.begin = res.begin;
        return ret;
    }
};


template<class Trule>
ignore<typename Trule::type_iter, Trule> make_ignore(const Trule & rule)
{
    return ignore<typename Trule::type_iter, Trule>(rule);
}


} /* namespace syntax */
} /* namespace exo */

#endif // EXO_SYNTAX_IGNORE_HPP_INCLUDED
