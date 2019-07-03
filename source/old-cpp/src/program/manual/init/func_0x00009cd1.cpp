FUNC_BEGIN(0x00009cd1, 0xdbd7dd77995f67f7, 0x10, ({0x8b, 0xdc, 0x56, 0x57, 0x8c, 0xd8, 0x50, 0x8e, 0xc0, 0x36, 0x8b, 0x4f, 0x8, 0x36, 0x8b, 0x7f, 0x6, 0x36, 0x8b, 0x77, 0x4, 0x36, 0x8e, 0x5f, 0x2, 0xfc, 0xf3, 0xa4, 0x1f, 0x5f, 0x5e, 0xc3}))
    II(0x00009cd1, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x00009cd3, 0x1)   pushw(si);                            /* push si */
    II(0x00009cd4, 0x1)   pushw(di);                            /* push di */
    II(0x00009cd5, 0x2)   mov(ax, ds);                          /* mov ax, ds */
    II(0x00009cd7, 0x1)   pushw(ax);                            /* push ax */
    II(0x00009cd8, 0x2)   mov(es, ax);                          /* mov es, ax */
    II(0x00009cda, 0x4)   mov(cx, memw_a16(ss, bx + 0x8));      /* mov cx, [ss:bx+0x8] */
    II(0x00009cde, 0x4)   mov(di, memw_a16(ss, bx + 0x6));      /* mov di, [ss:bx+0x6] */
    II(0x00009ce2, 0x4)   mov(si, memw_a16(ss, bx + 0x4));      /* mov si, [ss:bx+0x4] */
    II(0x00009ce6, 0x4)   mov(ds, memw_a16(ss, bx + 0x2));      /* mov ds, [ss:bx+0x2] */
    II(0x00009cea, 0x1)   cld();                                /* cld  */
    II(0x00009ceb, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x00009ced, 0x1)   popw(ds);                             /* pop ds */
    II(0x00009cee, 0x1)   popw(di);                             /* pop di */
    II(0x00009cef, 0x1)   popw(si);                             /* pop si */
    II(0x00009cf0, 0x1)   retw();                               /* ret  */
FUNC_END

