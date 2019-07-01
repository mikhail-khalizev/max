FUNC_BEGIN(0x100d4dc8, 0xe40d2038518d9a35, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x80, 0xf, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc7, 0, 0x4c, 0x5c, 0x1b, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d4dc8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d4dcd, 0x5)   calld(sys_check_available_stack_size, 0x90f80); /* call 0x10165d52 */
    II(0x100d4dd2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d4dd3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d4dd4, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d4dd5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d4dd6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d4dd7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d4dd8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d4dda, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d4de0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100d4de3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d4de6, 0x6)   mov(memd_a32(ds, eax), 0x101b5c4c);   /* mov dword [eax], 0x101b5c4c */
    II(0x100d4dec, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d4def, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100d4df2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d4df5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d4df7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d4df8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d4df9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d4dfa, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d4dfb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d4dfc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d4dfd, 0x1)   retd();                               /* ret */
FUNC_END

