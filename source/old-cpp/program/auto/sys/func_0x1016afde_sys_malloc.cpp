FUNC_BEGIN(sys_malloc, 0xd1edc85264c02cc9, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x6, 0xf, 0xa0, 0xf, 0xa8, 0x55, 0x83, 0xec, 0x4, 0x89, 0xc6, 0x85, 0xc0, 0x74, 0x5, 0x83, 0xf8, 0xd4, 0x76, 0x7, 0x31, 0xc0, 0xe9, 0xb4, 0, 0, 0, 0xbd, 0xc, 0xde, 0x1b, 0x10, 0x8d, 0x7e, 0x3, 0x30, 0xe4, 0x31, 0xd2, 0x88, 0x24, 0x24, 0x66, 0x83, 0xe7, 0xfc, 0x89, 0xf8, 0x83, 0xff, 0xc, 0x73, 0x5, 0xb8, 0xc, 0, 0, 0, 0x3b, 0x5, 0x14, 0xde, 0x1b, 0x10, 0x76, 0x18, 0x8b, 0xd, 0x10, 0xde, 0x1b, 0x10, 0x85, 0xc9, 0x75, 0x46, 0x89, 0xd, 0x14, 0xde, 0x1b, 0x10, 0x8b, 0xd, 0xc, 0xde, 0x1b, 0x10, 0xeb, 0x38, 0x31, 0xc9, 0xeb, 0xee, 0x8c, 0xda, 0x89, 0xe8, 0x89, 0xd, 0x10, 0xde, 0x1b, 0x10, 0x81, 0xe2, 0xff, 0xff, 0, 0, 0x89, 0xcb, 0x89, 0xf0, 0xe8, 0x1e, 0xb9, 0x1, 0, 0x89, 0xc2, 0x85, 0xc0, 0x75, 0x48, 0x8b, 0x1d, 0x14, 0xde, 0x1b, 0x10, 0x8b, 0x41, 0x14, 0x39, 0xd8, 0x76, 0x5, 0xa3, 0x14, 0xde, 0x1b, 0x10, 0x8b, 0x49, 0x8, 0x85, 0xc9, 0x75, 0xc8, 0x80, 0x3c, 0x24, 0, 0x75, 0xb, 0x89, 0xf0, 0xe8, 0x96, 0xbe, 0x1, 0, 0x85, 0xc0, 0x75, 0x15, 0x89, 0xf0, 0xe8, 0x54, 0xc0, 0x1, 0, 0x85, 0xc0, 0x74, 0x13, 0x30, 0xc9, 0x88, 0xc, 0x24, 0xe9, 0x72, 0xff, 0xff, 0xff, 0xc6, 0x4, 0x24, 0x1, 0xe9, 0x69, 0xff, 0xff, 0xff, 0x30, 0xed, 0x89, 0xd0, 0x88, 0x2d, 0xd4, 0xa2, 0x20, 0x10, 0x83, 0xc4, 0x4, 0x5d, 0xf, 0xa9, 0xf, 0xa1, 0x7, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1016afde, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016afdf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016afe0, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016afe1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016afe2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016afe3, 0x1)   pushd(es);                            /* push es */
    II(0x1016afe4, 0x2)   pushd(fs);                            /* push fs */
    II(0x1016afe6, 0x2)   pushd(gs);                            /* push gs */
    II(0x1016afe8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016afe9, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1016afec, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1016afee, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016aff0, 0x2)   jzd(0x1016aff7, 0x5);                 /* jz 0x1016aff7 */
    II(0x1016aff2, 0x3)   cmp(eax, -0x2c /* 0xd4 */);           /* cmp eax, 0xd4 */
    II(0x1016aff5, 0x2)   jbed(0x1016affe, 0x7);                /* jbe 0x1016affe */
l_0x1016aff7:
    II(0x1016aff7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1016aff9, 0x5)   jmpd(0x1016b0b2, 0xb4);               /* jmp 0x1016b0b2 */
l_0x1016affe:
    II(0x1016affe, 0x5)   mov(ebp, 0x101bde0c);                 /* mov ebp, 0x101bde0c */
    II(0x1016b003, 0x3)   lea(edi, esi + 0x3);                  /* lea edi, [esi+0x3] */
    II(0x1016b006, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x1016b008, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1016b00a, 0x3)   mov(memb_a32(ss, esp), ah);           /* mov [esp], ah */
    II(0x1016b00d, 0x4)   and_(di, -0x4 /* 0xfc */);            /* and di, 0xfc */
l_0x1016b011:
    II(0x1016b011, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x1016b013, 0x3)   cmp(edi, 0xc);                        /* cmp edi, 0xc */
    II(0x1016b016, 0x2)   jaed(0x1016b01d, 0x5);                /* jae 0x1016b01d */
    II(0x1016b018, 0x5)   mov(eax, 0xc);                        /* mov eax, 0xc */
