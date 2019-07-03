#ifndef EXO_UTIL_VALUE_OF_POINTER_ITERATOR_HPP_INCLUDED
#define EXO_UTIL_VALUE_OF_POINTER_ITERATOR_HPP_INCLUDED

#include <iterator>
#include <type_traits>
#include <exo/util/implicit_cast.hpp>

namespace exo {
namespace util {


template<typename Iterator>
class value_of_pointer_iterator
{
private:

    typedef std::iterator_traits<Iterator> __traits_type;

protected:

    Iterator _base;

public:

    static_assert(std::is_pointer<typename __traits_type::value_type>::value == true, "value_type must be pointer.");


    typedef Iterator iterator_type;
    typedef typename __traits_type::iterator_category iterator_category;
    typedef typename std::remove_pointer<typename __traits_type::value_type>::type value_type;
    typedef typename __traits_type::difference_type difference_type;
    typedef value_type & reference;
    typedef value_type * pointer;


    value_of_pointer_iterator()
    : _base(Iterator())
    {}

    explicit value_of_pointer_iterator(const Iterator & i)
    : _base(i)
    {}


    template<typename Iter>
    value_of_pointer_iterator(const value_of_pointer_iterator<Iter> & i)
    : _base(implicit_cast<Iterator>(i.base()))
    {}


    reference operator*() const
    {
        return *(*_base);
    }

    pointer operator->() const
    {
        return *_base;
    }

    // Random access iterator requirements
    reference operator[](const difference_type & n) const
    {
        return *_base[n];
    }


    value_of_pointer_iterator & operator++()
    {
        ++_base;
        return *this;
    }

    value_of_pointer_iterator operator++(int)
    {
        return value_of_pointer_iterator(_base++);
    }

    // Bidirectional iterator requirements
    value_of_pointer_iterator & operator--()
    {
        --_base;
        return *this;
    }

    value_of_pointer_iterator operator--(int)
    {
        return value_of_pointer_iterator(_base--);
    }


    value_of_pointer_iterator & operator+=(const difference_type & n)
    {
        _base += n;
        return *this;
    }

    value_of_pointer_iterator operator+(const difference_type & n) const
    {
        return value_of_pointer_iterator(_base + n);
    }

    value_of_pointer_iterator & operator-=(const difference_type & n)
    {
        _base -= n;
        return *this;
    }

    value_of_pointer_iterator operator-(const difference_type & n) const
    {
        return value_of_pointer_iterator(_base - n);
    }


    difference_type operator-(const value_of_pointer_iterator & i) const
    {
        return _base - i.base();
    }


    const Iterator & base() const
    {
        return _base;
    }
};

// Forward iterator requirements
template<typename IteratorL, typename IteratorR>
inline bool operator==(
        const value_of_pointer_iterator<IteratorL>& __lhs,
        const value_of_pointer_iterator<IteratorR>& __rhs)
{
    return __lhs.base() == __rhs.base();
}

template<typename Iterator>
inline bool operator==(
        const value_of_pointer_iterator<Iterator>& __lhs,
        const value_of_pointer_iterator<Iterator>& __rhs)
{
    return __lhs.base() == __rhs.base();
}

template<typename IteratorL, typename IteratorR>
inline bool operator!=(
        const value_of_pointer_iterator<IteratorL>& __lhs,
        const value_of_pointer_iterator<IteratorR>& __rhs)
{
    return __lhs.base() != __rhs.base();
}

template<typename Iterator>
inline bool operator!=(
        const value_of_pointer_iterator<Iterator>& __lhs,
        const value_of_pointer_iterator<Iterator>& __rhs)
{
    return __lhs.base() != __rhs.base();
}


template<typename Iterator>
value_of_pointer_iterator<Iterator> value_of_pointer_worker(const Iterator & i)
{
    return value_of_pointer_iterator<Iterator>(i);
}


} /* namespace util */
} /* namespace exo */

#endif /* EXO_UTIL_VALUE_OF_POINTER_ITERATOR_HPP_INCLUDED */
