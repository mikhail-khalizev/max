FUNC_BEGIN(0x100b71dc, 0x2d550d5acb0c27ed, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x6c, 0xeb, 0xa, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x50, 0xff, 0xff, 0xff, 0x89, 0xc2, 0x8d, 0x45, 0xec, 0xe8, 0xac, 0xf2, 0xfb, 0xff, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xeb, 0x8, 0x8d, 0x45, 0xec, 0xe8, 0xdb, 0xf9, 0xfb, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0x4a, 0x3b, 0x8, 0, 0x84, 0xc0, 0x74, 0x41, 0x8d, 0x45, 0xec, 0xe8, 0x6d, 0xf1, 0xfb, 0xff, 0x31, 0xd2, 0x8a, 0x50, 0x26, 0xf, 0xbf, 0x45, 0xf8, 0x39, 0xc2, 0x75, 0x12, 0x8d, 0x45, 0xec, 0xe8, 0x58, 0xf1, 0xfb, 0xff, 0x66, 0x8b, 0x40, 0x8, 0x66, 0x3b, 0x45, 0xfc, 0x74, 0x2, 0xeb, 0xe, 0x8d, 0x45, 0xec, 0xe8, 0x44, 0xf1, 0xfb, 0xff, 0x80, 0x78, 0x3e, 0x1e, 0x75, 0x2, 0xeb, 0x6, 0x8b, 0x45, 0xf0, 0xff, 0x45, 0xf0, 0xeb, 0xa9, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xf4, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0xf0, 0xec, 0xfb, 0xff, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0xe4, 0xec, 0xfb, 0xff, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b71dc, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x100b71e1, 0x5)   calld(sys_check_available_stack_size, 0xaeb6c); /* call 0x10165d52 */
    II(0x100b71e6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b71e7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b71e8, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b71e9, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b71ea, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b71eb, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b71ed, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x100b71f3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b71f6, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100b71f9, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100b71fd, 0x5)   calld(0x100b7152, -0xb0);             /* call 0x100b7152 */
    II(0x100b7202, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100b7204, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100b7207, 0x5)   calld(0x100764b8, -0x40d54);          /* call 0x100764b8 */
    II(0x100b720c, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x100b7213, 0x2)   jmpd(0x100b721d, 0x8);                /* jmp 0x100b721d */
l_0x100b7215:
    II(0x100b7215, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100b7218, 0x5)   calld(0x10076bf8, -0x40625);          /* call 0x10076bf8 */
l_0x100b721d:
    II(0x100b721d, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b721f, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100b7222, 0x5)   calld(0x1013ad71, 0x83b4a);           /* call 0x1013ad71 */
    II(0x100b7227, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b7229, 0x2)   jzd(0x100b726c, 0x41);                /* jz 0x100b726c */
    II(0x100b722b, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100b722e, 0x5)   calld(0x100763a0, -0x40e93);          /* call 0x100763a0 */
    II(0x100b7233, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b7235, 0x3)   mov(dl, memb_a32(ds, eax + 0x26));    /* mov dl, [eax+0x26] */
    II(0x100b7238, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x100b723c, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100b723e, 0x2)   jnzd(0x100b7252, 0x12);               /* jnz 0x100b7252 */
    II(0x100b7240, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100b7243, 0x5)   calld(0x100763a0, -0x40ea8);          /* call 0x100763a0 */
    II(0x100b7248, 0x4)   mov(ax, memw_a32(ds, eax + 0x8));     /* mov ax, [eax+0x8] */
    II(0x100b724c, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x4));     /* cmp ax, [ebp-0x4] */
    II(0x100b7250, 0x2)   jzd(0x100b7254, 0x2);                 /* jz 0x100b7254 */
l_0x100b7252:
    II(0x100b7252, 0x2)   jmpd(0x100b7262, 0xe);                /* jmp 0x100b7262 */
l_0x100b7254:
    II(0x100b7254, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100b7257, 0x5)   calld(0x100763a0, -0x40ebc);          /* call 0x100763a0 */
    II(0x100b725c, 0x4)   cmp(memb_a32(ds, eax + 0x3e), 0x1e);  /* cmp byte [eax+0x3e], 0x1e */
    II(0x100b7260, 0x2)   jnzd(0x100b7264, 0x2);                /* jnz 0x100b7264 */
l_0x100b7262:
    II(0x100b7262, 0x2)   jmpd(0x100b726a, 0x6);                /* jmp 0x100b726a */
l_0x100b7264:
    II(0x100b7264, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b7267, 0x3)   inc(memd_a32(ss, ebp - 0x10));        /* inc dword [ebp-0x10] */
l_0x100b726a:
    II(0x100b726a, 0x2)   jmpd(0x100b7215, -0x57);              /* jmp 0x100b7215 */
l_0x100b726c:
    II(0x100b726c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100b726f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100b7272, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b7274, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100b7277, 0x5)   calld(0x10075f6c, -0x41310);          /* call 0x10075f6c */
    II(0x100b727c, 0x2)   jmpd(0x100b7288, 0xa);                /* jmp 0x100b7288 */
//  II(0x100b727e, 0xa)   /* Недостижимый код. */
l_0x100b7288:
    II(0x100b7288, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b728b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b728d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b728e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b728f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b7290, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b7291, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b7292, 0x1)   retd();                               /* ret */
FUNC_END

