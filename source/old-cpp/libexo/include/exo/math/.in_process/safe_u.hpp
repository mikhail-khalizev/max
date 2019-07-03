#ifndef EXO_MATH_SAFE_U_HPP_INCLUDED
#define EXO_MATH_SAFE_U_HPP_INCLUDED

#include <stdexcept>
#include <exo/abstract_int.hpp>
#include <exo/math/tags.hpp>
//#include <exo/math/safe_s.hpp>
#include <exo/math/cpp_types.hpp>

namespace exo {
namespace math {


template<
    abstract_int i_bits_ = detail::pointer_bit_size /* by default - pointer size */,
    abstract_int f_bits_ = 0>
class safe_u
{
public:

    typedef typename detail::cpp_types< detail::cpp_types<i_bits_ + f_bits_>::ge_bits() >::utype type;

private:

    type val;

public:

    safe_u()
    : val(0)
    {}

    safe_u(type val_, tag_uncheck_construct)
    : val(val_)
    {}

    safe_u(typename detail::cpp_types< detail::cpp_types<i_bits_>::ge_bits() >::utype i_part)
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

    static constexpr safe_u max()
    {
        return safe_u(
                static_cast<type>(
                        (static_cast<type>(static_cast<type>(0) - 1)) >>
                        (detail::cpp_types<i_bits_ + f_bits_>::ge_bits() - bits())
                ), tag_uncheck_construct());
    }

    static constexpr safe_u min()
    {
        return safe_u();
    }


//    type get_cpp_type() const
//    {
//        return val;
//    }


    template<abstract_int i_bits1, abstract_int f_bits1>
    safe_u & operator|=(safe_u<i_bits1, f_bits1> a)
    {
        static_assert(i_bits1 <= i_bits_ && f_bits1 <= f_bits_, "Небезопасная операция.");

        if (f_bits_ == f_bits1)
            val |= a.val;
        else if (f_bits1 < f_bits_)
            val |= static_cast<type>(a.val) << (f_bits_ - f_bits1);
        else if (f_bits_ < f_bits1)
            val |= a.val >> (f_bits1 - f_bits_);

        return *this;
    }

    safe_u & operator>>=(abstract_int a)
    {
        val = static_cast<type>(val >> a);
        return *this;
    }


//    template<abstract_int i_bits1, abstract_int f_bits1>
//    static safe_u truncate_cast(safe_u<i_bits1, f_bits1> a)
//    {
//
//    }


    template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
    friend safe_u<
            i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
            f_bits1 < f_bits2 ? f_bits2     : f_bits1>
    operator+(safe_u<i_bits1, f_bits1> a, safe_u<i_bits2, f_bits2> b);

    template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
    friend safe_s<
            i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
            f_bits1 < f_bits2 ? f_bits2     : f_bits1>
    operator-(safe_u<i_bits1, f_bits1> a, safe_u<i_bits2, f_bits2> b);

