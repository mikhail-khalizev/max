FUNC_BEGIN(0x100cac00, 0xdc3daaca3c2e6ce, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x48, 0xb1, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x9, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cac00, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cac05, 0x5)   calld(sys_check_available_stack_size, 0x9b148); /* call 0x10165d52 */
    II(0x100cac0a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cac0b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cac0c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cac0d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cac0e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cac0f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cac10, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cac12, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cac18, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cac1b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cac1e, 0x4)   mov(ax, memw_a32(ds, eax + 0x9));     /* mov ax, [eax+0x9] */
    II(0x100cac22, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100cac25, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cac28, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cac2a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cac2b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cac2c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cac2d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cac2e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cac2f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cac30, 0x1)   retd();                               /* ret */
FUNC_END

