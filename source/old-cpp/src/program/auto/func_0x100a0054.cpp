FUNC_BEGIN(0x100a0054, 0xa3db6cb7c3f51826, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf4, 0x5c, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x67, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a0054, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a0059, 0x5)   calld(sys_check_available_stack_size, 0xc5cf4); /* call 0x10165d52 */
    II(0x100a005e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a005f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a0060, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a0061, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a0062, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a0063, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a0064, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a0066, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a006c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100a006f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100a0072, 0x3)   mov(eax, memd_a32(ds, eax + 0x67));   /* mov eax, [eax+0x67] */
    II(0x100a0075, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100a0078, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a007b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a007d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a007e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a007f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a0080, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a0081, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a0082, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a0083, 0x1)   retd();                               /* ret */
FUNC_END

