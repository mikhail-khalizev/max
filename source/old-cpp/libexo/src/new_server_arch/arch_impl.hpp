#ifndef IZH_BS_VIAUS_NEW_ARCH_ARCH_IMPL_HPP_INCLUDED
#define IZH_BS_VIAUS_NEW_ARCH_ARCH_IMPL_HPP_INCLUDED

#include <QReadWriteLock>
#include "arch.hpp"

namespace izh_bs {
namespace viaus {


template<typename T>
class i_pin_impl : public i_pin
{
    T * pair_preliminarily;
    T * pair;

protected:

    QReadWriteLock pair_use;

public:

    i_pin_impl();

    virtual bool is_free() const override;
    virtual bool can_use_pair(i_pin & pair) const override;
    virtual bool set_pair(i_pin & pair) override;
    virtual void after_successful_set_pair() override;
    virtual void unset_pair() override;
};




/* definitions */

template<typename T>
bool i_pin_impl<T>::is_free() const
{
    QReadLocker lock(& pair_use);
    return pair == NULL && pair_preliminarily == NULL;
}

template<typename T>
bool i_pin_impl<T>::can_use_pair(i_pin & pair_) const
{
    return dynamic_cast<T *>(& pair_) != NULL;
}

template<typename T>
bool i_pin_impl<T>::set_pair(i_pin & pair_)
{
    QReadLocker lock(& pair_use);

    if (pair != NULL || pair_preliminarily != NULL)
        return false; /* Мы не свободны. */

    pair_preliminarily = dynamic_cast<T *>(& pair_);

    return (pair_preliminarily != NULL);
}

template<typename T>
void i_pin_impl<T>::after_successful_set_pair()
{
    QReadLocker lock(& pair_use);
    pair = pair_preliminarily;
}

template<typename T>
void i_pin_impl<T>::unset_pair()
{
    QReadLocker lock(& pair_use);
    pair = pair_preliminarily = NULL;
}


} /* namespace viaus */
} /* namespace izh_bs */

#endif // IZH_BS_VIAUS_NEW_ARCH_ARCH_IMPL_HPP_INCLUDED
