FUNC_BEGIN(0x10152532, 0x476e792af72b6e3e, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x16, 0x38, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x14, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0xc1, 0xfa, 0x6, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x16, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0xc1, 0xfa, 0x6, 0x89, 0x50, 0x4, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x40, 0x8b, 0x55, 0xfc, 0x89, 0x42, 0x8, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4, 0x40, 0x8b, 0x55, 0xfc, 0x89, 0x42, 0xc, 0x8b, 0x45, 0xf8, 0xf6, 0x40, 0x12, 0x10, 0x74, 0xc, 0x8b, 0x45, 0xfc, 0xff, 0x40, 0x8, 0x8b, 0x45, 0xfc, 0xff, 0x40, 0xc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10152532, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10152537, 0x5)   calld(sys_check_available_stack_size, 0x13816); /* call 0x10165d52 */
    II(0x1015253c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015253d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1015253e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1015253f, 0x1)   pushd(edi);                           /* push edi */
    II(0x10152540, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10152541, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10152543, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10152549, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1015254c, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1015254f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10152552, 0x3)   mov(edx, memd_a32(ds, eax + 0x14));   /* mov edx, [eax+0x14] */
    II(0x10152555, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10152558, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015255b, 0x3)   sar(edx, 0x6);                        /* sar edx, 0x6 */
    II(0x1015255e, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x10152560, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10152563, 0x3)   mov(edx, memd_a32(ds, eax + 0x16));   /* mov edx, [eax+0x16] */
    II(0x10152566, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10152569, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015256c, 0x3)   sar(edx, 0x6);                        /* sar edx, 0x6 */
    II(0x1015256f, 0x3)   mov(memd_a32(ds, eax + 0x4), edx);    /* mov [eax+0x4], edx */
    II(0x10152572, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10152575, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10152577, 0x1)   inc(eax);                             /* inc eax */
    II(0x10152578, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1015257b, 0x3)   mov(memd_a32(ds, edx + 0x8), eax);    /* mov [edx+0x8], eax */
    II(0x1015257e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10152581, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x10152584, 0x1)   inc(eax);                             /* inc eax */
    II(0x10152585, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10152588, 0x3)   mov(memd_a32(ds, edx + 0xc), eax);    /* mov [edx+0xc], eax */
    II(0x1015258b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1015258e, 0x4)   test(memb_a32(ds, eax + 0x12), 0x10); /* test byte [eax+0x12], 0x10 */
    II(0x10152592, 0x2)   jzd(0x101525a0, 0xc);                 /* jz 0x101525a0 */
    II(0x10152594, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10152597, 0x3)   inc(memd_a32(ds, eax + 0x8));         /* inc dword [eax+0x8] */
    II(0x1015259a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015259d, 0x3)   inc(memd_a32(ds, eax + 0xc));         /* inc dword [eax+0xc] */
l_0x101525a0:
    II(0x101525a0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101525a2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101525a3, 0x1)   popd(edi);                            /* pop edi */
    II(0x101525a4, 0x1)   popd(esi);                            /* pop esi */
    II(0x101525a5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101525a6, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101525a7, 0x1)   retd();                               /* ret */
FUNC_END

