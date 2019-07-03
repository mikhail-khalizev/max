#ifndef EXO_CONTAINERS_INTEGRETY_LIST_DOUBLE_ITEM_HPP_INCLUDED
#define EXO_CONTAINERS_INTEGRETY_LIST_DOUBLE_ITEM_HPP_INCLUDED

#include <algorithm> /* Для std::swap. */

namespace izh_bs {


/** @brief Встраиваемая реализация двусвязного списка.
 *
 * Пример использования.
 * @code
 *      #pragma GCC diagnostic push
 *      /  У базового класса нет виртуального деструктора,
 *       * но в данном случае он нам и не нужен. Так что отключаем
 *       * соответствующее предупреждение компилятора. /
 *      #pragma GCC diagnostic ignored "-Weffc++"
 *
 *      class my_class : private list_double_item<my_class>
 *      {
 *      #pragma GCC diagnostic pop
 *
 *          /  Необходимо, чтобы list_double_item<my_class> разрешено было выполнить
 *           * повышающее и понижающее преобразование.  /
 *          friend class list_double_item<my_class>;
 *      }
 *
 *      int main()
 *      {
 *          ...
 *
 *          my_class a, b, c;
 *          a.insert_single_after(b);
 *          b.insert_single_after(c);
 *
 *          ...
 *      }
 * @endcode
 *
 */


/* @todo rename to 'list_double_base'
  list_double_item<T> : public list_double_base< list_double_item<T> >;
*/
template<typename T, int id = 0>
class list_double_item
{
private:

    list_double_item * prev;
    list_double_item * next;

    list_double_item(const list_double_item &) = delete;
    list_double_item & operator=(const list_double_item &) = delete;

public:

    typedef list_double_item item_type;
    typedef T value_type;


    /** Создаёт элемент не принадлежащий никакому списку. */
    list_double_item();

    /** Деструктор производит удаление элемента из списка, если элемент состоит в списке. */
    ~list_double_item();


    /** Удаляет элемент из списка в котором он находится (если находится) и инициализирует его конструктором по умолчанию. */
    void remove();

    /** Меняет местами два элемента.
     * @note Элементы могут находиться как в разных списках так и в одном и том же. */
    void swap(value_type & val);


    /** Помещает элемент \a val за текущем элементом.
     * @note Если элемент \a val на момент вызова функции состоял в каком-нибудь списке, то он удаляется из него. */
    void insert_single_after(value_type & val);

    /** Помещает элемент \a val перед текущем элементом.
     * @note Если элемент \a val на момент вызова функции состоял в каком-нибудь списке, то он удаляется из него. */
    void insert_single_before(value_type & val);


    /** Помещает элемент \a val со всем списком в котором он состоит за текущем элементом. */
    void insert_list_with_head_after(value_type & list);

    /** Помещает элемент \a val со всем списком в котором он состоит перед текущем элементом. */
    void insert_list_with_head_before(value_type & list);


    /** Помещает список в котором состоит элемент \a val (кроме самого себя) за текущем элементом. */
    void insert_list_after(value_type & list);

    /** Помещает список в котором состоит элемент \a val (кроме самого себя) перед текущем элементом. */
    void insert_list_before(value_type & list);


    /** Разделяет список на два. */
    void split(value_type & val);


    /** Возвращает признак показывающий пуст ли список (сам элемент не считается).
     * @return Истина, если список пуст, иначе ложь. */
    bool is_empty() const;

    /** Возвращает признак показывающий содержит ли список только один элемент (сам элемент не считается).
     * @return Истина, если в списке только один элемент, иначе ложь. */
    bool is_singular() const;

    /** Возвращает признак показывающий не пуст ли список (сам элемент не считается).
     * @return Истина, если список не пуст, иначе ложь. */
    bool is_not_empty() const;


    /** Возвращает значение элемента списка.
     * @return Значение элемента списка.
     * @warning Класс \a list_ltem должен быть объявлен
     * дружественным классом в классе \a value_type. */
    value_type & get_value();


    /** @warning Элемент, на который указывает итератор нельзя удалять
     * или заменять, иначе переход к следующему или предыдущему элементу
     * будет работать некорректно.
     *  Любые другие элементы можно удалять и заменять. */
    class iterator
    {
        item_type * cur_item;

        friend class list_double_item<T, id>;
        iterator(item_type * start_item);

    public:

        iterator(value_type & start_item);
        iterator(value_type * start_item);

