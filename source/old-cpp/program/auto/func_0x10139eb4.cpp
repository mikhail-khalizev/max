FUNC_BEGIN(0x10139eb4, 0x102c4b72fce2f793, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0x94, 0xbe, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xcf, 0xb, 0, 0, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xe8, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x6, 0xe8, 0xd3, 0xc, 0, 0, 0x83, 0xe8, 0x6, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xa, 0xe8, 0x51, 0xce, 0xf3, 0xff, 0x83, 0xe8, 0xa, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xe, 0xe8, 0x3a, 0xce, 0xf3, 0xff, 0x83, 0xe8, 0xe, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x2, 0xac, 0x6e, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xe4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10139eb4, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x10139eb9, 0x5)   calld(sys_check_available_stack_size, 0x2be94); /* call 0x10165d52 */
    II(0x10139ebe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10139ebf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10139ec0, 0x1)   pushd(esi);                           /* push esi */
    II(0x10139ec1, 0x1)   pushd(edi);                           /* push edi */
    II(0x10139ec2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10139ec3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10139ec5, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x10139ecb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10139ece, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10139ed1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139ed4, 0x5)   calld(0x1013aaa8, 0xbcf);             /* call 0x1013aaa8 */
    II(0x10139ed9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10139edc, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10139edf, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x10139ee2, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10139ee5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139ee8, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x10139eeb, 0x5)   calld(0x1013abc3, 0xcd3);             /* call 0x1013abc3 */
    II(0x10139ef0, 0x3)   sub(eax, 0x6);                        /* sub eax, 0x6 */
    II(0x10139ef3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10139ef6, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10139ef9, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x10139efc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139eff, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x10139f02, 0x5)   calld(0x10076d58, -0xc31af);          /* call 0x10076d58 */
    II(0x10139f07, 0x3)   sub(eax, 0xa);                        /* sub eax, 0xa */
    II(0x10139f0a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10139f0d, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10139f10, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10139f13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139f16, 0x3)   add(eax, 0xe);                        /* add eax, 0xe */
    II(0x10139f19, 0x5)   calld(0x10076d58, -0xc31c6);          /* call 0x10076d58 */
    II(0x10139f1e, 0x3)   sub(eax, 0xe);                        /* sub eax, 0xe */
    II(0x10139f21, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10139f24, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10139f27, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10139f2a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139f2d, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b6eac); /* mov dword [eax+0x2], 0x101b6eac */
    II(0x10139f34, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139f37, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
//    II(0x10139f3a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x10139f3d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10139f3f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10139f40, 0x1)   popd(edi);                            /* pop edi */
    II(0x10139f41, 0x1)   popd(esi);                            /* pop esi */
    II(0x10139f42, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10139f43, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10139f44, 0x1)   retd();                               /* ret */
FUNC_END

