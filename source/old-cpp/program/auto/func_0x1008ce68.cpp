FUNC_BEGIN(0x1008ce68, 0x9f4b6dc89609142c, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xe0, 0x8e, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x11, 0xc1, 0xf8, 0x10, 0x83, 0xf8, 0xc, 0x74, 0xe, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x11, 0xc1, 0xf8, 0x10, 0x83, 0xf8, 0x21, 0x75, 0x2, 0xeb, 0xe, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x11, 0xc1, 0xf8, 0x10, 0x83, 0xf8, 0x27, 0x75, 0x2, 0xeb, 0xe, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x11, 0xc1, 0xf8, 0x10, 0x83, 0xf8, 0x28, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x5b, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x22, 0xc1, 0xf8, 0x18, 0x83, 0xf8, 0x6, 0x74, 0xe, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x22, 0xc1, 0xf8, 0x18, 0x83, 0xf8, 0x5, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0, 0xeb, 0x39, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x22, 0xc1, 0xf8, 0x18, 0x83, 0xf8, 0x7, 0x7d, 0x10, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x2b, 0xe8, 0x90, 0x9c, 0xfe, 0xff, 0x98, 0x85, 0xc0, 0x74, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x2a, 0, 0x74, 0x6, 0xc6, 0x45, 0xf4, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008ce68, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1008ce6d, 0x5)   calld(sys_check_available_stack_size, 0xd8ee0); /* call 0x10165d52 */
    II(0x1008ce72, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008ce73, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008ce74, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008ce75, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008ce76, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008ce77, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008ce78, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008ce7a, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1008ce80, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008ce83, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ce86, 0x3)   mov(eax, memd_a32(ds, eax + 0x11));   /* mov eax, [eax+0x11] */
    II(0x1008ce89, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1008ce8c, 0x3)   cmp(eax, 0xc);                        /* cmp eax, 0xc */
    II(0x1008ce8f, 0x2)   jzd(0x1008ce9f, 0xe);                 /* jz 0x1008ce9f */
    II(0x1008ce91, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ce94, 0x3)   mov(eax, memd_a32(ds, eax + 0x11));   /* mov eax, [eax+0x11] */
    II(0x1008ce97, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1008ce9a, 0x3)   cmp(eax, 0x21);                       /* cmp eax, 0x21 */
    II(0x1008ce9d, 0x2)   jnzd(0x1008cea1, 0x2);                /* jnz 0x1008cea1 */
l_0x1008ce9f:
    II(0x1008ce9f, 0x2)   jmpd(0x1008ceaf, 0xe);                /* jmp 0x1008ceaf */
l_0x1008cea1:
    II(0x1008cea1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008cea4, 0x3)   mov(eax, memd_a32(ds, eax + 0x11));   /* mov eax, [eax+0x11] */
    II(0x1008cea7, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1008ceaa, 0x3)   cmp(eax, 0x27);                       /* cmp eax, 0x27 */
    II(0x1008cead, 0x2)   jnzd(0x1008ceb1, 0x2);                /* jnz 0x1008ceb1 */
l_0x1008ceaf:
    II(0x1008ceaf, 0x2)   jmpd(0x1008cebf, 0xe);                /* jmp 0x1008cebf */
l_0x1008ceb1:
    II(0x1008ceb1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ceb4, 0x3)   mov(eax, memd_a32(ds, eax + 0x11));   /* mov eax, [eax+0x11] */
    II(0x1008ceb7, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1008ceba, 0x3)   cmp(eax, 0x28);                       /* cmp eax, 0x28 */
    II(0x1008cebd, 0x2)   jnzd(0x1008cec5, 0x6);                /* jnz 0x1008cec5 */
l_0x1008cebf:
    II(0x1008cebf, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x1008cec3, 0x2)   jmpd(0x1008cf20, 0x5b);               /* jmp 0x1008cf20 */
l_0x1008cec5:
    II(0x1008cec5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008cec8, 0x3)   mov(eax, memd_a32(ds, eax + 0x22));   /* mov eax, [eax+0x22] */
    II(0x1008cecb, 0x3)   sar(eax, 0x18);                       /* sar eax, 0x18 */
    II(0x1008cece, 0x3)   cmp(eax, 0x6);                        /* cmp eax, 0x6 */
    II(0x1008ced1, 0x2)   jzd(0x1008cee1, 0xe);                 /* jz 0x1008cee1 */
    II(0x1008ced3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ced6, 0x3)   mov(eax, memd_a32(ds, eax + 0x22));   /* mov eax, [eax+0x22] */
    II(0x1008ced9, 0x3)   sar(eax, 0x18);                       /* sar eax, 0x18 */
    II(0x1008cedc, 0x3)   cmp(eax, 0x5);                        /* cmp eax, 0x5 */
    II(0x1008cedf, 0x2)   jnzd(0x1008cee7, 0x6);                /* jnz 0x1008cee7 */
l_0x1008cee1:
    II(0x1008cee1, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x1008cee5, 0x2)   jmpd(0x1008cf20, 0x39);               /* jmp 0x1008cf20 */
l_0x1008cee7:
    II(0x1008cee7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ceea, 0x3)   mov(eax, memd_a32(ds, eax + 0x22));   /* mov eax, [eax+0x22] */
    II(0x1008ceed, 0x3)   sar(eax, 0x18);                       /* sar eax, 0x18 */
    II(0x1008cef0, 0x3)   cmp(eax, 0x7);                        /* cmp eax, 0x7 */
    II(0x1008cef3, 0x2)   jged(0x1008cf05, 0x10);               /* jge 0x1008cf05 */
    II(0x1008cef5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008cef8, 0x3)   add(eax, 0x2b);                       /* add eax, 0x2b */
    II(0x1008cefb, 0x5)   calld(0x10076b90, -0x16370);          /* call 0x10076b90 */
    II(0x1008cf00, 0x1)   cwde();                               /* cwde */
    II(0x1008cf01, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1008cf03, 0x2)   jzd(0x1008cf07, 0x2);                 /* jz 0x1008cf07 */
l_0x1008cf05:
    II(0x1008cf05, 0x2)   jmpd(0x1008cf10, 0x9);                /* jmp 0x1008cf10 */
l_0x1008cf07:
    II(0x1008cf07, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008cf0a, 0x4)   cmp(memb_a32(ds, eax + 0x2a), 0);     /* cmp byte [eax+0x2a], 0x0 */
    II(0x1008cf0e, 0x2)   jzd(0x1008cf16, 0x6);                 /* jz 0x1008cf16 */
l_0x1008cf10:
    II(0x1008cf10, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x1008cf14, 0x2)   jmpd(0x1008cf1a, 0x4);                /* jmp 0x1008cf1a */
l_0x1008cf16:
    II(0x1008cf16, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
l_0x1008cf1a:
    II(0x1008cf1a, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1008cf1d, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
l_0x1008cf20:
    II(0x1008cf20, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1008cf23, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008cf25, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008cf26, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008cf27, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008cf28, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008cf29, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008cf2a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008cf2b, 0x1)   retd();                               /* ret */
FUNC_END

