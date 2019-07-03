#ifndef EXO_FORMAT_HEADER_FAT_BOOT_SECTOR_HPP_INCLUDED
#define EXO_FORMAT_HEADER_FAT_BOOT_SECTOR_HPP_INCLUDED

#include <iterator> // for std::begin, std::end
#include <stdexcept>

#include <exo/exception.hpp>
#include <exo/attributes.hpp>

#include <exo/format_header/fat/types.hpp>


namespace exo {
namespace format_header {
namespace fat {


namespace detail {

struct boot_sector_strip_part2_fat_12_16
{
    u8  bs_drv_num;
//private:    // иначе не POD и gcc игнорирует __attribute_packed__
    u8  bs_reserved_1;
//public:
    u8  bs_boot_sig;
    u32 bs_vol_id;
    u8  bs_vol_lab[11];
    u8  bs_fil_sys_type[8];
} __attribute_packed__;

static_assert(sizeof(boot_sector_strip_part2_fat_12_16) == 26, "Компилятор неправильно упаковал структуру.");


struct boot_sector_strip_part2_fat_32
{
    u32 bpb_fat_sz_32;
    u16 bpb_ext_flags;
    u16 bpb_fs_ver;
    u32 bpb_root_clus;
    u16 bpb_fs_info;
    u16 bpb_bk_boot_sec;
//private:    // иначе не POD и gcc игнорирует __attribute_packed__
    u8  bpb_reserved_2[12];
//public:

    u8  bs_drv_num;
//private:    // иначе не POD и gcc игнорирует __attribute_packed__
    u8  bs_reserved_1;
//public:
    u8  bs_boot_sig;
    u32 bs_vol_id;
    u8  bs_vol_lab[11];
    u8  bs_fil_sys_type[8];
} __attribute_packed__;

static_assert(sizeof(boot_sector_strip_part2_fat_32) == 54, "Компилятор неправильно упаковал структуру.");

} /* namespace detail */


extern const u16 permissible_bpb_bytes_per_sec[4];
extern const u8 permissible_bpb_sec_per_clus[8];


struct boot_sector_strip
{
    /** Инструкция безусловного перехода x86 для запуска загрузчика. */
    u8  bs_jmp_boot[3];
    u8  bs_oem_name[8];
    /** Кол-во байт в секторе. */
    u16 bpb_bytes_per_sec;
    /** Кол-во секторов в кластере.
     * @note 'bpb_bytes_per_sec' * 'bpb_sec_per_clus' must be <= 32 * 1024 */
    u8  bpb_sec_per_clus;
    u16 bpb_rsvd_sec_cnt;
    u8  bpb_num_fats;
    u16 bpb_root_ent_cnt;
    u16 bpb_tot_sec_16;
    u8  bpb_media;
    u16 bpb_fat_sz_16;
    u16 bpb_sec_per_trk;
    u16 bpb_num_heads;
    u32 bpb_hidd_sec;
    u32 bpb_tot_sec_32;

    union
    {
        detail::boot_sector_strip_part2_fat_12_16 part2_fat_12_16;
        detail::boot_sector_strip_part2_fat_32 part2_fat_32;
    };


    u32 get_root_dir_sectors() const
    {
        return ((bpb_root_ent_cnt * 32u) + (bpb_bytes_per_sec - 1u)) / bpb_bytes_per_sec;
    }

    /** @return FAT size in sectors. */
    u32 get_fat_size() const
    {
        return (bpb_fat_sz_16 != 0) ?
                bpb_fat_sz_16 :
                part2_fat_32.bpb_fat_sz_32;
    }

    u32 get_first_data_sector() const
    {
        return bpb_rsvd_sec_cnt + (bpb_num_fats * get_fat_size()) + get_root_dir_sectors();
    }

    u32 get_total_sec() const
    {
        return (bpb_tot_sec_16 != 0) ?
                        bpb_tot_sec_16 :
                        bpb_tot_sec_32;
    }

