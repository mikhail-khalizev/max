FUNC_BEGIN(0x100720b1, 0xed29b9d6f61f4f38, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x97, 0x3c, 0xf, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x12, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100720b1, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100720b6, 0x5)   calld(sys_check_available_stack_size, 0xf3c97); /* call 0x10165d52 */
    II(0x100720bb, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100720bc, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100720bd, 0x1)   pushd(edx);                           /* push edx */
    II(0x100720be, 0x1)   pushd(esi);                           /* push esi */
    II(0x100720bf, 0x1)   pushd(edi);                           /* push edi */
    II(0x100720c0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100720c1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100720c3, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100720c9, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100720cc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100720cf, 0x5)   calld(0x100720e6, 0x12);              /* call 0x100720e6 */
    II(0x100720d4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100720d7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100720da, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100720dd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100720df, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100720e0, 0x1)   popd(edi);                            /* pop edi */
    II(0x100720e1, 0x1)   popd(esi);                            /* pop esi */
    II(0x100720e2, 0x1)   popd(edx);                            /* pop edx */
    II(0x100720e3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100720e4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100720e5, 0x1)   retd();                               /* ret */
FUNC_END

