FUNC_BEGIN(0x0000ee93, 0x1fac8d90085061b1, 0x10, ({0xe8, 0x52, 0xfc, 0x9c, 0x72, 0x17, 0x8b, 0x3e, 0xa, 0, 0x8b, 0x76, 0x12, 0x8e, 0x5e, 0x4, 0xb9, 0x16, 0, 0xf3, 0xa5, 0x6, 0x1f, 0xa1, 0xa, 0, 0x89, 0x47, 0x12, 0xe8, 0xb0, 0xf9, 0x9d, 0x72, 0xf, 0x8b, 0x7e, 0x12, 0x8b, 0x36, 0xa, 0, 0x8e, 0x46, 0x4, 0xb9, 0x16, 0, 0xf3, 0xa5, 0x8b, 0x47, 0x16, 0x89, 0x46, 0x16, 0xc3}))
    II(0x0000ee93, 0x3)   callw(0x0000eae8, -0x3ae);            /* call 0xeae8 */
    II(0x0000ee96, 0x1)   pushfw();                             /* pushfw  */
    II(0x0000ee97, 0x2)   jbw(0x0000eeb0, 0x17);                /* jb 0xeeb0 */
    II(0x0000ee99, 0x4)   mov(di, memw_a16(ds, 0xa));           /* mov di, [0xa] */
    II(0x0000ee9d, 0x3)   mov(si, memw_a16(ss, bp + 0x12));     /* mov si, [bp+0x12] */
    II(0x0000eea0, 0x3)   mov(ds, memw_a16(ss, bp + 0x4));      /* mov ds, [bp+0x4] */
    II(0x0000eea3, 0x3)   mov(cx, 0x16);                        /* mov cx, 0x16 */
    II(0x0000eea6, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
    II(0x0000eea8, 0x1)   pushw(es);                            /* push es */
    II(0x0000eea9, 0x1)   popw(ds);                             /* pop ds */
    II(0x0000eeaa, 0x3)   mov(ax, memw_a16(ds, 0xa));           /* mov ax, [0xa] */
    II(0x0000eead, 0x3)   mov(memw_a16(ds, bx + 0x12), ax);     /* mov [bx+0x12], ax */
l_0x0000eeb0:
    II(0x0000eeb0, 0x3)   callw(0x0000e863, -0x650);            /* call 0xe863 */
    II(0x0000eeb3, 0x1)   popfw();                              /* popfw  */
    II(0x0000eeb4, 0x2)   jbw(0x0000eec5, 0xf);                 /* jb 0xeec5 */
    II(0x0000eeb6, 0x3)   mov(di, memw_a16(ss, bp + 0x12));     /* mov di, [bp+0x12] */
    II(0x0000eeb9, 0x4)   mov(si, memw_a16(ds, 0xa));           /* mov si, [0xa] */
    II(0x0000eebd, 0x3)   mov(es, memw_a16(ss, bp + 0x4));      /* mov es, [bp+0x4] */
    II(0x0000eec0, 0x3)   mov(cx, 0x16);                        /* mov cx, 0x16 */
    II(0x0000eec3, 0x2)   rep_a16 movsw_a16();                  /* rep movsw  */
l_0x0000eec5:
    II(0x0000eec5, 0x3)   mov(ax, memw_a16(ds, bx + 0x16));     /* mov ax, [bx+0x16] */
    II(0x0000eec8, 0x3)   mov(memw_a16(ss, bp + 0x16), ax);     /* mov [bp+0x16], ax */
    II(0x0000eecb, 0x1)   retw();                               /* ret  */
FUNC_END

