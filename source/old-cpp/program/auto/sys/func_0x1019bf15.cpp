FUNC_BEGIN(/* sys */ 0x1019bf15, 0x4ec5083c056c262, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x83, 0xec, 0x8, 0x83, 0x3d, 0x2c, 0x1d, 0x1c, 0x10, 0, 0xf, 0x85, 0x73, 0, 0, 0, 0x31, 0xc0, 0xa0, 0x8e, 0xe5, 0x1b, 0x10, 0x83, 0xf8, 0x1, 0x74, 0xb, 0x66, 0xb8, 0x86, 0x16, 0xcd, 0x2f, 0x66, 0x85, 0xc0, 0x75, 0x52, 0x89, 0xe6, 0x30, 0xe4, 0x30, 0xd2, 0x88, 0x24, 0x24, 0x30, 0xf6, 0x88, 0x64, 0x24, 0x1, 0x66, 0x89, 0x54, 0x24, 0x2, 0x8c, 0xda, 0x88, 0x64, 0x24, 0x4, 0x1e, 0x8e, 0xda, 0x66, 0xb8, 0, 0x4, 0xcd, 0x31, 0x88, 0x26, 0x88, 0x46, 0x1, 0x66, 0x89, 0x5e, 0x2, 0x88, 0x4e, 0x4, 0x88, 0x76, 0x5, 0x88, 0x56, 0x6, 0x1f, 0x31, 0xc0, 0xf, 0xb6, 0x74, 0x24, 0x1, 0x8a, 0x4, 0x24, 0x1, 0xf0, 0x85, 0xc0, 0x7e, 0xc, 0xc7, 0x5, 0x2c, 0x1d, 0x1c, 0x10, 0x1, 0, 0, 0, 0xeb, 0xa, 0xc7, 0x5, 0x2c, 0x1d, 0x1c, 0x10, 0xff, 0xff, 0xff, 0xff, 0xa1, 0x2c, 0x1d, 0x1c, 0x10, 0x83, 0xc4, 0x8, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1019bf15, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019bf16, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019bf17, 0x1)   pushd(edx);                           /* push edx */
    II(0x1019bf18, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019bf19, 0x3)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1019bf1c, 0x7)   cmp(memd_a32(ds, 0x101c1d2c), 0);     /* cmp dword [0x101c1d2c], 0x0 */
    II(0x1019bf23, 0x6)   jnzd(0x1019bf9c, 0x73);               /* jnz dword 0x1019bf9c */
    II(0x1019bf29, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1019bf2b, 0x5)   mov(al, memb_a32(ds, 0x101be58e));    /* mov al, [0x101be58e] */
    II(0x1019bf30, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x1019bf33, 0x2)   jzd(0x1019bf40, 0xb);                 /* jz 0x1019bf40 */
    II(0x1019bf35, 0x4)   mov(ax, 0x1686);                      /* mov ax, 0x1686 */
    II(0x1019bf39, 0x2)   int_(0x2f);                           /* int 0x2f */
    II(0x1019bf3b, 0x3)   test(ax, ax);                         /* test ax, ax */
    II(0x1019bf3e, 0x2)   jnzd(0x1019bf92, 0x52);               /* jnz 0x1019bf92 */
l_0x1019bf40:
    II(0x1019bf40, 0x2)   mov(esi, esp);                        /* mov esi, esp */
    II(0x1019bf42, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x1019bf44, 0x2)   xor_(dl, dl);                         /* xor dl, dl */
    II(0x1019bf46, 0x3)   mov(memb_a32(ss, esp), ah);           /* mov [esp], ah */
    II(0x1019bf49, 0x2)   xor_(dh, dh);                         /* xor dh, dh */
    II(0x1019bf4b, 0x4)   mov(memb_a32(ss, esp + 0x1), ah);     /* mov [esp+0x1], ah */
    II(0x1019bf4f, 0x5)   mov(memw_a32(ss, esp + 0x2), dx);     /* mov [esp+0x2], dx */
    II(0x1019bf54, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x1019bf56, 0x4)   mov(memb_a32(ss, esp + 0x4), ah);     /* mov [esp+0x4], ah */
    II(0x1019bf5a, 0x1)   pushd(ds);                            /* push ds */
    II(0x1019bf5b, 0x2)   mov(ds, edx);                         /* mov ds, edx */
    II(0x1019bf5d, 0x4)   mov(ax, 0x400);                       /* mov ax, 0x400 */
    II(0x1019bf61, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x1019bf63, 0x2)   mov(memb_a32(ds, esi), ah);           /* mov [esi], ah */
    II(0x1019bf65, 0x3)   mov(memb_a32(ds, esi + 0x1), al);     /* mov [esi+0x1], al */
    II(0x1019bf68, 0x4)   mov(memw_a32(ds, esi + 0x2), bx);     /* mov [esi+0x2], bx */
    II(0x1019bf6c, 0x3)   mov(memb_a32(ds, esi + 0x4), cl);     /* mov [esi+0x4], cl */
    II(0x1019bf6f, 0x3)   mov(memb_a32(ds, esi + 0x5), dh);     /* mov [esi+0x5], dh */
    II(0x1019bf72, 0x3)   mov(memb_a32(ds, esi + 0x6), dl);     /* mov [esi+0x6], dl */
    II(0x1019bf75, 0x1)   popd(ds);                             /* pop ds */
    II(0x1019bf76, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1019bf78, 0x5)   movzx(esi, memb_a32(ss, esp + 0x1));  /* movzx esi, byte [esp+0x1] */
    II(0x1019bf7d, 0x3)   mov(al, memb_a32(ss, esp));           /* mov al, [esp] */
    II(0x1019bf80, 0x2)   add(eax, esi);                        /* add eax, esi */
    II(0x1019bf82, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1019bf84, 0x2)   jled(0x1019bf92, 0xc);                /* jle 0x1019bf92 */
    II(0x1019bf86, 0xa)   mov(memd_a32(ds, 0x101c1d2c), 0x1);   /* mov dword [0x101c1d2c], 0x1 */
    II(0x1019bf90, 0x2)   jmpd(0x1019bf9c, 0xa);                /* jmp 0x1019bf9c */
l_0x1019bf92:
    II(0x1019bf92, 0xa)   mov(memd_a32(ds, 0x101c1d2c), 0xffffffff); /* mov dword [0x101c1d2c], 0xffffffff */
l_0x1019bf9c:
    II(0x1019bf9c, 0x5)   mov(eax, memd_a32(ds, 0x101c1d2c));   /* mov eax, [0x101c1d2c] */
    II(0x1019bfa1, 0x3)   add(esp, 0x8);                        /* add esp, 0x8 */
    II(0x1019bfa4, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019bfa5, 0x1)   popd(edx);                            /* pop edx */
    II(0x1019bfa6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019bfa7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019bfa8, 0x1)   retd();                               /* ret */
FUNC_END

