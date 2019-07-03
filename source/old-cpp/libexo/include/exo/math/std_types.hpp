#ifndef EXO_MATH_STD_TYPES_HPP_INCLUDED
#define EXO_MATH_STD_TYPES_HPP_INCLUDED

#include <limits>
#include <type_traits>
#include <exo/abstract_int.hpp>

namespace exo {
namespace math {


/**
    В данном файле определены следующие классы:

    Наименьшее большее или равно.
      sint_ge <abstract_int bits>
      uint_ge <abstract_int bits>

    Точное совпадение.
      sint_ <abstract_int bits>
      uint_ <abstract_int bits>

    Оптимальный.
      sint_o <abstract_int bits>
      uint_o <abstract_int bits>

    По размеру указателя.
      uint_pointer
      sint_pointer


    Переопределены std::numeric_limits для объявленных классов.

 */


#define TYPE_COMPARE(a, b)  ((a) <= (b))
#define NAME_CLASS_S        sint_ge
#define NAME_CLASS_U        uint_ge
#include <exo/math/detail/int_double.hpp>
#undef NAME_CLASS_U
#undef NAME_CLASS_S
#undef TYPE_COMPARE

#define TYPE_COMPARE(a, b)  ((a) == (b))
#define NAME_CLASS_S        sint_
#define NAME_CLASS_U        uint_
#include <exo/math/detail/int_double.hpp>
#undef NAME_CLASS_U
#undef NAME_CLASS_S
#undef TYPE_COMPARE

typedef uint_<8 * sizeof(void*)> uint_pointer;
typedef sint_<8 * sizeof(void*)> sint_pointer;

#define TYPE_COMPARE(a, b)  ((a < (8 * sizeof(int)) ? (8 * sizeof(int)) : a) <= (b))
#define NAME_CLASS_S        sint_o
#define NAME_CLASS_U        uint_o
#include <exo/math/detail/int_double.hpp>
#undef NAME_CLASS_U
#undef NAME_CLASS_S
#undef TYPE_COMPARE


#if 0
template<abstract_int bits_,
    abstract_int mantissa_ = (bits_ == 16) ? 10 : (bits_ == 32) ? 23 : (bits_ == 64) ? 52 : (bits_ == 80) ? 63 : (bits_ == 128) ? 112 : 0 /* unknown */,
    abstract_int exponent_ = (bits_ == 16) ?  5 : (bits_ == 32) ?  8 : (bits_ == 64) ? 11 : (bits_ == 80) ? 15 : (bits_ == 128) ?  15 : 0 /* unknown */ >
class float_ge
{
    template<typename T>
    static constexpr abstract_int mantissa_length(abstract_int cur_len = -1, T div = 1)
    {
        return (T(1) + div == T(1)) ?
                cur_len :
                mantissa_length<T>(cur_len + 1, div / 2);
    }

    template<typename T>
    static constexpr abstract_int exponent_length(abstract_int cur_len = 1, T div = 2)
    {
        return (div * div == div) ?
                cur_len :
                exponent_length<T>(cur_len + 1, div * div);
    }


    typedef
#define TYPE(T)  typename std::conditional<mantissa_ <= mantissa_length<T>(), T,
#include <exo/math/cxx_types_float.hpp>
#undef TYPE
                /* fail */ float
#define TYPE(T)  >::type
#include <exo/math/cxx_types_float.hpp>
#undef TYPE
            type_mantissa;

    typedef
#define TYPE(T)  typename std::conditional<exponent_ <= exponent_length<T>(), T,
#include <exo/math/cxx_types_float.hpp>
#undef TYPE
                /* fail */ float
#define TYPE(T)  >::type
#include <exo/math/cxx_types_float.hpp>
#undef TYPE
            type_exponent;


    static_assert(mantissa_ <= mantissa_length<type_mantissa>()
            && exponent_ <= exponent_length<type_exponent>()
            && std::is_same<type_mantissa, type_exponent>::value,
            "Данная размерность не поддерживается.");

public:

    typedef type_mantissa type;


    static constexpr abstract_int bits_mantissa()
    {
        return mantissa_length<type>();
    }

    static constexpr abstract_int bits_exponent()
    {
        return exponent_length<type>();
    }


    type get() const
    {
        return val;
    }

private:

    type val;
};


//class float_ : public float_ge


int main()
{
    std::cout << mantissa_length<float>() << ' ' << exponent_length<float>() << std::endl;
    std::cout << mantissa_length<double>() << ' ' << exponent_length<double>() << std::endl;
    std::cout << mantissa_length<__float80>() << ' ' << exponent_length<__float80>() << std::endl;
    std::cout << mantissa_length<long double>() << ' ' << exponent_length<long double>() << std::endl;
    std::cout << mantissa_length<__float128>() << ' ' << exponent_length<__float128>() << std::endl;
    return 0;
}
#endif


} /* namespace math */
} /* namespace exo */


namespace std {

#pragma GCC diagnostic push
/* У базового класса нет виртуального деструктора,
 * но в данном случае он нам и не нужен. Так что отключаем
 * соответствующее предупреждение компилятора. */
#pragma GCC diagnostic ignored "-Weffc++"


template<exo::abstract_int bits_>
struct numeric_limits<exo::math::uint_<bits_>>
: public numeric_limits<typename exo::math::uint_<bits_>::type>
{};

template<exo::abstract_int bits_>
struct numeric_limits<exo::math::sint_<bits_>>
: public numeric_limits<typename exo::math::sint_<bits_>::type>
{};


#pragma GCC diagnostic pop

} /* namespace std */


#endif /* EXO_MATH_STD_TYPES_HPP_INCLUDED */

