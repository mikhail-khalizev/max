FUNC_BEGIN(0x10148648, 0x26494b541c044271, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0, 0xd7, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x3b, 0x24, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x6, 0xe8, 0x6f, 0xe0, 0xf2, 0xff, 0x83, 0xe8, 0x6, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x2, 0xc, 0x73, 0x1b, 0x10, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x6, 0xe8, 0x8b, 0xdf, 0xf2, 0xff, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xec, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10148648, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x1014864d, 0x5)   calld(sys_check_available_stack_size, 0x1d700); /* call 0x10165d52 */
    II(0x10148652, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10148653, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10148654, 0x1)   pushd(esi);                           /* push esi */
    II(0x10148655, 0x1)   pushd(edi);                           /* push edi */
    II(0x10148656, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10148657, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10148659, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x1014865f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10148662, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10148665, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10148668, 0x5)   calld(0x1013aaa8, -0xdbc5);           /* call 0x1013aaa8 */
    II(0x1014866d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10148670, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10148673, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10148676, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10148679, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1014867c, 0x5)   calld(my_ctor_0x101b38f8, -0xd1f91);  /* call 0x100766f0 */
    II(0x10148681, 0x3)   sub(eax, 0x6);                        /* sub eax, 0x6 */
    II(0x10148684, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10148687, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x1014868a, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1014868d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10148690, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b730c); /* mov dword [eax+0x2], 0x101b730c */
    II(0x10148697, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1014869a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014869d, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x101486a0, 0x5)   calld(0x10076630, -0xd2075);          /* call 0x10076630 */
    II(0x101486a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101486a8, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
//    II(0x101486ab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x101486ae, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101486b0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101486b1, 0x1)   popd(edi);                            /* pop edi */
    II(0x101486b2, 0x1)   popd(esi);                            /* pop esi */
    II(0x101486b3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101486b4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101486b5, 0x1)   retd();                               /* ret */
FUNC_END

