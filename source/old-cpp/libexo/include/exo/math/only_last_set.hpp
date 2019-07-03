#ifndef EXO_MATH_ONLY_LAST_SET_HPP_INCLUDED
#define EXO_MATH_ONLY_LAST_SET_HPP_INCLUDED

namespace exo {
namespace math {


template<typename T>
T only_last_set(T in)
{
    T work = in; // work = '0000 1 ????' in binary.

    for (unsigned n = 1; n < sizeof(T) * 8u; n *= 2)
        work = work | (work >> n);

    // now work = '0000 1 1111'.

    return work ^ (work >> 1); // return '0000 1 0000'.
}


} /* namespace math */
} /* namespace exo */

#endif /* EXO_MATH_ONLY_LAST_SET_HPP_INCLUDED */
