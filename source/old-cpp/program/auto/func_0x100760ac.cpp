FUNC_BEGIN(0x100760ac, 0xd9a310d48411b400, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x9c, 0xfc, 0xe, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x5, 0x86, 0, 0, 0, 0xe8, 0x57, 0x5, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100760ac, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100760b1, 0x5)   calld(sys_check_available_stack_size, 0xefc9c); /* call 0x10165d52 */
    II(0x100760b6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100760b7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100760b8, 0x1)   pushd(esi);                           /* push esi */
    II(0x100760b9, 0x1)   pushd(edi);                           /* push edi */
    II(0x100760ba, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100760bb, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100760bd, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100760c3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100760c6, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100760c9, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100760cc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100760cf, 0x5)   add(eax, 0x86);                       /* add eax, 0x86 */
    II(0x100760d4, 0x5)   calld(0x10076630, 0x557);             /* call 0x10076630 */
    II(0x100760d9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100760db, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100760dc, 0x1)   popd(edi);                            /* pop edi */
    II(0x100760dd, 0x1)   popd(esi);                            /* pop esi */
    II(0x100760de, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100760df, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100760e0, 0x1)   retd();                               /* ret */
FUNC_END

