#ifndef EXO_MATH_SQRT_HPP_INCLUDED
#define EXO_MATH_SQRT_HPP_INCLUDED

#include <exo/attributes.hpp>
#include <exo/math/safe.hpp>

namespace exo {
namespace math {


#if 0
template<abstract_int bits1, abstract_int bits2>
safe_u<(bits1 + 1) / 2> sqrt(
        safe_u<bits1> in,
        const safe_u<bits2> & /* ret type */,
        round_down) __attribute_warn_unused_result__;

template<abstract_int bits1, abstract_int bits2>
safe_u<(bits1 + 1) / 2> sqrt(
        safe_u<bits1> in,
        const safe_u<bits2> & /* ret type */,
        round_down)
{
    typedef safe_u<bits1> in_type;
    typedef safe_u<(bits1 + 1) / 2> ret_type;

    /* 1) bits - чётное
     *    sqrt -> bits / 2
     * 2) bits - нечётное
     *    sqrt -> bits / 2 + 1
     */

    ret_type ret;

    ret_type step(
            static_cast<typename ret_type::type>(ret_type::max() - (ret_type::max() >> 1)),
            tag_uncheck_construct());

    /** square = (ret | step) ^ 2 */
    in_type square(
            static_cast<typename in_type::type>(
                static_cast<typename in_type::type>(ret_type::max() - (ret_type::max() >> 1)) *
                static_cast<typename in_type::type>(ret_type::max() - (ret_type::max() >> 1))),
            tag_uncheck_construct());

    do
    {
        if (square <= in)
            ret |= step;

        step >>= 1;
        square = (ret | step) * (ret | step);
    } while (step != 0);

    return ret;
}
#endif


} /* namespace math */
} /* namespace exo */

#endif /* EXO_MATH_SQRT_HPP_INCLUDED */
