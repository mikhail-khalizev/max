FUNC_BEGIN(0x10121078, 0x65323367ac8bea41, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xd0, 0x4c, 0x4, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x83, 0x7d, 0xf8, 0, 0x75, 0x11, 0xf, 0xbe, 0x4d, 0xfc, 0x31, 0xdb, 0x31, 0xd2, 0x31, 0xc0, 0xe8, 0x21, 0xfe, 0xff, 0xff, 0xeb, 0x32, 0xf, 0xbe, 0x4d, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x82, 0x51, 0xf5, 0xff, 0x8b, 0x70, 0x8, 0xc1, 0xfe, 0x10, 0x31, 0xdb, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf4, 0xe8, 0x44, 0xc1, 0x3, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x4d, 0x30, 0xe4, 0x98, 0x89, 0xf3, 0xe8, 0xed, 0xfd, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10121078, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1012107d, 0x5)   calld(sys_check_available_stack_size, 0x44cd0); /* call 0x10165d52 */
    II(0x10121082, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10121083, 0x1)   pushd(esi);                           /* push esi */
    II(0x10121084, 0x1)   pushd(edi);                           /* push edi */
    II(0x10121085, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10121086, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10121088, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1012108e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10121091, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x10121094, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x10121097, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1012109b, 0x2)   jnzd(0x101210ae, 0x11);               /* jnz 0x101210ae */
    II(0x1012109d, 0x4)   movsx(ecx, memb_a32(ss, ebp - 0x4));  /* movsx ecx, byte [ebp-0x4] */
    II(0x101210a1, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x101210a3, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101210a5, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101210a7, 0x5)   calld(0x10120ecd, -0x1df);            /* call 0x10120ecd */
    II(0x101210ac, 0x2)   jmpd(0x101210e0, 0x32);               /* jmp 0x101210e0 */
l_0x101210ae:
    II(0x101210ae, 0x4)   movsx(ecx, memb_a32(ss, ebp - 0x4));  /* movsx ecx, byte [ebp-0x4] */
    II(0x101210b2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101210b5, 0x5)   calld(0x1007623c, -0xaae7e);          /* call 0x1007623c */
    II(0x101210ba, 0x3)   mov(esi, memd_a32(ds, eax + 0x8));    /* mov esi, [eax+0x8] */
    II(0x101210bd, 0x3)   sar(esi, 0x10);                       /* sar esi, 0x10 */
    II(0x101210c0, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x101210c2, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x101210c5, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101210c8, 0x5)   calld(0x1015d211, 0x3c144);           /* call 0x1015d211 */
    II(0x101210cd, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x101210d0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101210d3, 0x3)   mov(al, memb_a32(ds, eax + 0x4d));    /* mov al, [eax+0x4d] */
    II(0x101210d6, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x101210d8, 0x1)   cwde();                               /* cwde */
    II(0x101210d9, 0x2)   mov(ebx, esi);                        /* mov ebx, esi */
    II(0x101210db, 0x5)   calld(0x10120ecd, -0x213);            /* call 0x10120ecd */
l_0x101210e0:
    II(0x101210e0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101210e2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101210e3, 0x1)   popd(edi);                            /* pop edi */
    II(0x101210e4, 0x1)   popd(esi);                            /* pop esi */
    II(0x101210e5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101210e6, 0x1)   retd();                               /* ret */
FUNC_END

