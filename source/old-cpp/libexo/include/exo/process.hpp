#ifndef EXO_PROCESS_HPP_INCLUDED
#define EXO_PROCESS_HPP_INCLUDED

namespace exo {


class process
{

public:

    /** Возвращает ложь после вызова функции exit, т.е. когда процесс начал завершаться. Иначе возвращает истину. */
    static bool worked()
    {
        /* @todo Реализовать.
         * Some_Class  A  __attribute__ ((init_priority (65535)));
         * process::exit() -> exit() */
        return true;
    }
};


} /* namespace exo */

#endif /* EXO_PROCESS_HPP_INCLUDED */
