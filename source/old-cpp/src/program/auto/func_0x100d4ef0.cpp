FUNC_BEGIN(0x100d4ef0, 0x70c4e9fd14889474, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x58, 0xe, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d4ef0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d4ef5, 0x5)   calld(sys_check_available_stack_size, 0x90e58); /* call 0x10165d52 */
    II(0x100d4efa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d4efb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d4efc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d4efd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d4efe, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d4eff, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d4f00, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d4f02, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d4f08, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100d4f0b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d4f0e, 0x4)   mov(ax, memw_a32(ds, eax + 0x4));     /* mov ax, [eax+0x4] */
    II(0x100d4f12, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100d4f15, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d4f18, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d4f1a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d4f1b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d4f1c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d4f1d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d4f1e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d4f1f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d4f20, 0x1)   retd();                               /* ret */
FUNC_END

