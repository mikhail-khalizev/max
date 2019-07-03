#ifndef EXO_UTIL_AUTO_INCREMENT_HPP_INCLUDED
#define EXO_UTIL_AUTO_INCREMENT_HPP_INCLUDED

namespace exo {
namespace util {


template<typename T, T & ref>
struct auto_increment
{
    auto_increment()
    {
        ref++;
    }

    ~auto_increment()
    {
        ref--;
    }

    T & get() const
    {
        return ref;
    }
};


} /* namespace util */
} /* namespace exo */

#endif /* EXO_UTIL_AUTO_INCREMENT_HPP_INCLUDED */

