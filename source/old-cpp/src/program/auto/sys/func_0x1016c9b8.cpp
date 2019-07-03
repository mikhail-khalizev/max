FUNC_BEGIN(/* sys */ 0x1016c9b8, 0xf6933e7ff9d06ed3, 0x20, ({0x50, 0xb8, 0, 0, 0, 0, 0xba, 0xff, 0, 0, 0, 0xe8, 0xf5, 0xb4, 0x1, 0, 0x58, 0xb4, 0x4c, 0xcd, 0x21, 0x8d, 0x40, 0}))
    II(0x1016c9b8, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016c9b9, 0x5)   mov(eax, 0);                          /* mov eax, 0x0 */
    II(0x1016c9be, 0x5)   mov(edx, 0xff);                       /* mov edx, 0xff */
    II(0x1016c9c3, 0x5)   calld(/* sys */ 0x10187ebd, 0x1b4f5); /* call 0x10187ebd */
    II(0x1016c9c8, 0x1)   popd(eax);                            /* pop eax */
    II(0x1016c9c9, 0x2)   mov(ah, 0x4c);                        /* mov ah, 0x4c */
    II(0x1016c9cb, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1016c9cd, 0x3)   lea(eax, eax + 0);                    /* lea eax, [eax+0x0] */
    II(0x1016c9d0, 0)     jmpd_func(/* sys */ 0x1016c9d0, 0);   /* Принудительное завершение функции. */
FUNC_END

