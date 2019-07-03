#ifndef EXO_UTIL_COUNT_OF_HPP_INCLUDED
#define EXO_UTIL_COUNT_OF_HPP_INCLUDED

#include <exo/abstract_int.hpp>

namespace exo {
namespace util {


template <typename T, abstract_int N>
constexpr abstract_int count_of(T (&)[N])
{
    return N;
}


} /* namespace util */
} /* namespace exo */

#endif /* EXO_UTIL_COUNT_OF_HPP_INCLUDED */
