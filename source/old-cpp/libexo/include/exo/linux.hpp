#ifndef EXO_LINUX_HPP_INCLUDED
#define EXO_LINUX_HPP_INCLUDED

/** Испольвозвать системные вызовы и библиотечные функции linux, posix в c++
 * довольно неудобно:
 * - Они возвращают или устанавливают в соответствующей переменной код ошибки
 * вместо генерирования исключения.
 * - Написание кода безопасного к исключениям требует либо написание дополнительных
 * классов, освобождающих полученные ресурсы или использование любда выражений
 * совместно с std::unique_ptr, что затрудняет чтение кода.
 * - Флаги, передаваемые в аргументы функций, не проверяются на этапе компиляции
 * на предмет допустимых к какой-либо конкретной функций. Т.е. мы можем совершенно
 * легально написать, скажем, 'open(".", FD_CLOEXEC)' и успешно скомпилировать
 * этот код. (Решение - enum class).
 * - Все функции, структуры, флаги находятся в глобальном пространстве имён.
 *
 * Всё это побудило к написанию exo::linux - обертки к функциям linux, устраняющим
 * выше перечисленные недостатки, и по возможности приближенной к 'низкому' уровню
 * системных и библиотечных функций. Т.е. писать высокоуровневые абстракции в
 * данном namespace не следует. */


#include <exo/linux/io.hpp>
#include <exo/linux/time.hpp>
#include <exo/linux/exception.hpp>


#ifdef linux
/* Объявлять "linux" маленькими буквами было плохой идеей. Следовало бы объявить "LINUX". */
#undef linux
#endif

namespace exo {
namespace linux {


#if 0
struct sem_remover
{
    struct sem_descriptor
    {
        int id;

        sem_descriptor()
        : id(-1) { }

        sem_descriptor(int id_)
        : id(id_) { }

        sem_descriptor & operator=(int id_)
        {
            id = id_;
            return *this;
        }

        operator int() const
        {
            return id;
        }
    };

    typedef sem_descriptor pointer;

    void operator()(pointer id) const;
};
#endif


} /* namespace linux */
} /* namespace exo */

#endif /* EXO_LINUX_HPP_INCLUDED */
