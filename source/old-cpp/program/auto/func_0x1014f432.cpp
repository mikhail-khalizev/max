FUNC_BEGIN(0x1014f432, 0x2531e0b4b3915bea, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x16, 0x69, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0x3, 0x45, 0xf8, 0x80, 0xb8, 0xb0, 0, 0, 0, 0, 0x75, 0x30, 0x8b, 0x45, 0xf8, 0xe8, 0xd4, 0x4e, 0x1, 0, 0x84, 0xc0, 0x75, 0xa, 0x8b, 0x45, 0xf8, 0x66, 0x83, 0x78, 0x8, 0x42, 0x75, 0x2, 0xeb, 0xa, 0x8b, 0x45, 0xf8, 0x66, 0x83, 0x78, 0x8, 0x29, 0x75, 0x2, 0xeb, 0xa, 0x8b, 0x45, 0xf8, 0x66, 0x83, 0x78, 0x8, 0x2a, 0x75, 0x2, 0xeb, 0x11, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x99, 0x1, 0, 0, 0xe9, 0x9c, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x93, 0x4e, 0x1, 0, 0x84, 0xc0, 0x74, 0x3c, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x1a, 0xc1, 0xfa, 0x10, 0xa1, 0x70, 0x81, 0x1c, 0x10, 0xc1, 0xf8, 0x10, 0xf, 0xaf, 0xd0, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x18, 0xc1, 0xf8, 0x10, 0x1, 0xc2, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8b, 0x80, 0xa7, 0xa6, 0x1c, 0x10, 0x1, 0xd0, 0x8a, 0, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x74, 0x48, 0x8b, 0x45, 0xf8, 0x66, 0x83, 0x78, 0x8, 0x42, 0x75, 0x3c, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x1a, 0xc1, 0xfa, 0x10, 0xa1, 0x70, 0x81, 0x1c, 0x10, 0xc1, 0xf8, 0x10, 0xf, 0xaf, 0xd0, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x18, 0xc1, 0xf8, 0x10, 0x1, 0xc2, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8b, 0x80, 0xab, 0xa6, 0x1c, 0x10, 0x1, 0xd0, 0x8a, 0, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x74, 0x2, 0xeb, 0xc, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x66, 0xfd, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1014f432, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1014f437, 0x5)   calld(sys_check_available_stack_size, 0x16916); /* call 0x10165d52 */
    II(0x1014f43c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014f43d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014f43e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014f43f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014f440, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014f441, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014f443, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1014f449, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014f44c, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1014f44f, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x1014f453, 0x3)   add(eax, memd_a32(ss, ebp - 0x8));    /* add eax, [ebp-0x8] */
    II(0x1014f456, 0x7)   cmp(memb_a32(ds, eax + 0xb0), 0);     /* cmp byte [eax+0xb0], 0x0 */
    II(0x1014f45d, 0x2)   jnzd(0x1014f48f, 0x30);               /* jnz 0x1014f48f */
    II(0x1014f45f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f462, 0x5)   calld(0x1016433b, 0x14ed4);           /* call 0x1016433b */
    II(0x1014f467, 0x2)   test(al, al);                         /* test al, al */
    II(0x1014f469, 0x2)   jnzd(0x1014f475, 0xa);                /* jnz 0x1014f475 */
    II(0x1014f46b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f46e, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x42);   /* cmp word [eax+0x8], 0x42 */
    II(0x1014f473, 0x2)   jnzd(0x1014f477, 0x2);                /* jnz 0x1014f477 */
l_0x1014f475:
    II(0x1014f475, 0x2)   jmpd(0x1014f481, 0xa);                /* jmp 0x1014f481 */
l_0x1014f477:
    II(0x1014f477, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f47a, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x29);   /* cmp word [eax+0x8], 0x29 */
    II(0x1014f47f, 0x2)   jnzd(0x1014f483, 0x2);                /* jnz 0x1014f483 */
l_0x1014f481:
    II(0x1014f481, 0x2)   jmpd(0x1014f48d, 0xa);                /* jmp 0x1014f48d */
