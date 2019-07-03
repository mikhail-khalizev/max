#ifndef EXO_UTIL_IMPLICIT_CAST_HPP_INCLUDED
#define EXO_UTIL_IMPLICIT_CAST_HPP_INCLUDED

namespace exo {
namespace util {


template <class OutputClass, class InputClass>
inline OutputClass implicit_cast(InputClass input)
{
    return input;
}


} /* namespace util */
} /* namespace exo */

#endif /* EXO_UTIL_IMPLICIT_CAST_HPP_INCLUDED */
