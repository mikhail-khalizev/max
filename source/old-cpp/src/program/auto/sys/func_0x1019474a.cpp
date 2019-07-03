FUNC_BEGIN(/* sys */ 0x1019474a, 0x5afa03247105d222, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x85, 0xc0, 0x74, 0x29, 0xf, 0xaf, 0x5, 0x5c, 0xbc, 0x20, 0x10, 0xbb, 0xe8, 0x3, 0, 0, 0x5, 0xf4, 0x1, 0, 0, 0x31, 0xd2, 0xf7, 0xf3, 0x85, 0xc0, 0x75, 0x1, 0x40, 0x89, 0xc6, 0x31, 0xc0, 0x88, 0xc3, 0xb4, 0x2c, 0xcd, 0x21, 0x38, 0xf3, 0x4e, 0x75, 0xf7, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1019474a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019474b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019474c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1019474d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019474e, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10194750, 0x2)   jzd(0x1019477b, 0x29);                /* jz 0x1019477b */
    II(0x10194752, 0x7)   imul(eax, memd_a32(ds, 0x1020bc5c));  /* imul eax, [0x1020bc5c] */
    II(0x10194759, 0x5)   mov(ebx, 0x3e8);                      /* mov ebx, 0x3e8 */
    II(0x1019475e, 0x5)   add(eax, 0x1f4);                      /* add eax, 0x1f4 */
    II(0x10194763, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10194765, 0x2)   div(ebx);                             /* div ebx */
    II(0x10194767, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10194769, 0x2)   jnzd(0x1019476c, 0x1);                /* jnz 0x1019476c */
    II(0x1019476b, 0x1)   inc(eax);                             /* inc eax */
l_0x1019476c:
    II(0x1019476c, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1019476e, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10194770, 0x2)   mov(bl, al);                          /* mov bl, al */
l_0x10194772:
    II(0x10194772, 0x2)   mov(ah, 0x2c);                        /* mov ah, 0x2c */
    II(0x10194774, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x10194776, 0x2)   cmp(bl, dh);                          /* cmp bl, dh */
    II(0x10194778, 0x1)   dec(esi);                             /* dec esi */
    II(0x10194779, 0x2)   jnzd(0x10194772, -0x9);               /* jnz 0x10194772 */
l_0x1019477b:
    II(0x1019477b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019477c, 0x1)   popd(edx);                            /* pop edx */
    II(0x1019477d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019477e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019477f, 0x1)   retd();                               /* ret */
FUNC_END

