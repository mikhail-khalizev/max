FUNC_BEGIN(0x00150bae, 0x5bc58bf4764252d, 0x10, ({0xf, 0x20, 0xd8, 0x66, 0x8b, 0xd0, 0x66, 0xc1, 0xea, 0x10, 0xcb}))
    II(0x00150bae, 0x3)   mov(eax, cr3);                        /* mov eax, cr3 */
    II(0x00150bb1, 0x3)   mov(edx, eax);                        /* mov edx, eax */
    II(0x00150bb4, 0x4)   shr(edx, 0x10);                       /* shr edx, 0x10 */
    II(0x00150bb8, 0x1)   retfw();                              /* retf  */
FUNC_END

