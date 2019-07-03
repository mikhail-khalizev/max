#ifndef OPENMAX_DOS_INTERRUPT_HPP_INCLUDED
#define OPENMAX_DOS_INTERRUPT_HPP_INCLUDED

namespace raw_program {
namespace dos {

void int_08();
void int_10();
void int_15();
void int_16();
void int_1c();
void int_21();
void int_2f();
void int_31();
void int_33();
void int_67();

void install_std_ints();

} /* namespace dos */
} /* namespace raw_program */

#endif /* OPENMAX_DOS_INTERRUPT_HPP_INCLUDED */

