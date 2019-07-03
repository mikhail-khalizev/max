#ifndef IZH_BS_VIAUS_NEW_ARCH_ARCH_HPP_INCLUDED
#define IZH_BS_VIAUS_NEW_ARCH_ARCH_HPP_INCLUDED

#include <memory>
#include <QObject>
#include <QString>
#include <QReadWriteLock>

namespace izh_bs {
namespace viaus {


/* Обдумывание новой архитектуры. */

/*
 *    ____________                              _______________                              ____________
 *   |            |                            |               |                            |            |
 *   |            |_________          _________|               |_________          _________|            |
 *   |            |         |  --->  |         |    i_module   |         |  --->  |         |  i_module  |
 *   |            |  i_pin  |        |  i_pin  |               |  i_pin  |        |  i_pin  |            |
 *   |            |_________|  <---  |_________|  (izh-proto)  |_________|  <---  |_________|    (uav)   |
 *   |            |                            |               |                            |            |
 *   |            |                            |_______________|                            |____________|
 *   |  i_module  |
 *   |            |
 *   |   (krl)    |                             _______________                              ____________
 *   |            |                            |               |                            |            |
 *   |            |_________          _________|               |_________          _________|            |
 *   |            |         |  --->  |         |    i_module   |         |  --->  |         |  i_module  |
 *   |            |  i_pin  |        |  i_pin  |               |  i_pin  |        |  i_pin  |            |
 *   |            |_________|  <---  |_________|  (izh-proto)  |_________|  <---  |_________|   (video)  |
 *   |            |                            |               |                            |            |
 *   |____________|                            |_______________|                            |____________|
 *
 *
 */


class i_pin;
class i_pin_iterator;
class pin_iterator;
class i_module;


typedef int pin_uid_type;


/** Разъём.
 * Два разъёма могут быть подсоединены друг к другу и образовать соединение.
 * Более двух разъёмов не могут быть подключены друг к другу (возможно, это ограничение стоит убрать в дальнейшем).
 * @warning Перед удалением разъём должен отключить "напарника" от себя.
 * @warning Само удаление возможно только при захвате на запись 'pin_process_mutex' модуля к которому относится разъём.
 * @warning Реализация класса должна быть потокобезопасной. */
class i_pin
{

    pin_uid_type m_uid;

public:

    i_pin();
    virtual ~i_pin() {}


    /** Уникальный идентификатор 'i_pin'. Создаётся в конструкторе.
     * Никакие два 'i_pin', неважно каким модулям принадлежащие, не могут иметь одинаковый 'uid'. */
    pin_uid_type uid() const;

    /** Возвращает модуль, к которому принадлежит разъём. */
    virtual const i_module & parent() const = 0;

    /** Полное имя разъёма. Например, ("krl", "55:33:22", "4").
     * @note Имя у разъёма может отсутствовать. В этом случае метод возвращает пустой список. */
    virtual QStringList full_name() const = 0;


    /** Является ли данный разъём свободным (без пары). */
    virtual bool is_free() const = 0;

//    virtual i_module * get_pair(uid_type & ret_pair_uid) = 0;


    /** @return Возвращает истину, если \a pair может быть подключен к нашему разъёму с точки зрения совместимости интерфейсов. */
    virtual bool can_use_pair(i_pin & pair) const = 0;


    /** Устанавливить \a pair в качестве "напарника".
     * @note В случае успешного завершения метода данный разъём уже не считается свободным.
     * @return Возвращает истину, если мы свободны и прияли \a pair в качестве "напарника".
     * @warning В случае успешного завершения метода данный модуль пока ещё не имеет права обращаться к установленному
     * \a pair, т.к. на данном этапе пока не известно, принял ли он нас в качестве своего "напарника".
     * @warning После успешного завершения данного метода должен быть обязательно вызван
     * \a after_successful_set_pair если "напарник" принял нас или \a unset_pair если не принял.
     * В случае неуспешного завершения данного метода вызовы перечисленных выше методов запрещены. */
    virtual bool set_pair(i_pin & pair) = 0;

    /** Вызов метода означает, что \a pair прянял нас в качестве своего "напарника", таким образом разрешается полный
     * доступ к методам \a pair. */
    virtual void after_successful_set_pair() = 0;

    /** Одностороние отсоединение от "напарника".
     * @note Метод разрешено вызывать на уже отсоединённом разъёме. */
    virtual void unset_pair() = 0;
};


class i_pin_iterator
{
public:

    i_pin_iterator();
    virtual ~i_pin_iterator() {}

    virtual i_pin_iterator * clone() const = 0;


    virtual i_pin & operator *() const = 0;
    i_pin * operator ->() const;

    virtual i_pin_iterator & operator ++() = 0;
//    virtual i_pin_iterator operator ++(int) = 0;

    virtual i_pin_iterator & operator --() = 0;
//    virtual i_pin_iterator operator --(int) = 0;


    virtual bool operator ==(const i_pin_iterator & x) const = 0;
    bool operator !=(const i_pin_iterator & x) const;
};


class pin_iterator
{
    std::auto_ptr<i_pin_iterator> impl;

public:

    pin_iterator(i_pin_iterator * impl);
    pin_iterator(const pin_iterator &);
    pin_iterator & operator =(const pin_iterator &);

    i_pin & operator *() const;
    i_pin * operator ->() const;

    pin_iterator & operator ++();
    pin_iterator & operator --();

    bool operator ==(const pin_iterator &) const;
    bool operator !=(const pin_iterator &) const;
};


/** @note Перед удалением модуля все разъёмы должны быть отсоединены от "напарников". */
class i_module : public QObject
{
    mutable QReadWriteLock m_pin_process_mutex;

public:

    i_module();
    virtual ~i_module() {}

    /** Возвращает имя модуля, каким оно используется в файлах конфигурации. */
    virtual QString module_name() const = 0;


    /** Только при даннй блокироке можно безопасно работать с итераторами и самими разъёмами модуля. */
    QReadWriteLock * pin_process_mutex() const;

    virtual pin_iterator begin_all() = 0;
    virtual pin_iterator end_all() = 0;

    virtual pin_iterator begin_free() = 0;
    virtual pin_iterator end_free() = 0;

    virtual i_pin * pin_by_uid(pin_uid_type) = 0;

signals:

    void on_pid_add(pin_uid_type);
    void on_pid_remove(pin_uid_type);
};


bool connect(i_pin &, i_pin &);
bool connect(i_pin &, i_module &);


} /* namespace viaus */
} /* namespace izh_bs */

#endif // IZH_BS_VIAUS_NEW_ARCH_ARCH_HPP_INCLUDED
