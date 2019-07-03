#ifndef NAME_CLASS_1
#    warning NAME_CLASS_1 not defined. Skip.
#else

template<abstract_int bits_>
class NAME_CLASS_1
{
public:

    typedef
#define TYPE(T)  typename std::conditional<TYPE_COMPARE(bits_, 8 * sizeof(SIGNED_TYPE T)), SIGNED_TYPE T,
#include <exo/math/cxx_types_int.hpp>
#undef TYPE
                /* fail */ SIGNED_TYPE char
#define TYPE(T)  >::type
#include <exo/math/cxx_types_int.hpp>
#undef TYPE
            type;

    static_assert(TYPE_COMPARE(bits_, 8 * sizeof(type)), "Данная размерность не поддерживается.");


private:

    // @todo В отдельный файл.
    static constexpr abstract_int bits_of()
    {
        return 0;
    }

    template<typename T>
    static constexpr abstract_int bits_of(T first)
    {
        return static_cast<abstract_int>(8 * sizeof(first));
    }

    template<abstract_int bits_2>
    static constexpr abstract_int bits_of(NAME_CLASS_1<bits_2>)
    {
        return bits_2;
    }

    template<abstract_int bits_2>
    static constexpr abstract_int bits_of(NAME_CLASS_2<bits_2>)
    {
        return bits_2;
    }

    template<typename T, typename... Args>
    static constexpr abstract_int bits_of(T first, Args... args)
    {
        return bits_of(first) + bits_of(args...);
    }

public:


    /** simple constructors. */

    constexpr NAME_CLASS_1()
    : val()
    {}

    template<abstract_int bits_2>
    constexpr NAME_CLASS_1(const NAME_CLASS_1<bits_2> & x)
    : val(static_cast<type>(x.get()))
    {}

    template<abstract_int bits_2>
    constexpr NAME_CLASS_1(const NAME_CLASS_2<bits_2> & x)
    : val(static_cast<type>(x.get()))
    {}

#define TYPE(T)    \
    constexpr NAME_CLASS_1(  signed T x) : val(static_cast<type>(x)) {}    \
    constexpr NAME_CLASS_1(unsigned T x) : val(static_cast<type>(x)) {}
#include <exo/math/cxx_types_int.hpp>
#undef TYPE


    /** concatenations constructors. */

    template<abstract_int bits_2, typename... Args>
    constexpr NAME_CLASS_1(const NAME_CLASS_1<bits_2> & first, Args... args)
    : val((NAME_CLASS_1(first) << bits_of(args...)) | NAME_CLASS_1(args...))
    {}

    template<abstract_int bits_2, typename... Args>
    constexpr NAME_CLASS_1(const NAME_CLASS_2<bits_2> & first, Args... args)
    : val((NAME_CLASS_1(first) << bits_of(args...)) | NAME_CLASS_1(args...))
    {}

#define TYPE(T)    \
    template<typename... Args> constexpr NAME_CLASS_1(  signed T first, Args... args) : val((NAME_CLASS_1(first) << bits_of(args...)) | NAME_CLASS_1(args...)) {}    \
    template<typename... Args> constexpr NAME_CLASS_1(unsigned T first, Args... args) : val((NAME_CLASS_1(first) << bits_of(args...)) | NAME_CLASS_1(args...)) {}
#include <exo/math/cxx_types_int.hpp>
#undef TYPE


    template<abstract_int bits_2>
    NAME_CLASS_1 & operator=(const NAME_CLASS_1<bits_2> & x)
    {
        val = static_cast<type>(x.get());
        return *this;
    }

    template<abstract_int bits_2>
    NAME_CLASS_1 & operator=(const NAME_CLASS_2<bits_2> & x)
    {
        val = static_cast<type>(x.get());
        return *this;
    }

#define TYPE(T)    \
    NAME_CLASS_1 & operator=(  signed T x) { val = static_cast<type>(x); return *this; }    \
    NAME_CLASS_1 & operator=(unsigned T x) { val = static_cast<type>(x); return *this; }
#include <exo/math/cxx_types_int.hpp>
#undef TYPE


    constexpr NAME_CLASS_1 operator+()
    {
        return NAME_CLASS_1(val);
    }

    constexpr NAME_CLASS_1 operator-()
    {
        return NAME_CLASS_1(-val);
    }

    constexpr NAME_CLASS_1 operator~()
    {
        return NAME_CLASS_1(~val);
    }


