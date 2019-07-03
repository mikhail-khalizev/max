#include <exo/global.hpp>

int main()
{
    uint_<64> a;
    a += a;
    a = a + a;
    a == a; 

    -4 == a + 1;


    uint_<64>(4);
    sint_<64>(4);
    a = sint_<64>(4);
    a = 4;

    sint_<16> b;
    a = b;
    a == b;
    b = b + 5;
    b = b << 8;


    uint_ge<33> c;
    c += c;
    c = c + c;
    c == c;
    c = 4;
    c >> 4;


    uint_<32>(1);
    uint_<32>(1, 2);
    uint_<32>(1, 2, 3);
    uint_<32>(1, 2, 3, 4);


    sint_<16> d(-1);
    uint_<32> e(d);
    if (e != 0xffffffff)
    return 1;

    ~e;
    if (e == 0)
    return 1;

    uint_<16> f(0xd6c0);
    f = f >> 1;
    if (f != 0x6b60)
    return 1;


    if (uint_<32>(0xffffffff) / uint_<16>(1) != uint_<32>(0xffffffff))
    return 1;


    if (uint_<16>::max() != 0xffff)
    return 1;

    if (sint_<16>::max() != 0x7fff)
    return 1;

    if (uint_<16>::min() != 0)
    return 1;

    if (sint_<16>::min() != sint_<16>(0x8000))
    return 1;


    return 0;
}
