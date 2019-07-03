#include <stdio.h>
#include <exo/math.hpp>

using namespace exo;
using namespace exo::math;


static int ret_code = 0;

#define my_assert(ex) \
    if (!(ex)) \
        { \
            printf("line %d\n", __LINE__); \
            ret_code = 1; \
        } \


namespace exo {

static void internal_check()
{
//    static_assert(uint<-9, -4>::first_frame_val() == -16, "");
//
//    static_assert(uint<-8, -3>::first_frame_val() == -8, "");
//    static_assert(uint<-1, 4>::first_frame_val() == -8, "");
//
//    static_assert(uint<0, 5>::first_frame_val() == 0, "");
//    static_assert(uint<7, 12>::first_frame_val() == 0, "");
//
//    static_assert(uint<8, 13>::first_frame_val() == 8, "");
//    static_assert(uint<15, 20>::first_frame_val() == 8, "");
//
//    static_assert(uint<16, 21>::first_frame_val() == 16, "");
}

} /* namespace exo */

int main()
{
    internal_check();


#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Wunused-but-set-variable"
    {
        safe_s<4> a = 3;
        safe_s<3> b = 3;

        auto c = a + b;
        auto d = a - b;
        auto e = a * b;
    }

    {
        safe_u<4> a = 3;
        safe_u<3> b = 3;

        auto c = a + b;
        auto d = a - b;
        auto e = a * b;
    }

    {
//        my_assert(sqrt(safe_u<>(1), safe_u<>(), round_down()) == 1);
//        my_assert(sqrt(safe_u<>(3), safe_u<>(), round_down()) == 1);
//        my_assert(sqrt(safe_u<>(4), safe_u<>(), round_down()) == 2);
//        my_assert(sqrt(safe_u<>(5), safe_u<>(), round_down()) == 2);
//        my_assert(sqrt(safe_u<>(8), safe_u<>(), round_down()) == 2);
//        my_assert(sqrt(safe_u<>(9), safe_u<>(), round_down()) == 3);
//        my_assert(sqrt(safe_u<>(10), safe_u<>(), round_down()) == 3);
    }
#pragma GCC diagnostic pop

    return ret_code;
}
