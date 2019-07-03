#include <stdio.h>
#include "exo/memory_space.hpp"

using namespace exo;

static size_t func(memory_space_const in)
{
    return in.size();
}

#define my_assert(ex) \
    if (!(ex)) \
        { \
            printf("%d: %lu\n", __LINE__, len); \
            ret_code= 1; \
        } \

int main()
{
    int ret_code = 0;


    // Проверяем неявное преобразование.

    memory_space_const tst;
    size_t & len = tst.size();

    len = func("tst");
    my_assert(len == 3);

    char buf[5] = {1, 2, 0, 3, 4};

    len = func(buf);
    my_assert(len == 4);


    // Проверяем явные преобразвания.

    tst = "tst";
    my_assert(tst.size() == 3);

    tst = buf;
    my_assert(tst.size() == 4);

    tst = static_cast<memory_space>(buf);
    my_assert(tst.size() == 2);


    return ret_code;
}
