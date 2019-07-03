FUNC_BEGIN(0x0014b58c, 0xe33b284be47be733, 0x10, ({0x60, 0xa1, 0xb4, 0x9, 0x50, 0x50, 0x8b, 0xc4, 0x16, 0x50, 0x16, 0x50, 0x6a, 0x10, 0xff, 0x1e, 0x22, 0, 0x83, 0xc4, 0xe, 0x61, 0xc3}))
    II(0x0014b58c, 0x1)   pusha();                              /* pusha  */
    II(0x0014b58d, 0x3)   mov(ax, memw_a16(ds, 0x9b4));         /* mov ax, [0x9b4] */
    II(0x0014b590, 0x1)   pushw(ax);                            /* push ax */
    II(0x0014b591, 0x1)   pushw(ax);                            /* push ax */
    II(0x0014b592, 0x2)   mov(ax, sp);                          /* mov ax, sp */
    II(0x0014b594, 0x1)   pushw(ss);                            /* push ss */
    II(0x0014b595, 0x1)   pushw(ax);                            /* push ax */
    II(0x0014b596, 0x1)   pushw(ss);                            /* push ss */
    II(0x0014b597, 0x1)   pushw(ax);                            /* push ax */
    II(0x0014b598, 0x2)   pushw(0x10);                          /* push 0x10 */
    II(0x0014b59a, 0x4)   callw_a16_far_ind(ds, 0x22);          /* call word far [0x22] */
    II(0x0014b59e, 0x3)   add(sp, 0xe);                         /* add sp, 0xe */
    II(0x0014b5a1, 0x1)   popa();                               /* popa  */
    II(0x0014b5a2, 0x1)   retw();                               /* ret  */
FUNC_END

