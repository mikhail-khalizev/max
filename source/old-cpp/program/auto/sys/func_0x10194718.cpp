FUNC_BEGIN(/* sys */ 0x10194718, 0x97b6694df2a4b81c, 0x20, ({0x53, 0x51, 0x52, 0x56, 0xb4, 0x2c, 0xcd, 0x21, 0x31, 0xc0, 0x88, 0xf0, 0x89, 0xc3, 0xb4, 0x2c, 0xcd, 0x21, 0x31, 0xc0, 0x88, 0xf0, 0x39, 0xc3, 0x74, 0xf4, 0x31, 0xf6, 0x88, 0xc3, 0xb4, 0x2c, 0xcd, 0x21, 0x46, 0x38, 0xf3, 0x74, 0xf7, 0x89, 0x35, 0x5c, 0xbc, 0x20, 0x10, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10194718, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194719, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019471a, 0x1)   pushd(edx);                           /* push edx */
    II(0x1019471b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019471c, 0x2)   mov(ah, 0x2c);                        /* mov ah, 0x2c */
    II(0x1019471e, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x10194720, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10194722, 0x2)   mov(al, dh);                          /* mov al, dh */
    II(0x10194724, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
l_0x10194726:
    II(0x10194726, 0x2)   mov(ah, 0x2c);                        /* mov ah, 0x2c */
    II(0x10194728, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1019472a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1019472c, 0x2)   mov(al, dh);                          /* mov al, dh */
    II(0x1019472e, 0x2)   cmp(ebx, eax);                        /* cmp ebx, eax */
    II(0x10194730, 0x2)   jzd(0x10194726, -0xc);                /* jz 0x10194726 */
    II(0x10194732, 0x2)   xor_(esi, esi);                       /* xor esi, esi */
    II(0x10194734, 0x2)   mov(bl, al);                          /* mov bl, al */
l_0x10194736:
    II(0x10194736, 0x2)   mov(ah, 0x2c);                        /* mov ah, 0x2c */
    II(0x10194738, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1019473a, 0x1)   inc(esi);                             /* inc esi */
    II(0x1019473b, 0x2)   cmp(bl, dh);                          /* cmp bl, dh */
    II(0x1019473d, 0x2)   jzd(0x10194736, -0x9);                /* jz 0x10194736 */
    II(0x1019473f, 0x6)   mov(memd_a32(ds, 0x1020bc5c), esi);   /* mov [0x1020bc5c], esi */
    II(0x10194745, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194746, 0x1)   popd(edx);                            /* pop edx */
    II(0x10194747, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194748, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194749, 0x1)   retd();                               /* ret */
FUNC_END

