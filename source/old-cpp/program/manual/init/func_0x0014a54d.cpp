FUNC_BEGIN(0x0014a54d, 0x394cb0cf7ae6792d, 0x10, ({0x8c, 0x5e, 0x12, 0xc7, 0x46, 0x16, 0x98, 0, 0xa1, 0xf4, 0x11, 0x89, 0x46, 0x10, 0xa1, 0xf6, 0x11, 0x89, 0x46, 0x14, 0xc7, 0x46, 0xa, 0x10, 0xc, 0xc7, 0x46, 0x8, 0x29, 0x42}))
    II(0x0014a54d, 0x3)   mov(memw_a16(ss, bp + 0x12), ds);     /* mov [bp+0x12], ds */
    II(0x0014a550, 0x5)   mov(memw_a16(ss, bp + 0x16), 0x98);   /* mov word [bp+0x16], 0x98 */
    II(0x0014a555, 0x3)   mov(ax, memw_a16(ds, 0x11f4));        /* mov ax, [0x11f4] */
    II(0x0014a558, 0x3)   mov(memw_a16(ss, bp + 0x10), ax);     /* mov [bp+0x10], ax */
    II(0x0014a55b, 0x3)   mov(ax, memw_a16(ds, 0x11f6));        /* mov ax, [0x11f6] */
    II(0x0014a55e, 0x3)   mov(memw_a16(ss, bp + 0x14), ax);     /* mov [bp+0x14], ax */
    II(0x0014a561, 0x5)   mov(memw_a16(ss, bp + 0xa), 0xc10);   /* mov word [bp+0xa], 0xc10 */
    II(0x0014a566, 0x5)   mov(memw_a16(ss, bp + 0x8), 0x4229);  /* mov word [bp+0x8], 0x4229 */
    II(0x0014a56b, 0)     jmpd_func(0x0014a56b, 0);             /* Принудительное завершение функции. */
FUNC_END

