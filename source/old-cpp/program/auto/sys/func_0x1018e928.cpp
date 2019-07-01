FUNC_BEGIN(/* sys */ 0x1018e928, 0x803bd11b526d7efc, 0x20, ({0x33, 0xc0, 0x8a, 0x6, 0x46, 0x66, 0x8b, 0x4, 0x45, 0xd0, 0xee, 0x1b, 0x10}))
    II(0x1018e928, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1018e92a, 0x2)   mov(al, memb_a32(ds, esi));           /* mov al, [esi] */
    II(0x1018e92c, 0x1)   inc(esi);                             /* inc esi */
    II(0x1018e92d, 0x8)   mov(ax, memw_a32(ds, eax * 0x2 + 0x101beed0)); /* mov ax, [eax*2+0x101beed0] */
    II(0x1018e935, 0)     jmpd_func(/* sys */ 0x1018e935, 0);   /* Принудительное завершение функции. */
FUNC_END

