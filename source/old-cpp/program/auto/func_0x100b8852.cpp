FUNC_BEGIN(0x100b8852, 0x3da51c85b770389b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf6, 0xd4, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0x6b, 0xc0, 0x33, 0xf6, 0x80, 0xc0, 0x81, 0x1c, 0x10, 0x40, 0x74, 0x9, 0xc6, 0x45, 0xf8, 0, 0xe9, 0x5e, 0, 0, 0, 0x66, 0x83, 0x7d, 0xfc, 0x39, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0x4, 0xeb, 0x51, 0x66, 0x83, 0x7d, 0xfc, 0x47, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0x5, 0xeb, 0x44, 0x66, 0x83, 0x7d, 0xfc, 0x42, 0x74, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x43, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0x6, 0xeb, 0x30, 0xf, 0xbf, 0x45, 0xfc, 0x6b, 0xc0, 0x33, 0xf6, 0x80, 0xd4, 0x81, 0x1c, 0x10, 0x2, 0x74, 0x1c, 0xf, 0xbf, 0x45, 0xfc, 0x6b, 0xc0, 0x33, 0xf6, 0x80, 0xc1, 0x81, 0x1c, 0x10, 0x1, 0x74, 0x6, 0xc6, 0x45, 0xf8, 0x3, 0xeb, 0xa, 0xc6, 0x45, 0xf8, 0x2, 0xeb, 0x4, 0xc6, 0x45, 0xf8, 0x1, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b8852, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b8857, 0x5)   calld(sys_check_available_stack_size, 0xad4f6); /* call 0x10165d52 */
    II(0x100b885c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b885d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b885e, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b885f, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b8860, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b8861, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b8862, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b8864, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b886a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100b886d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100b8871, 0x3)   imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
    II(0x100b8874, 0x7)   test(memb_a32(ds, eax + 0x101c81c0), 0x40); /* test byte [eax+0x101c81c0], 0x40 */
    II(0x100b887b, 0x2)   jzd(0x100b8886, 0x9);                 /* jz 0x100b8886 */
    II(0x100b887d, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x100b8881, 0x5)   jmpd(0x100b88e4, 0x5e);               /* jmp 0x100b88e4 */
l_0x100b8886:
    II(0x100b8886, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x39);   /* cmp word [ebp-0x4], 0x39 */
    II(0x100b888b, 0x2)   jnzd(0x100b8893, 0x6);                /* jnz 0x100b8893 */
    II(0x100b888d, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x4);    /* mov byte [ebp-0x8], 0x4 */
    II(0x100b8891, 0x2)   jmpd(0x100b88e4, 0x51);               /* jmp 0x100b88e4 */
l_0x100b8893:
    II(0x100b8893, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x47);   /* cmp word [ebp-0x4], 0x47 */
    II(0x100b8898, 0x2)   jnzd(0x100b88a0, 0x6);                /* jnz 0x100b88a0 */
    II(0x100b889a, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x5);    /* mov byte [ebp-0x8], 0x5 */
    II(0x100b889e, 0x2)   jmpd(0x100b88e4, 0x44);               /* jmp 0x100b88e4 */
l_0x100b88a0:
    II(0x100b88a0, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x42);   /* cmp word [ebp-0x4], 0x42 */
    II(0x100b88a5, 0x2)   jzd(0x100b88ae, 0x7);                 /* jz 0x100b88ae */
    II(0x100b88a7, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x43);   /* cmp word [ebp-0x4], 0x43 */
    II(0x100b88ac, 0x2)   jnzd(0x100b88b4, 0x6);                /* jnz 0x100b88b4 */
l_0x100b88ae:
    II(0x100b88ae, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x6);    /* mov byte [ebp-0x8], 0x6 */
    II(0x100b88b2, 0x2)   jmpd(0x100b88e4, 0x30);               /* jmp 0x100b88e4 */
l_0x100b88b4:
    II(0x100b88b4, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100b88b8, 0x3)   imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
    II(0x100b88bb, 0x7)   test(memb_a32(ds, eax + 0x101c81d4), 0x2); /* test byte [eax+0x101c81d4], 0x2 */
    II(0x100b88c2, 0x2)   jzd(0x100b88e0, 0x1c);                /* jz 0x100b88e0 */
    II(0x100b88c4, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100b88c8, 0x3)   imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
    II(0x100b88cb, 0x7)   test(memb_a32(ds, eax + 0x101c81c1), 0x1); /* test byte [eax+0x101c81c1], 0x1 */
    II(0x100b88d2, 0x2)   jzd(0x100b88da, 0x6);                 /* jz 0x100b88da */
    II(0x100b88d4, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x3);    /* mov byte [ebp-0x8], 0x3 */
    II(0x100b88d8, 0x2)   jmpd(0x100b88e4, 0xa);                /* jmp 0x100b88e4 */
l_0x100b88da:
    II(0x100b88da, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x2);    /* mov byte [ebp-0x8], 0x2 */
    II(0x100b88de, 0x2)   jmpd(0x100b88e4, 0x4);                /* jmp 0x100b88e4 */
l_0x100b88e0:
    II(0x100b88e0, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
l_0x100b88e4:
    II(0x100b88e4, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100b88e7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b88e9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b88ea, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b88eb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b88ec, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b88ed, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b88ee, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b88ef, 0x1)   retd();                               /* ret */
FUNC_END

