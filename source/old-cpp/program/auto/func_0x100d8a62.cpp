FUNC_BEGIN(0x100d8a62, 0x8ee47a4fa4462625, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe6, 0xd2, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xff, 0x4, 0, 0, 0xb8, 0x78, 0x72, 0x1c, 0x10, 0xe8, 0xcd, 0x51, 0x6, 0, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0xe, 0x9, 0x75, 0x12, 0x8b, 0x45, 0xfc, 0xe8, 0x25, 0xfb, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x66, 0x29, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x15, 0x8b, 0x55, 0xfc, 0x66, 0x8b, 0x52, 0x13, 0x66, 0x29, 0x10, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1b, 0, 0x74, 0x1c, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x15, 0xf, 0xbf, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x57, 0xfa, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x1b, 0x66, 0x89, 0x10, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0xe, 0x9, 0x74, 0x12, 0x8b, 0x45, 0xfc, 0xe8, 0xd5, 0xfa, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x66, 0x1, 0x10, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d8a62, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100d8a67, 0x5)   calld(sys_check_available_stack_size, 0x8d2e6); /* call 0x10165d52 */
    II(0x100d8a6c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d8a6d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d8a6e, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d8a6f, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d8a70, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d8a71, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d8a72, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d8a74, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100d8a7a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100d8a7d, 0x5)   mov(edx, 0x4ff);                      /* mov edx, 0x4ff */
    II(0x100d8a82, 0x5)   mov(eax, 0x101c7278);                 /* mov eax, 0x101c7278 */
    II(0x100d8a87, 0x5)   calld(0x1013dc59, 0x651cd);           /* call 0x1013dc59 */
    II(0x100d8a8c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8a8f, 0x4)   cmp(memb_a32(ds, eax + 0xe), 0x9);    /* cmp byte [eax+0xe], 0x9 */
    II(0x100d8a93, 0x2)   jnzd(0x100d8aa7, 0x12);               /* jnz 0x100d8aa7 */
    II(0x100d8a95, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8a98, 0x5)   calld(0x100d85c2, -0x4db);            /* call 0x100d85c2 */
    II(0x100d8a9d, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100d8a9f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8aa2, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100d8aa4, 0x3)   sub(memw_a32(ds, eax), dx);           /* sub [eax], dx */
l_0x100d8aa7:
    II(0x100d8aa7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8aaa, 0x3)   mov(eax, memd_a32(ds, eax + 0x15));   /* mov eax, [eax+0x15] */
    II(0x100d8aad, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100d8ab0, 0x4)   mov(dx, memw_a32(ds, edx + 0x13));    /* mov dx, [edx+0x13] */
    II(0x100d8ab4, 0x3)   sub(memw_a32(ds, eax), dx);           /* sub [eax], dx */
    II(0x100d8ab7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8aba, 0x4)   cmp(memd_a32(ds, eax + 0x1b), 0);     /* cmp dword [eax+0x1b], 0x0 */
    II(0x100d8abe, 0x2)   jzd(0x100d8adc, 0x1c);                /* jz 0x100d8adc */
    II(0x100d8ac0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8ac3, 0x3)   mov(eax, memd_a32(ds, eax + 0x15));   /* mov eax, [eax+0x15] */
    II(0x100d8ac6, 0x3)   movsx(edx, memw_a32(ds, eax));        /* movsx edx, word [eax] */
    II(0x100d8ac9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8acc, 0x5)   calld(0x100d8528, -0x5a9);            /* call 0x100d8528 */
    II(0x100d8ad1, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100d8ad3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8ad6, 0x3)   mov(eax, memd_a32(ds, eax + 0x1b));   /* mov eax, [eax+0x1b] */
    II(0x100d8ad9, 0x3)   mov(memw_a32(ds, eax), dx);           /* mov [eax], dx */
l_0x100d8adc:
    II(0x100d8adc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8adf, 0x4)   cmp(memb_a32(ds, eax + 0xe), 0x9);    /* cmp byte [eax+0xe], 0x9 */
    II(0x100d8ae3, 0x2)   jzd(0x100d8af7, 0x12);                /* jz 0x100d8af7 */
    II(0x100d8ae5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8ae8, 0x5)   calld(0x100d85c2, -0x52b);            /* call 0x100d85c2 */
    II(0x100d8aed, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100d8aef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8af2, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100d8af4, 0x3)   add(memw_a32(ds, eax), dx);           /* add [eax], dx */
l_0x100d8af7:
    II(0x100d8af7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d8af9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d8afa, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d8afb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d8afc, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d8afd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d8afe, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d8aff, 0x1)   retd();                               /* ret */
FUNC_END

