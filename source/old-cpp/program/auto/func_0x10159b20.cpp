FUNC_BEGIN(0x10159b20, 0xa3af2427498285ba, 0x20, ({0x68, 0x98, 0, 0, 0, 0xe8, 0x28, 0xc2, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x80, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xec, 0xb8, 0x1, 0, 0, 0, 0xe8, 0x3f, 0xa9, 0xf9, 0xff, 0xe8, 0xc1, 0x60, 0xfa, 0xff, 0x80, 0x4d, 0xf4, 0x1, 0x8b, 0x55, 0xec, 0x8d, 0x45, 0x80, 0xe8, 0xa1, 0x83, 0xf8, 0xff, 0x89, 0x45, 0xf0, 0x80, 0x65, 0xf4, 0xfe, 0x8d, 0x45, 0x80, 0xe8, 0x51, 0x92, 0xf8, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0x80, 0xe8, 0xa3, 0x91, 0xf8, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10159b20, 0x5)   pushd(0x98);                          /* push dword 0x98 */
    II(0x10159b25, 0x5)   calld(sys_check_available_stack_size, 0xc228); /* call 0x10165d52 */
    II(0x10159b2a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10159b2b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10159b2c, 0x1)   pushd(esi);                           /* push esi */
    II(0x10159b2d, 0x1)   pushd(edi);                           /* push edi */
    II(0x10159b2e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10159b2f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10159b31, 0x6)   sub(esp, 0x80);                       /* sub esp, 0x80 */
    II(0x10159b37, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10159b3a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10159b3d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10159b40, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x10159b43, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10159b48, 0x5)   calld(0x100f448c, -0x656c1);          /* call 0x100f448c */
    II(0x10159b4d, 0x5)   calld(0x100ffc13, -0x59f3f);          /* call 0x100ffc13 */
    II(0x10159b52, 0x4)   or_(memb_a32(ss, ebp - 0xc), 0x1);    /* or byte [ebp-0xc], 0x1 */
    II(0x10159b56, 0x3)   mov(edx, memd_a32(ss, ebp - 0x14));   /* mov edx, [ebp-0x14] */
    II(0x10159b59, 0x3)   lea(eax, ebp - 0x80);                 /* lea eax, [ebp-0x80] */
    II(0x10159b5c, 0x5)   calld(0x100e1f02, -0x77c5f);          /* call 0x100e1f02 */
    II(0x10159b61, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10159b64, 0x4)   and_(memb_a32(ss, ebp - 0xc), -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
    II(0x10159b68, 0x3)   lea(eax, ebp - 0x80);                 /* lea eax, [ebp-0x80] */
    II(0x10159b6b, 0x5)   calld(0x100e2dc1, -0x76daf);          /* call 0x100e2dc1 */
    II(0x10159b70, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10159b72, 0x3)   lea(eax, ebp - 0x80);                 /* lea eax, [ebp-0x80] */
    II(0x10159b75, 0x5)   calld(0x100e2d1d, -0x76e5d);          /* call 0x100e2d1d */
    II(0x10159b7a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10159b7c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10159b7d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10159b7e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10159b7f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10159b80, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10159b81, 0x1)   retd();                               /* ret */
FUNC_END

