/* "Создание" класса флагов из объявленного класса T. */

#ifndef T
#   warning T not define. Skip.
#else

#   ifndef _GLIBCXX_TYPE_TRAITS
#       error include <type_traits> before
#   endif


constexpr T operator~(T a)
{
    typedef typename std::underlying_type<T>::type enum_type;
    return static_cast<T>(~static_cast<enum_type>(a));
}


inline T & operator^=(T & a, T b)
{
    typedef typename std::underlying_type<T>::type enum_type;
    a = static_cast<T>(static_cast<enum_type>(a) ^ static_cast<enum_type>(b));
    return a;
}


constexpr T operator|(T a, T b)
{
    typedef typename std::underlying_type<T>::type enum_type;
    return static_cast<T>(static_cast<enum_type>(a) | static_cast<enum_type>(b));
}

constexpr T operator&(T a, T b)
{
    typedef typename std::underlying_type<T>::type enum_type;
    return static_cast<T>(static_cast<enum_type>(a) & static_cast<enum_type>(b));
}

constexpr T operator^(T a, T b)
{
    typedef typename std::underlying_type<T>::type enum_type;
    return static_cast<T>(static_cast<enum_type>(a) ^ static_cast<enum_type>(b));
}


constexpr bool is_set(T _this_, T what)
{
    return (_this_ & what) == what;
}

constexpr bool is_not_set(T _this_, T what)
{
    return is_set(_this_, what) == false;
}


#   undef T
#endif
