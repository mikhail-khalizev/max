FUNC_BEGIN(0x100a7491, 0x348e94efc15d9a90, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0xb7, 0xe8, 0xb, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x24, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf4, 0x89, 0x5d, 0xf8, 0x89, 0x4d, 0xfc, 0x8b, 0x45, 0xf0, 0xe8, 0xee, 0x35, 0x9, 0, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xe0, 0xe8, 0x60, 0x36, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x6, 0xe8, 0xfe, 0x35, 0, 0, 0x83, 0xe8, 0x6, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x16, 0xe8, 0x3, 0xf2, 0xfc, 0xff, 0x83, 0xe8, 0x16, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x1a, 0xe8, 0xa0, 0x3b, 0xfe, 0xff, 0x83, 0xe8, 0x1a, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xf0, 0xc7, 0x40, 0x2, 0x4, 0x4e, 0x1b, 0x10, 0x8b, 0x55, 0xf4, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x16, 0xe8, 0x8, 0xf1, 0xfc, 0xff, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf0, 0xe8, 0x57, 0, 0, 0, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf0, 0x83, 0xc0, 0x1a, 0xe8, 0xa3, 0x3a, 0xfe, 0xff, 0x8b, 0x45, 0xf0, 0xc6, 0x40, 0x1e, 0, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xdc, 0x8b, 0x45, 0xdc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc3}))
    II(0x100a7491, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x100a7496, 0x5)   calld(sys_check_available_stack_size, 0xbe8b7); /* call 0x10165d52 */
    II(0x100a749b, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a749c, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a749d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a749e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a74a0, 0x6)   sub(esp, 0x24);                       /* sub esp, 0x24 */
    II(0x100a74a6, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100a74a9, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100a74ac, 0x3)   mov(memd_a32(ss, ebp - 0x8), ebx);    /* mov [ebp-0x8], ebx */
    II(0x100a74af, 0x3)   mov(memd_a32(ss, ebp - 0x4), ecx);    /* mov [ebp-0x4], ecx */
//    II(0x100a74b2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a74b5, 0x5)   calld(0x1013aaa8, 0x935ee);           /* call 0x1013aaa8 */
    II(0x100a74ba, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100a74bd, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100a74c0, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x100a74c3, 0x5)   calld(0x100aab28, 0x3660);            /* call 0x100aab28 */
    II(0x100a74c8, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100a74cb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a74ce, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x100a74d1, 0x5)   calld(0x100aaad4, 0x35fe);            /* call 0x100aaad4 */
    II(0x100a74d6, 0x3)   sub(eax, 0x6);                        /* sub eax, 0x6 */
    II(0x100a74d9, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100a74dc, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100a74df, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x100a74e2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a74e5, 0x3)   add(eax, 0x16);                       /* add eax, 0x16 */
    II(0x100a74e8, 0x5)   calld(my_ctor_0x101b38f8, -0x30dfd);  /* call 0x100766f0 */
    II(0x100a74ed, 0x3)   sub(eax, 0x16);                       /* sub eax, 0x16 */
    II(0x100a74f0, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100a74f3, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100a74f6, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x100a74f9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a74fc, 0x3)   add(eax, 0x1a);                       /* add eax, 0x1a */
    II(0x100a74ff, 0x5)   calld(my_ctor_0x101b3b58, -0x1c460);  /* call 0x1008b0a4 */
    II(0x100a7504, 0x3)   sub(eax, 0x1a);                       /* sub eax, 0x1a */
    II(0x100a7507, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100a750a, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100a750d, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100a7510, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a7513, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b4e04); /* mov dword [eax+0x2], 0x101b4e04 */
    II(0x100a751a, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100a751d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a7520, 0x3)   add(eax, 0x16);                       /* add eax, 0x16 */
    II(0x100a7523, 0x5)   calld(0x10076630, -0x30ef8);          /* call 0x10076630 */
    II(0x100a7528, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100a752b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a752e, 0x5)   calld(0x100a758a, 0x57);              /* call 0x100a758a */
    II(0x100a7533, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100a7536, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a7539, 0x3)   add(eax, 0x1a);                       /* add eax, 0x1a */
    II(0x100a753c, 0x5)   calld(0x1008afe4, -0x1c55d);          /* call 0x1008afe4 */
    II(0x100a7541, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a7544, 0x4)   mov(memb_a32(ds, eax + 0x1e), 0);     /* mov byte [eax+0x1e], 0x0 */
    II(0x100a7548, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a754b, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
//    II(0x100a754e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x100a7551, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a7553, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a7554, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a7555, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a7556, 0x1)   retd();                               /* ret */
FUNC_END

