FUNC_BEGIN(0x100a2ab3, 0x3fa72ce3aa0a1f2d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x95, 0x32, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf8, 0xff, 0x52, 0x3c, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a2ab3, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a2ab8, 0x5)   calld(sys_check_available_stack_size, 0xc3295); /* call 0x10165d52 */
    II(0x100a2abd, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a2abe, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a2abf, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a2ac0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a2ac1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a2ac2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a2ac3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a2ac5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a2acb, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100a2ace, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100a2ad1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100a2ad4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a2ad7, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100a2ada, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a2add, 0x3)   calld_abs(memd_a32(ds, edx + 0x3c));  /* call dword near [edx+0x3c] */
    II(0x100a2ae0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a2ae2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a2ae3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a2ae4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a2ae5, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a2ae6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a2ae7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a2ae8, 0x1)   retd();                               /* ret */
FUNC_END

