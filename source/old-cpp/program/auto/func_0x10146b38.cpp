FUNC_BEGIN(0x10146b38, 0x8d87917db6bb5597, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x10, 0xf2, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x85, 0xfd, 0xff, 0xff, 0x84, 0xc0, 0x75, 0x6, 0xc6, 0x45, 0xf4, 0, 0xeb, 0x65, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x1c, 0xfe, 0xc0, 0x25, 0xff, 0, 0, 0, 0xf6, 0x80, 0xc0, 0x75, 0x1b, 0x10, 0xc0, 0x75, 0x12, 0xb8, 0x53, 0xd0, 0x1a, 0x10, 0x50, 0x8b, 0x45, 0xf8, 0x50, 0xe8, 0x29, 0xfe, 0xff, 0xff, 0x83, 0xc4, 0x8, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x1c, 0xfe, 0xc0, 0x25, 0xff, 0, 0, 0, 0xf6, 0x80, 0xc0, 0x75, 0x1b, 0x10, 0xe0, 0x75, 0x9, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x1c, 0x5f, 0x75, 0x1a, 0x8b, 0x45, 0xf8, 0x31, 0xd2, 0x8a, 0x50, 0x1c, 0x8b, 0x45, 0xfc, 0xe8, 0x2c, 0xb2, 0xff, 0xff, 0x8b, 0x45, 0xf8, 0xe8, 0x5c, 0xfb, 0xff, 0xff, 0xeb, 0xc7, 0xc6, 0x45, 0xf4, 0x1, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10146b38, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x10146b3d, 0x5)   calld(sys_check_available_stack_size, 0x1f210); /* call 0x10165d52 */
    II(0x10146b42, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10146b43, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10146b44, 0x1)   pushd(esi);                           /* push esi */
    II(0x10146b45, 0x1)   pushd(edi);                           /* push edi */
    II(0x10146b46, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10146b47, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10146b49, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10146b4f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10146b52, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10146b55, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10146b58, 0x5)   calld(0x101468e2, -0x27b);            /* call 0x101468e2 */
    II(0x10146b5d, 0x2)   test(al, al);                         /* test al, al */
    II(0x10146b5f, 0x2)   jnzd(0x10146b67, 0x6);                /* jnz 0x10146b67 */
    II(0x10146b61, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x10146b65, 0x2)   jmpd(0x10146bcc, 0x65);               /* jmp 0x10146bcc */
l_0x10146b67:
    II(0x10146b67, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10146b6a, 0x3)   mov(al, memb_a32(ds, eax + 0x1c));    /* mov al, [eax+0x1c] */
    II(0x10146b6d, 0x2)   inc(al);                              /* inc al */
    II(0x10146b6f, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10146b74, 0x7)   test(memb_a32(ds, eax + 0x101b75c0), 0xc0); /* test byte [eax+0x101b75c0], 0xc0 */
    II(0x10146b7b, 0x2)   jnzd(0x10146b8f, 0x12);               /* jnz 0x10146b8f */
    II(0x10146b7d, 0x5)   mov(eax, 0x101ad053);                 /* mov eax, 0x101ad053 */ /* "Expected a letter" */
    II(0x10146b82, 0x1)   pushd(eax);                           /* push eax */
    II(0x10146b83, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10146b86, 0x1)   pushd(eax);                           /* push eax */
    II(0x10146b87, 0x5)   calld(0x101469b5, -0x1d7);            /* call 0x101469b5 */
    II(0x10146b8c, 0x3)   add(esp, 0x8);                        /* add esp, 0x8 */
l_0x10146b8f:
    II(0x10146b8f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10146b92, 0x3)   mov(al, memb_a32(ds, eax + 0x1c));    /* mov al, [eax+0x1c] */
    II(0x10146b95, 0x2)   inc(al);                              /* inc al */
    II(0x10146b97, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10146b9c, 0x7)   test(memb_a32(ds, eax + 0x101b75c0), 0xe0); /* test byte [eax+0x101b75c0], 0xe0 */
    II(0x10146ba3, 0x2)   jnzd(0x10146bae, 0x9);                /* jnz 0x10146bae */
    II(0x10146ba5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10146ba8, 0x4)   cmp(memd_a32(ds, eax + 0x1c), 0x5f);  /* cmp dword [eax+0x1c], 0x5f */
    II(0x10146bac, 0x2)   jnzd(0x10146bc8, 0x1a);               /* jnz 0x10146bc8 */
l_0x10146bae:
    II(0x10146bae, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10146bb1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10146bb3, 0x3)   mov(dl, memb_a32(ds, eax + 0x1c));    /* mov dl, [eax+0x1c] */
    II(0x10146bb6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146bb9, 0x5)   calld(my_string_append_char, -0x4dd4); /* call 0x10141dea */
    II(0x10146bbe, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10146bc1, 0x5)   calld(0x10146722, -0x4a4);            /* call 0x10146722 */
    II(0x10146bc6, 0x2)   jmpd(0x10146b8f, -0x39);              /* jmp 0x10146b8f */
l_0x10146bc8:
    II(0x10146bc8, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
l_0x10146bcc:
    II(0x10146bcc, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x10146bcf, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10146bd1, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10146bd2, 0x1)   popd(edi);                            /* pop edi */
    II(0x10146bd3, 0x1)   popd(esi);                            /* pop esi */
    II(0x10146bd4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10146bd5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10146bd6, 0x1)   retd();                               /* ret */
FUNC_END

