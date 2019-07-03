FUNC_BEGIN(0x0014b55c, 0xbc3e1e315821db3f, 0x10, ({0x50, 0xa1, 0xe, 0, 0x3b, 0xc8, 0x76, 0x2, 0x8b, 0xc8, 0x58, 0x1e, 0x6, 0x8b, 0x3e, 0xa, 0, 0x1e, 0x7, 0x1f, 0x60, 0xfc, 0xf3, 0xa4, 0x61, 0x1f, 0xc3}))
    II(0x0014b55c, 0x1)   pushw(ax);                            /* push ax */
    II(0x0014b55d, 0x3)   mov(ax, memw_a16(ds, 0xe));           /* mov ax, [0xe] */
    II(0x0014b560, 0x2)   cmp(cx, ax);                          /* cmp cx, ax */
    II(0x0014b562, 0x2)   jbew(0x0014b566, 0x2);                /* jbe 0x14b566 */
    II(0x0014b564, 0x2)   mov(cx, ax);                          /* mov cx, ax */
l_0x0014b566:
    II(0x0014b566, 0x1)   popw(ax);                             /* pop ax */
    II(0x0014b567, 0x1)   pushw(ds);                            /* push ds */
    II(0x0014b568, 0x1)   pushw(es);                            /* push es */
    II(0x0014b569, 0x4)   mov(di, memw_a16(ds, 0xa));           /* mov di, [0xa] */
    II(0x0014b56d, 0x1)   pushw(ds);                            /* push ds */
    II(0x0014b56e, 0x1)   popw(es);                             /* pop es */
    II(0x0014b56f, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014b570, 0x1)   pusha();                              /* pusha  */
    II(0x0014b571, 0x1)   cld();                                /* cld  */
    II(0x0014b572, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x0014b574, 0x1)   popa();                               /* popa  */
    II(0x0014b575, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014b576, 0x1)   retw();                               /* ret  */
FUNC_END

