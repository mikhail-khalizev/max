#ifndef EXO_SYNTAX_BASE_HPP_INCLUDED
#define EXO_SYNTAX_BASE_HPP_INCLUDED

#include <tuple>
#include <memory>
#include <vector>
#include <exo/memory_space.hpp>
#include <exo/abstract_base.hpp>
#include <exo/math/std_types.hpp>

namespace exo {
namespace syntax {


template<class Titer, class Tmatch>
class rule_result
{
private:

    rule_result(const rule_result &) = delete;
    rule_result & operator=(const rule_result &) = delete;

public:

    typedef Titer type_iter;
    typedef Tmatch type_match;


    bool success;
    Titer begin;
    Tmatch match;

    rule_result()
    : success(false)
    , begin()
    , match()
    {}

    rule_result(rule_result && x)
    : success(false)
    , begin(x.begin)
    , match(std::move(x.match))
    {}

    rule_result(Titer begin_, const Tmatch & match_)
    : success(true)
    , begin(begin_)
    , match(match_)
    {}

    rule_result(Titer begin_, Tmatch && match_)
    : success(true)
    , begin(begin_)
    , match(std::move(match_))
    {}

    rule_result & operator=(rule_result && x)
    {
        success = x.success;
        begin = x.begin;
        match = std::move(x.match);
        return * this;
    }
};

template<class Titer>
class rule_result<Titer, void>
{
private:

    rule_result(const rule_result &) = delete;
    rule_result & operator=(const rule_result &) = delete;

public:

    typedef Titer type_iter;
    typedef void type_match;


    bool success;
    Titer begin;

    rule_result()
    : success(false)
    , begin()
    {}

    rule_result(rule_result && x)
    : success(false)
    , begin(x.begin)
    {}

    rule_result(Titer begin_)
    : success(true)
    , begin(begin_)
    {}

    rule_result & operator=(rule_result && x)
    {
        success = x.success;
        begin = x.begin;
        return * this;
    }
};


template<class Titer, class Tmatch>
class i_rule : public abstract_base
{
public:

    typedef Titer type_iter;
    typedef Tmatch type_match;
    typedef rule_result<Titer, Tmatch> type_result;

    type_result try_parse(type_iter begin, type_iter end) const
    {
        return _try_parse(begin, end);
    }

protected:

    virtual type_result _try_parse(type_iter begin, type_iter end) const = 0;
};


} /* namespace syntax */
} /* namespace exo */

#endif // EXO_SYNTAX_BASE_HPP_INCLUDED
