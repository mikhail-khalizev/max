#ifndef EXO_FORMAT_HEADER_FAT_DIRECTORY_ENTRY_HPP_INCLUDED
#define EXO_FORMAT_HEADER_FAT_DIRECTORY_ENTRY_HPP_INCLUDED

#include <exo/attributes.hpp>
#include <exo/format_header/fat/types.hpp>

namespace exo {
namespace format_header {
namespace fat {


const u32 max_directory_size = 65536 * 32; // bytes
const u32 max_long_name_characters = 255; // not including the trailing NUL
const u32 max_total_path_length_characters = 260; // including the trailing NUL


namespace detail {

struct short_directory_entry
{
    char dir_name[11];
    u8 dir_attr : 6;
    u8 dir_attr_reserved : 2;
    u8 dir_nt_res;
    u8 dir_crt_time_tenth;
    u16 dir_crt_time;
    u16 dir_crt_date;
    u16 dir_lst_acc_date;
    u16 dir_fst_clus_hi;
    u16 dir_wrt_time;
    u16 dir_wrt_date;
    u16 dir_fst_clus_lo;
    u32 dir_file_size;
} __attribute_packed__;

static_assert(sizeof(short_directory_entry) == 32, "Компилятор неправильно упаковал структуру.");


struct long_directory_entry
{
    u8 ldir_ord;
    char ldir_name1[10];
    u8 ldir_attr : 6;
    u8 dir_attr_reserved : 2;
    u8 ldir_type;
    u8 ldir_chksum;
    char ldir_name2[12];
    u16 ldir_fst_clus_lo;
    char ldir_name3[4];
} __attribute_packed__;

static_assert(sizeof(long_directory_entry) == 32, "Компилятор неправильно упаковал структуру.");

} /* namespace detail */


enum class attr : u8
{
    read_only = 0x01,
    hidden = 0x02,
    system = 0x04,
    volume_id = 0x08,
    directory = 0x10,
    archive = 0x20,
    long_name = read_only | hidden | system | volume_id

    /* if ((attr & (attr::directory | attr::volume_id)) == (attr::directory | attr::volume_id))
     *         Found an invalid directory entry. (is short entry). */
};

#define T attr
#include <exo/util/flags.hpp>


struct directory_entry
{
    union
    {
        detail::short_directory_entry s;
        detail::long_directory_entry l;
    };


    /* worked at any: short or long. */

    bool is_free_entry() const
    {
        return (static_cast<u8>(s.dir_name[0]) == 0xe5);
    }

    /** there are no allocated directory entries after this one. */
    bool is_free_and_last_entry() const
    {
        return (s.dir_name[0] == 0x00);
    }

    attr get_attr() const
    {
        return static_cast<attr>(s.dir_attr);
    }


    /* Worked at short. */

    u32 get_first_cluster() const
    {
        u32 ret = s.dir_fst_clus_hi;
        ret <<= 16;
        ret |= s.dir_fst_clus_lo;
        return ret;
    }

    // @note dir_name[0] == 0x05 replace to 0xe5 for file name.
} __attribute_packed__;

static_assert(sizeof(directory_entry) == 32, "Компилятор неправильно упаковал структуру.");


} /* namespace fat */
} /* namespace format_header */
} /* namespace exo */

#endif /* EXO_FORMAT_HEADER_FAT_DIRECTORY_ENTRY_HPP_INCLUDED */
