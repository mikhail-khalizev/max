FUNC_BEGIN(0x100836ad, 0x98237dc120dd070a, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x9b, 0x26, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x15, 0x2, 0x7e, 0x9, 0xc6, 0x45, 0xf8, 0, 0xe9, 0x6f, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x76, 0xfe, 0xff, 0xff, 0x84, 0xc0, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x5d, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x2a, 0xe8, 0x18, 0x76, 0xb, 0, 0x84, 0xc0, 0x75, 0x14, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x2a, 0xe8, 0x74, 0x66, 0, 0, 0xe8, 0x63, 0x68, 0, 0, 0x85, 0xc0, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0, 0xeb, 0x32, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x7, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x2a, 0xe8, 0x51, 0x66, 0, 0, 0xe8, 0x40, 0x68, 0, 0, 0xe8, 0x3f, 0x29, 0xff, 0xff, 0x84, 0xc0, 0x75, 0x6, 0xc6, 0x45, 0xf4, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100836ad, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100836b2, 0x5)   calld(sys_check_available_stack_size, 0xe269b); /* call 0x10165d52 */
    II(0x100836b7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100836b8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100836b9, 0x1)   pushd(edx);                           /* push edx */
    II(0x100836ba, 0x1)   pushd(esi);                           /* push esi */
    II(0x100836bb, 0x1)   pushd(edi);                           /* push edi */
    II(0x100836bc, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100836bd, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100836bf, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100836c5, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100836c8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100836cb, 0x4)   cmp(memb_a32(ds, eax + 0x15), 0x2);   /* cmp byte [eax+0x15], 0x2 */
    II(0x100836cf, 0x2)   jled(0x100836da, 0x9);                /* jle 0x100836da */
    II(0x100836d1, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x100836d5, 0x5)   jmpd(0x10083749, 0x6f);               /* jmp 0x10083749 */
l_0x100836da:
    II(0x100836da, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100836dd, 0x5)   calld(0x10083558, -0x18a);            /* call 0x10083558 */
    II(0x100836e2, 0x2)   test(al, al);                         /* test al, al */
    II(0x100836e4, 0x2)   jnzd(0x100836ec, 0x6);                /* jnz 0x100836ec */
    II(0x100836e6, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x100836ea, 0x2)   jmpd(0x10083749, 0x5d);               /* jmp 0x10083749 */
l_0x100836ec:
    II(0x100836ec, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100836ee, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100836f1, 0x3)   add(eax, 0x2a);                       /* add eax, 0x2a */
    II(0x100836f4, 0x5)   calld(0x1013ad11, 0xb7618);           /* call 0x1013ad11 */
    II(0x100836f9, 0x2)   test(al, al);                         /* test al, al */
    II(0x100836fb, 0x2)   jnzd(0x10083711, 0x14);               /* jnz 0x10083711 */
    II(0x100836fd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10083700, 0x3)   add(eax, 0x2a);                       /* add eax, 0x2a */
    II(0x10083703, 0x5)   calld(0x10089d7c, 0x6674);            /* call 0x10089d7c */
    II(0x10083708, 0x5)   calld(0x10089f70, 0x6863);            /* call 0x10089f70 */
    II(0x1008370d, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1008370f, 0x2)   jnzd(0x10083717, 0x6);                /* jnz 0x10083717 */
l_0x10083711:
    II(0x10083711, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x10083715, 0x2)   jmpd(0x10083749, 0x32);               /* jmp 0x10083749 */
l_0x10083717:
    II(0x10083717, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008371a, 0x3)   mov(edx, memd_a32(ds, eax + 0x7));    /* mov edx, [eax+0x7] */
    II(0x1008371d, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10083720, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10083723, 0x3)   add(eax, 0x2a);                       /* add eax, 0x2a */
    II(0x10083726, 0x5)   calld(0x10089d7c, 0x6651);            /* call 0x10089d7c */
    II(0x1008372b, 0x5)   calld(0x10089f70, 0x6840);            /* call 0x10089f70 */
    II(0x10083730, 0x5)   calld(0x10076074, -0xd6c1);           /* call 0x10076074 */
    II(0x10083735, 0x2)   test(al, al);                         /* test al, al */
    II(0x10083737, 0x2)   jnzd(0x1008373f, 0x6);                /* jnz 0x1008373f */
    II(0x10083739, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x1008373d, 0x2)   jmpd(0x10083743, 0x4);                /* jmp 0x10083743 */
l_0x1008373f:
    II(0x1008373f, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
l_0x10083743:
    II(0x10083743, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x10083746, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
l_0x10083749:
    II(0x10083749, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1008374c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008374e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008374f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10083750, 0x1)   popd(esi);                            /* pop esi */
    II(0x10083751, 0x1)   popd(edx);                            /* pop edx */
    II(0x10083752, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10083753, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10083754, 0x1)   retd();                               /* ret */
FUNC_END