        bool operator==(const iterator &) const;
        bool operator!=(const iterator &) const;

        iterator & operator++();
        iterator & operator--();
        iterator operator++(int);
        iterator operator--(int);

        /** Возвращает ссылку на значение элемента списка.
         * @return Ссылка на значение элемента списка.
         * @warning Класс \a list_double_item должен быть объявлен
         * дружественным классом в классе \a value_type. */
        value_type & operator*();

        /** Возвращает указатель на значение элемента списка.
         * @return Указатель на значение элемента списка.
         * @warning Класс \a list_double_item должен быть объявлен
         * дружественным классом в классе \a value_type. */
        value_type * operator->();
    };


    /** Возвращает итератор на первый элемент списка. */
    iterator begin();
    /** Возвращает итератор на элемент, следующий за последним элементом списка. */
    iterator end();

    /** Возвращает итератор на самого себя.
     * Это необходимо, когда нужно обойти все элементы списка.
     * В этом случае перебор всех элементов необходимо выполнять с помощью цикла:
     *  vi = lst -> myself();
     *  do {..}
     *  while(++vi != lst -> myself()); */
    iterator myself();

private:

    void init();
    void remove_uninit();


    /** Возвращает ссылку на элемет списка по его значению.
     *  Метод используется только в list_double и больше нигде
     * использоваться не должен, поэтому и объявлен как private.
     * @warning Класс \a list_item должен быть объявлен
     * дружественным классом в классе \a value_type. */
    static item_type & get_item(value_type & val);

    /** Возвращает указатель на элемет списка по указателю на его значению.
     *  Метод используется только в list_double и больше нигде
     * использоваться не должен, поэтому и объявлен как private.
     * @warning Класс \a list_item должен быть объявлен
     * дружественным классом в классе \a value_type. */
    static item_type * get_item(value_type * val);


    /** Устанавливает два элемента как следующие друг за другом.
     * @param prev Первый элемент.
     * @param next Второй элемент. */
    static void _set(item_type * prev, item_type * next);

    /** Устанавливает элемент \a item как элемент находящийся между заданными элементами.
     * @param prev Элемент после которого установится \a item.
     * @param item Элемент.
     * @param next Элемент перед которым установится \a item. */
    static void _set(item_type * prev, item_type & item, item_type * next);

