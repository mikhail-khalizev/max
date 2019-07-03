#ifndef EXO_UTIL_DELEGATE_HPP_INCLUDED
#define EXO_UTIL_DELEGATE_HPP_INCLUDED

#include <utility> // std::forward
#include <exo/util/implicit_cast.hpp>
#include <exo/math/std_types.hpp>


namespace exo {
namespace util {


namespace detail {

/** GNU g++  pointer to member function. */
class pmf_gnu
{
    union
    {
        void * funcadr;                          /* Всегда чётный. */
        math::uint_pointer::type vtable_offset;  /* offset in vtable in bytes + 1. Всегда нечётный. */
    };
    math::uint_pointer::type delta; /* Смещение, добавляемое к 'this'. */

public:

    template<typename T, typename R, typename... ArgTypes>
    pmf_gnu(R (T::*func)(ArgTypes...))
    : delta()
    {
        static_assert(sizeof(pmf_gnu) == sizeof(func), "Видимо, этот класс устарел.");
        reinterpret_cast<decltype(func)&>(*this) = func;
    }

    template<typename T, typename R, typename... ArgTypes>
    pmf_gnu(R (T::*func)(ArgTypes...) const)
    : delta()
    {
        static_assert(sizeof(pmf_gnu) == sizeof(func), "Видимо, этот класс устарел.");
        reinterpret_cast<decltype(func)&>(*this) = func;
    }


    void * get_real_this(void * this_) const
    {
        return & reinterpret_cast<char*>(this_)[delta];
    }

    void * get_real_func_addr(void * this_) const
    {
        if ((vtable_offset & 1) == 0)
            return funcadr;

        char * vtable = * reinterpret_cast<char**>(get_real_this(this_));
        return * reinterpret_cast<void**>(  & vtable[vtable_offset - 1]  );
    }
};


typedef pmf_gnu pmf;

} /* namespace detail */


/** unsafe потому что при уничтожении класса, на метод которого ссылается делегат,
 * сам делегат не 'отчищается'. Т.е. при его запуске происходит вызов метода
 * уничтоженного класса. */

template<typename T = void>
class delegate_unsafe;

template<>
struct delegate_unsafe<void>
{
    template<typename R, typename... ArgTypes>
    static delegate_unsafe<R (ArgTypes...)> create(R (*func)(ArgTypes...))
    {
        return delegate_unsafe<R (ArgTypes...)>(func);
    }

    template<typename X, typename Y, typename R, typename... ArgTypes>
    static delegate_unsafe<R (ArgTypes...)> create(X & x, R (Y::*func)(ArgTypes...))
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }

    template<typename X, typename Y, typename R, typename... ArgTypes>
    static delegate_unsafe<R (ArgTypes...)> create(X * x, R (Y::*func)(ArgTypes...))
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }

    template<typename X, typename Y, typename R, typename... ArgTypes>
    static delegate_unsafe<R (ArgTypes...)> create(X & x, R (Y::*func)(ArgTypes...) const)
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }

    template<typename X, typename Y, typename R, typename... ArgTypes>
    static delegate_unsafe<R (ArgTypes...)> create(X * x, R (Y::*func)(ArgTypes...) const)
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }
};

template<typename R, typename... ArgTypes>
class delegate_unsafe<R (ArgTypes...)>
{
    typedef R (*func_ptr_type)(ArgTypes...);
    typedef R (*member_func_ptr_type)(void * this_, ArgTypes...);

    void * this_; // NULL if func.
    void * func_; // ptr to func or member.

public:

    typedef R result_type;

    delegate_unsafe()
    : this_(NULL)
    , func_(NULL)
    {}

    delegate_unsafe(decltype(nullptr))
    : this_(NULL)
    , func_(NULL)
    {}

    delegate_unsafe(R (*func)(ArgTypes...))
    : this_(NULL)
    , func_(reinterpret_cast<void*>(func))
    {}

