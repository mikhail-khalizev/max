FUNC_BEGIN(/* sys */ 0x1017a450, 0xef0d19678c0a2c45, 0x20, ({0x55, 0x89, 0xe5, 0x56, 0x57, 0x83, 0xec, 0x4, 0x89, 0x55, 0xf4, 0xa2, 0xd4, 0x9d, 0x20, 0x10, 0x8d, 0x4, 0xc5, 0, 0, 0, 0, 0xa3, 0xd0, 0x9c, 0x20, 0x10, 0x8b, 0x45, 0xf4, 0xf, 0xaf, 0xc3, 0x8a, 0x55, 0xf4, 0x88, 0x1d, 0xd2, 0x9d, 0x20, 0x10, 0x88, 0x15, 0xd3, 0x9d, 0x20, 0x10, 0x8d, 0x4, 0xc5, 0, 0, 0, 0, 0x8b, 0x15, 0, 0xe2, 0x1b, 0x10, 0xa3, 0xf0, 0x9c, 0x20, 0x10, 0x85, 0xd2, 0x74, 0xa, 0x89, 0xc6, 0xd1, 0xee, 0x89, 0x35, 0xf0, 0x9c, 0x20, 0x10, 0xa1, 0xd0, 0x9c, 0x20, 0x10, 0xf, 0xaf, 0xc3, 0x83, 0xe8, 0x8, 0x89, 0xd, 0xcc, 0x9c, 0x20, 0x10, 0xa3, 0xe8, 0x9c, 0x20, 0x10, 0x85, 0xc9, 0x74, 0x15, 0x8b, 0x3d, 0xd0, 0x9c, 0x20, 0x10, 0x1, 0xc0, 0x1, 0xff, 0xa3, 0xe8, 0x9c, 0x20, 0x10, 0x89, 0x3d, 0xd0, 0x9c, 0x20, 0x10, 0xa1, 0xd0, 0x9c, 0x20, 0x10, 0x8d, 0xc, 0xdd, 0, 0, 0, 0, 0xf, 0xaf, 0xc8, 0x89, 0xd8, 0x8d, 0x1c, 0xdd, 0, 0, 0, 0, 0x29, 0xc3, 0xa1, 0xd0, 0x9c, 0x20, 0x10, 0xf, 0xaf, 0xd8, 0x8b, 0x15, 0xf0, 0x9c, 0x20, 0x10, 0x89, 0x1d, 0xec, 0x9c, 0x20, 0x10, 0x89, 0xc3, 0xf, 0xaf, 0xda, 0xb8, 0x50, 0x9a, 0x20, 0x10, 0x89, 0xda, 0x89, 0xd, 0xc4, 0x9c, 0x20, 0x10, 0xe8, 0xbb, 0xf0, 0xff, 0xff, 0xa3, 0xc8, 0x9c, 0x20, 0x10, 0x89, 0xda, 0xb8, 0x60, 0x9a, 0x20, 0x10, 0xe8, 0xaa, 0xf0, 0xff, 0xff, 0x8b, 0xd, 0xc8, 0x9c, 0x20, 0x10, 0x89, 0xc3, 0xa3, 0xd8, 0x9c, 0x20, 0x10, 0x85, 0xc9, 0x74, 0x4, 0x85, 0xc0, 0x75, 0x4, 0x31, 0xc0, 0xeb, 0xa, 0xe8, 0xbf, 0x42, 0x1, 0, 0xb8, 0x1, 0, 0, 0, 0x8d, 0x65, 0xf8, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x1017a450, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017a451, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1017a453, 0x1)   pushd(esi);                           /* push esi */
    II(0x1017a454, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017a455, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1017a458, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x1017a45b, 0x5)   mov(memb_a32(ds, 0x10209dd4), al);    /* mov [0x10209dd4], al */
    II(0x1017a460, 0x7)   lea(eax, eax * 0x8 + 0);              /* lea eax, [eax*8+0x0] */
    II(0x1017a467, 0x5)   mov(memd_a32(ds, 0x10209cd0), eax);   /* mov [0x10209cd0], eax */
    II(0x1017a46c, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1017a46f, 0x3)   imul(eax, ebx);                       /* imul eax, ebx */
    II(0x1017a472, 0x3)   mov(dl, memb_a32(ss, ebp - 0xc));     /* mov dl, [ebp-0xc] */
    II(0x1017a475, 0x6)   mov(memb_a32(ds, 0x10209dd2), bl);    /* mov [0x10209dd2], bl */
    II(0x1017a47b, 0x6)   mov(memb_a32(ds, 0x10209dd3), dl);    /* mov [0x10209dd3], dl */
    II(0x1017a481, 0x7)   lea(eax, eax * 0x8 + 0);              /* lea eax, [eax*8+0x0] */
    II(0x1017a488, 0x6)   mov(edx, memd_a32(ds, 0x101be200));   /* mov edx, [0x101be200] */
    II(0x1017a48e, 0x5)   mov(memd_a32(ds, 0x10209cf0), eax);   /* mov [0x10209cf0], eax */
    II(0x1017a493, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x1017a495, 0x2)   jzd(0x1017a4a1, 0xa);                 /* jz 0x1017a4a1 */
    II(0x1017a497, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1017a499, 0x2)   shr(esi, 0x1);                        /* shr esi, 1 */
    II(0x1017a49b, 0x6)   mov(memd_a32(ds, 0x10209cf0), esi);   /* mov [0x10209cf0], esi */
l_0x1017a4a1:
    II(0x1017a4a1, 0x5)   mov(eax, memd_a32(ds, 0x10209cd0));   /* mov eax, [0x10209cd0] */
    II(0x1017a4a6, 0x3)   imul(eax, ebx);                       /* imul eax, ebx */
    II(0x1017a4a9, 0x3)   sub(eax, 0x8);                        /* sub eax, 0x8 */
    II(0x1017a4ac, 0x6)   mov(memd_a32(ds, 0x10209ccc), ecx);   /* mov [0x10209ccc], ecx */
    II(0x1017a4b2, 0x5)   mov(memd_a32(ds, 0x10209ce8), eax);   /* mov [0x10209ce8], eax */
    II(0x1017a4b7, 0x2)   test(ecx, ecx);                       /* test ecx, ecx */
    II(0x1017a4b9, 0x2)   jzd(0x1017a4d0, 0x15);                /* jz 0x1017a4d0 */
    II(0x1017a4bb, 0x6)   mov(edi, memd_a32(ds, 0x10209cd0));   /* mov edi, [0x10209cd0] */
    II(0x1017a4c1, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x1017a4c3, 0x2)   add(edi, edi);                        /* add edi, edi */
    II(0x1017a4c5, 0x5)   mov(memd_a32(ds, 0x10209ce8), eax);   /* mov [0x10209ce8], eax */
    II(0x1017a4ca, 0x6)   mov(memd_a32(ds, 0x10209cd0), edi);   /* mov [0x10209cd0], edi */
l_0x1017a4d0:
    II(0x1017a4d0, 0x5)   mov(eax, memd_a32(ds, 0x10209cd0));   /* mov eax, [0x10209cd0] */
    II(0x1017a4d5, 0x7)   lea(ecx, ebx * 0x8 + 0);              /* lea ecx, [ebx*8+0x0] */
    II(0x1017a4dc, 0x3)   imul(ecx, eax);                       /* imul ecx, eax */
    II(0x1017a4df, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1017a4e1, 0x7)   lea(ebx, ebx * 0x8 + 0);              /* lea ebx, [ebx*8+0x0] */
    II(0x1017a4e8, 0x2)   sub(ebx, eax);                        /* sub ebx, eax */
    II(0x1017a4ea, 0x5)   mov(eax, memd_a32(ds, 0x10209cd0));   /* mov eax, [0x10209cd0] */
    II(0x1017a4ef, 0x3)   imul(ebx, eax);                       /* imul ebx, eax */
    II(0x1017a4f2, 0x6)   mov(edx, memd_a32(ds, 0x10209cf0));   /* mov edx, [0x10209cf0] */
    II(0x1017a4f8, 0x6)   mov(memd_a32(ds, 0x10209cec), ebx);   /* mov [0x10209cec], ebx */
    II(0x1017a4fe, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1017a500, 0x3)   imul(ebx, edx);                       /* imul ebx, edx */
    II(0x1017a503, 0x5)   mov(eax, 0x10209a50);                 /* mov eax, 0x10209a50 */
    II(0x1017a508, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1017a50a, 0x6)   mov(memd_a32(ds, 0x10209cc4), ecx);   /* mov [0x10209cc4], ecx */
    II(0x1017a510, 0x5)   calld(/* sys */ 0x101795d0, -0xf45);  /* call 0x101795d0 */
    II(0x1017a515, 0x5)   mov(memd_a32(ds, 0x10209cc8), eax);   /* mov [0x10209cc8], eax */
    II(0x1017a51a, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1017a51c, 0x5)   mov(eax, 0x10209a60);                 /* mov eax, 0x10209a60 */
    II(0x1017a521, 0x5)   calld(/* sys */ 0x101795d0, -0xf56);  /* call 0x101795d0 */
    II(0x1017a526, 0x6)   mov(ecx, memd_a32(ds, 0x10209cc8));   /* mov ecx, [0x10209cc8] */
    II(0x1017a52c, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1017a52e, 0x5)   mov(memd_a32(ds, 0x10209cd8), eax);   /* mov [0x10209cd8], eax */
    II(0x1017a533, 0x2)   test(ecx, ecx);                       /* test ecx, ecx */
    II(0x1017a535, 0x2)   jzd(0x1017a53b, 0x4);                 /* jz 0x1017a53b */
    II(0x1017a537, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1017a539, 0x2)   jnzd(0x1017a53f, 0x4);                /* jnz 0x1017a53f */
l_0x1017a53b:
    II(0x1017a53b, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1017a53d, 0x2)   jmpd(0x1017a549, 0xa);                /* jmp 0x1017a549 */
l_0x1017a53f:
    II(0x1017a53f, 0x5)   calld(/* sys */ 0x1018e803, 0x142bf); /* call 0x1018e803 */
    II(0x1017a544, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
l_0x1017a549:
    II(0x1017a549, 0x3)   lea(esp, ebp - 0x8);                  /* lea esp, [ebp-0x8] */
    II(0x1017a54c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017a54d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017a54e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1017a54f, 0x1)   retd();                               /* ret */
FUNC_END

