FUNC_BEGIN(0x00009e94, 0x39e4f7fba31a8ee0, 0x10, ({0x33, 0xd2, 0x68, 0, 0xf0, 0x1f, 0x33, 0xdb, 0xad, 0x3, 0xd8, 0xad, 0x13, 0xd0, 0xe2, 0xf8, 0x5e, 0x16, 0x1f, 0x93, 0xc3}))
    II(0x00009e94, 0x2)   xor_(dx, dx);                         /* xor dx, dx */
    II(0x00009e96, 0x3)   pushw(0xf000);                        /* push word 0xf000 */
    II(0x00009e99, 0x1)   popw(ds);                             /* pop ds */
    II(0x00009e9a, 0x2)   xor_(bx, bx);                         /* xor bx, bx */
l_0x00009e9c:
    II(0x00009e9c, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00009e9d, 0x2)   add(bx, ax);                          /* add bx, ax */
    II(0x00009e9f, 0x1)   lodsw_a16();                          /* lodsw  */
    II(0x00009ea0, 0x2)   adc(dx, ax);                          /* adc dx, ax */
    II(0x00009ea2, 0x2)   loopw_a16(0x00009e9c, -0x8);          /* loop 0x9e9c */
    II(0x00009ea4, 0x1)   popw(si);                             /* pop si */
    II(0x00009ea5, 0x1)   pushw(ss);                            /* push ss */
    II(0x00009ea6, 0x1)   popw(ds);                             /* pop ds */
    II(0x00009ea7, 0x1)   xchg(bx, ax);                         /* xchg bx, ax */
    II(0x00009ea8, 0x1)   retw();                               /* ret  */
FUNC_END

