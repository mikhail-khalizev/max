FUNC_BEGIN(0x00140603, 0x1d68936f22b39bee, 0x10, ({0xc8, 0, 0, 0, 0x6, 0x1e, 0x57, 0x56, 0x51, 0xfc, 0xc4, 0x7e, 0x6, 0xc5, 0x76, 0xa, 0x8b, 0x4e, 0xe, 0xf3, 0xa6, 0x8b, 0xc1, 0x59, 0x5e, 0x5f, 0x1f, 0x7, 0xc9, 0xcb}))
    II(0x00140603, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x00140607, 0x1)   pushw(es);                            /* push es */
    II(0x00140608, 0x1)   pushw(ds);                            /* push ds */
    II(0x00140609, 0x1)   pushw(di);                            /* push di */
    II(0x0014060a, 0x1)   pushw(si);                            /* push si */
    II(0x0014060b, 0x1)   pushw(cx);                            /* push cx */
    II(0x0014060c, 0x1)   cld();                                /* cld  */
    II(0x0014060d, 0x3)   les(di, ss, bp + 0x6);                /* les di, [bp+0x6] */
    II(0x00140610, 0x3)   lds(si, ss, bp + 0xa);                /* lds si, [bp+0xa] */
    II(0x00140613, 0x3)   mov(cx, memw_a16(ss, bp + 0xe));      /* mov cx, [bp+0xe] */
    II(0x00140616, 0x2)   repe_a16 cmpsb_a16();                 /* rep cmpsb  */
    II(0x00140618, 0x2)   mov(ax, cx);                          /* mov ax, cx */
    II(0x0014061a, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014061b, 0x1)   popw(si);                             /* pop si */
    II(0x0014061c, 0x1)   popw(di);                             /* pop di */
    II(0x0014061d, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014061e, 0x1)   popw(es);                             /* pop es */
    II(0x0014061f, 0x1)   leavew();                             /* leave  */
    II(0x00140620, 0x1)   retfw();                              /* retf  */
FUNC_END

