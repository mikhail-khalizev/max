FUNC_BEGIN(0x1009c484, 0x4ca79491374ce980, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xc4, 0x98, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x9d, 0xa9, 0xfd, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009c484, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1009c489, 0x5)   calld(sys_check_available_stack_size, 0xc98c4); /* call 0x10165d52 */
    II(0x1009c48e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c48f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c490, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009c491, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c492, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c493, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c494, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c496, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009c49c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009c49f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c4a2, 0x5)   calld(my_ctor_0x101b6edc, -0x25663);  /* call 0x10076e44 */
    II(0x1009c4a7, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009c4aa, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x1009c4ad, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009c4b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c4b3, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009c4b6, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009c4b9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c4bb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c4bc, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c4bd, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c4be, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009c4bf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c4c0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c4c1, 0x1)   retd();                               /* ret */
FUNC_END

