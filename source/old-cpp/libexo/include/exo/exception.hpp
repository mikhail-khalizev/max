#ifndef EXO_EXCEPTION_HPP_INCLUDED
#define EXO_EXCEPTION_HPP_INCLUDED

#include <stdexcept>

namespace exo {
namespace exception {

class not_implemented : public std::exception
{
public:

    not_implemented()
    {}

    /* @todo
     * not_implemented(memory_space_dyn);
     */

    virtual const char * what() const throw()
    {
        // operation is not implemented
        return "Не реализовано.";
    }
};

/* @todo rename to algoritm_bug ? */
class logic_error : public std::logic_error
{
public:

    logic_error()
    : std::logic_error("Ошибка в реализации алгоритма.")
    {}

    /* @todo
     * logic_error(memory_space_dyn);
     */
};


} /* namespace exception */
} /* namespace exo */

#endif /* EXO_EXCEPTION_HPP_INCLUDED */

