FUNC_BEGIN(0x1009c0a4, 0xb46d56e2d7683384, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa4, 0x9c, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x77, 0xeb, 0x9, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009c0a4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009c0a9, 0x5)   calld(sys_check_available_stack_size, 0xc9ca4); /* call 0x10165d52 */
    II(0x1009c0ae, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c0af, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c0b0, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c0b1, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c0b2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c0b3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c0b5, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009c0bb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009c0be, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1009c0c1, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x1009c0c6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c0c9, 0x5)   calld(my_dtor_0x101b6edc, 0x9eb77);   /* call 0x1013ac45 */
    II(0x1009c0ce, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1009c0d1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c0d4, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009c0d7, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009c0da, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c0dc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c0dd, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c0de, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c0df, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c0e0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c0e1, 0x1)   retd();                               /* ret */
FUNC_END

