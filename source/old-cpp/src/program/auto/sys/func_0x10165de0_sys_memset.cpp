FUNC_BEGIN(sys_memset, 0xacd568e91c768962, 0x20, ({0x50, 0x51, 0x88, 0xd6, 0xc1, 0xe2, 0x8, 0x88, 0xf2, 0xc1, 0xe2, 0x8, 0x88, 0xf2, 0x89, 0xd9, 0xe8, 0x4b, 0xb2, 0x1, 0, 0x59, 0x58, 0xc3}))
    II(0x10165de0, 0x1)   pushd(eax);                           /* push eax */
    II(0x10165de1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10165de2, 0x2)   mov(dh, dl);                          /* mov dh, dl */
    II(0x10165de4, 0x3)   shl(edx, 0x8);                        /* shl edx, 0x8 */
    II(0x10165de7, 0x2)   mov(dl, dh);                          /* mov dl, dh */
    II(0x10165de9, 0x3)   shl(edx, 0x8);                        /* shl edx, 0x8 */
    II(0x10165dec, 0x2)   mov(dl, dh);                          /* mov dl, dh */
    II(0x10165dee, 0x2)   mov(ecx, ebx);                        /* mov ecx, ebx */
    II(0x10165df0, 0x5)   calld(/* sys */ 0x10181040, 0x1b24b); /* call 0x10181040 */
    II(0x10165df5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10165df6, 0x1)   popd(eax);                            /* pop eax */
    II(0x10165df7, 0x1)   retd();                               /* ret */
FUNC_END

