FUNC_BEGIN(/* sys */ 0x1019aa08, 0x36e8904e21ef0a39, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x31, 0xc0, 0xba, 0, 0x80, 0, 0, 0xa0, 0x8e, 0xe5, 0x1b, 0x10, 0x89, 0x15, 0x54, 0x1c, 0x1c, 0x10, 0x83, 0xf8, 0x2, 0x7c, 0x5, 0x83, 0xf8, 0x8, 0x7e, 0x7, 0xb8, 0x1, 0, 0, 0, 0xeb, 0x2, 0x31, 0xc0, 0x85, 0xc0, 0x74, 0x35, 0xe8, 0xda, 0x14, 0, 0, 0x83, 0xf8, 0x1, 0x75, 0x2b, 0xba, 0xdb, 0xc9, 0x16, 0x10, 0xb8, 0xd0, 0xc9, 0x16, 0x10, 0x81, 0xea, 0xd0, 0xc9, 0x16, 0x10, 0x66, 0x89, 0xd7, 0xc1, 0xea, 0x10, 0x66, 0x89, 0xd6, 0x66, 0x89, 0xc3, 0xc1, 0xe8, 0x10, 0x66, 0x89, 0xc1, 0x66, 0xb8, 0, 0x6, 0xcd, 0x31, 0x66, 0x19, 0xc0, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1019aa08, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019aa09, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019aa0a, 0x1)   pushd(edx);                           /* push edx */
    II(0x1019aa0b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019aa0c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1019aa0d, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1019aa0f, 0x5)   mov(edx, 0x8000);                     /* mov edx, 0x8000 */
    II(0x1019aa14, 0x5)   mov(al, memb_a32(ds, 0x101be58e));    /* mov al, [0x101be58e] */
    II(0x1019aa19, 0x6)   mov(memd_a32(ds, 0x101c1c54), edx);   /* mov [0x101c1c54], edx */
    II(0x1019aa1f, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x1019aa22, 0x2)   jld(0x1019aa29, 0x5);                 /* jl 0x1019aa29 */
    II(0x1019aa24, 0x3)   cmp(eax, 0x8);                        /* cmp eax, 0x8 */
    II(0x1019aa27, 0x2)   jled(0x1019aa30, 0x7);                /* jle 0x1019aa30 */
l_0x1019aa29:
    II(0x1019aa29, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x1019aa2e, 0x2)   jmpd(0x1019aa32, 0x2);                /* jmp 0x1019aa32 */
l_0x1019aa30:
    II(0x1019aa30, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x1019aa32:
    II(0x1019aa32, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1019aa34, 0x2)   jzd(0x1019aa6b, 0x35);                /* jz 0x1019aa6b */
    II(0x1019aa36, 0x5)   calld(/* sys */ 0x1019bf15, 0x14da);  /* call 0x1019bf15 */
    II(0x1019aa3b, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x1019aa3e, 0x2)   jnzd(0x1019aa6b, 0x2b);               /* jnz 0x1019aa6b */
    II(0x1019aa40, 0x5)   mov(edx, /* sys */ 0x1016c9db);       /* mov edx, 0x1016c9db */
    II(0x1019aa45, 0x5)   mov(eax, /* sys */ 0x1016c9d0);       /* mov eax, 0x1016c9d0 */
    II(0x1019aa4a, 0x6)   sub(edx, /* sys */ 0x1016c9d0);       /* sub edx, 0x1016c9d0 */
    II(0x1019aa50, 0x3)   mov(di, dx);                          /* mov di, dx */
    II(0x1019aa53, 0x3)   shr(edx, 0x10);                       /* shr edx, 0x10 */
    II(0x1019aa56, 0x3)   mov(si, dx);                          /* mov si, dx */
    II(0x1019aa59, 0x3)   mov(bx, ax);                          /* mov bx, ax */
    II(0x1019aa5c, 0x3)   shr(eax, 0x10);                       /* shr eax, 0x10 */
    II(0x1019aa5f, 0x3)   mov(cx, ax);                          /* mov cx, ax */
    II(0x1019aa62, 0x4)   mov(ax, 0x600);                       /* mov ax, 0x600 */
    II(0x1019aa66, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x1019aa68, 0x3)   sbb(ax, ax);                          /* sbb ax, ax */
l_0x1019aa6b:
    II(0x1019aa6b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1019aa6c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019aa6d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1019aa6e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019aa6f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019aa70, 0x1)   retd();                               /* ret */
FUNC_END

