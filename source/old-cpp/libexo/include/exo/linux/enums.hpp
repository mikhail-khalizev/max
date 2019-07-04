#ifdef EXO_LINUX_ENUMS_HPP_REQUIRE
    fixed = 
# 77 "./linux/.internal/enums_body.hpp" 3 4
           0x10
# 77 "./linux/.internal/enums_body.hpp"
                    ,
    anonymous = 
# 78 "./linux/.internal/enums_body.hpp" 3 4
               0x20
# 78 "./linux/.internal/enums_body.hpp"
                            ,
    locked = 
# 79 "./linux/.internal/enums_body.hpp" 3 4
            0x02000
# 79 "./linux/.internal/enums_body.hpp"
                      ,
    populate = 
# 80 "./linux/.internal/enums_body.hpp" 3 4
              0x08000
# 80 "./linux/.internal/enums_body.hpp"
                          ,
    nonblock = 
# 81 "./linux/.internal/enums_body.hpp" 3 4
              0x10000
# 81 "./linux/.internal/enums_body.hpp"
                          ,
    noreserve = 
# 82 "./linux/.internal/enums_body.hpp" 3 4
               0x04000
# 82 "./linux/.internal/enums_body.hpp"
                            ,
    hugetlb = 
# 83 "./linux/.internal/enums_body.hpp" 3 4
             0x40000
# 83 "./linux/.internal/enums_body.hpp"
                        ,
    growsdown = 
# 84 "./linux/.internal/enums_body.hpp" 3 4
               0x00100
# 84 "./linux/.internal/enums_body.hpp"
                            ,
    stack = 
# 85 "./linux/.internal/enums_body.hpp" 3 4
           0x20000

# 86 "./linux/.internal/enums_body.hpp"
};

enum class clock_id : detail::clockid_t
{
    realtime = 
# 90 "./linux/.internal/enums_body.hpp" 3 4
              0
# 90 "./linux/.internal/enums_body.hpp"
                            ,
    monotonic = 
# 91 "./linux/.internal/enums_body.hpp" 3 4
               1
# 91 "./linux/.internal/enums_body.hpp"
                              ,
    process_cputime_id = 
# 92 "./linux/.internal/enums_body.hpp" 3 4
                        2
# 92 "./linux/.internal/enums_body.hpp"
                                                ,
    thread_cputime_id = 
# 93 "./linux/.internal/enums_body.hpp" 3 4
                       3
# 93 "./linux/.internal/enums_body.hpp"
                                              ,
    monotonic_raw = 
# 94 "./linux/.internal/enums_body.hpp" 3 4
                   4
# 94 "./linux/.internal/enums_body.hpp"
                                      ,
    realtime_coarse = 
# 95 "./linux/.internal/enums_body.hpp" 3 4
                     5
# 95 "./linux/.internal/enums_body.hpp"
                                          ,
    monotonic_coarse = 
# 96 "./linux/.internal/enums_body.hpp" 3 4
                      6
# 96 "./linux/.internal/enums_body.hpp"
                                            ,
    boottime = 
# 97 "./linux/.internal/enums_body.hpp" 3 4
              7
# 97 "./linux/.internal/enums_body.hpp"
                            ,
    realtime_alarm = 
# 98 "./linux/.internal/enums_body.hpp" 3 4
                    8
# 98 "./linux/.internal/enums_body.hpp"
                                        ,
    boottime_alarm = 
# 99 "./linux/.internal/enums_body.hpp" 3 4
                    9

# 100 "./linux/.internal/enums_body.hpp"
};
#endif /* EXO_LINUX_ENUMS_HPP_REQUIRE */
