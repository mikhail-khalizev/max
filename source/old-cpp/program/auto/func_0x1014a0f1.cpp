FUNC_BEGIN(0x1014a0f1, 0x4fecfed2c83ab064, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x57, 0xbc, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0xeb, 0x36, 0xc6, 0x45, 0xf8, 0x1, 0xe9, 0xdc, 0, 0, 0, 0xc6, 0x45, 0xf8, 0x2, 0xe9, 0xd3, 0, 0, 0, 0xc6, 0x45, 0xf8, 0x3, 0xe9, 0xca, 0, 0, 0, 0xc6, 0x45, 0xf8, 0x4, 0xe9, 0xc1, 0, 0, 0, 0xc6, 0x45, 0xf8, 0x5, 0xe9, 0xb8, 0, 0, 0, 0xc6, 0x45, 0xf8, 0x6, 0xe9, 0xaf, 0, 0, 0, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x66, 0x83, 0x7d, 0xf0, 0x21, 0xf, 0x82, 0x50, 0, 0, 0, 0x66, 0x83, 0x7d, 0xf0, 0x21, 0x76, 0xbb, 0x66, 0x83, 0x7d, 0xf0, 0x55, 0x72, 0x20, 0x66, 0x83, 0x7d, 0xf0, 0x55, 0x76, 0xa4, 0x66, 0x83, 0x7d, 0xf0, 0x5a, 0x72, 0x10, 0x66, 0x83, 0x7d, 0xf0, 0x5a, 0x76, 0x96, 0x66, 0x83, 0x7d, 0xf0, 0x5c, 0x74, 0xa1, 0xeb, 0xba, 0xeb, 0xb8, 0x66, 0x83, 0x7d, 0xf0, 0x27, 0x72, 0x19, 0x66, 0x83, 0x7d, 0xf0, 0x27, 0x76, 0x8f, 0x66, 0x83, 0x7d, 0xf0, 0x29, 0x72, 0x9, 0x66, 0x83, 0x7d, 0xf0, 0x2a, 0x76, 0x93, 0xeb, 0x9a, 0xeb, 0x98, 0xeb, 0x96, 0x66, 0x83, 0x7d, 0xf0, 0x11, 0x72, 0x2b, 0x66, 0x83, 0x7d, 0xf0, 0x12, 0xf, 0x86, 0x69, 0xff, 0xff, 0xff, 0x66, 0x83, 0x7d, 0xf0, 0x14, 0xf, 0x86, 0x79, 0xff, 0xff, 0xff, 0x66, 0x83, 0x7d, 0xf0, 0x15, 0xf, 0x84, 0x53, 0xff, 0xff, 0xff, 0xe9, 0x69, 0xff, 0xff, 0xff, 0xe9, 0x64, 0xff, 0xff, 0xff, 0x66, 0x83, 0x7d, 0xf0, 0xd, 0x72, 0x10, 0x66, 0x83, 0x7d, 0xf0, 0xe, 0xf, 0x86, 0x40, 0xff, 0xff, 0xff, 0xe9, 0x4d, 0xff, 0xff, 0xff, 0xe9, 0x48, 0xff, 0xff, 0xff, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014a0f1, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x1014a0f6, 0x5)   calld(sys_check_available_stack_size, 0x1bc57); /* call 0x10165d52 */
    II(0x1014a0fb, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014a0fc, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014a0fd, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014a0fe, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014a0ff, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014a100, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014a101, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014a103, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1014a109, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1014a10c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014a10f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1014a112, 0x2)   jmpd(0x1014a14a, 0x36);               /* jmp 0x1014a14a */
l_0x1014a114:
    II(0x1014a114, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x1014a118, 0x5)   jmpd(0x1014a1f9, 0xdc);               /* jmp 0x1014a1f9 */
l_0x1014a11d:
    II(0x1014a11d, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x2);    /* mov byte [ebp-0x8], 0x2 */
    II(0x1014a121, 0x5)   jmpd(0x1014a1f9, 0xd3);               /* jmp 0x1014a1f9 */
l_0x1014a126:
    II(0x1014a126, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x3);    /* mov byte [ebp-0x8], 0x3 */
    II(0x1014a12a, 0x5)   jmpd(0x1014a1f9, 0xca);               /* jmp 0x1014a1f9 */
l_0x1014a12f:
    II(0x1014a12f, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x4);    /* mov byte [ebp-0x8], 0x4 */
    II(0x1014a133, 0x5)   jmpd(0x1014a1f9, 0xc1);               /* jmp 0x1014a1f9 */
l_0x1014a138:
    II(0x1014a138, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x5);    /* mov byte [ebp-0x8], 0x5 */
    II(0x1014a13c, 0x5)   jmpd(0x1014a1f9, 0xb8);               /* jmp 0x1014a1f9 */
l_0x1014a141:
    II(0x1014a141, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x6);    /* mov byte [ebp-0x8], 0x6 */
    II(0x1014a145, 0x5)   jmpd(0x1014a1f9, 0xaf);               /* jmp 0x1014a1f9 */
