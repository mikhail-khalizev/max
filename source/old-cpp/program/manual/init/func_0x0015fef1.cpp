FUNC_BEGIN(0x0015fef1, 0x6050f9dbec8b4905, 0x10, ({0x55, 0x8b, 0xec, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0xff, 0x76, 0xa, 0xff, 0x76, 0x8, 0xff, 0x76, 0x6, 0xff, 0x76, 0x4, 0x90, 0xe, 0xe8, 0x77, 0x12, 0x1f, 0xc9, 0xc2, 0x8, 0}))
    II(0x0015fef1, 0x1)   pushw(bp);                            /* push bp */
    II(0x0015fef2, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015fef4, 0x1)   pushw(ds);                            /* push ds */
    II(0x0015fef5, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x0015fef8, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0015fefa, 0x3)   pushw(memw_a16(ss, bp + 0xa));        /* push word [bp+0xa] */
    II(0x0015fefd, 0x3)   pushw(memw_a16(ss, bp + 0x8));        /* push word [bp+0x8] */
    II(0x0015ff00, 0x3)   pushw(memw_a16(ss, bp + 0x6));        /* push word [bp+0x6] */
    II(0x0015ff03, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
//    II(0x0015ff06, 0x1)   nop();                                /* nop  */
    II(0x0015ff07, 0x1)   pushw(cs);                            /* push cs */
    II(0x0015ff08, 0x3)   callw(0x00161182, 0x1277);            /* call 0x161182 */
    II(0x0015ff0b, 0x1)   popw(ds);                             /* pop ds */
    II(0x0015ff0c, 0x1)   leavew();                             /* leave  */
    II(0x0015ff0d, 0x3)   retw(0x8);                            /* ret 0x8 */
FUNC_END

