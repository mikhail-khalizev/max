FUNC_BEGIN(/* sys */ 0x1016f5bc, 0x8c7128a32f37a82f, 0x20, ({0x53, 0x51, 0x83, 0xec, 0x4, 0x89, 0xc1, 0x89, 0xd3, 0x89, 0xe2, 0xe8, 0x90, 0xff, 0xff, 0xff, 0x83, 0xf8, 0xff, 0x74, 0x2d, 0x31, 0xc0, 0x66, 0x8b, 0x4, 0x24, 0x89, 0xe2, 0x89, 0x3, 0x89, 0xc8, 0xe8, 0x7a, 0xff, 0xff, 0xff, 0x83, 0xf8, 0xff, 0x74, 0x17, 0x8b, 0x13, 0xc1, 0xe2, 0x10, 0x31, 0xc0, 0x89, 0x13, 0x89, 0xd1, 0x66, 0x8b, 0x4, 0x24, 0x9, 0xc1, 0x31, 0xc0, 0x89, 0xb, 0xeb, 0x5, 0xb8, 0xff, 0xff, 0xff, 0xff, 0x83, 0xc4, 0x4, 0x59, 0x5b, 0xc3}))
    II(0x1016f5bc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016f5bd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016f5be, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1016f5c1, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x1016f5c3, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x1016f5c5, 0x2)   mov(edx, esp);                        /* mov edx, esp */
    II(0x1016f5c7, 0x5)   calld(/* sys */ 0x1016f55c, -0x70);   /* call 0x1016f55c */
    II(0x1016f5cc, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x1016f5cf, 0x2)   jzd(0x1016f5fe, 0x2d);                /* jz 0x1016f5fe */
    II(0x1016f5d1, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1016f5d3, 0x4)   mov(ax, memw_a32(ss, esp));           /* mov ax, [esp] */
    II(0x1016f5d7, 0x2)   mov(edx, esp);                        /* mov edx, esp */
    II(0x1016f5d9, 0x2)   mov(memd_a32(ds, ebx), eax);          /* mov [ebx], eax */
    II(0x1016f5db, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1016f5dd, 0x5)   calld(/* sys */ 0x1016f55c, -0x86);   /* call 0x1016f55c */
    II(0x1016f5e2, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x1016f5e5, 0x2)   jzd(0x1016f5fe, 0x17);                /* jz 0x1016f5fe */
    II(0x1016f5e7, 0x2)   mov(edx, memd_a32(ds, ebx));          /* mov edx, [ebx] */
    II(0x1016f5e9, 0x3)   shl(edx, 0x10);                       /* shl edx, 0x10 */
    II(0x1016f5ec, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1016f5ee, 0x2)   mov(memd_a32(ds, ebx), edx);          /* mov [ebx], edx */
    II(0x1016f5f0, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x1016f5f2, 0x4)   mov(ax, memw_a32(ss, esp));           /* mov ax, [esp] */
    II(0x1016f5f6, 0x2)   or_(ecx, eax);                        /* or ecx, eax */
    II(0x1016f5f8, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1016f5fa, 0x2)   mov(memd_a32(ds, ebx), ecx);          /* mov [ebx], ecx */
    II(0x1016f5fc, 0x2)   jmpd(0x1016f603, 0x5);                /* jmp 0x1016f603 */
l_0x1016f5fe:
    II(0x1016f5fe, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
l_0x1016f603:
    II(0x1016f603, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x1016f606, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016f607, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016f608, 0x1)   retd();                               /* ret */
FUNC_END

