#ifndef EXO_MATH_SAFE_S_HPP_INCLUDED
#define EXO_MATH_SAFE_S_HPP_INCLUDED

#include <stdexcept>
#include <exo/abstract_int.hpp>
#include <exo/math/tags.hpp>
#include <exo/math/cpp_types.hpp>

namespace exo {
namespace math {


/** @todo Написать комментарий получше.
 * расширяемые (т.е. без потери точности)
 * дробные с фиксированной точкой.
 */
template<
    abstract_int i_bits_ = detail::pointer_bit_size /* by default - pointer size */,
    abstract_int f_bits_ = 0>
class safe_s
{
public:

    typedef typename detail::cpp_types< detail::cpp_types<i_bits_ + f_bits_>::ge_bits() >::stype type;

private:

    type val;

public:

    safe_s()
    : val(0)
    {}

    safe_s(type val_, tag_uncheck_construct)
    : val(val_)
    {}

    safe_s(typename detail::cpp_types< detail::cpp_types<i_bits_>::ge_bits() >::stype i_part)
    : val(static_cast<type>(i_part) << f_bits_)
    {
        if (max().val < val || val < min().val)
            throw std::invalid_argument("Выход за пределы допустимого диапазона.");
    }


    static constexpr abstract_int bits()
    {
        return i_bits_ + f_bits_;
    }

    static constexpr abstract_int i_bits()
    {
        return i_bits_;
    }

    static constexpr abstract_int f_bits()
    {
        return f_bits_;
    }

    static constexpr safe_s max()
    {
        return safe_s(
                static_cast<type>(
                        (
                                static_cast<type>(1) <<
                                (bits() - 1)
                        ) - 1
                ), tag_uncheck_construct());
    }

    static constexpr safe_s min()
    {
        return safe_s(
                static_cast<type>(
                        (static_cast<type>(static_cast<type>(0) - 1)) <<
                        (bits() - 1)
                ), tag_uncheck_construct());
    }


//    type get_cpp_type() const
//    {
//        return val;
//    }


    safe_s & operator>>=(abstract_int a)
    {
        val = static_cast<type>(val >> a);
        return *this;
    }


    template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
    friend safe_s<
            i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
            f_bits1 < f_bits2 ? f_bits2     : f_bits1>
    operator+(safe_s<i_bits1, f_bits1> a, safe_s<i_bits2, f_bits2> b);

    template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
    friend safe_s<
            i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
            f_bits1 < f_bits2 ? f_bits2     : f_bits1>
    operator-(safe_s<i_bits1, f_bits1> a, safe_s<i_bits2, f_bits2> b);

    template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
    friend safe_s<
            i_bits1 + i_bits2 - 1,
            f_bits1 + f_bits2>
    operator*(safe_s<i_bits1, f_bits1> a, safe_s<i_bits2, f_bits2> b);
};

template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
safe_s<    i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
        f_bits1 < f_bits2 ? f_bits2     : f_bits1>
operator+(safe_s<i_bits1, f_bits1> a, safe_s<i_bits2, f_bits2> b)
{
    typedef safe_s<
            i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
            f_bits1 < f_bits2 ? f_bits2     : f_bits1>
    ret_type;

    typedef typename ret_type::type val_type;

    if (f_bits2 <= f_bits1)
        return ret_type(
                static_cast<val_type>(
                        static_cast<val_type>(a.val) +
                        (static_cast<val_type>(b.val) << (f_bits1 - f_bits2))),
                tag_uncheck_construct());
    else
        return ret_type(
                static_cast<val_type>(
                        (static_cast<val_type>(a.val) << (f_bits2 - f_bits1)) +
                        static_cast<val_type>(b.val)),
                tag_uncheck_construct());
}

template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
safe_s<    i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
        f_bits1 < f_bits2 ? f_bits2     : f_bits1>
operator-(safe_s<i_bits1, f_bits1> a, safe_s<i_bits2, f_bits2> b)
{
    typedef safe_s<
            i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
            f_bits1 < f_bits2 ? f_bits2     : f_bits1>
    ret_type;

    typedef typename ret_type::type val_type;

    if (f_bits2 <= f_bits1)
        return ret_type(
                static_cast<val_type>(
                        static_cast<val_type>(a.val) -
                        (static_cast<val_type>(b.val) << (f_bits1 - f_bits2))),
                tag_uncheck_construct());
    else
        return ret_type(
                static_cast<val_type>(
                        (static_cast<val_type>(a.val) << (f_bits2 - f_bits1)) -
                        static_cast<val_type>(b.val)),
                tag_uncheck_construct());
}

template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
safe_s<    i_bits1 + i_bits2 - 1,
        f_bits1 + f_bits2>
operator*(safe_s<i_bits1, f_bits1> a, safe_s<i_bits2, f_bits2> b)
{
    typedef safe_s<
            i_bits1 + i_bits2 - 1,
            f_bits1 + f_bits2>
    ret_type;

    typedef typename ret_type::type val_type;

    if (f_bits2 <= f_bits1)
        return ret_type(
                static_cast<val_type>(
                        static_cast<val_type>(a.val) *
                        (static_cast<val_type>(b.val) << (f_bits1 - f_bits2))),
                tag_uncheck_construct());
    else
        return ret_type(
                static_cast<val_type>(
                        (static_cast<val_type>(a.val) << (f_bits2 - f_bits1)) *
                        static_cast<val_type>(b.val)),
                tag_uncheck_construct());
}


} /* namespace math */
} /* namespace exo */

#endif /* EXO_MATH_SAFE_S_HPP_INCLUDED */
