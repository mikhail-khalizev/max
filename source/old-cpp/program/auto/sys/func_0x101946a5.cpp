FUNC_BEGIN(/* sys */ 0x101946a5, 0xcccfbe02df2eb811, 0x20, ({0x53, 0x51, 0x52, 0x89, 0xc2, 0x3b, 0x5, 0xd0, 0x9, 0x1c, 0x10, 0x72, 0x6, 0x31, 0xc0, 0x5a, 0x59, 0x5b, 0xc3, 0x83, 0xf8, 0x5, 0x7f, 0x31, 0x89, 0xc3, 0xa1, 0x24, 0xa, 0x1c, 0x10, 0xc1, 0xe3, 0x2, 0x1, 0xd8, 0x8a, 0x48, 0x1, 0xf6, 0xc1, 0x40, 0x75, 0x1d, 0x88, 0xcd, 0x80, 0xcd, 0x40, 0x88, 0x68, 0x1, 0x89, 0xd0, 0xe8, 0x9e, 0xff, 0xff, 0xff, 0x85, 0xc0, 0x74, 0xa, 0xa1, 0x24, 0xa, 0x1c, 0x10, 0x80, 0x4c, 0x3, 0x1, 0x20, 0xa1, 0x24, 0xa, 0x1c, 0x10, 0x8b, 0x4, 0x90, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101946a5, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101946a6, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101946a7, 0x1)   pushd(edx);                           /* push edx */
    II(0x101946a8, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x101946aa, 0x6)   cmp(eax, memd_a32(ds, 0x101c09d0));   /* cmp eax, [0x101c09d0] */
    II(0x101946b0, 0x2)   jbd(0x101946b8, 0x6);                 /* jb 0x101946b8 */
    II(0x101946b2, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101946b4, 0x1)   popd(edx);                            /* pop edx */
    II(0x101946b5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101946b6, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101946b7, 0x1)   retd();                               /* ret */
l_0x101946b8:
    II(0x101946b8, 0x3)   cmp(eax, 0x5);                        /* cmp eax, 0x5 */
    II(0x101946bb, 0x2)   jgd(0x101946ee, 0x31);                /* jg 0x101946ee */
    II(0x101946bd, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x101946bf, 0x5)   mov(eax, memd_a32(ds, ptr_of_fd_table_)); /* mov eax, [0x101c0a24] */
    II(0x101946c4, 0x3)   shl(ebx, 0x2);                        /* shl ebx, 0x2 */
    II(0x101946c7, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x101946c9, 0x3)   mov(cl, memb_a32(ds, eax + 0x1));     /* mov cl, [eax+0x1] */
    II(0x101946cc, 0x3)   test(cl, 0x40);                       /* test cl, 0x40 */
    II(0x101946cf, 0x2)   jnzd(0x101946ee, 0x1d);               /* jnz 0x101946ee */
    II(0x101946d1, 0x2)   mov(ch, cl);                          /* mov ch, cl */
    II(0x101946d3, 0x3)   or_(ch, 0x40);                        /* or ch, 0x40 */
    II(0x101946d6, 0x3)   mov(memb_a32(ds, eax + 0x1), ch);     /* mov [eax+0x1], ch */
    II(0x101946d9, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x101946db, 0x5)   calld(/* sys */ 0x1019467e, -0x62);   /* call 0x1019467e */
    II(0x101946e0, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101946e2, 0x2)   jzd(0x101946ee, 0xa);                 /* jz 0x101946ee */
    II(0x101946e4, 0x5)   mov(eax, memd_a32(ds, ptr_of_fd_table_)); /* mov eax, [0x101c0a24] */
    II(0x101946e9, 0x5)   or_(memb_a32(ds, ebx + eax + 0x1), 0x20); /* or byte [ebx+eax+0x1], 0x20 */
l_0x101946ee:
    II(0x101946ee, 0x5)   mov(eax, memd_a32(ds, ptr_of_fd_table_)); /* mov eax, [0x101c0a24] */
    II(0x101946f3, 0x3)   mov(eax, memd_a32(ds, eax + edx * 0x4)); /* mov eax, [eax+edx*4] */
    II(0x101946f6, 0x1)   popd(edx);                            /* pop edx */
    II(0x101946f7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101946f8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101946f9, 0x1)   retd();                               /* ret */
FUNC_END

