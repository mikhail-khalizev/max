FUNC_BEGIN(0x0014a4fa, 0x1b0ed03ac5189d96, 0x10, ({0x8b, 0x1e, 0x96, 0x9, 0x8e, 0x57, 0x2, 0x8b, 0x67, 0xe, 0x8e, 0x46, 0x6, 0x8b, 0x7f, 0x8, 0x8b, 0x77, 0xa, 0xff, 0x74, 0x4, 0xb9, 0x15, 0, 0xfc, 0xf3, 0xa5, 0x59, 0xe3, 0x52, 0xc3}))
    II(0x0014a4fa, 0x4)   mov(bx, memw_a16(ds, 0x996));         /* mov bx, [0x996] */
    II(0x0014a4fe, 0x3)   mov(ss, memw_a16(ds, bx + 0x2));      /* mov ss, [bx+0x2] */
    II(0x0014a501, 0x3)   mov(sp, memw_a16(ds, bx + 0xe));      /* mov sp, [bx+0xe] */
    II(0x0014a504, 0x3)   mov(es, memw_a16(ss, bp + 0x6));      /* mov es, [bp+0x6] */
    II(0x0014a507, 0x3)   mov(di, memw_a16(ds, bx + 0x8));      /* mov di, [bx+0x8] */
    II(0x0014a50a, 0x3)   mov(si, memw_a16(ds, bx + 0xa));      /* mov si, [bx+0xa] */
    II(0x0014a50d, 0x3)   pushw(memw_a16(ds, si + 0x4));        /* push word [si+0x4] */
    II(0x0014a510, 0x3)   mov(cx, 0x15);                        /* mov cx, 0x15 */
    II(0x0014a513, 0x1)   cld();                                /* cld  */
    II(0x0014a514, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x0014a516, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014a517, 0x2)   jcxzw_func(0x0014a56b, 0x52);         /* jcxz 0x14a56b */
    II(0x0014a519, 0x1)   retw();                               /* ret  */
FUNC_END

