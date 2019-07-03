FUNC_BEGIN(0x100a9f78, 0xa029056709ecad53, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd0, 0xbd, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x7d, 0xf8, 0x8b, 0x75, 0xfc, 0xa5, 0xa5, 0xa5, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a9f78, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a9f7d, 0x5)   calld(sys_check_available_stack_size, 0xbbdd0); /* call 0x10165d52 */
    II(0x100a9f82, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a9f83, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a9f84, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a9f85, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a9f86, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a9f87, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a9f89, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100a9f8f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a9f92, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a9f95, 0x3)   mov(edi, memd_a32(ss, ebp - 0x8));    /* mov edi, [ebp-0x8] */
    II(0x100a9f98, 0x3)   mov(esi, memd_a32(ss, ebp - 0x4));    /* mov esi, [ebp-0x4] */
    II(0x100a9f9b, 0x1)   movsd_a32();                          /* movsd */
    II(0x100a9f9c, 0x1)   movsd_a32();                          /* movsd */
    II(0x100a9f9d, 0x1)   movsd_a32();                          /* movsd */
    II(0x100a9f9e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a9fa1, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100a9fa4, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100a9fa7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a9fa9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a9faa, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a9fab, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a9fac, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a9fad, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a9fae, 0x1)   retd();                               /* ret */
FUNC_END

