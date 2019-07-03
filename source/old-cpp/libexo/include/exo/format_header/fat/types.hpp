#ifndef EXO_FORMAT_HEADER_FAT_TYPES_HPP_INCLUDED
#define EXO_FORMAT_HEADER_FAT_TYPES_HPP_INCLUDED

#include <exo/math/std_types.hpp>

namespace exo {
namespace format_header {
namespace fat {


typedef typename math::uint_<8>::type  u8;
typedef typename math::uint_<16>::type u16;
typedef typename math::uint_<32>::type u32;
typedef typename math::uint_<64>::type u64;


enum class fs_type
{
    fat_12,
    fat_16,
    fat_32
};


} /* namespace fat */
} /* namespace format_header */
} /* namespace exo */

#endif /* EXO_FORMAT_HEADER_FAT_TYPES_HPP_INCLUDED */
