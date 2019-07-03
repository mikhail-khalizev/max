#ifndef EXO_FORMAT_HEADER_FAT_FAT_ITEM_HPP_INCLUDED
#define EXO_FORMAT_HEADER_FAT_FAT_ITEM_HPP_INCLUDED

#include <exo/format_header/fat/types.hpp>

namespace exo {
namespace format_header {
namespace fat {


namespace detail {

template<fs_type type>
class fat_item_specific {};

template<>
class fat_item_specific<fs_type::fat_16>
{
public:

    u16 val;
};

static_assert(sizeof(fat_item_specific<fs_type::fat_16>) == 2, "Компилятор неправильно упаковал структуру.");


template<>
class fat_item_specific<fs_type::fat_32>
{
public:

    u32 val : 28;

private:

    u32 reserved : 4;
};

static_assert(sizeof(fat_item_specific<fs_type::fat_32>) == 4, "Компилятор неправильно упаковал структуру.");


template<fs_type type, typename entry_type, entry_type bad_cluster>
struct fat_item_generic
{
private:

    fat_item_specific<type> e;

public:

    entry_type get()
    {
        return e.val;
    }

    void set(entry_type x)
    {
        e.val = x;
    }


    bool is_free()
    {
        return get() == 0;
    }

    void set_to_free()
    {
        set(0);
    }


    bool is_bad_cluster()
    {
        return get() == bad_cluster;
    }

    void set_to_bad_cluster()
    {
        set(bad_cluster);
    }


    bool is_eof()
    {
        return bad_cluster < get();
    }

    void set_to_eof()
    {
        set(bad_cluster + 1);
    }
};

} /* namespace detail */



#pragma GCC diagnostic push
/* У базового класса нет виртуального деструктора,
 * но в данном случае он нам и не нужен. Так что отключаем
 * соответствующее предупреждение компилятора. */
#pragma GCC diagnostic ignored "-Weffc++"


template<fs_type type>
struct fat_item {};

template<>
struct fat_item<fs_type::fat_16> : public detail::fat_item_generic<fs_type::fat_16, u16, 0xfff7>
{};

template<>
struct fat_item<fs_type::fat_32> : public detail::fat_item_generic<fs_type::fat_32, u32, 0x0ffffff7>
{};


#pragma GCC diagnostic pop


} /* namespace fat */
} /* namespace format_header */
} /* namespace exo */

#endif /* EXO_FORMAT_HEADER_FAT_FAT_ITEM_HPP_INCLUDED */
