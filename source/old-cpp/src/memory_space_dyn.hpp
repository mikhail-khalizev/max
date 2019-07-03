#ifndef EXO_MEMORY_SPACE_DYN_HPP_INCLUDED
#define EXO_MEMORY_SPACE_DYN_HPP_INCLUDED

#include <exo/memory_space.hpp>


namespace exo {


namespace detail {

class memory_space_dyn_internal
{
public:

    memory_space buf;
    size_t offset, size;

private:

    /** Кол-во ссылок из memory_space_dyn. В случае, если (1 < ref_count) buf изменять запрещено. */
    size_t ref_count;

    /** Истина, ессли buf является областью выделенной с помощью malloc, а не статическими данными.
     * @todo Возможно, имеет смысл объединить с ref_count для уменьшения используемого места.
     * Если ref_count < 0 - static; ref_count > 0 - malloc. */
    bool is_malloc_buf_;


public:

    memory_space_dyn_internal();
    memory_space_dyn_internal(const memory_space_dyn_internal &) = delete;
    memory_space_dyn_internal & operator=(const memory_space_dyn_internal &) = delete;
    ~memory_space_dyn_internal();


    bool is_malloc_buf()
    {
        return is_malloc_buf_;
    }

//    void set_malloc_buf(bool v)
//    {
//        is_malloc_buf_ = v;
//    }


    size_t get_ref_count()
    {
        return ref_count;
    }

//    void set_ref_count(size_t v)
//    {
//        ref_count = v;
//    }
};

} /* namespace detail */


/**    exo::memory_space_dyn - как std::string, только жёстко используется malloc, realloc, free.
 *  @note Не является потокобезопасным.
 *
 *  @todo Должен являтся потокобезопасным в следующем смысле. Несколько потоков используют memory_space_dyn,
 * внутренняя структура которых является общей. При этом изменение класса должно безопасно скопировать внутренюю
 * структуру. */
class memory_space_dyn
{
    detail::memory_space_dyn_internal * internal;

    /** Безопасно устанавливает internal равным NULL. */
    void release();

public:

    memory_space_dyn();
    memory_space_dyn(const memory_space_dyn & x);
    memory_space_dyn(memory_space_dyn && x);

    static memory_space_dyn convert_form_static(memory_space buf);
    static memory_space_dyn convert_form_malloc(memory_space buf);

    memory_space_dyn & operator=(const memory_space_dyn & x);
    memory_space_dyn & operator=(memory_space_dyn && x);

    ~memory_space_dyn();


    size_t size() const;
    size_t capacity() const;
    void reserve(size_t len = 0);
    void shrink_to_fit();


    /** @note copy space before return */
    memory_space ms_rw();
    memory_space_const ms_ro() const;


    memory_space_dyn & append(const memory_space_dyn & x);
    memory_space_dyn & append(const memory_space_dyn & x, size_t pos, size_t n);

    memory_space_dyn & insert(size_t offset, const memory_space_dyn & x);
    memory_space_dyn & insert(size_t offset, const memory_space_dyn & x, size_t pos, size_t n);


    memory_space_dyn & operator+=(const memory_space_dyn & x)
    {
        return append(x);
    }

    memory_space_dyn & operator<<(const memory_space_dyn & x)
    {
        return append(x);
    }
};

inline memory_space_dyn operator+(const memory_space_dyn & a, const memory_space_dyn & b)
{
    memory_space_dyn ret = a;
    ret.append(b);
    return ret;
}

inline memory_space_dyn operator+(memory_space_dyn && a, const memory_space_dyn & b)
{
    a.append(b);
    return a; // Конструктор из временного объекта.
}

inline memory_space_dyn operator+(const memory_space_dyn & a, memory_space_dyn && b)
{
    b.insert(0, a);
    return b; // Конструктор из временного объекта.
}

inline memory_space_dyn operator+(memory_space_dyn && a, memory_space_dyn && b)
{
    const auto res_size = a.size() + b.size();

    // @todo Усовершенствовать алгоритм.

    if (a.capacity() < res_size && res_size <= b.capacity()) // Если в 'a' не влезет, но влезет в 'b'.
    {
        b.insert(0, a);
        return b; // Конструктор из временного объекта.
    }
    else
    {
        a.append(b);
        return a; // Конструктор из временного объекта.
    }
}


} /* namespace exo */

#endif /* EXO_MEMORY_SPACE_DYN_HPP_INCLUDED */