    u32 get_count_of_clusters() const
    {
        /* Count of sectors in the data region of the volume. */
        u32 data_sec = get_total_sec() - get_first_data_sector();
        return data_sec / bpb_sec_per_clus;
    }

    fs_type determine_type() const
    {
        u32 count_of_clusters = get_count_of_clusters();

        if (count_of_clusters < 4085)
            return fs_type::fat_12;
        else if(count_of_clusters < 65525)
            return fs_type::fat_16;
        else
            return fs_type::fat_32;
    }

    bool is_correct() const
    {
        bool first_check =
                (
                    (bs_jmp_boot[0] == 0xeb && bs_jmp_boot[2] == 0x90)
                    || (bs_jmp_boot[0] == 0xe9)
                )
                // bpb_bytes_per_sec and bpb_sec_per_clus check later.
                && bpb_rsvd_sec_cnt != 0
                && bpb_num_fats != 0
                && (bpb_tot_sec_16 != 0 || bpb_tot_sec_32 != 0)
                &&
                (
                    bpb_media == 0xf0
                    || 0xf8 <= bpb_media
                );


        bool check_enum = false;
        for (auto i = std::begin(permissible_bpb_bytes_per_sec); i < std::end(permissible_bpb_bytes_per_sec); i++)
            check_enum = check_enum || (bpb_bytes_per_sec == *i);

        first_check = first_check && check_enum;


        check_enum = false;
        for (auto i = std::begin(permissible_bpb_sec_per_clus); i < std::end(permissible_bpb_sec_per_clus); i++)
            check_enum = check_enum || (bpb_sec_per_clus == *i);

        first_check = first_check && check_enum;



        if (first_check == false)
            return false;


        fs_type type = determine_type();

        if (type == fs_type::fat_32)
            return
                    bpb_root_ent_cnt == 0
                    && bpb_tot_sec_16 == 0
                    && bpb_fat_sz_16 == 0
                    && part2_fat_32.bpb_fat_sz_32 != 0
                    && part2_fat_32.bpb_fs_ver == 0
                    && part2_fat_32.bs_boot_sig == 0x29;
        else
            return
                    bpb_fat_sz_16 != 0
                    && part2_fat_12_16.bs_boot_sig == 0x29;
    }


    /** fat32 может занимать больше 4Гб */
    u64 get_first_sector_of_cluster(u32 num) const
    {
        return (static_cast<u64>(num - 2u) * bpb_sec_per_clus) + get_first_data_sector();
    }

    u32 get_first_sector_of_fat(u8 fat_num) const
    {
        if (bpb_num_fats <= fat_num)
            throw std::out_of_range("fat_num");

        return bpb_rsvd_sec_cnt + (fat_num * get_fat_size());
    }


/*
    case fs_type::fat_16:
            if (       entry_num <= 1
                    || get_fat_size() < 2 * entry_num + 2
                    || get_count_of_clusters() + 1 < entry_num)
                throw std::out_of_range("entry_num");

        case fs_type::fat_32:
            if (       entry_num <= 1
                    || get_fat_size() < 4 * entry_num + 4
                    || get_count_of_clusters() + 1 < entry_num)
                throw std::out_of_range("entry_num");

*/
} __attribute_packed__;

static_assert(sizeof(boot_sector_strip) == 90, "Компилятор неправильно упаковал структуру.");


/* BPB (BIOS Parameter Block). This sector is sometimes called the
“boot sector” or the “reserved sector” or the “0th sector". */
struct boot_sector
{
    boot_sector_strip bss;

private:

    u8 reserved[512 - sizeof(bss) - 2];

public:

    u8 magic_55;
    u8 magic_aa;


    bool is_correct()
    {
        return
                magic_55 == 0x55
                && magic_aa == 0xaa
                && bss.is_correct();
    }
} __attribute_packed__;

static_assert(sizeof(boot_sector) == 512, "Компилятор неправильно упаковал структуру.");


} /* namespace fat */
} /* namespace format_header */
} /* namespace exo */

#endif /* EXO_FORMAT_HEADER_FAT_BOOT_SECTOR_HPP_INCLUDED */
