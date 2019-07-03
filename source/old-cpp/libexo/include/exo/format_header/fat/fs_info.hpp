#ifndef EXO_FORMAT_HEADER_FAT_FS_INFO_HPP_INCLUDED
#define EXO_FORMAT_HEADER_FAT_FS_INFO_HPP_INCLUDED

#include <exo/attributes.hpp>
#include <exo/format_header/fat/types.hpp>

namespace exo {
namespace format_header {
namespace fat {


class fs_info
{
private:

    /** Всегда 0x41615252. Поле используется для проверки, что это действительно fs_info. */
    u32 fsi_lead_sig;

    /** Зарезервировано для будущего использования. При создании следует заполнить нулями.
     * Значение поля не должно где-либо использоваться. */
    u8 fsi_reserved_1[480];

    /** Всегда 0x61417272. Another signature that is more localized in the sector to the
     * location of the fields that are used. */
    u32 fsi_struc_sig;

public:

    /** Содержит последнее известное кол-во свободных кластеров на диске. Если значение
     * равно 0xffffffff, значит кол-во свободных кластеров не известно. Однако любое
     * прочее значение ещё не означает, что оно корректно. При использовании данного поля
     * следует хотя бы проверить, что оно меньше, чем общее кол-во кластеров на диске. */
    u32 fsi_free_count;

    /** Это поле содержит подсказку - номер кластера, начиная с которого следует начать
     * поиск свободного кластера. При большом кол-ве занятых кластеров в начале таблицы FAT,
     * использование этого поля помагает уменьшить время поиска по сравнении с поиском
     * свободного кластера начиная со 2 кластера. Обычно это поле устанавливается в значение
     * последнего выделенного (allocated) кластера. Если значение равно 0xffffffff, значит
     * подсказки нет и следует начать поиск с кластера 2. Любое другое значение ещё не означает,
     * что оно содержит корректный номер кластера, поэтому перед использованием следует
     * его проверить. */
    u32 fsi_nxt_free;

private:

    /** Зарезервировано для будущего использования. При создании следует заполнить нулями.
     * Значение поля не должно где-либо использоваться. */
    u8 fsi_reserved_2[12];

    /** Всегда 0xaa550000. Поле используется для проверки, что это действительно fs_info. */
    u32 fsi_trail_sig;


public:

    fs_info()
        : fsi_lead_sig(0x41615252)
        , fsi_reserved_1()
        , fsi_struc_sig(0x61417272)
        , fsi_free_count(0xffffffff)
        , fsi_nxt_free(0xffffffff)
        , fsi_reserved_2()
        , fsi_trail_sig(0xaa550000)
    {}

    bool is_correct() const
    {
        return fsi_lead_sig == 0x41615252
                && fsi_struc_sig == 0x61417272
                && fsi_trail_sig == 0xaa550000;
    }
} __attribute_packed__;

static_assert(sizeof(fs_info) == 512, "Компилятор неправильно упаковал структуру.");


} /* namespace fat */
} /* namespace format_header */
} /* namespace exo */

#endif // EXO_FORMAT_HEADER_FAT_FS_INFO_HPP_INCLUDED
