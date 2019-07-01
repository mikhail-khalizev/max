#ifndef EXO_MEMORY_SPACE_HPP_INCLUDED
#define EXO_MEMORY_SPACE_HPP_INCLUDED

#include <iosfwd>
#include <string>
#include <cstddef>
#include <stdexcept>
#include <type_traits>

#include <string.h>
#include <boost/functional/hash_fwd.hpp>

namespace exo {


class memory_space;
class memory_space_const;


/*
 * memory_space             - Область памяти, значения которой можно изменять.  Можно изменять и границы самой области.
 * const memory_space       - Область памяти, значения которой можно изменять.  Границы самой области изменять нельзя.
 * memory_space_const       - Область памяти, значения которой нельзя изменять. Можно изменять и границы самой области.
 * const memory_space_const - Область памяти, значения которой нельзя изменять. Границы самой области изменять нельзя.
 */


/** @note Если бы мы его назвали const_memory_space,
 * то его можно было бы спутать с 'const memory_space',
 * либо можно было бы подумать что это одно и тоже. */
class memory_space_const
{
protected:

    /** Указатель на данные. */
    char * ptr;

    /** Длина данных.
     * @todo Возможно, имеет смысл заменить len на ptr_end. И вынести ptr_type в шаблон.
     * Посмотреть на boost::interval
     * @note Нет. Оставить совместимость с iovec.
     *
     * Возможно, сделать const_space<T>, и потом memory_space : public const_space<T>.
     * Чтобы добавить
     *    template<size_t N>
     *    memory_space_const(const char (&str)[N]);
     * и т.п.
     *
     * @todo Доп класс для универсального задания 'спец. значений'. Например:
     *   (NULL, 0) - is_not_valid, is_empty,
     *   (   1, 0) - end of file, is_empty
     *   (   2, 0) - end of packet, is_empty,
     *   (   3, 0) - start of packet, is_empty.
     *            ...
     *   const memory_cpace ms_eof = memory_space::generate_special(); // increment internal var and return it.
     *   const memory_cpace ms_eop = memory_space::generate_special();
     *  */

    /* @todo change to  math::fixed. */
    size_t len;


public:


    /* Конструкторы. */

    memory_space_const();

    memory_space_const(const std::string & str);

    /** Конструкор \a memory_space_const из константой строки.
     * При этом на этапе компиляции определяется длина строки, что конечно же
     * лучше, чем на этапе выполнения.
     * @note Последний символ '\\0' не учитывается в длине строки.
     * @warning Не следует использовать в качестве аргумента массив символов
     * фиксированного размера, как например 'char buf[5]', т.к. последний символ
     * не будет учитан в длине \a memory_space_const. */
    template<size_t N>
    memory_space_const(const char (&str)[N]);

    /** Создаёт \a memory_space_const из стандартной строки языка C.
     * @param str Строка, заканчивающиеся символом '\\0'.
     * @note explicit, чтобы не происходило "случайных" преобразований
     * в \a memory_space_const с трудозатратным вычислением длины строки. */
    explicit memory_space_const(const char * str);

    memory_space_const(const void * offset, size_t len);
    memory_space_const(const void * begin, const void * end);

    /** Создаёт \a memory_space_const из подобласти \a str,
     * начинающейся со смещения \a offset байт от начала.
     * @param str Исходная область памяти.
     * @param offset Смещение в байтах.
     * @note В случае выхода за границы исходной области памяти, создаётся
     * пустой \a memory_space_const, как в конструкторе по умолчанию. */
    memory_space_const(const memory_space_const str, size_t offset);


    /* Операторы присваивания. */

    memory_space_const & operator=(std::string str);

    /** @warning Не следует использовать в качестве аргумента массив символов
     * фиксированного размера, как например 'char buf[5]', т.к. последний символ
     * не будет учитан в длине \a memory_space_const. */
    template<size_t N>
    memory_space_const & operator=(const char (&str)[N]);

    memory_space_const & operator=(const char * str);

    memory_space_const & operator=(const memory_space_const & x);


    /* Методы преобразования в другие классы. */

    std::string str() const;
    operator std::string() const;

    memory_space const_cast_() const;


    /* Методы изменения границ областей памяти. */

    void clean();

    // @todo remove_prefix -> without_prefix

