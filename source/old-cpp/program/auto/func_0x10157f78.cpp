FUNC_BEGIN(0x10157f78, 0x2241c57ec338a583, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xd0, 0xdd, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf0, 0xb8, 0x1, 0, 0, 0, 0xe8, 0xe7, 0xc4, 0xf9, 0xff, 0x8b, 0x45, 0xf0, 0x80, 0x78, 0x5c, 0, 0x75, 0x6, 0xc6, 0x45, 0xf4, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x8b, 0x55, 0xf0, 0x88, 0x42, 0x5c, 0x8b, 0x45, 0xf0, 0x80, 0x78, 0x3d, 0xc, 0x75, 0xf, 0xbb, 0x1, 0, 0, 0, 0x31, 0xd2, 0x8b, 0x45, 0xf0, 0xe8, 0x7a, 0xb0, 0, 0, 0x8b, 0x45, 0xf0, 0x80, 0x78, 0x5c, 0, 0x74, 0xa, 0x8b, 0x45, 0xf0, 0xe8, 0x1c, 0x1e, 0xf5, 0xff, 0xeb, 0x8, 0x8b, 0x45, 0xf0, 0xe8, 0x89, 0xa8, 0xff, 0xff, 0x8b, 0x45, 0xf0, 0xe8, 0x51, 0x89, 0xfa, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10157f78, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10157f7d, 0x5)   calld(sys_check_available_stack_size, 0xddd0); /* call 0x10165d52 */
    II(0x10157f82, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10157f83, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10157f84, 0x1)   pushd(esi);                           /* push esi */
    II(0x10157f85, 0x1)   pushd(edi);                           /* push edi */
    II(0x10157f86, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10157f87, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10157f89, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x10157f8f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10157f92, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10157f95, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10157f98, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10157f9b, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10157fa0, 0x5)   calld(0x100f448c, -0x63b19);          /* call 0x100f448c */
    II(0x10157fa5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10157fa8, 0x4)   cmp(memb_a32(ds, eax + 0x5c), 0);     /* cmp byte [eax+0x5c], 0x0 */
    II(0x10157fac, 0x2)   jnzd(0x10157fb4, 0x6);                /* jnz 0x10157fb4 */
    II(0x10157fae, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x10157fb2, 0x2)   jmpd(0x10157fb8, 0x4);                /* jmp 0x10157fb8 */
l_0x10157fb4:
    II(0x10157fb4, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
l_0x10157fb8:
    II(0x10157fb8, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x10157fbb, 0x3)   mov(edx, memd_a32(ss, ebp - 0x10));   /* mov edx, [ebp-0x10] */
    II(0x10157fbe, 0x3)   mov(memb_a32(ds, edx + 0x5c), al);    /* mov [edx+0x5c], al */
    II(0x10157fc1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10157fc4, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0xc);   /* cmp byte [eax+0x3d], 0xc */
    II(0x10157fc8, 0x2)   jnzd(0x10157fd9, 0xf);                /* jnz 0x10157fd9 */
    II(0x10157fca, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x10157fcf, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10157fd1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10157fd4, 0x5)   calld(0x10163053, 0xb07a);            /* call 0x10163053 */
l_0x10157fd9:
    II(0x10157fd9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10157fdc, 0x4)   cmp(memb_a32(ds, eax + 0x5c), 0);     /* cmp byte [eax+0x5c], 0x0 */
    II(0x10157fe0, 0x2)   jzd(0x10157fec, 0xa);                 /* jz 0x10157fec */
    II(0x10157fe2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10157fe5, 0x5)   calld(0x100a9e06, -0xae1e4);          /* call 0x100a9e06 */
    II(0x10157fea, 0x2)   jmpd(0x10157ff4, 0x8);                /* jmp 0x10157ff4 */
l_0x10157fec:
    II(0x10157fec, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10157fef, 0x5)   calld(0x1015287d, -0x5777);           /* call 0x1015287d */
l_0x10157ff4:
    II(0x10157ff4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10157ff7, 0x5)   calld(0x1010094d, -0x576af);          /* call 0x1010094d */
    II(0x10157ffc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10157ffe, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10157fff, 0x1)   popd(edi);                            /* pop edi */
    II(0x10158000, 0x1)   popd(esi);                            /* pop esi */
    II(0x10158001, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10158002, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10158003, 0x1)   retd();                               /* ret */
FUNC_END

