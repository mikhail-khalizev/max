#ifndef OPENMAX_DOS_MEMORY_HPP_INCLUDED
#define OPENMAX_DOS_MEMORY_HPP_INCLUDED

namespace raw_program {
namespace dos {


void dos_mem_init();

/** int 0x48
 * input:
 * bx - number of paragraphs
 * output:
 * cf = false if successful
 * ax - points to block if successful
 *    = 7 if unsufficient memory
 * bx - size of largest block if failed
 */
void dos_mem_alloc();

void dos_mem_free();

/** int 0x4a
 * input:
 * es - segment address of block
 * bx - requested new block size in paragraphs
 * output:
 * cf = false if successful
 * bx - max available block size if filed
 * ax = 8 if insufficient memory
 *    = 9 if invalid memory block in es
 */
void dos_mem_resize();

void xms_handler();


} /* namespace dos */
} /* namespace raw_program */

#endif /* OPENMAX_DOS_MEMORY_HPP_INCLUDED */