    memory_space_const add_suffix(ssize_t n) const;
    memory_space_const add_prefix(ssize_t n) const;
    memory_space_const remove_suffix(ssize_t n) const;
    memory_space_const remove_prefix(ssize_t n) const;
    memory_space_const remove_prefix(size_t n) const;
    memory_space_const remove_prefix(int n) const;
    // @todo Добавить шаблонные {add,remove}_{suffix,prefix}, которые определяют тип - знаковый или беззнаковый, и на основании этого вызывают одну из основных.

    memory_space_const sub_space(size_t byte_offset) const;
    memory_space_const sub_space(size_t byte_offset, size_t byte_len) const;


    /* Методы доступа к данным области памяти. */

    /* @todo rename to begin */
    const void * data() const;
    const void * & data();

    const void * end() const;

    size_t size() const;
    size_t & size();

    /* @todo Переименовать get в map ? */

    template<typename T>
    typename std::add_lvalue_reference<
        typename std::add_const<
        typename std::remove_reference<T>::type>::type>::type
    get(size_t num = 0) const;

    template<typename T>
    typename std::add_lvalue_reference<
        typename std::add_const<
        typename std::remove_reference<T>::type>::type>::type
    get(size_t num, size_t byte_offset) const;

    template<typename T, typename C>
    C const get(size_t num = 0) const;


    /* Методы проверки чего-либо. */

    bool is_empty() const;
    bool is_not_empty() const;
    bool is_valid() const;
    bool is_not_valid() const;

    int compare(const memory_space_const & x) const;

    /** Does "this" start with "x" */
    bool starts_with(const memory_space_const & x) const;
    bool ends_with(const memory_space_const & x) const;


    /* Прочие методы. */

    void copy_to(void * ptr) const;
};


#pragma GCC diagnostic push
/* У базового класса нет виртуального деструктора,
 * но в данном случае он нам и не нужен. Так что отключаем
 * соответствующее предупреждение компилятора. */
#pragma GCC diagnostic ignored "-Weffc++"

class memory_space : public memory_space_const
{
#pragma GCC diagnostic pop

public:

    memory_space();

/* В случае явного преобразования переменной buf, объявленной как 'char buf[5]',
 * предпочтение отдаётся 'explicit memory_space(char * str);', а не
 * этой функции. Что нас не устраивает, так что закоментируем её.

    ** @note Длина memory_space приравнивается кол-ву элементов массива.
    template<size_t N>
    memory_space(char (&str)[N]);
 */

    explicit memory_space(char * str);
    explicit memory_space(unsigned char * str);
    memory_space(void * offset, size_t len);
    memory_space(void * begin, void * end);

    memory_space & operator=(char * str);
    memory_space & operator=(const memory_space & x);

    memory_space add_suffix(ssize_t n) const;
    memory_space add_prefix(ssize_t n) const;
    memory_space remove_suffix(ssize_t n) const;
    memory_space remove_prefix(ssize_t n) const;

    memory_space sub_space(size_t offset) const;
    memory_space sub_space(size_t offset, size_t len) const;

    void * data() const;
    void * & data();

    template<typename T>
    typename std::add_lvalue_reference<T>::type get(size_t num = 0) const;
    template<typename T>
    typename std::add_lvalue_reference<T>::type get(size_t num, size_t byte_offset) const;

    template<typename T>
    void set(size_t num, T val) const;
    template<typename T>
    void set(size_t num, size_t byte_offset, T val) const;

