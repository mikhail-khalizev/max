FUNC_BEGIN(0x0014d0fa, 0x9193a10aff1df0f5, 0x10, ({0x55, 0x8b, 0xec, 0x68, 0x92, 0, 0xff, 0x76, 0x4, 0xe8, 0xa6, 0xff, 0x5b, 0x5b, 0xc9, 0xc3}))
    II(0x0014d0fa, 0x1)   pushw(bp);                            /* push bp */
    II(0x0014d0fb, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0014d0fd, 0x3)   pushw(0x92);                          /* push word 0x92 */
    II(0x0014d100, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
    II(0x0014d103, 0x3)   callw(0x0014d0ac, -0x5a);             /* call 0x14d0ac */
    II(0x0014d106, 0x1)   popw(bx);                             /* pop bx */
    II(0x0014d107, 0x1)   popw(bx);                             /* pop bx */
    II(0x0014d108, 0x1)   leavew();                             /* leave  */
    II(0x0014d109, 0x1)   retw();                               /* ret  */
FUNC_END