    /** Устанавливает связанную цепочку элементов (start, end) как цепочку
     * находящуюся между заданными элементами (prev, next).
     * @param prev Элемент после которого установится начало цепочки.
     * @param start Первый элемент связанной цепочки.
     * @param end Последний элемент связанной цепочки.
     * @param next Элемент перед которым установится конец цепочки.
     * @warning Целостность цепочки (т.е. то, что между \a start и \a end есть связь) не проверяется. */
    static void _set(item_type * prev, item_type * start, item_type * end, item_type * next);
};



/* --- Определения методов list_double_item. --- */

template<typename T, int id>
list_double_item<T, id> & list_double_item<T, id>::get_item(value_type & val)
{
    return val;
}

template<typename T, int id>
list_double_item<T, id> * list_double_item<T, id>::get_item(value_type * val)
{
    return val;
}

template<typename T, int id>
T & list_double_item<T, id>::get_value()
{
    return * static_cast<T*>(this);
}

template<typename T, int id>
void list_double_item<T, id>::_set(item_type * prev, item_type * next)
{
    prev -> next = next;
    next -> prev = prev;
}

template<typename T, int id>
void list_double_item<T, id>::_set(item_type * prev, item_type & item, item_type * next)
{
    _set(prev, &item);
    _set(&item, next);
}

template<typename T, int id>
void list_double_item<T, id>::_set(item_type * prev, item_type * start, item_type * end, item_type * next)
{
    _set(prev, start);
    _set(end, next);
}


template<typename T, int id>
list_double_item<T, id>::list_double_item()
: prev(this)
, next(this) { }

template<typename T, int id>
void list_double_item<T, id>::init()
{
    prev = next = this;
}

template<typename T, int id>
list_double_item<T, id>::~list_double_item()
{
    remove_uninit();
}

template<typename T, int id>
void list_double_item<T, id>::remove_uninit()
{
    _set(prev, next);
}

template<typename T, int id>
void list_double_item<T, id>::remove()
{
    remove_uninit();
    init();
}

template<typename T, int id>
void list_double_item<T, id>::swap(value_type & val)
{
    item_type & item_1 = * this;
    item_type * prev_1 = item_1.prev;
    item_type * next_1 = item_1.next;

    item_type & item_2 = val;
    item_type * prev_2 = item_2.prev;
    item_type * next_2 = item_2.next;

    bool i1_e = item_1.is_empty();
    bool i2_e = item_2.is_empty();

    if (i1_e)
        item_2.init();
    else
        _set(prev_1, item_2, next_1);

    if (i2_e)
        item_1.init();
    else
        _set(prev_2, item_1, next_2);
}

template<typename T, int id>
void list_double_item<T, id>::insert_single_after(value_type & val)
{
    get_item(val).remove_uninit();
    _set(this, val, this -> next);
}

template<typename T, int id>
void list_double_item<T, id>::insert_single_before(value_type & val)
{
    get_item(val).remove_uninit();
    _set(this -> prev, val, this);
}

template<typename T, int id>
void list_double_item<T, id>::insert_list_with_head_after(value_type & list)
{
    _set(this, list, list.prev, this -> next);
}

template<typename T, int id>
void list_double_item<T, id>::insert_list_with_head_before(value_type & list)
{
    _set(this -> prev, list, list.prev, this);
}

template<typename T, int id>
void list_double_item<T, id>::insert_list_after(value_type & list)
{
    item_type & item = list;

    if (item.is_empty())
        return;

    _set(this, item.next, item.prev, this -> next);
    item.init();
}

template<typename T, int id>
void list_double_item<T, id>::insert_list_before(value_type & list)
{
    item_type & item = list;

    if (item.is_empty())
        return;

    _set(this -> prev, item.next, item.prev, this);
    item.init();
}

template<typename T, int id>
void list_double_item<T, id>::split(value_type & val)
{
    _set(val.prev, this, prev, &val);
}


template<typename T, int id>
bool list_double_item<T, id>::is_empty() const
{
    return (this == this -> next);
}

template<typename T, int id>
bool list_double_item<T, id>::is_not_empty() const
{
    return ! is_empty();
}

template<typename T, int id>
bool list_double_item<T, id>::is_singular() const
{
    return is_not_empty() && (this -> next == this -> prev);
}


template<typename T, int id>
typename list_double_item<T, id>::iterator list_double_item<T, id>::begin()
{
    return iterator(this -> next);
}

template<typename T, int id>
typename list_double_item<T, id>::iterator list_double_item<T, id>::end()
{
    return iterator(this);
}

template<typename T, int id>
typename list_double_item<T, id>::iterator list_double_item<T, id>::myself()
{
    return iterator(this);
}


/* --- Определения методов list_double_item::iterator. --- */

template<typename T, int id>
list_double_item<T, id>::iterator::iterator(item_type * start_item)
: cur_item(start_item)
{}

template<typename T, int id>
list_double_item<T, id>::iterator::iterator(value_type * start_item)
: cur_item(start_item)
{}

template<typename T, int id>
bool list_double_item<T, id>::iterator::operator==(const typename list_double_item<T, id>::iterator & x) const
{
    return cur_item == x.cur_item;
}

template<typename T, int id>
bool list_double_item<T, id>::iterator::operator!=(const typename list_double_item<T, id>::iterator & x) const
{
    return ! (*this == x);
}

template<typename T, int id>
typename list_double_item<T, id>::iterator & list_double_item<T, id>::iterator::operator++()
{
    cur_item = cur_item -> next;
    return *this;
}

template<typename T, int id>
typename list_double_item<T, id>::iterator & list_double_item<T, id>::iterator::operator--()
{
    cur_item = cur_item -> prev;
    return *this;
}

template<typename T, int id>
typename list_double_item<T, id>::iterator list_double_item<T, id>::iterator::operator++(int)
{
    typename list_double_item<T, id>::iterator ret = *this;
    cur_item = cur_item -> next;
    return ret;
}

template<typename T, int id>
typename list_double_item<T, id>::iterator list_double_item<T, id>::iterator::operator--(int)
{
    typename list_double_item<T, id>::iterator ret = *this;
    cur_item = cur_item -> prev;
    return ret;
}

template<typename T, int id>
T & list_double_item<T, id>::iterator::operator*()
{
    return cur_item -> get_value();
}

template<typename T, int id>
T * list_double_item<T, id>::iterator::operator->()
{
    return &(cur_item -> get_value());
}


} /* namespace izh_bs */

#endif /* EXO_CONTAINERS_INTEGRETY_LIST_DOUBLE_ITEM_HPP_INCLUDED */
