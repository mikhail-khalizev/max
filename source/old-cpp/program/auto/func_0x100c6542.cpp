FUNC_BEGIN(0x100c6542, 0x22f91ea7cfcd9cf, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0x6, 0xf8, 0x9, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x24, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf4, 0x89, 0x5d, 0xfc, 0x89, 0x4d, 0xf8, 0xc7, 0x45, 0xec, 0, 0, 0, 0, 0xf, 0xbf, 0x55, 0xf4, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8b, 0x80, 0x62, 0xa5, 0x1c, 0x10, 0xe8, 0x2d, 0x51, 0, 0, 0x66, 0x8b, 0x40, 0x17, 0x89, 0x45, 0xe8, 0xf, 0xbf, 0x45, 0xf8, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0xba, 0x68, 0xa4, 0x1c, 0x10, 0x1, 0xc2, 0x89, 0x55, 0xe4, 0xc7, 0x45, 0xe0, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xe0, 0xff, 0x45, 0xe0, 0xf, 0xbf, 0x45, 0xe0, 0x83, 0xf8, 0x5d, 0xf, 0x8d, 0x7f, 0, 0, 0, 0xf, 0xbf, 0x55, 0xe0, 0x8b, 0x45, 0xe4, 0xe8, 0x66, 0x97, 0x1, 0, 0x89, 0x45, 0xdc, 0x8b, 0x45, 0xdc, 0x8b, 0x40, 0xc, 0xc1, 0xf8, 0x10, 0x85, 0xc0, 0x7e, 0x15, 0x80, 0x7d, 0x10, 0, 0x75, 0xd, 0x8b, 0x45, 0xdc, 0x8b, 0x40, 0xe, 0xc1, 0xf8, 0x10, 0x85, 0xc0, 0x7e, 0x2, 0xeb, 0x2, 0xeb, 0x11, 0xf, 0xbf, 0x55, 0xf4, 0xf, 0xbf, 0x45, 0xe0, 0xe8, 0xda, 0xe3, 0xfa, 0xff, 0x84, 0xc0, 0x75, 0x2, 0xeb, 0x34, 0x8b, 0x45, 0xdc, 0x8b, 0x40, 0x10, 0xc1, 0xf8, 0x10, 0x8d, 0x50, 0x1, 0xf, 0xbf, 0x45, 0xec, 0xe8, 0x67, 0x8, 0xfb, 0xff, 0x89, 0x45, 0xec, 0xf, 0xbf, 0x55, 0xe0, 0x8b, 0x45, 0xe4, 0x8b, 0x80, 0xfa, 0, 0, 0, 0xe8, 0x86, 0x50, 0, 0, 0x66, 0x8b, 0x40, 0x12, 0x66, 0x3b, 0x45, 0xe8, 0x7f, 0x3b, 0xe9, 0x6e, 0xff, 0xff, 0xff, 0xf, 0xbf, 0x55, 0xf4, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0xbb, 0x68, 0xa4, 0x1c, 0x10, 0x1, 0xd8, 0xe8, 0xd9, 0x96, 0x1, 0, 0x89, 0xc2, 0x8b, 0x45, 0xec, 0x66, 0x3b, 0x42, 0x17, 0x7e, 0x11, 0xbb, 0x7, 0, 0, 0, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xf0, 0xe8, 0x86, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc2, 0x4, 0}))
    II(0x100c6542, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x100c6547, 0x5)   calld(sys_check_available_stack_size, 0x9f806); /* call 0x10165d52 */
    II(0x100c654c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100c654d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100c654e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100c654f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100c6551, 0x6)   sub(esp, 0x24);                       /* sub esp, 0x24 */
    II(0x100c6557, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100c655a, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100c655d, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x100c6560, 0x3)   mov(memd_a32(ss, ebp - 0x8), ecx);    /* mov [ebp-0x8], ecx */
    II(0x100c6563, 0x7)   mov(memd_a32(ss, ebp - 0x14), 0);     /* mov dword [ebp-0x14], 0x0 */
    II(0x100c656a, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x100c656e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100c6572, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100c6578, 0x6)   mov(eax, memd_a32(ds, eax + 0x101ca562)); /* mov eax, [eax+0x101ca562] */
    II(0x100c657e, 0x5)   calld(0x100cb6b0, 0x512d);            /* call 0x100cb6b0 */
    II(0x100c6583, 0x4)   mov(ax, memw_a32(ds, eax + 0x17));    /* mov ax, [eax+0x17] */
    II(0x100c6587, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x100c658a, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x100c658e, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100c6594, 0x5)   mov(edx, 0x101ca468);                 /* mov edx, 0x101ca468 */
    II(0x100c6599, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100c659b, 0x3)   mov(memd_a32(ss, ebp - 0x1c), edx);   /* mov [ebp-0x1c], edx */
    II(0x100c659e, 0x7)   mov(memd_a32(ss, ebp - 0x20), 0);     /* mov dword [ebp-0x20], 0x0 */
    II(0x100c65a5, 0x2)   jmpd(0x100c65ad, 0x6);                /* jmp 0x100c65ad */
l_0x100c65a7:
    II(0x100c65a7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x100c65aa, 0x3)   inc(memd_a32(ss, ebp - 0x20));        /* inc dword [ebp-0x20] */
