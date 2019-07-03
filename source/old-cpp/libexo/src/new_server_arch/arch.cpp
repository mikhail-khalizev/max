#include <QAtomicInt>
#include "arch.hpp"
#include "arch_impl.hpp" /* @tmp */

namespace izh_bs {
namespace viaus {


static QAtomicInt global_pin_enumerator;


i_pin::i_pin()
    : m_uid()
{
    m_uid = global_pin_enumerator.fetchAndAddRelaxed(1);
}

pin_uid_type i_pin::uid() const
{
    return m_uid;
}

i_pin * i_pin_iterator::operator ->() const
{
    return & (this -> operator *());
}

bool i_pin_iterator::operator !=(const i_pin_iterator & x) const
{
    return ! this -> operator ==(x);
}

pin_iterator::pin_iterator(i_pin_iterator * impl_)
    : impl(impl_)
{}

pin_iterator::pin_iterator(const pin_iterator & p)
    : impl(p.impl -> clone())
{}

pin_iterator & pin_iterator::operator =(const pin_iterator & p)
{
    impl.reset(p.impl -> clone());
    return * this;
}

i_pin & pin_iterator::operator *() const
{
    return impl -> operator *();
}

i_pin * pin_iterator::operator ->() const
{
    return impl -> operator ->();
}

pin_iterator & pin_iterator::operator ++()
{
    impl -> operator ++();
    return * this;
}

pin_iterator & pin_iterator::operator --()
{
    impl -> operator --();
    return * this;
}

bool pin_iterator::operator ==(const pin_iterator & x) const
{
    return impl -> operator ==(*x.impl.get());
}

bool pin_iterator::operator !=(const pin_iterator & x) const
{
    return impl -> operator !=(*x.impl.get());
}

QReadWriteLock * i_module::pin_process_mutex() const
{
    return & m_pin_process_mutex;
}


bool connect(i_pin & a, i_pin & b)
{
    bool ok = b.set_pair(a);
    if (! ok)
        return false;

    ok = a.set_pair(b);
    if (! ok)
    {
        b.unset_pair();
        return false;
    }

    b.after_successful_set_pair();
    a.after_successful_set_pair();
    return true;
}

bool connect(i_pin & p, i_module & m)
{
    QReadLocker lock(m.pin_process_mutex());


    const pin_iterator end = m.end_free();

    for (pin_iterator it = m.begin_free(); it != end; ++it)
    {
        bool ok = connect(p, *it);
        if (ok)
            return true;
    }

    return false;
}


} /* namespace viaus */
} /* namespace izh_bs */
