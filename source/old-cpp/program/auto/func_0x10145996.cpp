FUNC_BEGIN(0x10145996, 0x6fb6e8223552ba6e, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xb2, 0x3, 0x2, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf4, 0xe8, 0x65, 0xfd, 0xff, 0xff, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xec, 0, 0x75, 0x6, 0xc6, 0x45, 0xf0, 0, 0xeb, 0x14, 0x8b, 0x45, 0xec, 0xe8, 0x39, 0x22, 0, 0, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x10, 0xc6, 0x45, 0xf0, 0x1, 0x8a, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10145996, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1014599b, 0x5)   calld(sys_check_available_stack_size, 0x203b2); /* call 0x10165d52 */
    II(0x101459a0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101459a1, 0x1)   pushd(esi);                           /* push esi */
    II(0x101459a2, 0x1)   pushd(edi);                           /* push edi */
    II(0x101459a3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101459a4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101459a6, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x101459ac, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x101459af, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x101459b2, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
//    II(0x101459b5, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
//    II(0x101459b8, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101459bb, 0x5)   calld(0x10145725, -0x29b);            /* call 0x10145725 */
    II(0x101459c0, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x101459c3, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x101459c7, 0x2)   jnzd(0x101459cf, 0x6);                /* jnz 0x101459cf */
    II(0x101459c9, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0);     /* mov byte [ebp-0x10], 0x0 */
    II(0x101459cd, 0x2)   jmpd(0x101459e3, 0x14);               /* jmp 0x101459e3 */
l_0x101459cf:
    II(0x101459cf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x101459d2, 0x5)   calld(0x10147c10, 0x2239);            /* call 0x10147c10 */
    II(0x101459d7, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x101459d9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101459dc, 0x3)   mov(memw_a32(ds, eax), dx);           /* mov [eax], dx */
    II(0x101459df, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0x1);   /* mov byte [ebp-0x10], 0x1 */
l_0x101459e3:
    II(0x101459e3, 0x3)   mov(al, memb_a32(ss, ebp - 0x10));    /* mov al, [ebp-0x10] */
    II(0x101459e6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101459e8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101459e9, 0x1)   popd(edi);                            /* pop edi */
    II(0x101459ea, 0x1)   popd(esi);                            /* pop esi */
    II(0x101459eb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101459ec, 0x1)   retd();                               /* ret */
FUNC_END

