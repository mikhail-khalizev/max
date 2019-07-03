FUNC_BEGIN(0x100e0b0c, 0x214b6464fd3af416, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3c, 0x52, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0b0c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e0b11, 0x5)   calld(sys_check_available_stack_size, 0x8523c); /* call 0x10165d52 */
    II(0x100e0b16, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0b17, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0b18, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0b19, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0b1a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0b1b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0b1c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0b1e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e0b24, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e0b27, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0b2a, 0x4)   mov(ax, memw_a32(ds, eax + 0x4));     /* mov ax, [eax+0x4] */
    II(0x100e0b2e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e0b31, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e0b34, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0b36, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0b37, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0b38, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0b39, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0b3a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0b3b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0b3c, 0x1)   retd();                               /* ret */
FUNC_END

