#ifndef EXO_LINUX_TIME_INTERNAL_HPP_INCLUDED
#define EXO_LINUX_TIME_INTERNAL_HPP_INCLUDED

#include <time.h>
#include <exo/attributes.hpp>
#include <exo/linux/time.hpp>

namespace exo {
namespace linux {

time convert_timespec_to_time(struct timespec ts);

} /* namespace linux */
} /* namespace exo */

#endif /* EXO_LINUX_TIME_INTERNAL_HPP_INCLUDED */
