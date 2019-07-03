#include "exo/types.hpp"
#include "exo/SelfTest.hpp"

namespace exo {

SELF_TEST("exo::sint")
{
    {
        sint<2> a = 1;
        throw_assert(a.max() == 1, "%d.", (int)a.max());
        throw_assert(a.min() == -2, "%d.", (int)a.min());

        sint<3> b = 2;
        throw_assert(b.max() == 3, "%d.", (int)b.max());
        throw_assert(b.min() == -4, "%d.", (int)b.min());

        auto c = a + b;

        throw_assert(c.get() == 3, "%d.", (int)c.get());

        throw_assert(c.max() == 7, "%d.", (int)c.max());
        throw_assert(c.min() == -8, "%d.", (int)c.min());

        throw_assert(sint<16>::max() == 32767, "%d.", (int)sint<16>::max());
        throw_assert(sint<16>::min() == -32768, "%d.", (int)sint<16>::min());
    }

    {
        sint<6> a = 4;
        sint<a.bits() - 1> b = 1;

        throw_assert(a.max() == b.max() * 2 + 1, "%d, %d.", a.max(), b.max());
        throw_assert(a.min() == b.min() * 2, "%d, %d.", a.min(), b.min());
    }

    {
        sint<6> a = 4;
        sint<9> b = 5;
        auto c = a * b;

        throw_assert(c.get() == 20, "%d.", (int)c.get());

        throw_assert(c.min() <= - a.min() * b.min(), "%d, %d, %d.",
                (int)c.min(), (int)a.min(), (int)b.min());

        throw_assert(-a.min() * b.min() < sint<c.bits() - 1>::min(), "%d, %d, %d.",
                (int)a.min(), (int)b.min(), (int)sint<c.bits() - 1>::min());
    }
}

SELF_TEST("exo::uint")
{
    {
        uint<2> a = 1;
        throw_assert(a.max() == 3, "%d.", (int)a.max());

        uint<3> b = 2;
        throw_assert(b.max() == 7, "%d.", (int)b.max());

        auto c = a + b;

        throw_assert(c.get() == 3, "%d.", (int)c.get());

        throw_assert(c.max() == 15, "%d.", (int)c.max());

        throw_assert(uint<16>::max() == 65535, "%d.", (int)uint<16>::max());
    }

    {
        uint<6> a = 4;
        uint<a.bits() - 1> b = 1;

        throw_assert(a.max() == b.max() * 2 + 1, "%d, %d.", a.max(), b.max());
    }

    {
        uint<6> a = 4;
        uint<9> b = 5;
        auto c = a * b;

        throw_assert(c.get() == 20, "%d.", (int)c.get());

        throw_assert(a.max() * b.max() <= c.max(), "%d, %d, %d.",
                (int)a.max(), (int)b.max(), (int)c.max());

        throw_assert(uint<c.bits() - 1>::max() < a.max() * b.max(), "%d, %d, %d.",
                (int)uint<c.bits() - 1>::max(), (int)a.max(), (int)b.max());
    }
}

} // namespace exo

