#include "time_internal.hpp"
#include <stdexcept>

#include <exo/linux/time.hpp>
#include <exo/linux/exception.hpp>


namespace exo {
namespace linux {


time convert_timespec_to_time(struct timespec ts)
{
    time ret(static_cast<time::total_sec_type>(ts.tv_sec), static_cast<time::only_nsec_type>(ts.tv_nsec));

    if (ret.total_sec() != ts.tv_sec || ret.only_nsec() != ts.tv_nsec)
        throw std::out_of_range("Не удалось преобразовать timespec к exo::linux::time."); /* Странно. */

    return ret;
}

void time::set_clock_time(clock_id id) const
{
    struct timespec tp;
    tp.tv_sec = total_sec();
    tp.tv_nsec = only_nsec();

    int ok = clock_settime(static_cast<clockid_t>(id), & tp);
    if (ok != 0)
        exception::throw_errno();
}

time time::get_clock_res(clock_id id)
{
    struct timespec tp;
    int ok = clock_getres(static_cast<clockid_t>(id), & tp);
    if (ok != 0)
        exception::throw_errno();

    return convert_timespec_to_time(tp);
}

time time::get_clock_time(clock_id id)
{
    struct timespec tp;
    int ok = clock_gettime(static_cast<clockid_t>(id), & tp);
    if (ok != 0)
        exception::throw_errno();

    return convert_timespec_to_time(tp);
}


calendar_time::calendar_time(time t)
: gmtoff()
, yday()
, sec()
, min()
, hour()
, mday()
, year()
, month()
, wday()
, isdst()
{
    struct tm tm;
    time_t _t = t.total_sec();
    localtime_r(&_t, & tm);

    gmtoff = static_cast<s32>(tm.tm_gmtoff);
    yday = static_cast<u16>(tm.tm_yday);
    sec = static_cast<u8>(tm.tm_sec);
    min = static_cast<u8>(tm.tm_min);
    hour = static_cast<u8>(tm.tm_hour);
    mday = static_cast<u8>(tm.tm_mday);
    year = static_cast<u8>(tm.tm_year);
    month = static_cast<u8>(tm.tm_mon);
    wday = static_cast<u8>(tm.tm_wday);
    isdst = static_cast<s8>(tm.tm_isdst);

    if (gmtoff != tm.tm_gmtoff || isdst != tm.tm_isdst
            || tm.tm_yday < 0 || yday != static_cast<unsigned>(tm.tm_yday)
            || tm.tm_sec  < 0 || sec  != static_cast<unsigned>(tm.tm_sec)
            || tm.tm_min  < 0 || min  != static_cast<unsigned>(tm.tm_min)
            || tm.tm_hour < 0 || hour != static_cast<unsigned>(tm.tm_hour)
            || tm.tm_mday < 0 || mday != static_cast<unsigned>(tm.tm_mday)
            || tm.tm_year < 0 || year != static_cast<unsigned>(tm.tm_year)
            || tm.tm_mon  < 0 || month != static_cast<unsigned>(tm.tm_mon)
            || tm.tm_wday < 0 || wday != static_cast<unsigned>(tm.tm_wday))
        throw std::out_of_range("Не удалось преобразовать time_t к exo::linux::calendar_time."); /* Странно. */
}


} /* namespace linux */
} /* namespace exo */
