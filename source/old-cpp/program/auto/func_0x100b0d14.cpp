FUNC_BEGIN(0x100b0d14, 0xc1303de8c364119e, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x34, 0x50, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0x33, 0xa0, 0x8, 0, 0x84, 0xc0, 0x74, 0x48, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0x27, 0x58, 0xfc, 0xff, 0x8b, 0x50, 0x18, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0x11, 0x58, 0xfc, 0xff, 0x8b, 0x50, 0x1a, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x50, 0x4, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x40, 0x8b, 0x55, 0xfc, 0x89, 0x42, 0x8, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4, 0x40, 0x8b, 0x55, 0xfc, 0x89, 0x42, 0xc, 0xeb, 0x63, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x23, 0xe8, 0xda, 0x9f, 0x8, 0, 0x84, 0xc0, 0x74, 0x52, 0x8d, 0x55, 0xf0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x23, 0xe8, 0x77, 0x97, 0xfd, 0xff, 0xe8, 0x86, 0xbc, 0xff, 0xff, 0xf, 0xbf, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x10, 0x8d, 0x55, 0xec, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x23, 0xe8, 0x5c, 0x97, 0xfd, 0xff, 0xe8, 0x6b, 0xbc, 0xff, 0xff, 0x8b, 0x10, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x50, 0x4, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x40, 0x8b, 0x55, 0xfc, 0x89, 0x42, 0x8, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4, 0x40, 0x8b, 0x55, 0xfc, 0x89, 0x42, 0xc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b0d14, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x100b0d19, 0x5)   calld(sys_check_available_stack_size, 0xb5034); /* call 0x10165d52 */
    II(0x100b0d1e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b0d1f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b0d20, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b0d21, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b0d22, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b0d23, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b0d25, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x100b0d2b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b0d2e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100b0d31, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b0d33, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0d36, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x100b0d39, 0x5)   calld(0x1013ad71, 0x8a033);           /* call 0x1013ad71 */
    II(0x100b0d3e, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b0d40, 0x2)   jzd(0x100b0d8a, 0x48);                /* jz 0x100b0d8a */
    II(0x100b0d42, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0d45, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x100b0d48, 0x5)   calld(0x10076574, -0x3a7d9);          /* call 0x10076574 */
    II(0x100b0d4d, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
    II(0x100b0d50, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100b0d53, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0d56, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x100b0d58, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0d5b, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x100b0d5e, 0x5)   calld(0x10076574, -0x3a7ef);          /* call 0x10076574 */
    II(0x100b0d63, 0x3)   mov(edx, memd_a32(ds, eax + 0x1a));   /* mov edx, [eax+0x1a] */
    II(0x100b0d66, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100b0d69, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0d6c, 0x3)   mov(memd_a32(ds, eax + 0x4), edx);    /* mov [eax+0x4], edx */
    II(0x100b0d6f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0d72, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100b0d74, 0x1)   inc(eax);                             /* inc eax */
    II(0x100b0d75, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b0d78, 0x3)   mov(memd_a32(ds, edx + 0x8), eax);    /* mov [edx+0x8], eax */
    II(0x100b0d7b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0d7e, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x100b0d81, 0x1)   inc(eax);                             /* inc eax */
    II(0x100b0d82, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b0d85, 0x3)   mov(memd_a32(ds, edx + 0xc), eax);    /* mov [edx+0xc], eax */
    II(0x100b0d88, 0x2)   jmpd(0x100b0ded, 0x63);               /* jmp 0x100b0ded */
l_0x100b0d8a:
    II(0x100b0d8a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b0d8c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0d8f, 0x3)   add(eax, 0x23);                       /* add eax, 0x23 */
    II(0x100b0d92, 0x5)   calld(0x1013ad71, 0x89fda);           /* call 0x1013ad71 */
    II(0x100b0d97, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b0d99, 0x2)   jzd(0x100b0ded, 0x52);                /* jz 0x100b0ded */
    II(0x100b0d9b, 0x3)   lea(edx, ebp - 0x10);                 /* lea edx, [ebp-0x10] */
    II(0x100b0d9e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0da1, 0x3)   add(eax, 0x23);                       /* add eax, 0x23 */
    II(0x100b0da4, 0x5)   calld(0x1008a520, -0x26889);          /* call 0x1008a520 */
    II(0x100b0da9, 0x5)   calld(0x100aca34, -0x437a);           /* call 0x100aca34 */
    II(0x100b0dae, 0x3)   movsx(edx, memw_a32(ds, eax));        /* movsx edx, word [eax] */
    II(0x100b0db1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0db4, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x100b0db6, 0x3)   lea(edx, ebp - 0x14);                 /* lea edx, [ebp-0x14] */
    II(0x100b0db9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0dbc, 0x3)   add(eax, 0x23);                       /* add eax, 0x23 */
    II(0x100b0dbf, 0x5)   calld(0x1008a520, -0x268a4);          /* call 0x1008a520 */
    II(0x100b0dc4, 0x5)   calld(0x100aca34, -0x4395);           /* call 0x100aca34 */
    II(0x100b0dc9, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x100b0dcb, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100b0dce, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0dd1, 0x3)   mov(memd_a32(ds, eax + 0x4), edx);    /* mov [eax+0x4], edx */
    II(0x100b0dd4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0dd7, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100b0dd9, 0x1)   inc(eax);                             /* inc eax */
    II(0x100b0dda, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b0ddd, 0x3)   mov(memd_a32(ds, edx + 0x8), eax);    /* mov [edx+0x8], eax */
    II(0x100b0de0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0de3, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x100b0de6, 0x1)   inc(eax);                             /* inc eax */
    II(0x100b0de7, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100b0dea, 0x3)   mov(memd_a32(ds, edx + 0xc), eax);    /* mov [edx+0xc], eax */
l_0x100b0ded:
    II(0x100b0ded, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b0df0, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b0df3, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b0df6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b0df8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b0df9, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b0dfa, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b0dfb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b0dfc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b0dfd, 0x1)   retd();                               /* ret */
FUNC_END

