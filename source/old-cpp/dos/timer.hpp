#ifndef OPENMAX_DOS_TIMER_HPP_INCLUDED
#define OPENMAX_DOS_TIMER_HPP_INCLUDED

#include <exo/global.hpp>


namespace raw_program {
namespace dos {


void timer_write_latch(uint_<32> port, uint_<8> val);
void timer_write_p43(uint_<8> val);
uint_<8> timer_read_latch(uint_<32> port);

void TIMER_SetGate2(bool in);

void timers_init();


} /* namespace dos */
} /* namespace raw_program */

#endif /* OPENMAX_DOS_TIMER_HPP_INCLUDED */
