FUNC_BEGIN(0x0015febc, 0xced05fc702d0ebc5, 0x10, ({0x55, 0x8b, 0xec, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0xff, 0x76, 0x4, 0x90, 0xe, 0xe8, 0x2a, 0x12, 0x1f, 0xc9, 0xc2, 0x2, 0}))
    II(0x0015febc, 0x1)   pushw(bp);                            /* push bp */
    II(0x0015febd, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015febf, 0x1)   pushw(ds);                            /* push ds */
    II(0x0015fec0, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x0015fec3, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x0015fec5, 0x3)   pushw(memw_a16(ss, bp + 0x4));        /* push word [bp+0x4] */
//    II(0x0015fec8, 0x1)   nop();                                /* nop  */
    II(0x0015fec9, 0x1)   pushw(cs);                            /* push cs */
    II(0x0015feca, 0x3)   callw(0x001610f7, 0x122a);            /* call 0x1610f7 */
    II(0x0015fecd, 0x1)   popw(ds);                             /* pop ds */
    II(0x0015fece, 0x1)   leavew();                             /* leave  */
    II(0x0015fecf, 0x3)   retw(0x2);                            /* ret 0x2 */
FUNC_END

