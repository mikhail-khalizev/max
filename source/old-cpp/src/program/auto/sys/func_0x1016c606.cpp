FUNC_BEGIN(/* sys */ 0x1016c606, 0xf6f9d8c5dbe17b9b, 0x20, ({0x51, 0x56, 0x83, 0xec, 0xc, 0x89, 0xc6, 0x89, 0xe0, 0x89, 0xe1, 0xe8, 0x76, 0xb3, 0x1, 0, 0x89, 0xf0, 0xe8, 0x6, 0, 0, 0, 0x83, 0xc4, 0xc, 0x5e, 0x59, 0xc3}))
    II(0x1016c606, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016c607, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016c608, 0x3)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1016c60b, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1016c60d, 0x2)   mov(eax, esp);                        /* mov eax, esp */
    II(0x1016c60f, 0x2)   mov(ecx, esp);                        /* mov ecx, esp */
    II(0x1016c611, 0x5)   calld(/* sys */ 0x1018798c, 0x1b376); /* call 0x1018798c */
    II(0x1016c616, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1016c618, 0x5)   calld(/* sys */ 0x1016c623, 0x6);     /* call 0x1016c623 */
    II(0x1016c61d, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x1016c620, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016c621, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016c622, 0x1)   retd();                               /* ret */
FUNC_END