l_0x1014a14a:
    II(0x1014a14a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1014a14d, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1014a150, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x21);  /* cmp word [ebp-0x10], 0x21 */
    II(0x1014a155, 0x6)   jbd(0x1014a1ab, 0x50);                /* jb dword 0x1014a1ab */
    II(0x1014a15b, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x21);  /* cmp word [ebp-0x10], 0x21 */
    II(0x1014a160, 0x2)   jbed(0x1014a11d, -0x45);              /* jbe 0x1014a11d */
    II(0x1014a162, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x55);  /* cmp word [ebp-0x10], 0x55 */
    II(0x1014a167, 0x2)   jbd(0x1014a189, 0x20);                /* jb 0x1014a189 */
    II(0x1014a169, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x55);  /* cmp word [ebp-0x10], 0x55 */
    II(0x1014a16e, 0x2)   jbed(0x1014a114, -0x5c);              /* jbe 0x1014a114 */
    II(0x1014a170, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x5a);  /* cmp word [ebp-0x10], 0x5a */
    II(0x1014a175, 0x2)   jbd(0x1014a187, 0x10);                /* jb 0x1014a187 */
    II(0x1014a177, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x5a);  /* cmp word [ebp-0x10], 0x5a */
    II(0x1014a17c, 0x2)   jbed(0x1014a114, -0x6a);              /* jbe 0x1014a114 */
    II(0x1014a17e, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x5c);  /* cmp word [ebp-0x10], 0x5c */
    II(0x1014a183, 0x2)   jzd(0x1014a126, -0x5f);               /* jz 0x1014a126 */
    II(0x1014a185, 0x2)   jmpd(0x1014a141, -0x46);              /* jmp 0x1014a141 */
l_0x1014a187:
    II(0x1014a187, 0x2)   jmpd(0x1014a141, -0x48);              /* jmp 0x1014a141 */
l_0x1014a189:
    II(0x1014a189, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x27);  /* cmp word [ebp-0x10], 0x27 */
    II(0x1014a18e, 0x2)   jbd(0x1014a1a9, 0x19);                /* jb 0x1014a1a9 */
    II(0x1014a190, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x27);  /* cmp word [ebp-0x10], 0x27 */
    II(0x1014a195, 0x2)   jbed(0x1014a126, -0x71);              /* jbe 0x1014a126 */
    II(0x1014a197, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x29);  /* cmp word [ebp-0x10], 0x29 */
    II(0x1014a19c, 0x2)   jbd(0x1014a1a7, 0x9);                 /* jb 0x1014a1a7 */
    II(0x1014a19e, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x2a);  /* cmp word [ebp-0x10], 0x2a */
    II(0x1014a1a3, 0x2)   jbed(0x1014a138, -0x6d);              /* jbe 0x1014a138 */
    II(0x1014a1a5, 0x2)   jmpd(0x1014a141, -0x66);              /* jmp 0x1014a141 */
l_0x1014a1a7:
    II(0x1014a1a7, 0x2)   jmpd(0x1014a141, -0x68);              /* jmp 0x1014a141 */
l_0x1014a1a9:
    II(0x1014a1a9, 0x2)   jmpd(0x1014a141, -0x6a);              /* jmp 0x1014a141 */
l_0x1014a1ab:
    II(0x1014a1ab, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x11);  /* cmp word [ebp-0x10], 0x11 */
    II(0x1014a1b0, 0x2)   jbd(0x1014a1dd, 0x2b);                /* jb 0x1014a1dd */
    II(0x1014a1b2, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x12);  /* cmp word [ebp-0x10], 0x12 */
    II(0x1014a1b7, 0x6)   jbed(0x1014a126, -0x97);              /* jbe dword 0x1014a126 */
    II(0x1014a1bd, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x14);  /* cmp word [ebp-0x10], 0x14 */
    II(0x1014a1c2, 0x6)   jbed(0x1014a141, -0x87);              /* jbe dword 0x1014a141 */
    II(0x1014a1c8, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x15);  /* cmp word [ebp-0x10], 0x15 */
    II(0x1014a1cd, 0x6)   jzd(0x1014a126, -0xad);               /* jz dword 0x1014a126 */
    II(0x1014a1d3, 0x5)   jmpd(0x1014a141, -0x97);              /* jmp 0x1014a141 */
//  II(0x1014a1d8, 0x5)   /* Недостижимый код. */
l_0x1014a1dd:
    II(0x1014a1dd, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0xd);   /* cmp word [ebp-0x10], 0xd */
    II(0x1014a1e2, 0x2)   jbd(0x1014a1f4, 0x10);                /* jb 0x1014a1f4 */
    II(0x1014a1e4, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0xe);   /* cmp word [ebp-0x10], 0xe */
    II(0x1014a1e9, 0x6)   jbed(0x1014a12f, -0xc0);              /* jbe dword 0x1014a12f */
    II(0x1014a1ef, 0x5)   jmpd(0x1014a141, -0xb3);              /* jmp 0x1014a141 */
l_0x1014a1f4:
    II(0x1014a1f4, 0x5)   jmpd(0x1014a141, -0xb8);              /* jmp 0x1014a141 */
l_0x1014a1f9:
    II(0x1014a1f9, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1014a1fc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014a1fe, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014a1ff, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014a200, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014a201, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014a202, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014a203, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014a204, 0x1)   retd();                               /* ret */
FUNC_END

