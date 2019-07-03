#include <stdio.h>
#include <exo/util/auto_increment.hpp>

using exo::util::auto_increment;

#define my_assert(ex) \
    if (!(ex)) \
        { \
            printf("%d: %d\n", __LINE__, counter); \
            ret_code = 1; \
        } \

int counter = 0;

int main()
{
    int ret_code = 0;

    {
        auto_increment<int, counter> ai;
        my_assert(counter == 1);
    }

    my_assert(counter == 0);

    return ret_code;
}
