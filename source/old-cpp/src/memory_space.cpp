#include <iostream>
//#include "exo/RE.hpp"
//#include "exo/SelfTest.hpp"
//#include "exo/IO/IStream.hpp"
#include <exo/memory_space.hpp>
//#include "exo/Memory/Pool.hpp"

namespace exo {

std::ostream & operator<<(std::ostream & o, memory_space_const ms)
{
    return o.write(&ms.get<char>(), static_cast<std::streamsize>(ms.size()));
}

#if 0

IO::IStreamWriter & operator<<(IO::IStreamWriter & o, const memory_space_const in)
{
    if (o.GetModeSkip())
        return o;

    memory_space wr = o.GetWriteSpace(in.size());
    throw_assert(in.size() <= wr.size(), "%d <= %d.", in.size(), wr.size());

    memcpy(wr.data(), in.data(), in.size());
    o.Writed(in.size());

    return o;
}

namespace detail {

IO::IStreamWriter & wr_arr(IO::IStreamWriter & o, const memory_space_const * in_arr, size_t n)
{
    size_t len = 0;

    for (size_t i = 0; i < n; i++)
        len += in_arr[i].size();


    if (o.GetModeSkip())
        return o;

    memory_space wr = o.GetWriteSpace(len);
    throw_assert(len <= wr.size(), "%d <= %d.", len, wr.size());

    char * ptr = wr.data();

    for (size_t i = 0; i < n; i++)
    {
        memcpy(ptr, in_arr[i].data(), in_arr[i].size());
        ptr += in_arr[i].size();
    }

    o.Writed(len);
    return o;
}

} // namespace detail

bool memory_space_const::_Parse(memory_space_const sp, apr_uint64_t & res, uint base)
{
    const memory_space_const sp_orig = sp;

#define ISSPACE(c)              ((c) == ' ' || (c) == '\f' || (c) == '\n' || \
                                 (c) == '\r' || (c) == '\t' || (c) == '\v')
#define ISUPPER(c)              ((c) >= 'A' && (c) <= 'Z')
#define ISLOWER(c)              ((c) >= 'a' && (c) <= 'z')
#define ISALPHA(c)              (ISUPPER (c) || ISLOWER (c))
#define TOUPPER(c)              (ISLOWER (c) ? (c) - 'a' + 'A' : (c))
#define TOLOWER(c)              (ISUPPER (c) ? (c) - 'A' + 'a' : (c))

    bool overflow = false;
    apr_uint64_t ui64 = 0;

    const char * save;
    bool negative = false;
    const char * endptr_ = NULL;

    if (sp.IsEmpty())
        throw_ms("Пустая строчка.");

    if (base == 1 || base > 36)
        throw_msg("Некорректное значение основания системы исчесления (%d).", base);

    save = sp.data();

    /* Skip white space.  */
    while (sp.IsNonEmpty())
        if (ISSPACE(sp[0]))
            sp.RemovePrefix(1);
        else
            break;

    if (sp.IsEmpty())
        goto noconv;

    /* Check for a sign.  */
    if (sp[0] == '-')
    {
        negative = true;
        sp.RemovePrefix(1);
    }
    else if (sp[0] == '+')
        sp.RemovePrefix(1);

    /* Recognize number prefix and if BASE is zero, figure it out ourselves.  */
    if (sp.at(0) == '0')
    {
        if (base == 0 || base == 16)
        {
            if (2 <= sp.size())
                if (TOUPPER(sp[1]) == 'X')
                {
                    sp.RemovePrefix(2);
                    base = 16;
                }
        }
        else if (base == 0)
            base = 8;
    }
    else if (base == 0)
        base = 10;

    apr_uint64_t cutoff;
    apr_uint64_t cutlim;

    if (base == 10)
    {
        /* Оптимизация. Увеличивает скорость на 18%. */
        cutoff = APR_UINT64_MAX / 10;
        cutlim = APR_UINT64_MAX % 10;
    }
    else
    {
        cutoff = APR_UINT64_MAX / base;
        cutlim = APR_UINT64_MAX % base;
    }

    /* Save the pointer so we can check later if anything happened.  */
    save = sp.data();

    for (; sp.IsNonEmpty(); sp.RemovePrefix(1))
    {
        unsigned char c = sp[0];

        if (c >= '0' && c <= '9')
            c -= '0';
        else if (ISALPHA(c))
            c = TOUPPER(c) - 'A' + 10;
        else
            break;

        if (c >= base)
            break;

        /* Check for overflow.  */
        if (ui64 > cutoff || (ui64 == cutoff && c > cutlim))
            overflow = true;
        else
        {
            ui64 *= base;
            ui64 += c;
        }
    }

    /* Check if anything actually happened.  */
    if (sp.data() == save)
        goto noconv;

