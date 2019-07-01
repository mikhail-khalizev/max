FUNC_BEGIN(0x100898c4, 0x736f37d154d6841d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x84, 0xc4, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x7d, 0xfc, 0x8b, 0x75, 0xf8, 0x8d, 0x76, 0xb, 0xa5, 0xa5, 0xa5, 0xa5, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100898c4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100898c9, 0x5)   calld(sys_check_available_stack_size, 0xdc484); /* call 0x10165d52 */
    II(0x100898ce, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100898cf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100898d0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100898d1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100898d2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100898d3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100898d5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100898db, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100898de, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100898e1, 0x3)   mov(edi, memd_a32(ss, ebp - 0x4));    /* mov edi, [ebp-0x4] */
    II(0x100898e4, 0x3)   mov(esi, memd_a32(ss, ebp - 0x8));    /* mov esi, [ebp-0x8] */
    II(0x100898e7, 0x3)   lea(esi, esi + 0xb);                  /* lea esi, [esi+0xb] */
    II(0x100898ea, 0x1)   movsd_a32();                          /* movsd */
    II(0x100898eb, 0x1)   movsd_a32();                          /* movsd */
    II(0x100898ec, 0x1)   movsd_a32();                          /* movsd */
    II(0x100898ed, 0x1)   movsd_a32();                          /* movsd */
    II(0x100898ee, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100898f0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100898f1, 0x1)   popd(edi);                            /* pop edi */
    II(0x100898f2, 0x1)   popd(esi);                            /* pop esi */
    II(0x100898f3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100898f4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100898f5, 0x1)   retd();                               /* ret */
FUNC_END

