#ifndef NAME_CLASS_1
#    warning NAME_CLASS_1 not defined. Skip.
#else

#define TYPE(T)    \
    template<abstract_int bits_2>    \
    inline constexpr auto operator OP(const signed T & a, const NAME_CLASS_1<bits_2> & b) -> decltype( NAME_CLASS_S<8 * sizeof(signed T)>(a).operator OP <bits_2>(b) )    \
    { return NAME_CLASS_S< 8 * sizeof(signed T) >(a) OP b; }    \
    \
    template<abstract_int bits_2>    \
    inline constexpr auto operator OP(const NAME_CLASS_1<bits_2> & a, const signed T & b) -> decltype( a.operator OP <8 * sizeof(signed T)>(NAME_CLASS_S< 8 * sizeof(signed T) >(b)) )    \
    { return a OP NAME_CLASS_S< 8 * sizeof(signed T) >(b); }    \
    \
    template<abstract_int bits_2>    \
    inline constexpr auto operator OP(const unsigned T & a, const NAME_CLASS_1<bits_2> & b) -> decltype( NAME_CLASS_U<8 * sizeof(unsigned T)>(a).operator OP <bits_2>(b) )    \
    { return NAME_CLASS_U< 8 * sizeof(unsigned T) >(a) OP b; }    \
    \
    template<abstract_int bits_2>    \
    inline constexpr auto operator OP(const NAME_CLASS_1<bits_2> & a, const unsigned T & b) -> decltype( a.operator OP <8 * sizeof(unsigned T)>(NAME_CLASS_U< 8 * sizeof(unsigned T) >(b)) )    \
    { return a OP NAME_CLASS_U< 8 * sizeof(unsigned T) >(b); }

#define OP +
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP -
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP *
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP /
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP %
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP &
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP |
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP ^
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP <<
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP >>
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP ==
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP !=
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP >
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP <
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP >=
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP <=
#include <exo/math/cxx_types_int.hpp>
#undef OP
#undef TYPE
#undef MYSELF

#endif
