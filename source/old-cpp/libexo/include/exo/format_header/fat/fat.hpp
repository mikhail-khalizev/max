#ifndef EXO_FORMAT_HEADER_FAT_FAT_HPP_INCLUDED
#define EXO_FORMAT_HEADER_FAT_FAT_HPP_INCLUDED

#include <exo/format_header/fat/types.hpp>
#include <exo/format_header/fat/fat_item.hpp>


namespace exo {
namespace format_header {
namespace fat {


namespace detail {

template<fs_type type, typename entry_type, entry_type ClnShutBitMask, entry_type HrdErrBitMask>
class fat_general
{
public:

    /** @note this должен ссылаться непосредственно на FAT. */

    /** @note Первые две записи зарезервированны. */
    fat_item<type> & operator[](entry_type entry_num)
    {
        return reinterpret_cast< fat_item<type> * >(this)[entry_num];
    }


    /** Содержит ли диск отметку о необходимости проверки тома? */
    bool is_dirty()
    {
        return (operator[](1).get() & ClnShutBitMask) == 0;
    }

    void set_dirty(bool flag)
    {
        entry_type old = operator[](1).get();

        entry_type val;
        if (flag)
            val = old & (~ClnShutBitMask);
        else
            val = old | ClnShutBitMask;

        operator[](1).set(val);
    }


    bool have_io_disk_error_at_last_mount()
    {
        return (operator[](1).get() & HrdErrBitMask) == 0;
    }

    void set_io_disk_error_at_current_mount(bool flag)
    {
        entry_type old = operator[](1).get();

        entry_type val;
        if (flag)
            val = old & (~HrdErrBitMask);
        else
            val = old | HrdErrBitMask;

        operator[](1).set(1, val);
    }
};

} /* namespace detail */



#pragma GCC diagnostic push
/* У базового класса нет виртуального деструктора,
 * но в данном случае он нам и не нужен. Так что отключаем
 * соответствующее предупреждение компилятора. */
#pragma GCC diagnostic ignored "-Weffc++"


/** @note this должен ссылаться непосредственно на FAT:
 *  fat<??> & table = ms.get<fat<??>>(); */

/** Непосредственно таблица FAT. */
template<fs_type type>
class fat {};

template<>
class fat<fs_type::fat_16> : public detail::fat_general<fs_type::fat_16, u16, 0x8000, 0x4000>
{};

template<>
class fat<fs_type::fat_32> : public detail::fat_general<fs_type::fat_32, u32, 0x08000000, 0x04000000>
{};


#pragma GCC diagnostic pop


} /* namespace fat */
} /* namespace format_header */
} /* namespace exo */

#endif /* EXO_FORMAT_HEADER_FAT_FAT_HPP_INCLUDED */
