FUNC_BEGIN(0x100ba18e, 0x1859c8fb0605ebcb, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0xba, 0xbb, 0xa, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x4c, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0xe8, 0x16, 0xa8, 0xfb, 0xff, 0x84, 0xc0, 0x74, 0x10, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x4d, 0xe8, 0x4c, 0x9, 0xfd, 0xff, 0xeb, 0xe, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x57, 0xe8, 0x3c, 0x9, 0xfd, 0xff, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x50, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x7e, 0x9, 0x8b, 0x45, 0xf8, 0x80, 0x78, 0xe, 0, 0x74, 0x2, 0xeb, 0x4c, 0xc7, 0x45, 0xf4, 0x1, 0, 0, 0, 0xb8, 0xa, 0, 0, 0, 0xe8, 0xf5, 0xbb, 0xa, 0, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xec, 0, 0x74, 0x16, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf0, 0xe8, 0x15, 0x9b, 0xfe, 0xff, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x89, 0x45, 0xe4, 0xeb, 0x6, 0x8b, 0x45, 0xec, 0x89, 0x45, 0xe4, 0x8b, 0x55, 0xe4, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0x8b, 0x5d, 0xf4, 0xe8, 0x70, 0xab, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ba18e, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x100ba193, 0x5)   calld(sys_check_available_stack_size, 0xabbba); /* call 0x10165d52 */
    II(0x100ba198, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ba199, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ba19a, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ba19b, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ba19c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ba19d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ba19f, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x100ba1a5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ba1a8, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ba1ab, 0x5)   mov(edx, 0x4c);                       /* mov edx, 0x4c */
    II(0x100ba1b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ba1b3, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x100ba1b6, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100ba1b9, 0x5)   calld(0x100749d4, -0x457ea);          /* call 0x100749d4 */
    II(0x100ba1be, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ba1c0, 0x2)   jzd(0x100ba1d2, 0x10);                /* jz 0x100ba1d2 */
    II(0x100ba1c2, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100ba1c5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ba1c8, 0x3)   add(eax, 0x4d);                       /* add eax, 0x4d */
    II(0x100ba1cb, 0x5)   calld(0x1008ab1c, -0x2f6b4);          /* call 0x1008ab1c */
    II(0x100ba1d0, 0x2)   jmpd(0x100ba1e0, 0xe);                /* jmp 0x100ba1e0 */
l_0x100ba1d2:
    II(0x100ba1d2, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100ba1d5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ba1d8, 0x3)   add(eax, 0x57);                       /* add eax, 0x57 */
    II(0x100ba1db, 0x5)   calld(0x1008ab1c, -0x2f6c4);          /* call 0x1008ab1c */
l_0x100ba1e0:
    II(0x100ba1e0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ba1e3, 0x3)   mov(al, memb_a32(ds, eax + 0x50));    /* mov al, [eax+0x50] */
    II(0x100ba1e6, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100ba1eb, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100ba1ed, 0x2)   jled(0x100ba1f8, 0x9);                /* jle 0x100ba1f8 */
    II(0x100ba1ef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ba1f2, 0x4)   cmp(memb_a32(ds, eax + 0xe), 0);      /* cmp byte [eax+0xe], 0x0 */
    II(0x100ba1f6, 0x2)   jzd(0x100ba1fa, 0x2);                 /* jz 0x100ba1fa */
l_0x100ba1f8:
    II(0x100ba1f8, 0x2)   jmpd(0x100ba246, 0x4c);               /* jmp 0x100ba246 */
l_0x100ba1fa:
    II(0x100ba1fa, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0x1);    /* mov dword [ebp-0xc], 0x1 */
    II(0x100ba201, 0x5)   mov(eax, 0xa);                        /* mov eax, 0xa */
    II(0x100ba206, 0x5)   calld(sys_new, 0xabbf5);              /* call 0x10165e00 */
    II(0x100ba20b, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x100ba20e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100ba211, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100ba214, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x100ba218, 0x2)   jzd(0x100ba230, 0x16);                /* jz 0x100ba230 */
    II(0x100ba21a, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100ba21d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100ba220, 0x5)   calld(0x100a3d3a, -0x164eb);          /* call 0x100a3d3a */
    II(0x100ba225, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
//    II(0x100ba228, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x100ba22b, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x100ba22e, 0x2)   jmpd(0x100ba236, 0x6);                /* jmp 0x100ba236 */
l_0x100ba230:
    II(0x100ba230, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100ba233, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
l_0x100ba236:
    II(0x100ba236, 0x3)   mov(edx, memd_a32(ss, ebp - 0x1c));   /* mov edx, [ebp-0x1c] */
    II(0x100ba239, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100ba23e, 0x3)   mov(ebx, memd_a32(ss, ebp - 0xc));    /* mov ebx, [ebp-0xc] */
    II(0x100ba241, 0x5)   calld(0x100a4db6, -0x15490);          /* call 0x100a4db6 */
l_0x100ba246:
    II(0x100ba246, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ba248, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ba249, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ba24a, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ba24b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ba24c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ba24d, 0x1)   retd();                               /* ret */
FUNC_END