    NAME_CLASS_1 & operator++()
    {
        val++;
        return *this;
    }

    NAME_CLASS_1 operator++(int)
    {
        NAME_CLASS_1 ret = *this;
        val++;
        return ret;
    }

    NAME_CLASS_1 & operator--()
    {
        val--;
        return *this;
    }

    NAME_CLASS_1 operator--(int)
    {
        NAME_CLASS_1 ret = *this;
        val--;
        return ret;
    }


#define TYPE(T) \
    NAME_CLASS_1 & operator OP (  signed T x) { val OP x; return *this; }    \
    NAME_CLASS_1 & operator OP (unsigned T x) { val OP x; return *this; }
#define MYSELF    \
    template<abstract_int bits_2>    \
    NAME_CLASS_1 & operator OP(NAME_CLASS_1<bits_2> x)    \
    { val OP x.get(); return *this; }

#define OP +=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP -=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP *=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP /=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP %=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP &=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP |=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP ^=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP <<=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#define OP >>=
MYSELF
#include <exo/math/cxx_types_int.hpp>
#undef OP
#undef TYPE
#undef MYSELF


#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Wtype-limits"
#pragma GCC diagnostic ignored "-Wsign-conversion"

#define MYSELF    \
    template<abstract_int bits_2>    \
    constexpr auto operator OP(const NAME_CLASS_1<bits_2> & b) -> NAME_CLASS_1< bits_ < bits_2 ? bits_2 : bits_ >    \
    { return get() OP b.get(); }     \
    \
    template<abstract_int bits_2>    \
    constexpr auto operator OP(const NAME_CLASS_2<bits_2> & b) -> typename std::conditional<std::is_signed<decltype(type() OP b.get())>::value, NAME_CLASS_S< bits_ < bits_2 ? bits_2 : bits_ >, NAME_CLASS_U< bits_ < bits_2 ? bits_2 : bits_ >>::type    \
    { return get() OP b.get(); }


#define OP +
MYSELF
#undef OP
#define OP -
MYSELF
#undef OP
#define OP *
MYSELF
#undef OP
#define OP /
MYSELF
#undef OP
#define OP %
MYSELF
#undef OP
#define OP &
MYSELF
#undef OP
#define OP |
MYSELF
#undef OP
#define OP ^
MYSELF
#undef OP
#define OP <<
MYSELF
#undef OP
#define OP >>
MYSELF
#undef OP

#undef MYSELF
#define MYSELF    \
    template<abstract_int bits_2>                                           \
    constexpr bool operator OP(const NAME_CLASS_1<bits_2> & b)              \
    { return get() OP b.get(); }                                            \
                                                                            \
    template<abstract_int bits_2>                                           \
    constexpr bool operator OP(const NAME_CLASS_2<bits_2> & b)              \
    {                                                                       \
        return 0 <= get() ?                                                 \
                (0 <= b.get() ?                                             \
                    NAME_CLASS_U<bits_>(*this) OP NAME_CLASS_U<bits_2>(b)   \
                    : NAME_CLASS_2<bits_2>(0) OP b)                         \
                : (*this) OP NAME_CLASS_1<bits_>(0);                        \
    }

// us 0 <= b.get() ? a OP NAME_CLASS_U<bits_2>(b) : 0 OP b
// su 0 <= a.get() ? NAME_CLASS_U<bits_1>(a) OP b : a OP 0

#define OP ==
MYSELF
#undef OP
#define OP !=
MYSELF
#undef OP
#define OP >
MYSELF
#undef OP
#define OP <
MYSELF
#undef OP
#define OP >=
MYSELF
#undef OP
#define OP <=
MYSELF
#undef OP
#undef MYSELF

#pragma GCC diagnostic pop


    constexpr operator type() const
    {
        return val;
    }

    constexpr type get() const
    {
        return val;
    }


    static constexpr abstract_int bits()
    {
        return static_cast<abstract_int>(8 * sizeof(type));
    }

    static constexpr NAME_CLASS_1 max()
    {
        return std::is_signed<type>::value ?
            (static_cast<type>(1) << (bits() - 1)) - 1 :
            (static_cast<type>(static_cast<type>(0) - 1)) >> (static_cast<abstract_int>(8 * sizeof(type)) - bits());
    }

    static constexpr NAME_CLASS_1 min()
    {
        return std::is_signed<type>::value ?
            (static_cast<type>(static_cast<type>(0) - 1)) << (bits() - 1) :
            0;
    }

private:

    type val;
};


#endif
