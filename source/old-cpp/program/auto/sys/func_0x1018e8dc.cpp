FUNC_BEGIN(/* sys */ 0x1018e8dc, 0xeb0eac0e852630fe, 0x20, ({0x8b, 0x45, 0x18, 0xd1, 0xe8, 0x89, 0x45, 0xec}))
    II(0x1018e8dc, 0x3)   mov(eax, memd_a32(ss, ebp + 0x18));   /* mov eax, [ebp+0x18] */
    II(0x1018e8df, 0x2)   shr(eax, 0x1);                        /* shr eax, 1 */
    II(0x1018e8e1, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1018e8e4, 0)     jmpd_func(/* sys */ 0x1018e8e4, 0);   /* Принудительное завершение функции. */
FUNC_END