l_0x100c65ad:
    II(0x100c65ad, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x20)); /* movsx eax, word [ebp-0x20] */
    II(0x100c65b1, 0x3)   cmp(eax, 0x5d);                       /* cmp eax, 0x5d */
    II(0x100c65b4, 0x6)   jged(0x100c6639, 0x7f);               /* jge dword 0x100c6639 */
    II(0x100c65ba, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x20)); /* movsx edx, word [ebp-0x20] */
    II(0x100c65be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100c65c1, 0x5)   calld(0x100dfd2c, 0x19766);           /* call 0x100dfd2c */
    II(0x100c65c6, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
//    II(0x100c65c9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x100c65cc, 0x3)   mov(eax, memd_a32(ds, eax + 0xc));    /* mov eax, [eax+0xc] */
    II(0x100c65cf, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100c65d2, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100c65d4, 0x2)   jled(0x100c65eb, 0x15);               /* jle 0x100c65eb */
    II(0x100c65d6, 0x4)   cmp(memb_a32(ss, ebp + 0x10), 0);     /* cmp byte [ebp+0x10], 0x0 */
    II(0x100c65da, 0x2)   jnzd(0x100c65e9, 0xd);                /* jnz 0x100c65e9 */
    II(0x100c65dc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x100c65df, 0x3)   mov(eax, memd_a32(ds, eax + 0xe));    /* mov eax, [eax+0xe] */
    II(0x100c65e2, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100c65e5, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100c65e7, 0x2)   jled(0x100c65eb, 0x2);                /* jle 0x100c65eb */
l_0x100c65e9:
    II(0x100c65e9, 0x2)   jmpd(0x100c65ed, 0x2);                /* jmp 0x100c65ed */
l_0x100c65eb:
    II(0x100c65eb, 0x2)   jmpd(0x100c65fe, 0x11);               /* jmp 0x100c65fe */
l_0x100c65ed:
    II(0x100c65ed, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x100c65f1, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x20)); /* movsx eax, word [ebp-0x20] */
    II(0x100c65f5, 0x5)   calld(0x100749d4, -0x51c26);          /* call 0x100749d4 */
    II(0x100c65fa, 0x2)   test(al, al);                         /* test al, al */
    II(0x100c65fc, 0x2)   jnzd(0x100c6600, 0x2);                /* jnz 0x100c6600 */
l_0x100c65fe:
    II(0x100c65fe, 0x2)   jmpd(0x100c6634, 0x34);               /* jmp 0x100c6634 */
l_0x100c6600:
    II(0x100c6600, 0x3)   mov(eax, memd_a32(ss, ebp - 0x24));   /* mov eax, [ebp-0x24] */
    II(0x100c6603, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x100c6606, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100c6609, 0x3)   lea(edx, eax + 0x1);                  /* lea edx, [eax+0x1] */
    II(0x100c660c, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x14)); /* movsx eax, word [ebp-0x14] */
    II(0x100c6610, 0x5)   calld(0x10076e7c, -0x4f799);          /* call 0x10076e7c */
    II(0x100c6615, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100c6618, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x20)); /* movsx edx, word [ebp-0x20] */
    II(0x100c661c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100c661f, 0x6)   mov(eax, memd_a32(ds, eax + 0xfa));   /* mov eax, [eax+0xfa] */
    II(0x100c6625, 0x5)   calld(0x100cb6b0, 0x5086);            /* call 0x100cb6b0 */
    II(0x100c662a, 0x4)   mov(ax, memw_a32(ds, eax + 0x12));    /* mov ax, [eax+0x12] */
    II(0x100c662e, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x18));    /* cmp ax, [ebp-0x18] */
    II(0x100c6632, 0x2)   jgd(0x100c666f, 0x3b);                /* jg 0x100c666f */
l_0x100c6634:
    II(0x100c6634, 0x5)   jmpd(0x100c65a7, -0x92);              /* jmp 0x100c65a7 */
l_0x100c6639:
    II(0x100c6639, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x100c663d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100c6641, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100c6647, 0x5)   mov(ebx, 0x101ca468);                 /* mov ebx, 0x101ca468 */
    II(0x100c664c, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x100c664e, 0x5)   calld(0x100dfd2c, 0x196d9);           /* call 0x100dfd2c */
    II(0x100c6653, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100c6655, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100c6658, 0x4)   cmp(ax, memw_a32(ds, edx + 0x17));    /* cmp ax, [edx+0x17] */
    II(0x100c665c, 0x2)   jled(0x100c666f, 0x11);               /* jle 0x100c666f */
    II(0x100c665e, 0x5)   mov(ebx, 0x7);                        /* mov ebx, 0x7 */
    II(0x100c6663, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x100c6667, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100c666a, 0x5)   calld(0x100c64f5, -0x17a);            /* call 0x100c64f5 */
l_0x100c666f:
    II(0x100c666f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100c6671, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100c6672, 0x1)   popd(edi);                            /* pop edi */
    II(0x100c6673, 0x1)   popd(esi);                            /* pop esi */
    II(0x100c6674, 0x3)   retd(0x4);                            /* ret 0x4 */
FUNC_END

