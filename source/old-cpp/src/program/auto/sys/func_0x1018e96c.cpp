FUNC_BEGIN(/* sys */ 0x1018e96c, 0x29b5530c27088e2f, 0x20, ({0x66, 0x8b, 0x6, 0x83, 0xc6, 0x2}))
    II(0x1018e96c, 0x3)   mov(ax, memw_a32(ds, esi));           /* mov ax, [esi] */
    II(0x1018e96f, 0x3)   add(esi, 0x2);                        /* add esi, 0x2 */
    II(0x1018e972, 0)     jmpd_func(/* sys */ 0x1018e972, 0);   /* Принудительное завершение функции. */
FUNC_END

