FUNC_BEGIN(0x100b906f, 0x8ee9dc5e7e44b131, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xd9, 0xcc, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0xe8, 0x62, 0xff, 0xff, 0xff, 0x88, 0x45, 0xf8, 0x80, 0x7d, 0xf8, 0x4, 0x7d, 0xb, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xf4, 0xe9, 0x71, 0, 0, 0, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf0, 0xff, 0x45, 0xf0, 0xf, 0xbf, 0x45, 0xf0, 0x83, 0xf8, 0x4, 0x7d, 0x29, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x26, 0x25, 0xff, 0, 0, 0, 0xf, 0xbf, 0x55, 0xf0, 0x39, 0xc2, 0x74, 0x10, 0xf, 0xbf, 0x55, 0xf0, 0x8b, 0x45, 0xfc, 0xe8, 0x91, 0xd1, 0xfb, 0xff, 0x84, 0xc0, 0x75, 0x2, 0xeb, 0x2, 0xeb, 0x2, 0xeb, 0xc8, 0xf, 0xbf, 0x45, 0xf0, 0x83, 0xf8, 0x4, 0x7d, 0x6, 0xc6, 0x45, 0xf4, 0x1, 0xeb, 0x21, 0x80, 0x7d, 0xf8, 0x5, 0x75, 0xf, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x50, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x74, 0x2, 0xeb, 0x4, 0xc6, 0x45, 0xf8, 0x4, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b906f, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x100b9074, 0x5)   calld(sys_check_available_stack_size, 0xaccd9); /* call 0x10165d52 */
    II(0x100b9079, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b907a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b907b, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b907c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b907d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b907e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b907f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b9081, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100b9087, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b908a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b908d, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x100b9090, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100b9093, 0x5)   calld(0x100b8ffa, -0x9e);             /* call 0x100b8ffa */
    II(0x100b9098, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
    II(0x100b909b, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0x4);    /* cmp byte [ebp-0x8], 0x4 */
    II(0x100b909f, 0x2)   jged(0x100b90ac, 0xb);                /* jge 0x100b90ac */
    II(0x100b90a1, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100b90a4, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
    II(0x100b90a7, 0x5)   jmpd(0x100b911d, 0x71);               /* jmp 0x100b911d */
l_0x100b90ac:
    II(0x100b90ac, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x100b90b3, 0x2)   jmpd(0x100b90bb, 0x6);                /* jmp 0x100b90bb */
l_0x100b90b5:
    II(0x100b90b5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b90b8, 0x3)   inc(memd_a32(ss, ebp - 0x10));        /* inc dword [ebp-0x10] */
l_0x100b90bb:
    II(0x100b90bb, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x100b90bf, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
    II(0x100b90c2, 0x2)   jged(0x100b90ed, 0x29);               /* jge 0x100b90ed */
    II(0x100b90c4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b90c7, 0x3)   mov(al, memb_a32(ds, eax + 0x26));    /* mov al, [eax+0x26] */
    II(0x100b90ca, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100b90cf, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x10)); /* movsx edx, word [ebp-0x10] */
    II(0x100b90d3, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100b90d5, 0x2)   jzd(0x100b90e7, 0x10);                /* jz 0x100b90e7 */
    II(0x100b90d7, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x10)); /* movsx edx, word [ebp-0x10] */
    II(0x100b90db, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b90de, 0x5)   calld(0x10076274, -0x42e6f);          /* call 0x10076274 */
    II(0x100b90e3, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b90e5, 0x2)   jnzd(0x100b90e9, 0x2);                /* jnz 0x100b90e9 */
l_0x100b90e7:
    II(0x100b90e7, 0x2)   jmpd(0x100b90eb, 0x2);                /* jmp 0x100b90eb */
l_0x100b90e9:
    II(0x100b90e9, 0x2)   jmpd(0x100b90ed, 0x2);                /* jmp 0x100b90ed */
l_0x100b90eb:
    II(0x100b90eb, 0x2)   jmpd(0x100b90b5, -0x38);              /* jmp 0x100b90b5 */
l_0x100b90ed:
    II(0x100b90ed, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x100b90f1, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
    II(0x100b90f4, 0x2)   jged(0x100b90fc, 0x6);                /* jge 0x100b90fc */
    II(0x100b90f6, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x100b90fa, 0x2)   jmpd(0x100b911d, 0x21);               /* jmp 0x100b911d */
l_0x100b90fc:
    II(0x100b90fc, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0x5);    /* cmp byte [ebp-0x8], 0x5 */
    II(0x100b9100, 0x2)   jnzd(0x100b9111, 0xf);                /* jnz 0x100b9111 */
    II(0x100b9102, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b9105, 0x3)   mov(al, memb_a32(ds, eax + 0x50));    /* mov al, [eax+0x50] */
    II(0x100b9108, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100b910d, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100b910f, 0x2)   jzd(0x100b9113, 0x2);                 /* jz 0x100b9113 */
l_0x100b9111:
    II(0x100b9111, 0x2)   jmpd(0x100b9117, 0x4);                /* jmp 0x100b9117 */
l_0x100b9113:
    II(0x100b9113, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x4);    /* mov byte [ebp-0x8], 0x4 */
l_0x100b9117:
    II(0x100b9117, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100b911a, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
l_0x100b911d:
    II(0x100b911d, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100b9120, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b9122, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b9123, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b9124, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b9125, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b9126, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b9127, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b9128, 0x1)   retd();                               /* ret */
FUNC_END

