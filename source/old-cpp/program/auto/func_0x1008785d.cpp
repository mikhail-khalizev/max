FUNC_BEGIN(0x1008785d, 0x26f22b148012c540, 0x20, ({0x68, 0x3c, 0, 0, 0, 0xe8, 0xeb, 0xe4, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x24, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xfc, 0xe8, 0xcd, 0xb1, 0xc, 0, 0x84, 0xc0, 0x74, 0x11, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xf, 0xe8, 0x7b, 0x34, 0xb, 0, 0x84, 0xc0, 0x74, 0x2, 0xeb, 0xf, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x4e, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x75, 0x9, 0xc6, 0x45, 0xf4, 0, 0xe9, 0xf3, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x80, 0xe9, 0xfe, 0xff, 0x8b, 0x50, 0x12, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x54, 0x25, 0xff, 0, 0, 0, 0x39, 0xd0, 0x7d, 0x1f, 0xe8, 0xc6, 0x2e, 0, 0, 0x31, 0xdb, 0x88, 0xc3, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xc5, 0xda, 0x1, 0, 0xc6, 0x45, 0xf4, 0, 0xe9, 0xb7, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x44, 0xe9, 0xfe, 0xff, 0x8b, 0x50, 0x8, 0xc1, 0xfa, 0x10, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xc1, 0xe2, 0x2, 0x1b, 0xc2, 0xc1, 0xf8, 0x2, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x4d, 0x25, 0xff, 0, 0, 0, 0x39, 0xd0, 0x7d, 0x6c, 0x8b, 0x45, 0xfc, 0xe8, 0x59, 0xaf, 0xc, 0, 0xb8, 0x1b, 0, 0, 0, 0xe8, 0xd2, 0xe4, 0xd, 0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xec, 0x89, 0x45, 0xe8, 0x83, 0x7d, 0xe8, 0, 0x74, 0x16, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xec, 0xe8, 0x40, 0x3f, 0x4, 0, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xe4, 0x89, 0x45, 0xe0, 0xeb, 0x6, 0x8b, 0x45, 0xe8, 0x89, 0x45, 0xe0, 0x8b, 0x55, 0xe0, 0x8d, 0x45, 0xdc, 0xe8, 0xfc, 0x36, 0, 0, 0x8d, 0x45, 0xdc, 0xe8, 0x18, 0x36, 0, 0, 0x89, 0xc2, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xd8, 0xd3, 0x1, 0, 0xc6, 0x45, 0xf4, 0x1, 0x31, 0xd2, 0x8d, 0x45, 0xdc, 0xe8, 0xf6, 0x11, 0, 0, 0xeb, 0x1f, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xf, 0xe8, 0x21, 0x36, 0, 0, 0x89, 0x45, 0xf0, 0x8b, 0x5d, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf0, 0xe8, 0x32, 0xdf, 0xff, 0xff, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008785d, 0x5)   pushd(0x3c);                          /* push dword 0x3c */
    II(0x10087862, 0x5)   calld(sys_check_available_stack_size, 0xde4eb); /* call 0x10165d52 */
    II(0x10087867, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10087868, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10087869, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008786a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008786b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008786c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008786e, 0x6)   sub(esp, 0x24);                       /* sub esp, 0x24 */
    II(0x10087874, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10087877, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1008787a, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1008787d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087880, 0x5)   calld(0x10152a52, 0xcb1cd);           /* call 0x10152a52 */
    II(0x10087885, 0x2)   test(al, al);                         /* test al, al */
    II(0x10087887, 0x2)   jzd(0x1008789a, 0x11);                /* jz 0x1008789a */
    II(0x10087889, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1008788b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008788e, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x10087891, 0x5)   calld(0x1013ad11, 0xb347b);           /* call 0x1013ad11 */
    II(0x10087896, 0x2)   test(al, al);                         /* test al, al */
    II(0x10087898, 0x2)   jzd(0x1008789c, 0x2);                 /* jz 0x1008789c */
l_0x1008789a:
    II(0x1008789a, 0x2)   jmpd(0x100878ab, 0xf);                /* jmp 0x100878ab */
l_0x1008789c:
    II(0x1008789c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008789f, 0x3)   mov(al, memb_a32(ds, eax + 0x4e));    /* mov al, [eax+0x4e] */
    II(0x100878a2, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100878a7, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100878a9, 0x2)   jnzd(0x100878b4, 0x9);                /* jnz 0x100878b4 */
l_0x100878ab:
    II(0x100878ab, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x100878af, 0x5)   jmpd(0x100879a7, 0xf3);               /* jmp 0x100879a7 */
l_0x100878b4:
    II(0x100878b4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100878b7, 0x5)   calld(0x1007623c, -0x11680);          /* call 0x1007623c */
    II(0x100878bc, 0x3)   mov(edx, memd_a32(ds, eax + 0x12));   /* mov edx, [eax+0x12] */
    II(0x100878bf, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100878c2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100878c5, 0x3)   mov(al, memb_a32(ds, eax + 0x54));    /* mov al, [eax+0x54] */
    II(0x100878c8, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100878cd, 0x2)   cmp(eax, edx);                        /* cmp eax, edx */
    II(0x100878cf, 0x2)   jged(0x100878f0, 0x1f);               /* jge 0x100878f0 */
    II(0x100878d1, 0x5)   calld(0x1008a79c, 0x2ec6);            /* call 0x1008a79c */
    II(0x100878d6, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x100878d8, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x100878da, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100878dd, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100878e2, 0x5)   calld(0x100a53ac, 0x1dac5);           /* call 0x100a53ac */
    II(0x100878e7, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x100878eb, 0x5)   jmpd(0x100879a7, 0xb7);               /* jmp 0x100879a7 */
l_0x100878f0:
    II(0x100878f0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100878f3, 0x5)   calld(0x1007623c, -0x116bc);          /* call 0x1007623c */
    II(0x100878f8, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x100878fb, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100878fe, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x10087900, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x10087903, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x10087906, 0x2)   sbb(eax, edx);                        /* sbb eax, edx */
    II(0x10087908, 0x3)   sar(eax, 0x2);                        /* sar eax, 0x2 */
    II(0x1008790b, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1008790d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087910, 0x3)   mov(al, memb_a32(ds, eax + 0x4d));    /* mov al, [eax+0x4d] */
    II(0x10087913, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10087918, 0x2)   cmp(eax, edx);                        /* cmp eax, edx */
    II(0x1008791a, 0x2)   jged(0x10087988, 0x6c);               /* jge 0x10087988 */
    II(0x1008791c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008791f, 0x5)   calld(0x1015287d, 0xcaf59);           /* call 0x1015287d */
    II(0x10087924, 0x5)   mov(eax, 0x1b);                       /* mov eax, 0x1b */
    II(0x10087929, 0x5)   calld(sys_new, 0xde4d2);              /* call 0x10165e00 */
    II(0x1008792e, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
//    II(0x10087931, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x10087934, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x10087937, 0x4)   cmp(memd_a32(ss, ebp - 0x18), 0);     /* cmp dword [ebp-0x18], 0x0 */
    II(0x1008793b, 0x2)   jzd(0x10087953, 0x16);                /* jz 0x10087953 */
    II(0x1008793d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10087940, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x10087943, 0x5)   calld(my_ctor_c15, 0x43f40);          /* call 0x100cb888 */
    II(0x10087948, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
//    II(0x1008794b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x1008794e, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x10087951, 0x2)   jmpd(0x10087959, 0x6);                /* jmp 0x10087959 */
l_0x10087953:
    II(0x10087953, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10087956, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
l_0x10087959:
    II(0x10087959, 0x3)   mov(edx, memd_a32(ss, ebp - 0x20));   /* mov edx, [ebp-0x20] */
    II(0x1008795c, 0x3)   lea(eax, ebp - 0x24);                 /* lea eax, [ebp-0x24] */
    II(0x1008795f, 0x5)   calld(0x1008b060, 0x36fc);            /* call 0x1008b060 */
    II(0x10087964, 0x3)   lea(eax, ebp - 0x24);                 /* lea eax, [ebp-0x24] */
    II(0x10087967, 0x5)   calld(0x1008af84, 0x3618);            /* call 0x1008af84 */
    II(0x1008796c, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1008796e, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x10087973, 0x5)   calld(0x100a4d50, 0x1d3d8);           /* call 0x100a4d50 */
    II(0x10087978, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x1008797c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1008797e, 0x3)   lea(eax, ebp - 0x24);                 /* lea eax, [ebp-0x24] */
    II(0x10087981, 0x5)   calld(0x10088b7c, 0x11f6);            /* call 0x10088b7c */
    II(0x10087986, 0x2)   jmpd(0x100879a7, 0x1f);               /* jmp 0x100879a7 */
l_0x10087988:
    II(0x10087988, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008798b, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x1008798e, 0x5)   calld(0x1008afb4, 0x3621);            /* call 0x1008afb4 */
    II(0x10087993, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10087996, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x4));    /* mov ebx, [ebp-0x4] */
    II(0x10087999, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
//    II(0x1008799c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1008799f, 0x5)   calld(0x100858d6, -0x20ce);           /* call 0x100858d6 */
    II(0x100879a4, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
l_0x100879a7:
    II(0x100879a7, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100879aa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100879ac, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100879ad, 0x1)   popd(edi);                            /* pop edi */
    II(0x100879ae, 0x1)   popd(esi);                            /* pop esi */
    II(0x100879af, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100879b0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100879b1, 0x1)   retd();                               /* ret */
FUNC_END