    /* Store in ENDPTR the address of one character
       past the last character we converted.  */
    endptr_ = sp.data();

    if (overflow)
    {
        throw_ms("Переполнение. '", sp_orig, "'.");
        //errno = ERANGE;
        //return APR_UINT64_MAX;
    }

    if (endptr_ != sp.end())
        throw_ms("Преобразования не получилось. '", sp_orig, "'.");

    res = ui64;
    return negative;

noconv:

    /* We must handle a special case here: the base is 0 or 16 and the
       first two characters are '0' and 'x', but the rest are no
       hexadecimal digits.  This is no error case.  We return 0 and
       ENDPTR points to the `x`. */

    if (2 <= save - sp.data())
    {
        if ((TOUPPER(save[-1]) == 'X') && save[-2] == '0')
            endptr_ = &save[-1];
    }
    else
        /*  There was no number to convert.  */
        endptr_ = sp.data();

    if (endptr_ != sp.end())
        throw_ms("Преобразования не получилось. '", sp_orig, "'.");

    res = ui64;
    return negative;
}

SELF_TEST("exo::memory_space_const")
{
    memory_space_const tst("fff");

    throw_assert(tst.size() == 3, "%u.", tst.size());

    tst.AddSuffix(2);
    throw_assert(tst.size() == 5, "%u.", tst.size());

    tst.AddSuffix(-3);
    throw_assert(tst.size() == 2, "%u.", tst.size());

    tst.RemoveSuffix(1);
    throw_assert(tst.size() == 1, "%u.", tst.size());

    tst.RemoveSuffix(-5);
    throw_assert(tst.size() == 6, "%u.", tst.size());
}

template<typename T>
void check_(memory_space_const str, const char * is_corr_, int base, T res, int error)
{
    bool is_must_be_corr = (strlen(is_corr_) == 0) && (error == 0);

    try
    {
        T val;
        str.Parse(val, base);
        if (is_must_be_corr && val == res)
            return;

        throw_msg("'%s', '%s', %u.\n%qu \t%qd.\n%qu \t%qd.",
                str.data(), is_corr_, base,
                (apr_uint64_t) val, (apr_uint64_t) val,
                (apr_uint64_t) res, (apr_uint64_t) res);
    }
    _catch_
    {
        if (is_must_be_corr == false)
            return;
        else
            throw;
    }
}

SELF_TEST("exo::memory_space_const")
{
    check_<apr_uint64_t> ("0", "", 10, 0, 0);
    check_<apr_uint64_t> ("+0", "", 10, 0, 0);
    check_<apr_uint64_t> ("-0", "", 10, 0, 0);
    check_<apr_uint64_t> ("18446744073709551615", "", 10, (apr_uint64_t) (-1), 0);
    check_<apr_uint64_t> ("18446744073709551616", "", 10, (apr_uint64_t) (-1), ERANGE);
    check_<apr_uint64_t> ("-1", "", 10, (apr_uint64_t) (-1), ERANGE);
    check_<apr_uint64_t> ("20xyz", "xyz", 10, 20, 0);
    check_<apr_uint64_t> (memory_space_const("20xyz ", 2), "", 10, 20, 0);
    check_<apr_uint64_t> (memory_space_const("  20xyz  ", 2), "", 10, 20, 1);

    check_<apr_int64_t> ("0", "", 10, 0, 0);
    check_<apr_int64_t> ("9223372036854775807", "", 10, ((apr_uint64_t) (-1) / 2), 0);
    check_<apr_int64_t> ("9223372036854775808", "", 10, ((apr_uint64_t) (-1) / 2), ERANGE);
    check_<apr_int64_t> ("-9223372036854775808", "", 10, ((apr_uint64_t) (-1) / 2 + 1), 0);
    check_<apr_int64_t> ("-9223372036854775809", "", 10, ((apr_uint64_t) (-1) / 2 + 1), ERANGE);
    check_<apr_int64_t> ("32768", "", 10, 32768, 0);
    check_<apr_int64_t> ("-32768", "", 10, -32768, 0);
    check_<apr_int64_t> ("001", "", 10, 1, 0);
    check_<apr_int64_t> ("-001", "", 10, -1, 0);
}

SELF_TEST("exo::memory_space_const")
{
    memory_space_const x = "abc";
    memory_space_const x2 = "abb";
    memory_space_const y[] = { "a", "b", "c" };

    throw_assert(x == x, "fail");
    throw_assert(x != x2, "fail");

    throw_assert(x == y, "fail");
    throw_assert(y == x, "fail");

    throw_assert(x2 != y, "fail");
    throw_assert(y != x2, "fail");


    throw_assert(x == "abc", "fail");
    throw_assert("abc" == x, "fail");

    throw_assert(x != "abb", "fail");
    throw_assert("abb" != x, "fail");
}

#endif

} /* namespace exo */

