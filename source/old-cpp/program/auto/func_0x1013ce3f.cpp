FUNC_BEGIN(0x1013ce3f, 0xc3ffda0ee2077ce7, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x9, 0x8f, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x81, 0x38, 0xff, 0xff, 0, 0, 0x74, 0xc, 0x8b, 0x45, 0xf8, 0x81, 0x78, 0x1c, 0xff, 0xff, 0, 0, 0x75, 0x2, 0xeb, 0x4a, 0x8b, 0x45, 0xfc, 0x8b, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x1c, 0xe8, 0xf1, 0x34, 0x4, 0, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0xb, 0, 0x75, 0xa, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0xf, 0, 0x74, 0xb, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0xb, 0xe8, 0xc1, 0x90, 0x2, 0, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0xf, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0xb, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0, 0xff, 0xff, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013ce3f, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1013ce44, 0x5)   calld(sys_check_available_stack_size, 0x28f09); /* call 0x10165d52 */
    II(0x1013ce49, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013ce4a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013ce4b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013ce4c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013ce4d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013ce4e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013ce50, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013ce56, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013ce59, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013ce5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ce5f, 0x6)   cmp(memd_a32(ds, eax), 0xffff);       /* cmp dword [eax], 0xffff */
    II(0x1013ce65, 0x2)   jzd(0x1013ce73, 0xc);                 /* jz 0x1013ce73 */
    II(0x1013ce67, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ce6a, 0x7)   cmp(memd_a32(ds, eax + 0x1c), 0xffff); /* cmp dword [eax+0x1c], 0xffff */
    II(0x1013ce71, 0x2)   jnzd(0x1013ce75, 0x2);                /* jnz 0x1013ce75 */
l_0x1013ce73:
    II(0x1013ce73, 0x2)   jmpd(0x1013cebf, 0x4a);               /* jmp 0x1013cebf */
l_0x1013ce75:
    II(0x1013ce75, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ce78, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x1013ce7a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ce7d, 0x3)   mov(eax, memd_a32(ds, eax + 0x1c));   /* mov eax, [eax+0x1c] */
    II(0x1013ce80, 0x5)   calld(/* sys */ 0x10180376, 0x434f1); /* call 0x10180376 */
    II(0x1013ce85, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ce88, 0x4)   cmp(memd_a32(ds, eax + 0xb), 0);      /* cmp dword [eax+0xb], 0x0 */
    II(0x1013ce8c, 0x2)   jnzd(0x1013ce98, 0xa);                /* jnz 0x1013ce98 */
    II(0x1013ce8e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ce91, 0x5)   cmp(memw_a32(ds, eax + 0xf), 0);      /* cmp word [eax+0xf], 0x0 */
    II(0x1013ce96, 0x2)   jzd(0x1013cea3, 0xb);                 /* jz 0x1013cea3 */
l_0x1013ce98:
    II(0x1013ce98, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ce9b, 0x3)   mov(eax, memd_a32(ds, eax + 0xb));    /* mov eax, [eax+0xb] */
    II(0x1013ce9e, 0x5)   calld(sys_delete, 0x290c1);           /* call 0x10165f64 */
l_0x1013cea3:
    II(0x1013cea3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013cea6, 0x6)   mov(memw_a32(ds, eax + 0xf), 0);      /* mov word [eax+0xf], 0x0 */
    II(0x1013ceac, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ceaf, 0x7)   mov(memd_a32(ds, eax + 0xb), 0);      /* mov dword [eax+0xb], 0x0 */
    II(0x1013ceb6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ceb9, 0x6)   mov(memd_a32(ds, eax), 0xffff);       /* mov dword [eax], 0xffff */
l_0x1013cebf:
    II(0x1013cebf, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013cec1, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013cec2, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013cec3, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013cec4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013cec5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013cec6, 0x1)   retd();                               /* ret */
FUNC_END

