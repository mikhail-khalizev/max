#ifndef EXO_LINUX_TIME_HPP_INCLUDED
#define EXO_LINUX_TIME_HPP_INCLUDED

#include <exo/linux/types.hpp>
#include <exo/math/std_types.hpp>


#ifdef linux
/* Объявлять "linux" маленькими буквами было плохой идеей. Следовало бы объявить "LINUX". */
#undef linux
#endif


namespace exo {
namespace linux {

// @todo std::chrono


class time
{
public:

    typedef exo::math::uint_<32>::type total_sec_type;
    typedef exo::math::uint_<32>::type only_nsec_type;
    typedef exo::math::uint_<64>::type total_nsec_type;

private:

    /** Seconds since 1970-01-01 00:00:00 UTC */
    total_sec_type sec;
    only_nsec_type nsec;

public:

    time();
    time(total_sec_type total_sec, only_nsec_type only_nsec);

    /** Seconds since 1970-01-01 00:00:00 UTC */
    total_sec_type total_sec() const;
    only_nsec_type only_nsec() const;
    /** Nanoseconds since 1970-01-01 00:00:00 UTC */
    total_nsec_type total_nsec() const;


    void set_clock_time(clock_id id) const;

    static time get_clock_res(clock_id id);
    static time get_clock_time(clock_id id);
};

/* @todo Может использовать boost?
 * Сделать struct. Все поля открыты и оптимальны (тип int). */
class calendar_time
{
public:

    typedef exo::math::uint_<8>::type  u8;
    typedef exo::math::sint_<8>::type  s8;
    typedef exo::math::uint_<16>::type u16;
    typedef exo::math::sint_<32>::type s32;


    s32 gmtoff; /* Seconds east of UTC. */

    u16 yday;   /* Days in year.[0-365] */

    u8 sec;     /* Seconds.    [0-60] (1 leap second) */
    u8 min;     /* Minutes.    [0-59] */
    u8 hour;    /* Hours.    [0-23] */
    u8 mday;    /* Day.        [1-31] */

private:

    u8 year;    /* Year. -1900 */

public:

    u8 month;   /* Month.    [0-11] */
    u8 wday;    /* Day of week.    [0-6]  2 - вторник. */
    s8 isdst;   /* DST.        [-1/0/1] */


    calendar_time(time t);

    decltype(year + 1900U) get_year() const;
};



/* definition */

inline time::time()
: sec(0)
, nsec(0)
{}

inline time::time(total_sec_type total_sec_, only_nsec_type only_nsec_)
: sec(total_sec_)
, nsec(only_nsec_)
{}

inline time::total_sec_type time::total_sec() const
{
    return sec;
}

inline time::only_nsec_type time::only_nsec() const
{
    return nsec;
}

inline time::total_nsec_type time::total_nsec() const
{
    return nsec + sec * 1000000000ul;
}

inline decltype(calendar_time::year + 1900U) calendar_time::get_year() const
{
    return year + 1900U;
}


} /* namespace linux */
} /* namespace exo */

#endif /* EXO_LINUX_TIME_HPP_INCLUDED */
