FUNC_BEGIN(0x10114463, 0xa745fc18c573f349, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe5, 0x18, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x83, 0x78, 0xc, 0, 0x74, 0x15, 0x31, 0xdb, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x12, 0xc1, 0xfa, 0x10, 0xb8, 0x1f, 0, 0, 0, 0xe8, 0x38, 0x66, 0x1, 0, 0xc6, 0x5, 0x1e, 0x39, 0x1c, 0x10, 0x3, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x4, 0x1b, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10114463, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10114468, 0x5)   calld(sys_check_available_stack_size, 0x518e5); /* call 0x10165d52 */
    II(0x1011446d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011446e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011446f, 0x1)   pushd(edx);                           /* push edx */
    II(0x10114470, 0x1)   pushd(esi);                           /* push esi */
    II(0x10114471, 0x1)   pushd(edi);                           /* push edi */
    II(0x10114472, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10114473, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10114475, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1011447b, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1011447e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114481, 0x5)   cmp(memw_a32(ds, eax + 0xc), 0);      /* cmp word [eax+0xc], 0x0 */
    II(0x10114486, 0x2)   jzd(0x1011449d, 0x15);                /* jz 0x1011449d */
    II(0x10114488, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1011448a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011448d, 0x3)   mov(edx, memd_a32(ds, eax + 0x12));   /* mov edx, [eax+0x12] */
    II(0x10114490, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10114493, 0x5)   mov(eax, 0x1f);                       /* mov eax, 0x1f */
    II(0x10114498, 0x5)   calld(0x1012aad5, 0x16638);           /* call 0x1012aad5 */
l_0x1011449d:
    II(0x1011449d, 0x7)   mov(memb_a32(ds, 0x101c391e), 0x3);   /* mov byte [0x101c391e], 0x3 */
    II(0x101144a4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101144a7, 0x7)   mov(memd_a32(ds, eax + 0x4), 0x1b);   /* mov dword [eax+0x4], 0x1b */
    II(0x101144ae, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101144b0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101144b1, 0x1)   popd(edi);                            /* pop edi */
    II(0x101144b2, 0x1)   popd(esi);                            /* pop esi */
    II(0x101144b3, 0x1)   popd(edx);                            /* pop edx */
    II(0x101144b4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101144b5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101144b6, 0x1)   retd();                               /* ret */
FUNC_END

