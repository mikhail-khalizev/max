FUNC_BEGIN(0x1010e7df, 0x41c20e4b33b20069, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0x69, 0x75, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x88, 0x45, 0xfc, 0xc6, 0x45, 0xf0, 0x1, 0xc6, 0x45, 0xf4, 0x1, 0xc6, 0x45, 0xf8, 0, 0x80, 0x7d, 0xf0, 0, 0x74, 0x1e, 0xb8, 0x1, 0, 0, 0, 0xe8, 0xf0, 0xd6, 0xff, 0xff, 0x85, 0xc0, 0x75, 0xc, 0xc7, 0x45, 0xec, 0, 0, 0, 0, 0xe9, 0x8c, 0, 0, 0, 0xc6, 0x45, 0xf0, 0, 0x80, 0x7d, 0xf4, 0, 0x74, 0x15, 0xe8, 0xd6, 0xf0, 0xff, 0xff, 0x85, 0xc0, 0x74, 0x6, 0xc6, 0x45, 0xf4, 0, 0xeb, 0x6, 0xc6, 0x45, 0xf0, 0x1, 0xeb, 0x43, 0xc7, 0x45, 0xe8, 0x4, 0, 0, 0, 0xff, 0x4d, 0xe8, 0x66, 0x83, 0x7d, 0xe8, 0xff, 0x74, 0x1b, 0xb8, 0x33, 0, 0, 0, 0xe8, 0x7c, 0x77, 0xf6, 0xff, 0x89, 0xc2, 0x8a, 0x45, 0xe8, 0x4, 0x6b, 0xf, 0xbe, 0xc0, 0xe8, 0x8d, 0xc2, 0xfb, 0xff, 0xeb, 0xdb, 0x31, 0xc0, 0x8a, 0x45, 0xfc, 0xe8, 0x86, 0xfc, 0xff, 0xff, 0x88, 0x45, 0xf8, 0x80, 0x7d, 0xf8, 0, 0x75, 0x4, 0xc6, 0x45, 0xf4, 0x1, 0x80, 0x7d, 0xf8, 0, 0xf, 0x84, 0x74, 0xff, 0xff, 0xff, 0xe8, 0x9d, 0xd5, 0x5, 0, 0xe8, 0x21, 0xa0, 0xfd, 0xff, 0xe8, 0x23, 0xd4, 0x5, 0, 0xb8, 0x6, 0, 0, 0, 0xe8, 0xf, 0x8, 0xff, 0xff, 0xc7, 0x45, 0xec, 0x1, 0, 0, 0, 0x8b, 0x45, 0xec, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010e7df, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x1010e7e4, 0x5)   calld(sys_check_available_stack_size, 0x57569); /* call 0x10165d52 */
    II(0x1010e7e9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010e7ea, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010e7eb, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010e7ec, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010e7ed, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010e7ee, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010e7ef, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010e7f1, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x1010e7f7, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
    II(0x1010e7fa, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0x1);   /* mov byte [ebp-0x10], 0x1 */
    II(0x1010e7fe, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x1010e802, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
l_0x1010e806:
    II(0x1010e806, 0x4)   cmp(memb_a32(ss, ebp - 0x10), 0);     /* cmp byte [ebp-0x10], 0x0 */
    II(0x1010e80a, 0x2)   jzd(0x1010e82a, 0x1e);                /* jz 0x1010e82a */
    II(0x1010e80c, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x1010e811, 0x5)   calld(0x1010bf06, -0x2910);           /* call 0x1010bf06 */
    II(0x1010e816, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1010e818, 0x2)   jnzd(0x1010e826, 0xc);                /* jnz 0x1010e826 */
    II(0x1010e81a, 0x7)   mov(memd_a32(ss, ebp - 0x14), 0);     /* mov dword [ebp-0x14], 0x0 */
    II(0x1010e821, 0x5)   jmpd(0x1010e8b2, 0x8c);               /* jmp 0x1010e8b2 */
l_0x1010e826:
    II(0x1010e826, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0);     /* mov byte [ebp-0x10], 0x0 */
l_0x1010e82a:
    II(0x1010e82a, 0x4)   cmp(memb_a32(ss, ebp - 0xc), 0);      /* cmp byte [ebp-0xc], 0x0 */
    II(0x1010e82e, 0x2)   jzd(0x1010e845, 0x15);                /* jz 0x1010e845 */
    II(0x1010e830, 0x5)   calld(0x1010d90b, -0xf2a);            /* call 0x1010d90b */
    II(0x1010e835, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1010e837, 0x2)   jzd(0x1010e83f, 0x6);                 /* jz 0x1010e83f */
    II(0x1010e839, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x1010e83d, 0x2)   jmpd(0x1010e845, 0x6);                /* jmp 0x1010e845 */
l_0x1010e83f:
    II(0x1010e83f, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0x1);   /* mov byte [ebp-0x10], 0x1 */
    II(0x1010e843, 0x2)   jmpd(0x1010e888, 0x43);               /* jmp 0x1010e888 */
l_0x1010e845:
    II(0x1010e845, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0x4);   /* mov dword [ebp-0x18], 0x4 */
l_0x1010e84c:
    II(0x1010e84c, 0x3)   dec(memd_a32(ss, ebp - 0x18));        /* dec dword [ebp-0x18] */
    II(0x1010e84f, 0x5)   cmp(memw_a32(ss, ebp - 0x18), -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xff */
    II(0x1010e854, 0x2)   jzd(0x1010e871, 0x1b);                /* jz 0x1010e871 */
    II(0x1010e856, 0x5)   mov(eax, 0x33);                       /* mov eax, 0x33 */
    II(0x1010e85b, 0x5)   calld(0x10075fdc, -0x98884);          /* call 0x10075fdc */
    II(0x1010e860, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1010e862, 0x3)   mov(al, memb_a32(ss, ebp - 0x18));    /* mov al, [ebp-0x18] */
    II(0x1010e865, 0x2)   add(al, 0x6b);                        /* add al, 0x6b */
    II(0x1010e867, 0x3)   movsx(eax, al);                       /* movsx eax, al */
    II(0x1010e86a, 0x5)   calld(0x100caafc, -0x43d73);          /* call 0x100caafc */
    II(0x1010e86f, 0x2)   jmpd(0x1010e84c, -0x25);              /* jmp 0x1010e84c */
l_0x1010e871:
    II(0x1010e871, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1010e873, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1010e876, 0x5)   calld(0x1010e501, -0x37a);            /* call 0x1010e501 */
    II(0x1010e87b, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
    II(0x1010e87e, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0);      /* cmp byte [ebp-0x8], 0x0 */
    II(0x1010e882, 0x2)   jnzd(0x1010e888, 0x4);                /* jnz 0x1010e888 */
    II(0x1010e884, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
l_0x1010e888:
    II(0x1010e888, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0);      /* cmp byte [ebp-0x8], 0x0 */
    II(0x1010e88c, 0x6)   jzd(0x1010e806, -0x8c);               /* jz dword 0x1010e806 */
    II(0x1010e892, 0x5)   calld(/* sys */ 0x1016be34, 0x5d59d); /* call 0x1016be34 */
    II(0x1010e897, 0x5)   calld(0x100e88bd, -0x25fdf);          /* call 0x100e88bd */
    II(0x1010e89c, 0x5)   calld(/* sys */ 0x1016bcc4, 0x5d423); /* call 0x1016bcc4 */
    II(0x1010e8a1, 0x5)   mov(eax, 0x6);                        /* mov eax, 0x6 */
    II(0x1010e8a6, 0x5)   calld(0x100ff0ba, -0xf7f1);           /* call 0x100ff0ba */
    II(0x1010e8ab, 0x7)   mov(memd_a32(ss, ebp - 0x14), 0x1);   /* mov dword [ebp-0x14], 0x1 */
l_0x1010e8b2:
    II(0x1010e8b2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1010e8b5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010e8b7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010e8b8, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010e8b9, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010e8ba, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010e8bb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010e8bc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010e8bd, 0x1)   retd();                               /* ret */
FUNC_END

