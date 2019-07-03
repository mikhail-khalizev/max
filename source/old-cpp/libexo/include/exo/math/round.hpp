#ifndef EXO_MATH_ROUND_HPP_INCLUDED
#define EXO_MATH_ROUND_HPP_INCLUDED

namespace exo {
namespace math {


// @todo Округлаять только стандартные целые и свои  uint sint ?
// @todo Добавить round_up_to_pow_of_2

template <typename T>
constexpr T round_up(T value, T step)
{
    return ((value + step - 1) / step) * step;
}

template <typename T>
constexpr T round_down(T value, T step)
{
    return (value / step) * step;
}


} /* namespace math */
} /* namespace exo */

#endif /* EXO_MATH_ROUND_HPP_INCLUDED */
