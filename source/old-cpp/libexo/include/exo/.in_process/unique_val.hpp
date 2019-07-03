#ifndef EXO__IN_PROCESS_UNIQUE_VAL_HPP_INCLUDED
#define EXO__IN_PROCESS_UNIQUE_VAL_HPP_INCLUDED


namespace exo {

// @todo Надо всё обдумать. Протестировать.

template <typename T, typename D>
class unique_val
{
public:

    typedef T element_type;
    typedef D deleter_type;

private:

    typedef typename std::remove_const<element_type>::type element_internal_type;


    typedef std::tuple<element_internal_type, deleter_type> tuple_type;
    tuple_type tuple;


    typedef typename
            std::conditional<std::is_pointer<element_type>::value,
                element_type,
                typename std::conditional<std::is_reference<element_type>::value,
                    element_type,
                    const element_type &>::type>::type
            in_element_type;

    typedef typename
            std::conditional<std::is_reference<deleter_type>::value,
                deleter_type,
                const deleter_type &>::type
            in_deleter_type;

    typedef typename std::remove_reference<element_type>::type && in_t_element_type;
    typedef typename std::remove_reference<deleter_type>::type && in_t_deleter_type;


    typedef typename
            std::conditional<std::is_pointer<element_type>::value,
                element_type,
                element_type *>::type
            ptr_element_type;

    typedef typename
            std::conditional<std::is_pointer<element_type>::value,
                element_type,
                const element_type *>::type
            c_ptr_element_type;

public:

    unique_val()
    : tuple()
    {
        static_assert(!std::is_pointer<deleter_type>::value, "constructed with null function pointer deleter");
    }

    unique_val(std::nullptr_t)
    : tuple()
    {
        static_assert(std::is_pointer<element_type>::value, "try assign nullptr to non pointer");
        static_assert(!std::is_pointer<deleter_type>::value, "constructed with null function pointer deleter");
    }

    explicit unique_val(in_element_type v)
    : tuple(v, deleter_type())
    {
        static_assert(!std::is_pointer<deleter_type>::value, "constructed with null function pointer deleter");
    }

    unique_val(in_element_type v, in_deleter_type d)
    : tuple(v, d)
    {}

    explicit unique_val(in_t_element_type v)
    : tuple(std::move(v), deleter_type())
    {
        static_assert(!std::is_reference<element_type>::value, "rvalue element bound to reference");
        static_assert(!std::is_pointer<deleter_type>::value, "constructed with null function pointer deleter");
    }

    unique_val(in_t_element_type v, in_t_deleter_type d)
    : tuple(std::move(v), std::move(d))
    {
        static_assert(!std::is_reference<element_type>::value, "rvalue element bound to reference");
        static_assert(!std::is_reference<deleter_type>::value, "rvalue deleter bound to reference");
    }

    unique_val(unique_val && u)
    : tuple(u.release(), std::forward<deleter_type>(u.get_deleter()))
    {}

    template<typename T2, typename D2, typename = typename
            std::enable_if<
                !std::is_array<T2>::value
                && std::is_convertible<T2, T>::value
                && ((std::is_reference<D2>::value && std::is_same<D2, D>::value /* @todo Другие случаи пока не поддерживааем (необходим копирующий конструктор, а не перемещающий). */)
                    || (!std::is_reference<D2>::value && std::is_convertible<D2, D>::value))
            >::type>
    unique_val(unique_val<T2, D2> && u)
    : tuple(u.release(), std::forward<D2>(u.get_deleter()))
    {}

    // @todo Стоит добавить конструктор от переменного кол-ва элементов, передающий эти элементы в конструктор element_type.

    ~unique_val()
    {
        reset();
    }


    unique_val & operator=(unique_val && u)
    {
        reset(u.release());
        get_deleter() = std::forward<deleter_type>(u.get_deleter());
        return *this;
    }

    template<typename T2, typename D2, typename = typename
            std::enable_if<
                !std::is_array<T2>::value
                && std::is_convertible<T2, T>::value
            >::type>
    unique_val & operator=(unique_val<T2, D2> && u)
    {
        reset(u.release());
        get_deleter() = std::forward<D2>(u.get_deleter());
        return *this;
    }

    unique_val & operator=(std::nullptr_t)
    {
        reset();
        return *this;
    }


    typename std::add_lvalue_reference<element_type>::type get()
    {
        return std::get<0>(tuple);
    }

    typename std::add_lvalue_reference<element_type const>::type get() const
    {
        return std::get<0>(tuple);
    }

    deleter_type & get_deleter()
    {
        return std::get<1>(tuple);
    }

    const deleter_type & get_deleter() const
    {
        return std::get<1>(tuple);
    }


private:

    template<typename _T>
    _T * get_ptr(_T * x)
    {
        return x;
    }

    template<typename _T>
    _T * get_ptr(_T & x)
    {
        return std::addressof(x);
    }

public:

    ptr_element_type operator->()
    {
        return get_ptr(get());
    }

    c_ptr_element_type operator->() const
    {
        return get_ptr(get());
    }

    typename std::add_lvalue_reference<std::remove_pointer<ptr_element_type>>::type operator*()
    {
        return * operator->();
    }

    typename std::add_lvalue_reference<std::remove_pointer<c_ptr_element_type>>::type operator*() const
    {
        return * operator->();
    }

    explicit operator bool() const
    {
        return get() == element_type() ? false : true;
    }


    element_type release()
    {
        element_type val = std::forward<element_type>(get());
        get() = element_type();
        return std::forward<element_type>(val);
    }

    void reset(element_type val = element_type())
    {
        std::swap(
                const_cast<element_internal_type&>(val),
                const_cast<element_internal_type&>(get()));

        if (val != element_type())
            get_deleter()(val);
    }

    void swap(unique_val & u)
    {
        std::swap(tuple, u.tuple);
    }


    unique_val(const unique_val &) = delete;
    unique_val & operator=(const unique_val &) = delete;
};

template<typename T, typename D>
class unique_val<T[], D>
{
    // now not implement
};

} /* namespace exo */

#endif /* EXO__IN_PROCESS_UNIQUE_VAL_HPP_INCLUDED */
