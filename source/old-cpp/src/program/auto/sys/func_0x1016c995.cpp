FUNC_BEGIN(/* sys */ 0x1016c995, 0x4605c89dbedbcb3e, 0x20, ({0x52, 0x50, 0xba, 0x78, 0xc7, 0x16, 0x10, 0x66, 0xb8, 0x1, 0x3d, 0xcd, 0x21, 0x66, 0x89, 0xc3, 0x5a, 0x89, 0xd6, 0xfc, 0xac, 0x3c, 0, 0x75, 0xfb, 0x89, 0xf1, 0x29, 0xd1, 0x49, 0xb4, 0x40, 0xcd, 0x21, 0x58}))
    II(0x1016c995, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016c996, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016c997, 0x5)   mov(edx, /* sys */ 0x1016c778);       /* mov edx, 0x1016c778 */
    II(0x1016c99c, 0x4)   mov(ax, 0x3d01);                      /* mov ax, 0x3d01 */
    II(0x1016c9a0, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1016c9a2, 0x3)   mov(bx, ax);                          /* mov bx, ax */
    II(0x1016c9a5, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016c9a6, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x1016c9a8, 0x1)   cld();                                /* cld */
l_0x1016c9a9:
    II(0x1016c9a9, 0x1)   lodsb_a32();                          /* lodsb */
    II(0x1016c9aa, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x1016c9ac, 0x2)   jnzd(0x1016c9a9, -0x5);               /* jnz 0x1016c9a9 */
    II(0x1016c9ae, 0x2)   mov(ecx, esi);                        /* mov ecx, esi */
    II(0x1016c9b0, 0x2)   sub(ecx, edx);                        /* sub ecx, edx */
    II(0x1016c9b2, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x1016c9b3, 0x2)   mov(ah, 0x40);                        /* mov ah, 0x40 */
    II(0x1016c9b5, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1016c9b7, 0x1)   popd(eax);                            /* pop eax */
    II(0x1016c9b8, 0)     jmpd_func(/* sys */ 0x1016c9b8, 0);   /* Принудительное завершение функции. */
FUNC_END

