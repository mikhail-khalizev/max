FUNC_BEGIN(0x10088379, 0xaff7b91d08b3367c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xcf, 0xd9, 0xd, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x80, 0x7d, 0xfc, 0, 0x75, 0x14, 0xbb, 0x79, 0x83, 0x8, 0x10, 0x8b, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0xe8, 0x96, 0x9, 0xff, 0xff, 0x84, 0xc0, 0x75, 0x1a, 0x8b, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0xe8, 0x8f, 0xa6, 0xc, 0, 0x84, 0xc0, 0x74, 0xb, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf0, 0xe8, 0xfc, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10088379, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008837e, 0x5)   calld(sys_check_available_stack_size, 0xdd9cf); /* call 0x10165d52 */
    II(0x10088383, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10088384, 0x1)   pushd(esi);                           /* push esi */
    II(0x10088385, 0x1)   pushd(edi);                           /* push edi */
    II(0x10088386, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10088387, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10088389, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1008838f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10088392, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x10088395, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x10088398, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008839b, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1008839e, 0x4)   cmp(memb_a32(ss, ebp - 0x4), 0);      /* cmp byte [ebp-0x4], 0x0 */
    II(0x100883a2, 0x2)   jnzd(0x100883b8, 0x14);               /* jnz 0x100883b8 */
    II(0x100883a4, 0x5)   mov(ebx, 0x10088379);                 /* mov ebx, 0x10088379 */
    II(0x100883a9, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100883ac, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100883af, 0x5)   calld(0x10078d4a, -0xf66a);           /* call 0x10078d4a */
    II(0x100883b4, 0x2)   test(al, al);                         /* test al, al */
    II(0x100883b6, 0x2)   jnzd(0x100883d2, 0x1a);               /* jnz 0x100883d2 */
l_0x100883b8:
    II(0x100883b8, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100883bb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100883be, 0x5)   calld(0x10152a52, 0xca68f);           /* call 0x10152a52 */
    II(0x100883c3, 0x2)   test(al, al);                         /* test al, al */
    II(0x100883c5, 0x2)   jzd(0x100883d2, 0xb);                 /* jz 0x100883d2 */
    II(0x100883c7, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100883ca, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100883cd, 0x5)   calld(0x100884ce, 0xfc);              /* call 0x100884ce */
l_0x100883d2:
    II(0x100883d2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100883d4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100883d5, 0x1)   popd(edi);                            /* pop edi */
    II(0x100883d6, 0x1)   popd(esi);                            /* pop esi */
    II(0x100883d7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100883d8, 0x1)   retd();                               /* ret */
FUNC_END