    void copy_from(void * ptr) const;
};


bool operator==(const memory_space_const & x, const memory_space_const & y);
bool operator!=(const memory_space_const & x, const memory_space_const & y);


bool operator==(const memory_space_const & x, const std::string & y);
bool operator!=(const memory_space_const & x, const std::string & y);

bool operator==(const std::string & x, const memory_space_const & y);
bool operator!=(const std::string & x, const memory_space_const & y);


template<size_t N>
bool operator==(const memory_space_const & x, const char (&y)[N]);
template<size_t N>
bool operator!=(const memory_space_const & x, const char (&y)[N]);

template<size_t N>
bool operator==(const char (&x)[N], const memory_space_const & y);
template<size_t N>
bool operator!=(const char (&x)[N], const memory_space_const & y);


template<size_t N>
bool operator==(const memory_space_const x, const memory_space_const (&y)[N]);
template<size_t N>
bool operator!=(const memory_space_const x, const memory_space_const (&y)[N]);

template<size_t N>
bool operator==(const memory_space_const (&x)[N], const memory_space_const y);
template<size_t N>
bool operator!=(const memory_space_const (&x)[N], const memory_space_const y);


#define MEMORY_SPACE_BINARY_PREDICATE(cmp, X, Y) \
    bool operator cmp (const X & x, const Y & y);

MEMORY_SPACE_BINARY_PREDICATE(< , memory_space_const, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(<=, memory_space_const, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(>=, memory_space_const, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(> , memory_space_const, memory_space_const)

MEMORY_SPACE_BINARY_PREDICATE(< , memory_space_const, std::string)
MEMORY_SPACE_BINARY_PREDICATE(<=, memory_space_const, std::string)
MEMORY_SPACE_BINARY_PREDICATE(>=, memory_space_const, std::string)
MEMORY_SPACE_BINARY_PREDICATE(> , memory_space_const, std::string)

MEMORY_SPACE_BINARY_PREDICATE(< , std::string, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(<=, std::string, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(>=, std::string, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(> , std::string, memory_space_const)

#undef MEMORY_SPACE_BINARY_PREDICATE


std::ostream & operator<<(std::ostream & o, memory_space_const space);


std::size_t hash_value(const memory_space_const space);
void hash_value(size_t & seed, const memory_space_const space);

template<size_t N>
std::size_t hash_value(const memory_space_const (&x)[N]);
template<size_t N>
void hash_value(size_t & seed, const memory_space_const (&x)[N]);




/* definitions */

inline memory_space_const::memory_space_const()
: ptr(NULL)
, len(0) { }

inline memory_space_const::memory_space_const(const std::string & str_)
: ptr(const_cast<char*>(str_.data()))
, len(str_.size()) { }

template<size_t N>
inline memory_space_const::memory_space_const(const char (&str_)[N])
: ptr(const_cast<char*>(str_))
, len(N - 1) { }

inline memory_space_const::memory_space_const(const char * str_)
: ptr(const_cast<char*>(str_))
, len((str_ == NULL) ? 0 : strlen(ptr)) { }

inline memory_space_const::memory_space_const(const void * offset, size_t len_)
: ptr(const_cast<char*>(reinterpret_cast<const char*> (offset)))
, len(len_) { }

inline memory_space_const::memory_space_const(const void * begin, const void * end)
: ptr(const_cast<char*>(reinterpret_cast<const char*> (begin)))
, len(begin <= end ? reinterpret_cast<size_t>(end) - reinterpret_cast<size_t>(begin) : 0) { }

inline memory_space_const::memory_space_const(memory_space_const str_, size_t offset)
: ptr(offset <= str_.len ? str_.ptr + offset : NULL)
, len(offset <= str_.len ? str_.len - offset : 0) { }

inline memory_space_const & memory_space_const::operator=(std::string str_)
{
    ptr = const_cast<char*>(str_.data());
    len = str_.size();
    return *this;
}

template<size_t N>
inline memory_space_const & memory_space_const::operator=(const char (&str_)[N])
{
    ptr = const_cast<char*>(str_);
    len = N - 1;
    return *this;
}

inline memory_space_const & memory_space_const::operator=(const char * str_)
{
    ptr = const_cast<char*>(str_);
    len = (str_ == NULL) ? 0 : strlen(ptr);
    return *this;
}

inline memory_space_const & memory_space_const::operator=(const memory_space_const & x)
{
    ptr = x.ptr;
    len = x.len;
    return *this;
}

inline void memory_space_const::clean()
{
    ptr = NULL;
    len = 0;
}

inline memory_space_const memory_space_const::add_suffix(ssize_t n) const
{
    size_t new_len = len + static_cast<size_t>(n);

    if (0 <= n)
    {
        if (new_len < len)
            new_len = static_cast<size_t>(-1); // to max
    }
    else
        if (len < new_len)
            new_len = 0;

    return memory_space_const(ptr, new_len);
}

inline memory_space_const memory_space_const::add_prefix(ssize_t n) const
{
    char * new_ptr = ptr - n;
    size_t new_len = len + static_cast<size_t>(n);

    if (0 <= n)
    {
        if (new_len < len)
        {
            new_len = static_cast<size_t>(-1);
            new_ptr = 0;
        }
    }
    else
        if (len < new_len)
        {
            new_len = 0;
            new_ptr = ptr + len;
        }

    return memory_space_const(new_ptr, new_len);
}

inline memory_space_const memory_space_const::remove_suffix(ssize_t n) const
{
    size_t new_len = len - static_cast<size_t>(n);

    if (0 <= n)
    {
        if (len < new_len)
            new_len = 0;
    }
    else
        if (new_len < len)
            new_len = static_cast<size_t>(-1);

    return memory_space_const(ptr, new_len);
}

inline memory_space_const memory_space_const::remove_prefix(ssize_t n) const
{
    char * new_ptr = ptr + n;
    size_t new_len = len - static_cast<size_t>(n);

    if (0 <= n)
    {
        if (len < new_len)
        {
            new_len = 0;
            new_ptr = ptr + len;
        }
    }
    else
        if (new_len < len)
        {
            new_len = static_cast<size_t>(-1);
            new_ptr = 0;
        }

    return memory_space_const(new_ptr, new_len);
}

inline memory_space_const memory_space_const::remove_prefix(size_t n) const
{
    char * new_ptr = ptr + n;
    size_t new_len = len - static_cast<size_t>(n);

    if (len < new_len)
    {
        new_len = 0;
        new_ptr = ptr + len;
    }

    return memory_space_const(new_ptr, new_len);
}

inline memory_space_const memory_space_const::remove_prefix(int n) const
{
    return remove_prefix(static_cast<size_t>(n));
}

inline const void * memory_space_const::data() const
{
    return ptr;
}

inline const void * & memory_space_const::data()
{
    return reinterpret_cast<const void * &>(const_cast<const char * &>(ptr));
}

inline const void * memory_space_const::end() const
{
    return ptr + len;
}

inline size_t memory_space_const::size() const
{
    return len;
}

inline size_t & memory_space_const::size()
{
    return len;
}

template<typename T>
inline    typename std::add_lvalue_reference<
        typename std::add_const<
        typename std::remove_reference<T>::type>::type>::type
memory_space_const::get(size_t num) const
{
    return reinterpret_cast<
            typename std::add_pointer<
            typename std::add_const<
            typename std::remove_reference<T>::type>::type>::type>(ptr)[num];
}

template<typename T>
inline    typename std::add_lvalue_reference<
        typename std::add_const<
        typename std::remove_reference<T>::type>::type>::type
memory_space_const::get(size_t num, size_t byte_offset) const
{
    return reinterpret_cast<
            typename std::add_pointer<
            typename std::add_const<
            typename std::remove_reference<T>::type>::type>::type>(&ptr[byte_offset])[num];
}

template<typename T, typename C>
inline C const memory_space_const::get(size_t num) const
{
    return static_cast<C const>(reinterpret_cast<T const *>(ptr)[num]);
}

//inline char memory_space_const::at(int i) const
//{
//    if (0 <= i && static_cast<size_t>(i) < len)
//        return ptr[i];
//
//    // throw_assert(0 <= i && (size_t)i < size(), "Выход за границы массива (%d, %d).", i, size());
//    std::__throw_out_of_range(__N("memory_space_const::at"));
//}

inline bool memory_space_const::is_empty() const
{
    return (len == 0);
}

inline bool memory_space_const::is_not_empty() const
{
    return !is_empty();
}

inline bool memory_space_const::is_valid() const
{
    return (ptr != NULL);
}

inline bool memory_space_const::is_not_valid() const
{
    return !is_valid();
}

inline int memory_space_const::compare(const memory_space_const & x) const
{
    int r = memcmp(ptr, x.ptr, len < x.len ? len : x.len);
    if (r == 0)
    {
        if (len < x.len) r = -1;
        else if (len > x.len) r = +1;
    }
    return r;
}

inline bool memory_space_const::starts_with(const memory_space_const & x) const
{
    if (x.len <= len)
        if (memcmp(ptr, x.ptr, x.len) == 0)
            return true;
    return false;
}

inline bool memory_space_const::ends_with(const memory_space_const & x) const
{
    if (x.len <= len)
        if (memcmp(ptr + len - x.len, x.ptr, x.len) == 0)
            return true;
    return false;
}

inline memory_space_const memory_space_const::sub_space(size_t byte_offset) const
{
    return remove_prefix(byte_offset);
}

inline memory_space_const memory_space_const::sub_space(size_t byte_offset, size_t byte_len) const
{
    memory_space_const ret = sub_space(byte_offset);
    ret.len = std::min(ret.len, byte_len);
    return ret;
}

inline memory_space_const::operator std::string() const
{
    return std::string(ptr, len);
}

inline std::string memory_space_const::str() const
{
    return std::string(ptr, len);
}

inline void memory_space_const::copy_to(void * ptr_to) const
{
    memcpy(ptr_to, ptr, len);
}

inline memory_space memory_space_const::const_cast_() const
{
    return memory_space(ptr, len);
}


/*
template <typename T>
inline T memory_space_const::parse(uint base) const
{
    static_assert(std::numeric_limits<T>::max() != 0, "can't determine max of T");

    const bool is_may_be_negative = ((T) (-1)) < ((T) (0));

    apr_uint64_t res;
    bool negative = _Parse(*this, res, base);

    if (res == 0)
        return 0;

    if (negative)
    {
        if (is_may_be_negative == false)
            throw_ms("Число не должно быть отрицательным. '", *this, "'.");

        if ((apr_uint64_t) (-std::numeric_limits<T>::min()) < res)
            throw_ms("Переполнение. '", *this, "'.");

        return -res;
    }
    else
    {
        if ((apr_uint64_t) std::numeric_limits<T>::max() < res)
            throw_ms("Переполнение. '", *this, "'.");

        return res;
    }
}
template <typename T>
inline void memory_space_const::parse(T & res, uint base) const
{
    res = parse<T>(base);
}
*/

inline memory_space::memory_space()
: memory_space_const() { }

/*
template<size_t N>
inline memory_space::memory_space(char (&str)[N])
: memory_space_const((void*)str, N) { }
*/

inline memory_space::memory_space(char * str_)
: memory_space_const(str_) { }

inline memory_space::memory_space(void * offset, size_t len_)
: memory_space_const(offset, len_) { }

inline memory_space::memory_space(void * begin, void * end)
: memory_space_const(begin, end) { }

inline memory_space & memory_space::operator=(char * str_)
{
    memory_space_const::operator=(str_);
    return *this;
}

inline memory_space & memory_space::operator=(const memory_space & x)
{
    memory_space_const::operator=(x);
    return *this;
}

inline memory_space memory_space::add_suffix(ssize_t n) const
{
    return static_cast<memory_space_const>(*this).add_suffix(n).const_cast_();
}

inline memory_space memory_space::add_prefix(ssize_t n) const
{
    return static_cast<memory_space_const>(*this).add_prefix(n).const_cast_();
}

inline memory_space memory_space::remove_suffix(ssize_t n) const
{
    return static_cast<memory_space_const>(*this).remove_suffix(n).const_cast_();
}

inline memory_space memory_space::remove_prefix(ssize_t n) const
{
    return static_cast<memory_space_const>(*this).remove_prefix(n).const_cast_();
}

inline memory_space memory_space::sub_space(size_t offset) const
{
    return static_cast<memory_space_const>(*this).sub_space(offset).const_cast_();
}

inline memory_space memory_space::sub_space(size_t offset, size_t len_) const
{
    return static_cast<memory_space_const>(*this).sub_space(offset, len_).const_cast_();
}

inline void * memory_space::data() const
{
    return ptr;
}

inline void * & memory_space::data()
{
    return reinterpret_cast<void * &>(ptr);
}

template<typename T>
inline typename std::add_lvalue_reference<T>::type memory_space::get(size_t num) const
{
    return reinterpret_cast<
            typename std::add_pointer<
            typename std::remove_reference<T>::type>::type>(ptr)[num];
}

template<typename T>
inline typename std::add_lvalue_reference<T>::type memory_space::get(size_t num, size_t byte_offset) const
{
    return reinterpret_cast<
            typename std::add_pointer<
            typename std::remove_reference<T>::type>::type>(&ptr[byte_offset])[num];
}

template<typename T>
inline void memory_space::set(size_t num, T val) const
{
    reinterpret_cast<
            typename std::add_pointer<
            typename std::remove_reference<T>::type>::type>(ptr)[num] = val;
}

template<typename T>
inline void memory_space::set(size_t num, size_t byte_offset, T val) const
{
    reinterpret_cast<
            typename std::add_pointer<
            typename std::remove_reference<T>::type>::type>(&ptr[byte_offset])[num] = val;
}

inline void memory_space::copy_from(void * ptr_from) const
{
    memcpy(ptr, ptr_from, len);
}


inline bool operator==(const memory_space_const & x, const memory_space_const & y)
{
    if (x.size() == y.size())
    {
        if (x.data() == y.data())
            return true;
        if (memcmp(x.data(), y.data(), x.size()) == 0)
            return true;
    }

    return false;
}

inline bool operator!=(const memory_space_const & x, const memory_space_const & y)
{
    return !(x == y);
}

inline bool operator==(const memory_space_const & x, const std::string & y)
{
    return x == memory_space_const(y);
}

inline bool operator!=(const memory_space_const & x, const std::string & y)
{
    return !(x == y);
}

inline bool operator==(const std::string & x, const memory_space_const & y)
{
    return y == x;
}

inline bool operator!=(const std::string & x, const memory_space_const & y)
{
    return !(x == y);
}

template<size_t N>
bool operator==(const memory_space_const & x, const char (&y)[N])
{
    return x == memory_space_const(y);
}

template<size_t N>
bool operator!=(const memory_space_const & x, const char (&y)[N])
{
    return !(x == y);
}

template<size_t N>
bool operator==(const char (&x)[N], const memory_space_const & y)
{
    return y == x;
}

template<size_t N>
bool operator!=(const char (&x)[N], const memory_space_const & y)
{
    return !(x == y);
}

template<size_t N>
bool operator==(const memory_space_const x, const memory_space_const (&y)[N])
{
    size_t y_len = 0;

    for (size_t i = 0; i < N; i++)
        y_len += y[i].size();

    if (x.size() != y_len)
        return false;


    const char * x_ptr = x.data();

    for (size_t i = 0; i < N; i++)
    {
        if (y[i] != memory_space_const(x_ptr, y[i].size()))
            return false;

        x_ptr += y[i].size();
    }

    return true;
}

template<size_t N>
bool operator!=(const memory_space_const x, const memory_space_const (&y)[N])
{
    return !(x == y);
}

template<size_t N>
bool operator==(const memory_space_const (&x)[N], const memory_space_const y)
{
    return y == x;
}

template<size_t N>
bool operator!=(const memory_space_const (&x)[N], const memory_space_const y)
{
    return !(x == y);
}


#define MEMORY_SPACE_BINARY_PREDICATE(cmp, X, Y)                               \
    inline bool operator cmp (const X & x, const Y & y)                        \
    {                                                                          \
        return (memory_space_const(x).compare(memory_space_const(y)) cmp 0);   \
    }

MEMORY_SPACE_BINARY_PREDICATE(< , memory_space_const, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(<=, memory_space_const, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(>=, memory_space_const, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(> , memory_space_const, memory_space_const)

MEMORY_SPACE_BINARY_PREDICATE(< , memory_space_const, std::string)
MEMORY_SPACE_BINARY_PREDICATE(<=, memory_space_const, std::string)
MEMORY_SPACE_BINARY_PREDICATE(>=, memory_space_const, std::string)
MEMORY_SPACE_BINARY_PREDICATE(> , memory_space_const, std::string)

MEMORY_SPACE_BINARY_PREDICATE(< , std::string, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(<=, std::string, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(>=, std::string, memory_space_const)
MEMORY_SPACE_BINARY_PREDICATE(> , std::string, memory_space_const)

#undef MEMORY_SPACE_BINARY_PREDICATE


inline std::size_t hash_value(const memory_space_const space)
{
    size_t seed = 0;
    hash_value(seed, space);
    return seed;
}

inline void hash_value(size_t & seed, const memory_space_const space)
{
    boost::hash_range(seed, & space.get<char>(), & space.get<char>() + space.size());
}

template<size_t N>
inline std::size_t hash_value(const memory_space_const(&x)[N])
{
    size_t seed = 0;
    hash_value(seed, x);
    return seed;
}

template<size_t N>
inline void hash_value(size_t & seed, const memory_space_const(&x)[N])
{
    for (size_t i = 0; i < N; i++)
        hash_value(seed, x[i]);
}


} /* namespace exo */

#endif /* EXO_MEMORY_SPACE_HPP_INCLUDED */

