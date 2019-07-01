FUNC_BEGIN(0x100ab1c8, 0xd19b695e280813e0, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x80, 0xab, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ab1c8, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100ab1cd, 0x5)   calld(sys_check_available_stack_size, 0xbab80); /* call 0x10165d52 */
    II(0x100ab1d2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ab1d3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ab1d4, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ab1d5, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ab1d6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ab1d7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ab1d9, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ab1df, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ab1e2, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x100ab1e5, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100ab1e8, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100ab1eb, 0x3)   mov(memb_a32(ds, edx + 0x8), al);     /* mov [edx+0x8], al */
    II(0x100ab1ee, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ab1f0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ab1f1, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ab1f2, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ab1f3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ab1f4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ab1f5, 0x1)   retd();                               /* ret */
FUNC_END