l_0x1014f483:
    II(0x1014f483, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f486, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x2a);   /* cmp word [eax+0x8], 0x2a */
    II(0x1014f48b, 0x2)   jnzd(0x1014f48f, 0x2);                /* jnz 0x1014f48f */
l_0x1014f48d:
    II(0x1014f48d, 0x2)   jmpd(0x1014f4a0, 0x11);               /* jmp 0x1014f4a0 */
l_0x1014f48f:
    II(0x1014f48f, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x1014f493, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f496, 0x5)   calld(0x1014f634, 0x199);             /* call 0x1014f634 */
    II(0x1014f49b, 0x5)   jmpd(0x1014f53c, 0x9c);               /* jmp 0x1014f53c */
l_0x1014f4a0:
    II(0x1014f4a0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f4a3, 0x5)   calld(0x1016433b, 0x14e93);           /* call 0x1016433b */
    II(0x1014f4a8, 0x2)   test(al, al);                         /* test al, al */
    II(0x1014f4aa, 0x2)   jzd(0x1014f4e8, 0x3c);                /* jz 0x1014f4e8 */
    II(0x1014f4ac, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f4af, 0x3)   mov(edx, memd_a32(ds, eax + 0x1a));   /* mov edx, [eax+0x1a] */
    II(0x1014f4b2, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1014f4b5, 0x5)   mov(eax, memd_a32(ds, 0x101c8170));   /* mov eax, [0x101c8170] */
    II(0x1014f4ba, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1014f4bd, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x1014f4c0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f4c3, 0x3)   mov(eax, memd_a32(ds, eax + 0x18));   /* mov eax, [eax+0x18] */
    II(0x1014f4c6, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1014f4c9, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1014f4cb, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x1014f4cf, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x1014f4d5, 0x6)   mov(eax, memd_a32(ds, eax + 0x101ca6a7)); /* mov eax, [eax+0x101ca6a7] */
    II(0x1014f4db, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1014f4dd, 0x2)   mov(al, memb_a32(ds, eax));           /* mov al, [eax] */
    II(0x1014f4df, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1014f4e4, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1014f4e6, 0x2)   jzd(0x1014f530, 0x48);                /* jz 0x1014f530 */
l_0x1014f4e8:
    II(0x1014f4e8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f4eb, 0x5)   cmp(memw_a32(ds, eax + 0x8), 0x42);   /* cmp word [eax+0x8], 0x42 */
    II(0x1014f4f0, 0x2)   jnzd(0x1014f52e, 0x3c);               /* jnz 0x1014f52e */
    II(0x1014f4f2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f4f5, 0x3)   mov(edx, memd_a32(ds, eax + 0x1a));   /* mov edx, [eax+0x1a] */
    II(0x1014f4f8, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1014f4fb, 0x5)   mov(eax, memd_a32(ds, 0x101c8170));   /* mov eax, [0x101c8170] */
    II(0x1014f500, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1014f503, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x1014f506, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f509, 0x3)   mov(eax, memd_a32(ds, eax + 0x18));   /* mov eax, [eax+0x18] */
    II(0x1014f50c, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1014f50f, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1014f511, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x1014f515, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x1014f51b, 0x6)   mov(eax, memd_a32(ds, eax + 0x101ca6ab)); /* mov eax, [eax+0x101ca6ab] */
    II(0x1014f521, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1014f523, 0x2)   mov(al, memb_a32(ds, eax));           /* mov al, [eax] */
    II(0x1014f525, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1014f52a, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1014f52c, 0x2)   jzd(0x1014f530, 0x2);                 /* jz 0x1014f530 */
l_0x1014f52e:
    II(0x1014f52e, 0x2)   jmpd(0x1014f53c, 0xc);                /* jmp 0x1014f53c */
l_0x1014f530:
    II(0x1014f530, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x1014f534, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014f537, 0x5)   calld(0x1014f2a2, -0x29a);            /* call 0x1014f2a2 */
l_0x1014f53c:
    II(0x1014f53c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014f53e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014f53f, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014f540, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014f541, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014f542, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014f543, 0x1)   retd();                               /* ret */
FUNC_END

