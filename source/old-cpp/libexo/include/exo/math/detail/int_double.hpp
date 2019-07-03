#ifndef NAME_CLASS_S
#    warning NAME_CLASS_S not defined. Skip.
#else


template<abstract_int bits_>
class NAME_CLASS_S;


#define NAME_CLASS_1   NAME_CLASS_U
#define NAME_CLASS_2   NAME_CLASS_S
#define SIGNED_TYPE    unsigned
#include <exo/math/detail/int_single_class.hpp>
#undef SIGNED_TYPE
#undef NAME_CLASS_1
#undef NAME_CLASS_2

#define NAME_CLASS_1   NAME_CLASS_S
#define NAME_CLASS_2   NAME_CLASS_U
#define SIGNED_TYPE    signed
#include <exo/math/detail/int_single_class.hpp>
#undef SIGNED_TYPE
#undef NAME_CLASS_1
#undef NAME_CLASS_2


#define NAME_CLASS_1   NAME_CLASS_U
#define NAME_CLASS_2   NAME_CLASS_S
#define SIGNED_TYPE    unsigned
#include <exo/math/detail/int_single_bop.hpp>
#undef SIGNED_TYPE
#undef NAME_CLASS_1
#undef NAME_CLASS_2

#define NAME_CLASS_1   NAME_CLASS_S
#define NAME_CLASS_2   NAME_CLASS_U
#define SIGNED_TYPE    signed
#include <exo/math/detail/int_single_bop.hpp>
#undef SIGNED_TYPE
#undef NAME_CLASS_1
#undef NAME_CLASS_2


#endif
