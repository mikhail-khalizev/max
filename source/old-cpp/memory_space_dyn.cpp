#include <memory> // unique_ptr
#include <cstddef> // for malloc, realloc, free.
#include <algorithm>

#include <exo/memory_space_dyn.hpp>
#include <exo/math/only_last_set.hpp>

#if 0
namespace exo {


namespace detail {

memory_space_dyn_internal::memory_space_dyn_internal()
: buf()
, offset()
, size()
, ref_count(1)
, is_malloc_buf_(true)
{}

memory_space_dyn_internal::~memory_space_dyn_internal()
{
    if (buf.is_not_empty() && is_malloc_buf())
        free(buf.data());
}

} /* namespace detail */


/** Глобальный mutex для случая когда создаётся копия memory_space_dyn, уделение которого производиться в другом потоке.
 * @note Создаётся через new, чтобы при завершении многопоточного приложения не получилось, что главный поток
 * уничтожил данный mutex, а другой собирается его использовать.
 *
 * boost::mutex & get_mutex_memory_space_dyn_tors()
 * {
 *    static boost::mutex * mutex = NULL;
 *    if (mutex != NULL)
 *        mutex = new boost::mutex();
 *    return * mutex;
 * }
 *
 * @todo Зачем вообще такой случай рассматривать? Если такое произошло, то нарушена синхронизация в многопотоковой
 * программе. И даже если мы предусмотрим этот случай программа всё равно правильно работать от этого не станет.
 * Не следует удалять этот комментарий, чтобы было видно, что эта особенность была учтёна при разработке модуля. */


static size_t recommend_size(size_t s)
{
    /* Думаю, для уменьшения фрагментации стоит выделять данные
     * не произвольного размера, напрямую зависимое от 's' (типа '1.125 * s'),
     * а фиксированного размера, например в виде степени двойки: 32, 64, 128 ...
     *
     * Для уменьшения потерь будем использовать не степень двойки, а число вида:
     *  (n_step + 8) << (n_base - 3)), где 0 <= n_step <= 7.
     *
     * Покажем его на примерах (в бинарном представлении):
     *  0...0 1000 0..0
     *  0...0 1001 0..0
     *  0...0 1010 0..0
     *        ...
     *  0...0 1111 0..0
     *  0..01 0000 0..0
     *  0..01 0010 0..0
     *
     * Потери памяти при этом составляют 12,5% в худшем случае. */

    size_t ols = exo::math::only_last_set(s);
    size_t ret = s;

    if ((ols >> 3) != 0) // Если ols достаточно большой.
    {
        size_t mask = (ols >> 3) - 1;
        ret = (s + mask) & (~mask); // Округление в большую сторону.
    }

    /* Предполагаем, что потери на malloc составляют около двух указателей,
     * поэтому увеличиваем слишком маленькие значения ret. */
    return std::max(ret, 2 * sizeof(size_t));
}


void memory_space_dyn::release()
{
    if (internal == NULL)
        return;

    if (internal -> ref_count <= 1) /* На всякий случай '<=' вместо '=='. */
        delete internal; /* Мы единственные, кто сылается на данный 'memory_space_dyn_internal'. Удаляем его. */
    else
        internal -> ref_count--;

    internal = NULL;
}


memory_space_dyn::memory_space_dyn()
: internal(new detail::memory_space_dyn_internal) // @todo Не надо спешить с 'new'.
{}

memory_space_dyn::memory_space_dyn(const memory_space_dyn & x)
: internal(x.internal)
{
    internal -> ref_count++;
}

memory_space_dyn::memory_space_dyn(memory_space_dyn && x)
: internal(x.internal)
{
    /* 'x' - временный объект. Просто обнулим его 'internal'. */
    x.internal = NULL;
}

memory_space_dyn & memory_space_dyn::operator=(const memory_space_dyn & x)
{
    if (internal == x.internal)
        return * this;

    release();

    internal = x.internal;
    internal -> ref_count++;

    return * this;
}

memory_space_dyn & memory_space_dyn::operator=(memory_space_dyn && x)
{
    if (internal == x.internal)
        return * this;

    release();
    internal = x.internal;
    x.internal = NULL;

    return * this;
}

memory_space_dyn::~memory_space_dyn()
{
    release();
}


size_t memory_space_dyn::size() const
{
    return (internal == NULL) ? 0 : internal -> size;
}

size_t memory_space_dyn::capacity() const
{
    return (internal == NULL) ? 0 : internal -> buf.size();
}

void memory_space_dyn::reserve(size_t len)
{
    if (internal == NULL)
    {
        if (len == 0)
            return;
        else
            internal = new detail::memory_space_dyn_internal();
    }


    if (internal -> offset + len < internal -> buf.size())
        return; // Итак достаточно места.

    if (internal -> ref_count <= 1 && internal -> is_malloc_buf())
    {
        len = recommend_size(len + internal -> offset);

        void * ptr = realloc(internal -> buf.data(), len);
        if (ptr == NULL)
            throw std::bad_alloc();

        internal -> buf = memory_space(ptr, len);
    }
    else
    {
        std::unique_ptr<detail::memory_space_dyn_internal> new_internal(new detail::memory_space_dyn_internal());

        len = recommend_size(len);

        void * ptr = malloc(len);
        if (ptr == NULL)
            throw std::bad_alloc();

        new_internal -> buf = memory_space(ptr, len);
        new_internal -> offset = 0;
        new_internal -> size = internal -> size;

        memory_space_const used = internal -> buf.sub_space(internal -> offset, internal -> size);
        used.copy_to(ptr);


        release();
        internal = new_internal.release();
    }
}

} /* namespace exo */
#endif