l_0x1016b01d:
    II(0x1016b01d, 0x6)   cmp(eax, memd_a32(ds, 0x101bde14));   /* cmp eax, [0x101bde14] */
    II(0x1016b023, 0x2)   jbed(0x1016b03d, 0x18);               /* jbe 0x1016b03d */
    II(0x1016b025, 0x6)   mov(ecx, memd_a32(ds, 0x101bde10));   /* mov ecx, [0x101bde10] */
    II(0x1016b02b, 0x2)   test(ecx, ecx);                       /* test ecx, ecx */
    II(0x1016b02d, 0x2)   jnzd(0x1016b075, 0x46);               /* jnz 0x1016b075 */
l_0x1016b02f:
    II(0x1016b02f, 0x6)   mov(memd_a32(ds, 0x101bde14), ecx);   /* mov [0x101bde14], ecx */
    II(0x1016b035, 0x6)   mov(ecx, memd_a32(ds, 0x101bde0c));   /* mov ecx, [0x101bde0c] */
    II(0x1016b03b, 0x2)   jmpd(0x1016b075, 0x38);               /* jmp 0x1016b075 */
l_0x1016b03d:
    II(0x1016b03d, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1016b03f, 0x2)   jmpd(0x1016b02f, -0x12);              /* jmp 0x1016b02f */
l_0x1016b041:
    II(0x1016b041, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x1016b043, 0x2)   mov(eax, ebp);                        /* mov eax, ebp */
    II(0x1016b045, 0x6)   mov(memd_a32(ds, 0x101bde10), ecx);   /* mov [0x101bde10], ecx */
    II(0x1016b04b, 0x6)   and_(edx, 0xffff);                    /* and edx, 0xffff */
    II(0x1016b051, 0x2)   mov(ebx, ecx);                        /* mov ebx, ecx */
    II(0x1016b053, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1016b055, 0x5)   calld(/* sys */ 0x10186978, 0x1b91e); /* call 0x10186978 */
    II(0x1016b05a, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1016b05c, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016b05e, 0x2)   jnzd(0x1016b0a8, 0x48);               /* jnz 0x1016b0a8 */
    II(0x1016b060, 0x6)   mov(ebx, memd_a32(ds, 0x101bde14));   /* mov ebx, [0x101bde14] */
    II(0x1016b066, 0x3)   mov(eax, memd_a32(ds, ecx + 0x14));   /* mov eax, [ecx+0x14] */
    II(0x1016b069, 0x2)   cmp(eax, ebx);                        /* cmp eax, ebx */
    II(0x1016b06b, 0x2)   jbed(0x1016b072, 0x5);                /* jbe 0x1016b072 */
    II(0x1016b06d, 0x5)   mov(memd_a32(ds, 0x101bde14), eax);   /* mov [0x101bde14], eax */
l_0x1016b072:
    II(0x1016b072, 0x3)   mov(ecx, memd_a32(ds, ecx + 0x8));    /* mov ecx, [ecx+0x8] */
l_0x1016b075:
    II(0x1016b075, 0x2)   test(ecx, ecx);                       /* test ecx, ecx */
    II(0x1016b077, 0x2)   jnzd(0x1016b041, -0x38);              /* jnz 0x1016b041 */
    II(0x1016b079, 0x4)   cmp(memb_a32(ss, esp), 0);            /* cmp byte [esp], 0x0 */
    II(0x1016b07d, 0x2)   jnzd(0x1016b08a, 0xb);                /* jnz 0x1016b08a */
    II(0x1016b07f, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1016b081, 0x5)   calld(/* sys */ 0x10186f1c, 0x1be96); /* call 0x10186f1c */
    II(0x1016b086, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016b088, 0x2)   jnzd(0x1016b09f, 0x15);               /* jnz 0x1016b09f */
l_0x1016b08a:
    II(0x1016b08a, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1016b08c, 0x5)   calld(/* sys */ 0x101870e5, 0x1c054); /* call 0x101870e5 */
    II(0x1016b091, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1016b093, 0x2)   jzd(0x1016b0a8, 0x13);                /* jz 0x1016b0a8 */
    II(0x1016b095, 0x2)   xor_(cl, cl);                         /* xor cl, cl */
    II(0x1016b097, 0x3)   mov(memb_a32(ss, esp), cl);           /* mov [esp], cl */
    II(0x1016b09a, 0x5)   jmpd(0x1016b011, -0x8e);              /* jmp 0x1016b011 */
l_0x1016b09f:
    II(0x1016b09f, 0x4)   mov(memb_a32(ss, esp), 0x1);          /* mov byte [esp], 0x1 */
    II(0x1016b0a3, 0x5)   jmpd(0x1016b011, -0x97);              /* jmp 0x1016b011 */
l_0x1016b0a8:
    II(0x1016b0a8, 0x2)   xor_(ch, ch);                         /* xor ch, ch */
    II(0x1016b0aa, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1016b0ac, 0x6)   mov(memb_a32(ds, 0x1020a2d4), ch);    /* mov [0x1020a2d4], ch */
l_0x1016b0b2:
    II(0x1016b0b2, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x1016b0b5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016b0b6, 0x2)   popd(gs);                             /* pop gs */
    II(0x1016b0b8, 0x2)   popd(fs);                             /* pop fs */
    II(0x1016b0ba, 0x1)   popd(es);                             /* pop es */
    II(0x1016b0bb, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016b0bc, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016b0bd, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016b0be, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016b0bf, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016b0c0, 0x1)   retd();                               /* ret */
FUNC_END

