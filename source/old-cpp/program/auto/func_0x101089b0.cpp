FUNC_BEGIN(0x101089b0, 0x88ea7e4249bdaec2, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x98, 0xd3, 0x5, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x45, 0xfc, 0x50, 0x8b, 0x45, 0xf8, 0xff, 0x70, 0xc, 0x8b, 0x45, 0xf8, 0xff, 0x70, 0x8, 0x8b, 0x45, 0xf8, 0x8b, 0x48, 0x4, 0x8b, 0x45, 0xf8, 0x8b, 0x18, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0xe, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xf4, 0x8b, 0x40, 0x16, 0xe8, 0x8e, 0x1c, 0x6, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x101089b0, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x101089b5, 0x5)   calld(sys_check_available_stack_size, 0x5d398); /* call 0x10165d52 */
    II(0x101089ba, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101089bb, 0x1)   pushd(esi);                           /* push esi */
    II(0x101089bc, 0x1)   pushd(edi);                           /* push edi */
    II(0x101089bd, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101089be, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101089c0, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x101089c6, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x101089c9, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x101089cc, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x101089cf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101089d2, 0x1)   pushd(eax);                           /* push eax */
    II(0x101089d3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101089d6, 0x3)   pushd(memd_a32(ds, eax + 0xc));       /* push dword [eax+0xc] */
    II(0x101089d9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101089dc, 0x3)   pushd(memd_a32(ds, eax + 0x8));       /* push dword [eax+0x8] */
    II(0x101089df, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101089e2, 0x3)   mov(ecx, memd_a32(ds, eax + 0x4));    /* mov ecx, [eax+0x4] */
//    II(0x101089e5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101089e8, 0x2)   mov(ebx, memd_a32(ds, eax));          /* mov ebx, [eax] */
    II(0x101089ea, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101089ed, 0x3)   mov(edx, memd_a32(ds, eax + 0xe));    /* mov edx, [eax+0xe] */
    II(0x101089f0, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x101089f3, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101089f6, 0x3)   mov(eax, memd_a32(ds, eax + 0x16));   /* mov eax, [eax+0x16] */
    II(0x101089f9, 0x5)   calld(/* sys */ 0x1016a68c, 0x61c8e); /* call 0x1016a68c */
    II(0x101089fe, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10108a00, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10108a01, 0x1)   popd(edi);                            /* pop edi */
    II(0x10108a02, 0x1)   popd(esi);                            /* pop esi */
    II(0x10108a03, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10108a04, 0x1)   retd();                               /* ret */
FUNC_END