    template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
    friend safe_u<
            i_bits1 + i_bits2,
            f_bits1 + f_bits2>
    operator*(safe_u<i_bits1, f_bits1> a, safe_u<i_bits2, f_bits2> b);

//    template<abstract_int bits1, abstract_int bits2>
//    friend safe_u<bits1 < bits2 ? bits2 : bits1> operator|(safe_u<bits1> a, safe_u<bits2> b);
//
//    template<abstract_int bits1, abstract_int bits2>
//    friend safe_u<bits1 < bits2 ? bits2 : bits1> operator&(safe_u<bits1> a, safe_u<bits2> b);
//
//
//    template<abstract_int bits1, abstract_int bits2>
//    friend bool operator==(safe_u<bits1> a, safe_u<bits2> b);
//
//    template<abstract_int bits1>
//    friend bool operator==(safe_u<bits1> a, abstract_int b);
//
//    template<abstract_int bits1, abstract_int bits2>
//    friend bool operator!=(safe_u<bits1> a, safe_u<bits2> b);
//
//    template<abstract_int bits1>
//    friend bool operator!=(safe_u<bits1> a, abstract_int b);
//
//    template<abstract_int bits1, abstract_int bits2>
//    friend bool operator<=(safe_u<bits1> a, safe_u<bits2> b);
};

template<abstract_int i_bits1, abstract_int f_bits1, abstract_int i_bits2, abstract_int f_bits2>
safe_u< i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
        f_bits1 < f_bits2 ? f_bits2     : f_bits1>
operator+(safe_u<i_bits1, f_bits1> a, safe_u<i_bits2, f_bits2> b)
{
    typedef safe_u<
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
safe_s< i_bits1 < i_bits2 ? i_bits2 + 1 : i_bits1 + 1,
        f_bits1 < f_bits2 ? f_bits2     : f_bits1>
operator-(safe_u<i_bits1, f_bits1> a, safe_u<i_bits2, f_bits2> b)
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
safe_u< i_bits1 + i_bits2,
        f_bits1 + f_bits2>
operator*(safe_u<i_bits1, f_bits1> a, safe_u<i_bits2, f_bits2> b)
{
    typedef safe_u<
            i_bits1 + i_bits2,
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

//template<abstract_int bits1, abstract_int bits2>
//safe_u<bits1 < bits2 ? bits2 : bits1> operator/(safe_u<bits1> a, safe_u<bits2> b)
//{
//    typedef safe_u<bits1 < bits2 ? bits2 : bits1> ret_type;
//    typedef typename ret_type::type val_type;
//
//    return ret_type(
//            static_cast<val_type>(
//                    static_cast<val_type>(a.val) /
//                    static_cast<val_type>(b.val)),
//            tag_uncheck_construct());
//}
//
//template<abstract_int bits1, abstract_int bits2>
//safe_u<bits1 < bits2 ? bits2 : bits1> operator|(safe_u<bits1> a, safe_u<bits2> b)
//{
//    typedef safe_u<bits1 < bits2 ? bits2 : bits1> ret_type;
//    typedef typename ret_type::type val_type;
//
//    return ret_type(
//            static_cast<val_type>(
//                    static_cast<val_type>(a.val) |
//                    static_cast<val_type>(b.val)),
//            tag_uncheck_construct());
//}
//
//template<abstract_int bits1, abstract_int bits2>
//safe_u<bits1 < bits2 ? bits2 : bits1> operator&(safe_u<bits1> a, safe_u<bits2> b)
//{
//    typedef safe_u<bits1 < bits2 ? bits2 : bits1> ret_type;
//    typedef typename ret_type::type val_type;
//
//    return ret_type(
//            static_cast<val_type>(
//                    static_cast<val_type>(a.val) &
//                    static_cast<val_type>(b.val)),
//            tag_uncheck_construct());
//}


//template<abstract_int bits1, abstract_int bits2>
//bool operator==(safe_u<bits1> a, safe_u<bits2> b)
//{
//    return a.val == b.val;
//}
//
//template<abstract_int bits1>
//bool operator==(safe_u<bits1> a, abstract_int b)
//{
//    if (0 <= b)
//        return a.val == static_cast<__abstract_uint>(b);
//    else
//        return false;
//}
//
//template<abstract_int bits1, abstract_int bits2>
//bool operator!=(safe_u<bits1> a, safe_u<bits2> b)
//{
//    return ! (a == b);
//}
//
//template<abstract_int bits1>
//bool operator!=(safe_u<bits1> a, abstract_int b)
//{
//    return ! (a == b);
//}
//
//template<abstract_int bits1, abstract_int bits2>
//bool operator<=(safe_u<bits1> a, safe_u<bits2> b)
//{
//    return a.val <= b.val;

//}

} /* namespace math */
} /* namespace exo */

#endif /* EXO_MATH_SAFE_U_HPP_INCLUDED */
