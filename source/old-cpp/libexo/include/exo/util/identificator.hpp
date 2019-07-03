#ifndef EXO_UTIL_IDENTIFICATOR_HPP_INCLUDED
#define EXO_UTIL_IDENTIFICATOR_HPP_INCLUDED

#include <stdexcept>
#include <set>

namespace exo {
namespace util {


/** @warnind "unsafe" потому что возвращённый идентификатор не освобождается автоматически. */
template<typename T>
class identificator_unsafe_manager
{
public:

    typedef T value_type;

private:

    const value_type max;
    const value_type min;
    value_type last;

    /** Интервал свободных идентификаторов. */
    struct free_interval
    {
        T low;
        T high;

        free_interval(T low_, T high_)
        : low(low_)
        , high(high_) { }

        bool operator<(const free_interval x) const
        {
            return high < x.low;
        }
    };

    /** Бинарное дерево всех интервалов свободных идентификаторов. */
    /* @todo Переписать с использованием exo::util::used_space */
    std::set<free_interval> free;

public:

    identificator_unsafe_manager(value_type max_, value_type min_ = 0)
    : max(max_)
    , min(min_)
    , last(max)
    , free()
    {
        if (max < min)
            throw std::invalid_argument("Максимум должен быть не менее минимума.");
        free.insert(free_interval(min, max));
    }

private:

    /* Выбирает первый (он же минимальный) элемент из it и устанавливает
     * соответствующим образом last. */
    value_type create_from_min_item(typename std::set<free_interval>::iterator it)
    {
        last = it -> low;

        if (it -> low == it -> high)
            free.erase(it);
        else
            const_cast<free_interval&>(*it).low = last + 1;

        return last;
    }

    /* Выбирает последний (он же максимальный) элемент из it и устанавливает
     * соответствующим образом last. */
    value_type create_from_max_item(typename std::set<free_interval>::iterator it)
    {
        last = it -> high;

        if (it -> low == it -> high)
            free.erase(it);
        else
            const_cast<free_interval&>(*it).high = last - 1;

        return last;
    }

public:

    /** Пытается создать идентификатор.
     * @return */
    std::pair<value_type, bool> try_create()
    {
        if (free.empty())
            return std::make_pair(value_type(), false);

        value_type recomend = last + 1;

        auto it = free.lower_bound(free_interval(recomend, recomend));

        if (it == free.end())
            return std::make_pair(create_from_min_item(free.begin()), true);
        else
        {
            if (recomend <= it -> low)
                return std::make_pair(create_from_min_item(it), true);

            if (it -> high == recomend)
                return std::make_pair(create_from_max_item(it), true);

            if (it -> high < recomend)
                throw std::logic_error("Ошибка в логике модуля.");

            free_interval i1 = *it;
            free_interval i2 = *it;

            i1.high = recomend - 1;
            i2.low = recomend + 1;

            const_cast<free_interval&>(*it) = i1;
            free.insert(i2);

            last = recomend;
            return std::make_pair(recomend, true);
        }
    }

    /** Создаёт идентификатор.
     * @return Идентификатор. */
    value_type create()
    {
        auto ret = try_create();
        if (ret.second == false)
            throw std::runtime_error("Свободные идентификаторы закончились.");
        return ret.first;
    }

    /** Пытается освободить идентификатор.
     * @param val Идентификатор.
     * @return Истина, если всё хорошо. Ложь, если val не корректно: либо val
     * уже освобождено, либо выходит за допустимый диапазон значений. */
    bool try_release(value_type val)
    {
        if (val < min || max < val)
            return false; // Выход за допустимый диапазон.

        auto it = free.lower_bound(free_interval(val, val));

        if (it != free.end())
            if (it -> low <= val && val <= it -> high)
                return false; // Идентификатор уже освобождён.

        /** Интервал перед it. */
        auto prev = free.end();
        if (it != free.begin())
        {
            prev = it;
            prev--;
        }

#if 0 // debug
        if (it != free.end())
            log_debug_msg("%d, %d, %d.", val, it -> low, it -> high);

        if (prev != free.end())
            log_debug_msg("%d, %d, %d.", val, prev -> low, prev -> high);


        if (it != free.end())
            throw_assert(val < it -> low && it -> low <= it -> high,
                    "%d, %d, %d.", val, it -> low, it -> high);

        if (prev != free.end())
            throw_assert(prev -> low <= prev -> high && prev -> low <= val,
                    "%d, %d, %d.", val, prev -> low, prev -> high);
#endif

        if (prev == free.end())
        {
            if (it == free.end())
            {
                if (free.size() != 0) // Такого быть не должно.
                    throw std::logic_error("Ошибка в логике модуля.");
                free.insert(free_interval(val, val));
            }
            else // it != free.end()
            {
                if (it -> low == val + 1)
                    const_cast<free_interval&>(*it).low = val;
                else
                    free.insert(free_interval(val, val));
            }
        }
        else // prev != free.end()
        {
            if (it == free.end())
            {
                if (prev -> high == val - 1)
                    const_cast<free_interval&>(*prev).high = val;
                else
                    free.insert(free_interval(val, val));
            }
            else // it != free.end()
            {
                if (prev -> high == val - 1)
                {
                    if (it -> low != val + 1)
                        const_cast<free_interval&>(*prev).high = val;
                    else
                    {
                        auto save = it -> high;
                        free.erase(it);
                        const_cast<free_interval&>(*prev).high = save;
                    }
                }
                else if (it -> low == val + 1)
                    const_cast<free_interval&>(*it).low = val;
                else
                    free.insert(free_interval(val, val));
            }
        }

        return true;
    }

    /** Освобождает идентификатор.
     * @param val Идентификатор. */
    void release(value_type val)
    {
        bool ok = try_release(val);
        if (ok == false)
            throw std::runtime_error("Идентификатор уже освобождён либо выходит за допустимый диапазон значений.");
    }

    value_type get_max() const
    {
        return max;
    }

    value_type get_min() const
    {
        return min;
    }

    friend void internal_check();
};


} /* namespace unil */
} /* namespace exo */

#endif /* EXO_UTIL_IDENTIFICATOR_HPP_INCLUDED */

