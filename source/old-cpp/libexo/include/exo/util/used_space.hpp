#ifndef EXO_UTIL_USED_SPACE_HPP_INCLUDED
#define EXO_UTIL_USED_SPACE_HPP_INCLUDED

#include <map>
#include <tuple>
#include <limits>
#include <stdexcept>


namespace exo {
namespace util {


/* @todo http://www.boost.org/doc/libs/1_54_0/libs/concept_check/creating_concepts.htm */

// always  x_begin <= y_begin
// void combine(D & x, D && y, T x_begin, T x_end, T y_begin, T y_end);

namespace detail {

struct nil
{};


template<typename T, typename D>
struct useful_data_for_used_space_traits
{
    static void combine_(std::tuple<T, D> & x, std::tuple<T, D> & y, T x_begin, T y_begin)
    {
        combine(std::get<1>(x),
                std::get<1>(y),
                x_begin,
                std::get<0>(x),
                y_begin,
                std::get<0>(y));

        std::get<0>(x) = std::get<0>(y); // set end.
    }
};

template<typename T>
struct useful_data_for_used_space_traits<T, nil>
{
    static void combine_(std::tuple<T, nil> & x, std::tuple<T, nil> & y, T, T)
    {
        std::get<0>(x) = std::get<0>(y);
    }
};

} /* namespace detail */


/** @todo Доработать const методы и добавить const_iterator. */
template<typename T, typename D = detail::nil>
class used_space
{
    // min почему то "undefined reference" при T = uint_<32>. Заменим на get_min.
    //static constexpr T min = std::numeric_limits<T>::min();
    std::map<T, std::tuple<T, D> > spaces;   /* [T start, T end)  D - useful data */

    static T get_min()
    {
        return std::numeric_limits<T>::min();
    }

public:

    class iterator
    {
    private:

        typename std::map<T, std::tuple<T, D> >::iterator iter;

        iterator(decltype(iter) x)
        : iter(x)
        {}

        friend class used_space;

    public:

        T get_begin() const
        {
            return iter -> first;
        }

        T get_end() const
        {
            return std::get<0>(iter -> second);
        }


        D & operator *() const
        {
            return std::get<1>(iter -> second);
        }

        D * operator ->() const
        {
            return & std::get<1>(iter -> second);
        }

        iterator & operator ++()
        {
            ++iter;
            return *this;
        }

        iterator operator ++(int)
        {
            iterator tmp = *this;
            iter++;
            return tmp;
        }

        iterator & operator --()
        {
            --iter;
            return *this;
        }

        iterator operator --(int)
        {
            iterator tmp = *this;
            iter--;
            return tmp;
        }

        bool operator ==(const iterator & x) const
        {
            return iter == x.iter;
        }

        bool operator !=(const iterator & x) const
        {
            return iter != x.iter;
        }
    };


    used_space()
    : spaces()
    {}


    iterator begin()
    {
        return iterator(spaces.begin());
    }

    iterator end()
    {
        return iterator(spaces.end());
    }

    size_t size() const
    {
        return spaces.size();
    }


    void clear()
    {
        spaces.clear();
    }

// +
    iterator find(T const val, bool with_rigth_bound = true)
    {
        auto iter = spaces.upper_bound(val);

        if (iter == spaces.begin())
            return end();

        iter--;

        if (iterator(iter).get_end() == get_min())
            return iterator(iter);

        if (val < iterator(iter).get_end()
                || (with_rigth_bound && val == iterator(iter).get_end()))
            return iterator(iter);

        return end();
    }

// +
    iterator lower_bound(T const val, bool with_rigth_bound = true)
    {
        auto iter = spaces.upper_bound(val);

        if (iter == spaces.begin())
            return iterator(iter);

        auto iter_mm = iter;
        iter_mm--;

        if (iterator(iter_mm).get_end() == get_min())
            return iterator(iter_mm);

        if (val < iterator(iter_mm).get_end()
                || (with_rigth_bound && val == iterator(iter_mm).get_end()))
            return iterator(iter_mm);
        else
            return iterator(iter);
    }

// +
    bool contains(T const val, bool with_rigth_bound = true)
    {
        return find(val, with_rigth_bound) != end();
    }

// +
    iterator set_end(const iterator cur, T const new_end)
    {
        if (new_end == cur.get_begin())
            throw std::out_of_range("Попытка установить нулевую длину промежутка.");

        if (new_end < cur.get_begin() && new_end != get_min())
            throw std::out_of_range("Попытка установить отрицательную длину промежутка.");

        iterator next = cur;
        next++;

        while (next != end())
        {
            if (new_end < next.get_begin() && new_end != get_min())
                break;

            detail::useful_data_for_used_space_traits<T, D>::combine_(cur.iter -> second, next.iter -> second, cur.iter -> first, next.iter -> first);
            next = iterator(spaces.erase(next.iter));
        }

        if (cur.get_end() == get_min() || new_end == get_min())
            std::get<0>(cur.iter -> second) = new_end;
        else
            std::get<0>(cur.iter -> second) = std::max(cur.get_end(), new_end);

        return cur;
    }

// +
    /** Добавляет область [begin, end). */
    iterator add(T new_begin, const T new_end)
    {
        if (new_end == new_begin)
            throw std::out_of_range("Попытка добавить пустой промежуток.");

        if (new_end < new_begin && new_end != get_min())
            throw std::out_of_range("Попытка добавить промежуток отрицательной длины.");



        auto iter_combine_begin = spaces.lower_bound(new_begin);

        if (iter_combine_begin != spaces.begin())
        {
            auto iter_before = iter_combine_begin;
            iter_before--;

            if (new_begin <= iterator(iter_before).get_end() || iterator(iter_before).get_end() == get_min())
                return set_end(iterator(iter_before), new_end);
        }


        if (iter_combine_begin != spaces.end())
            if (iterator(iter_combine_begin).get_begin() <= new_end || new_end == get_min())
            {
                const_cast<T&>(iter_combine_begin -> first) = new_begin;
                return set_end(iterator(iter_combine_begin), new_end);
            }


        auto ret = spaces.insert(std::make_pair(new_begin, std::tuple<T, D>(new_end, D())));
        if (ret.second == false)
            throw std::logic_error("Элемент уже существует, хотя не должен.");

        return iterator(ret.first);
    }
};

template<typename T, typename D1 = detail::nil, typename D2 = detail::nil>
bool equal_spaces(used_space<T, D1> & a, used_space<T, D2> & b)
{
    if (a.size() != b.size())
        return false;

    auto iter1 = a.begin();
    auto iter2 = b.begin();

    for (; iter1 != a.end(); iter1++, iter2++)
        if ((iter1.get_begin() != iter2.get_begin()) || (iter1.get_end() != iter2.get_end()))
                return false;

    return true;
}


} /* namespace util */
} /* namespace exo */

#endif /* EXO_UTIL_USED_SPACE_HPP_INCLUDED */

