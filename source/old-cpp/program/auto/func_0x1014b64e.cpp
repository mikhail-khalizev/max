FUNC_BEGIN(0x1014b64e, 0x3ca4cada08221d34, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xfa, 0xa6, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x61, 0xab, 0xf2, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x89, 0x50, 0x7e, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x7e, 0, 0x75, 0x23, 0x8b, 0x45, 0xfc, 0xe8, 0x63, 0xff, 0xff, 0xff, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xb7, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xe8, 0x35, 0xab, 0xf2, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x89, 0x50, 0x7e, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x7e, 0xe8, 0x67, 0xf4, 0xf3, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1014b64e, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1014b653, 0x5)   calld(sys_check_available_stack_size, 0x1a6fa); /* call 0x10165d52 */
    II(0x1014b658, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014b659, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014b65a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014b65b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014b65c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014b65d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014b65f, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1014b665, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014b668, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1014b66b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014b66e, 0x5)   calld(0x100761d4, -0xd549f);          /* call 0x100761d4 */
    II(0x1014b673, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1014b675, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014b678, 0x3)   mov(memd_a32(ds, eax + 0x7e), edx);   /* mov [eax+0x7e], edx */
    II(0x1014b67b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014b67e, 0x4)   cmp(memd_a32(ds, eax + 0x7e), 0);     /* cmp dword [eax+0x7e], 0x0 */
    II(0x1014b682, 0x2)   jnzd(0x1014b6a7, 0x23);               /* jnz 0x1014b6a7 */
    II(0x1014b684, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014b687, 0x5)   calld(0x1014b5ef, -0x9d);             /* call 0x1014b5ef */
    II(0x1014b68c, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1014b68f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014b692, 0x5)   calld(0x1014b64e, -0x49);             /* call 0x1014b64e */
    II(0x1014b697, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014b69a, 0x5)   calld(0x100761d4, -0xd54cb);          /* call 0x100761d4 */
    II(0x1014b69f, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1014b6a1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014b6a4, 0x3)   mov(memd_a32(ds, eax + 0x7e), edx);   /* mov [eax+0x7e], edx */
l_0x1014b6a7:
    II(0x1014b6a7, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1014b6aa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014b6ad, 0x3)   mov(eax, memd_a32(ds, eax + 0x7e));   /* mov eax, [eax+0x7e] */
    II(0x1014b6b0, 0x5)   calld(0x1008ab1c, -0xc0b99);          /* call 0x1008ab1c */
    II(0x1014b6b5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014b6b7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014b6b8, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014b6b9, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014b6ba, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014b6bb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014b6bc, 0x1)   retd();                               /* ret */
FUNC_END

