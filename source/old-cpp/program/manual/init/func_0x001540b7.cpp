FUNC_BEGIN(0x001540b7, 0xc824775cbc48445a, 0x10, ({0x50, 0x6, 0x68, 0xa8, 0, 0x7, 0x26, 0xff, 0x36, 0x78, 0x3b, 0x7, 0x26, 0xa0, 0x2f, 0, 0x2c, 0x2, 0x7, 0x58, 0xc3}))
    II(0x001540b7, 0x1)   pushw(ax);                            /* push ax */
    II(0x001540b8, 0x1)   pushw(es);                            /* push es */
    II(0x001540b9, 0x3)   pushw(0xa8);                          /* push word 0xa8 */
    II(0x001540bc, 0x1)   popw(es);                             /* pop es */
    II(0x001540bd, 0x5)   pushw(memw_a16(es, 0x3b78));          /* push word [es:0x3b78] */
    II(0x001540c2, 0x1)   popw(es);                             /* pop es */
    II(0x001540c3, 0x4)   mov(al, memb_a16(es, 0x2f));          /* mov al, [es:0x2f] */
    II(0x001540c7, 0x2)   sub(al, 0x2);                         /* sub al, 0x2 */
    II(0x001540c9, 0x1)   popw(es);                             /* pop es */
    II(0x001540ca, 0x1)   popw(ax);                             /* pop ax */
    II(0x001540cb, 0x1)   retw();                               /* ret  */
FUNC_END

