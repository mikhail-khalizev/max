#ifndef EXO_LINUX_TYPES_HPP_INCLUDED
#define EXO_LINUX_TYPES_HPP_INCLUDED

#include <type_traits>

#include <exo/abstract_int.hpp>
#include <exo/math/std_types.hpp>


#ifdef linux
/* Объявлять "linux" маленькими буквами было плохой идеей. Следовало бы объявить "LINUX". */
#undef linux
#endif

namespace exo {
namespace linux {


namespace detail {

typedef typename exo::math::uint_<4 * 8>::type mode_t;
typedef typename exo::math::uint_<4 * 8>::type clockid_t;

} /* namespace detail */


typedef typename exo::math::uint_<4 * 8>::type uid_t;
typedef typename exo::math::uint_<4 * 8>::type gid_t;
typedef typename exo::math::uint_<8 * 8>::type dev_t;
typedef typename exo::math::uint_<8 * 8>::type ino_t;
typedef typename exo::math::uint_<8 * 8>::type nlink_t;

/* Не понимаю, зачем системный вызов Linux использует signed значение в качестве размера файла в системных вызовах. Исправим это. */
typedef typename exo::math::uint_<8 * 8>::type filesize_t;


#define EXO_LINUX_ENUMS_HPP_REQUIRE
#include <exo/linux/enums.hpp>
#undef EXO_LINUX_ENUMS_HPP_REQUIRE

#define T file_flags
#include <exo/util/flags.hpp>

#define T file_perm
#include <exo/util/flags.hpp>

#define T map_prot
#include <exo/util/flags.hpp>

#define T map_type
#include <exo/util/flags.hpp>


} /* namespace linux */
} /* namespace exo */

#endif /* EXO_LINUX_TYPES_HPP_INCLUDED */