    template<typename X, typename Y>
    delegate_unsafe(X & xthis, R (Y::*func)(ArgTypes...))
    : this_(NULL)
    , func_(NULL)
    {
        detail::pmf p(func);

        Y * ythis = implicit_cast<Y*>(&xthis);
        this_ = p.get_real_this(ythis);
        if (this_ != NULL)
            func_ = p.get_real_func_addr(ythis);
    }

    template<typename X, typename Y>
    delegate_unsafe(X * xthis, R (Y::*func)(ArgTypes...))
    : this_(NULL)
    , func_(NULL)
    {
        detail::pmf p(func);

        Y * ythis = implicit_cast<Y*>(xthis);
        this_ = p.get_real_this(ythis);
        if (this_ != NULL)
            func_ = p.get_real_func_addr(ythis);
    }

    template<typename X, typename Y>
    delegate_unsafe(X & xthis, R (Y::*func)(ArgTypes...) const)
    : this_(NULL)
    , func_(NULL)
    {
        detail::pmf p(func);

        Y * ythis = implicit_cast<Y*>(&xthis);
        this_ = p.get_real_this(ythis);
        if (this_ != NULL)
            func_ = p.get_real_func_addr(ythis);
    }

    template<typename X, typename Y>
    delegate_unsafe(X * xthis, R (Y::*func)(ArgTypes...) const)
    : this_(NULL)
    , func_(NULL)
    {
        detail::pmf p(func);

        Y * ythis = implicit_cast<Y*>(xthis);
        this_ = p.get_real_this(ythis);
        if (this_ != NULL)
            func_ = p.get_real_func_addr(ythis);
    }

    delegate_unsafe(const delegate_unsafe & x) = default;


    delegate_unsafe & operator=(decltype(nullptr))
    {
        this_ = NULL;
        func_ = NULL;
        return * this;
    }

    delegate_unsafe & operator=(R (*func)(ArgTypes...))
    {
        this_ = NULL;
        func_ = reinterpret_cast<void*>(func);
        return * this;
    }

    delegate_unsafe & operator=(const delegate_unsafe & x) = default;


    static delegate_unsafe<R (ArgTypes...)> create(R (*func)(ArgTypes...))
    {
        return delegate_unsafe<R (ArgTypes...)>(func);
    }

    template<typename X, typename Y>
    static delegate_unsafe<R (ArgTypes...)> create(X & x, R (Y::*func)(ArgTypes...))
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }

    template<typename X, typename Y>
    static delegate_unsafe<R (ArgTypes...)> create(X * x, R (Y::*func)(ArgTypes...))
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }

    template<typename X, typename Y>
    static delegate_unsafe<R (ArgTypes...)> create(X & x, R (Y::*func)(ArgTypes...) const)
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }

    template<typename X, typename Y>
    static delegate_unsafe<R (ArgTypes...)> create(X * x, R (Y::*func)(ArgTypes...) const)
    {
        return delegate_unsafe<R (ArgTypes...)>(x, func);
    }

    ~delegate_unsafe() = default;


    bool is_empty() const
    {
        return func_ == NULL;
    }

    bool is_not_empty() const
    {
        return ! is_empty();
    }


    result_type operator()(ArgTypes... args) const
    {
        if (this_ == NULL)
            return reinterpret_cast<func_ptr_type>(func_)(std::forward<ArgTypes>(args)...); // func call
        else
            return reinterpret_cast<member_func_ptr_type>(func_)(this_, std::forward<ArgTypes>(args)...); // member call
    }


    bool operator==(const delegate_unsafe & x) const
    {
        return this_ == x.this_ && func_ == x.func_;
    }

    bool operator!=(const delegate_unsafe & x) const
    {
        return ! (*this == x);
    }
};


} /* namespace util */
} /* namespace exo */

#endif /* EXO_UTIL_DELEGATE_HPP_INCLUDED */
