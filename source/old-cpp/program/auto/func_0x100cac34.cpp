FUNC_BEGIN(0x100cac34, 0xfb9239e99d3dd7a6, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x14, 0xb1, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x7, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cac34, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cac39, 0x5)   calld(sys_check_available_stack_size, 0x9b114); /* call 0x10165d52 */
    II(0x100cac3e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cac3f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cac40, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cac41, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cac42, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cac43, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cac44, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cac46, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cac4c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cac4f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cac52, 0x4)   mov(ax, memw_a32(ds, eax + 0x7));     /* mov ax, [eax+0x7] */
    II(0x100cac56, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100cac59, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cac5c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cac5e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cac5f, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cac60, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cac61, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cac62, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cac63, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cac64, 0x1)   retd();                               /* ret */
FUNC_END

