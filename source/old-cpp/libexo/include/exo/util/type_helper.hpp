#ifndef EXO_UTIL_TYPE_HELPER_HPP_INCLUDED
#define EXO_UTIL_TYPE_HELPER_HPP_INCLUDED

#include <map>
#include <tuple>
#include <limits>
#include <stdexcept>


namespace exo {
namespace util {


/**
 * Предоставляет тип std::tuple состающий из заданных типов Types за исключением типа void.
 */
template<class ...Types>
struct tuple_skip_void_helper;

template<>
struct tuple_skip_void_helper<>
{
    typedef std::tuple<> type;
};

template<class First, class ...Types>
struct tuple_skip_void_helper<First, Types...>
{
    typedef typename std::__combine_tuples<std::tuple<First>, typename tuple_skip_void_helper<Types...>::type>::__type type;
};

template<class ...Types>
struct tuple_skip_void_helper<void, Types...>
{
    typedef typename tuple_skip_void_helper<Types...>::type type;
};


/**
 * Определяет, являются ли заданные типы одним типом.
 */
template<class ...Types>
struct is_one_type_helper;

template<>
struct is_one_type_helper<>
{
    typedef void type;
};

template<class Type>
struct is_one_type_helper<Type>
{
    typedef Type type;
};

template<class Type>
struct is_one_type_helper<Type, Type>
{
    typedef Type type;
};

template<class Type1, class Type2>
struct is_one_type_helper<Type1, Type2>
{
    typedef void type;
};

template<class First, class Second, class Third, class ...Types>
struct is_one_type_helper<First, Second, Third, Types...>
{
    typedef typename is_one_type_helper<typename is_one_type_helper<First, Second>::type, Third, Types...>::type type;
};


/**
 * Определяет, являются ли все типы находящиеся в типе std::tuple одним типом.
 */
template<class Tuple>
struct tuple_from_one_type_helper
{
    typedef void type;
};

template<class ...Types>
struct tuple_from_one_type_helper<std::tuple<Types...>>
{
    typedef typename is_one_type_helper<Types...>::type type;
};


/**
 * Определяет кол-во элементов в std::tuple.
 */
template<class Tuple>
struct tuple_size_helper
{
    static constexpr auto value = 0;
};

template<class ...Types>
struct tuple_size_helper<std::tuple<Types...>>
{
    static constexpr auto value = sizeof...(Types);
};


} /* namespace util */
} /* namespace exo */

#endif // EXO_UTIL_TYPE_HELPER_HPP_INCLUDED
