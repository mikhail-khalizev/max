FUNC_BEGIN(0x0014a786, 0xf96b2166577234ca, 0x10, ({0x55, 0x8b, 0xec, 0x8e, 0x46, 0x4, 0x8a, 0x46, 0x6, 0xb4, 0xff, 0xba, 0x1, 0x13, 0xe, 0xe8, 0xce, 0xfb, 0xf5, 0x1b, 0xc0, 0x5d, 0xc3}))
    II(0x0014a786, 0x1)   pushw(bp);                            /* push bp */
    II(0x0014a787, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0014a789, 0x3)   mov(es, memw_a16(ss, bp + 0x4));      /* mov es, [bp+0x4] */
    II(0x0014a78c, 0x3)   mov(al, memb_a16(ss, bp + 0x6));      /* mov al, [bp+0x6] */
    II(0x0014a78f, 0x2)   mov(ah, 0xff);                        /* mov ah, 0xff */
    II(0x0014a791, 0x3)   mov(dx, 0x1301);                      /* mov dx, 0x1301 */
    II(0x0014a794, 0x1)   pushw(cs);                            /* push cs */
    II(0x0014a795, 0x3)   callw(0x0014a366, -0x432);            /* call 0x14a366 */
    II(0x0014a798, 0x1)   cmc();                                /* cmc  */
    II(0x0014a799, 0x2)   sbb(ax, ax);                          /* sbb ax, ax */
    II(0x0014a79b, 0x1)   popw(bp);                             /* pop bp */
    II(0x0014a79c, 0x1)   retw();                               /* ret  */
FUNC_END

