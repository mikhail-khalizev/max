FUNC_BEGIN(0x1012b3dd, 0xa2d1e7a63209d9ee, 0x20, ({0x68, 0x38, 0, 0, 0, 0xe8, 0x6b, 0xa9, 0x3, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x20, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xf8, 0xfe, 0x80, 0xd4, 0x59, 0x1c, 0x10, 0xf, 0xbf, 0x5d, 0xfc, 0xf, 0xbf, 0x45, 0xf8, 0x31, 0xd2, 0x8a, 0x90, 0xd4, 0x59, 0x1c, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0xe8, 0x5e, 0xff, 0xff, 0xff, 0xe8, 0xd2, 0xce, 0x1, 0, 0x89, 0x45, 0xec, 0xe8, 0xca, 0xce, 0x1, 0, 0x89, 0x45, 0xe8, 0xc6, 0x45, 0xf4, 0x1, 0x80, 0x7d, 0xf4, 0, 0x74, 0x9, 0x83, 0x3d, 0x24, 0x56, 0x1c, 0x10, 0, 0x75, 0x5, 0xe9, 0xba, 0, 0, 0, 0xb8, 0x1, 0, 0, 0, 0xe8, 0xe6, 0xd3, 0xff, 0xff, 0x8b, 0x45, 0xe8, 0xe8, 0x56, 0xd1, 0x1, 0, 0x3d, 0xb8, 0xb, 0, 0, 0x76, 0x21, 0xf, 0xbf, 0x5d, 0xfc, 0xf, 0xbf, 0x45, 0xf8, 0x31, 0xd2, 0x8a, 0x90, 0xd4, 0x59, 0x1c, 0x10, 0xf, 0xbf, 0x45, 0xf8, 0xe8, 0x4, 0xff, 0xff, 0xff, 0xe8, 0x78, 0xce, 0x1, 0, 0x89, 0x45, 0xe8, 0xc6, 0x45, 0xf4, 0, 0xc7, 0x45, 0xe4, 0x4, 0, 0, 0, 0xff, 0x4d, 0xe4, 0x66, 0x83, 0x7d, 0xe4, 0xff, 0x74, 0x58, 0xf, 0xbf, 0x45, 0xe4, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x3, 0x75, 0x3c, 0xf, 0xbf, 0x55, 0xe4, 0xf, 0xbf, 0x45, 0xf8, 0x8a, 0x92, 0xd4, 0x59, 0x1c, 0x10, 0x3a, 0x90, 0xd4, 0x59, 0x1c, 0x10, 0x74, 0x26, 0xc6, 0x45, 0xf4, 0x1, 0x8b, 0x45, 0xec, 0xe8, 0xdd, 0xd0, 0x1, 0, 0x3d, 0x30, 0x75, 0, 0, 0x76, 0x13, 0xbb, 0x4, 0, 0, 0, 0xba, 0x1, 0, 0, 0, 0xf, 0xbf, 0x45, 0xe4, 0xe8, 0xa5, 0xbf, 0xff, 0xff, 0xeb, 0x9e, 0xe8, 0x17, 0xfd, 0x3, 0, 0x83, 0xf8, 0x1b, 0x75, 0x4, 0xc6, 0x45, 0xf4, 0, 0xe9, 0x32, 0xff, 0xff, 0xff, 0xc7, 0x45, 0xf0, 0x4, 0, 0, 0, 0xff, 0x4d, 0xf0, 0x66, 0x83, 0x7d, 0xf0, 0xff, 0x74, 0x43, 0xf, 0xbf, 0x45, 0xf0, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x3, 0x75, 0x27, 0xf, 0xbf, 0x45, 0xf0, 0x1, 0xc0, 0x66, 0x8b, 0x80, 0xe4, 0x59, 0x1c, 0x10, 0x66, 0x3b, 0x45, 0xfc, 0x74, 0x9, 0x83, 0x3d, 0x24, 0x56, 0x1c, 0x10, 0, 0x75, 0x2, 0xeb, 0x9, 0xc7, 0x45, 0xe0, 0, 0, 0, 0, 0xeb, 0x9, 0xeb, 0xb3, 0xc7, 0x45, 0xe0, 0x1, 0, 0, 0, 0x8b, 0x45, 0xe0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1012b3dd, 0x5)   pushd(0x38);                          /* push dword 0x38 */
    II(0x1012b3e2, 0x5)   calld(sys_check_available_stack_size, 0x3a96b); /* call 0x10165d52 */
    II(0x1012b3e7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012b3e8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012b3e9, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012b3ea, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012b3eb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012b3ec, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012b3ee, 0x6)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x1012b3f4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1012b3f7, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1012b3fa, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012b3fe, 0x6)   inc(memb_a32(ds, eax + 0x101c59d4));  /* inc byte [eax+0x101c59d4] */
    II(0x1012b404, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x1012b408, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012b40c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1012b40e, 0x6)   mov(dl, memb_a32(ds, eax + 0x101c59d4)); /* mov dl, [eax+0x101c59d4] */
    II(0x1012b414, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012b418, 0x5)   calld(0x1012b37b, -0xa2);             /* call 0x1012b37b */
    II(0x1012b41d, 0x5)   calld(0x101482f4, 0x1ced2);           /* call 0x101482f4 */
    II(0x1012b422, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x1012b425, 0x5)   calld(0x101482f4, 0x1ceca);           /* call 0x101482f4 */
    II(0x1012b42a, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x1012b42d, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
l_0x1012b431:
    II(0x1012b431, 0x4)   cmp(memb_a32(ss, ebp - 0xc), 0);      /* cmp byte [ebp-0xc], 0x0 */
    II(0x1012b435, 0x2)   jzd(0x1012b440, 0x9);                 /* jz 0x1012b440 */
    II(0x1012b437, 0x7)   cmp(memd_a32(ds, 0x101c5624), 0);     /* cmp dword [0x101c5624], 0x0 */
    II(0x1012b43e, 0x2)   jnzd(0x1012b445, 0x5);                /* jnz 0x1012b445 */
l_0x1012b440:
    II(0x1012b440, 0x5)   jmpd(0x1012b4ff, 0xba);               /* jmp 0x1012b4ff */
l_0x1012b445:
    II(0x1012b445, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x1012b44a, 0x5)   calld(0x10128835, -0x2c1a);           /* call 0x10128835 */
    II(0x1012b44f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x1012b452, 0x5)   calld(0x101485ad, 0x1d156);           /* call 0x101485ad */
    II(0x1012b457, 0x5)   cmp(eax, 0xbb8);                      /* cmp eax, 0xbb8 */
    II(0x1012b45c, 0x2)   jbed(0x1012b47f, 0x21);               /* jbe 0x1012b47f */
    II(0x1012b45e, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x1012b462, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012b466, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1012b468, 0x6)   mov(dl, memb_a32(ds, eax + 0x101c59d4)); /* mov dl, [eax+0x101c59d4] */
    II(0x1012b46e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012b472, 0x5)   calld(0x1012b37b, -0xfc);             /* call 0x1012b37b */
    II(0x1012b477, 0x5)   calld(0x101482f4, 0x1ce78);           /* call 0x101482f4 */
    II(0x1012b47c, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
l_0x1012b47f:
    II(0x1012b47f, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x1012b483, 0x7)   mov(memd_a32(ss, ebp - 0x1c), 0x4);   /* mov dword [ebp-0x1c], 0x4 */
l_0x1012b48a:
    II(0x1012b48a, 0x3)   dec(memd_a32(ss, ebp - 0x1c));        /* dec dword [ebp-0x1c] */
    II(0x1012b48d, 0x5)   cmp(memw_a32(ss, ebp - 0x1c), -0x1 /* 0xff */); /* cmp word [ebp-0x1c], 0xff */
    II(0x1012b492, 0x2)   jzd(0x1012b4ec, 0x58);                /* jz 0x1012b4ec */
    II(0x1012b494, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x1012b498, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x1012b49e, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x1012b4a4, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1012b4a9, 0x3)   cmp(eax, 0x3);                        /* cmp eax, 0x3 */
    II(0x1012b4ac, 0x2)   jnzd(0x1012b4ea, 0x3c);               /* jnz 0x1012b4ea */
    II(0x1012b4ae, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x1c)); /* movsx edx, word [ebp-0x1c] */
    II(0x1012b4b2, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1012b4b6, 0x6)   mov(dl, memb_a32(ds, edx + 0x101c59d4)); /* mov dl, [edx+0x101c59d4] */
    II(0x1012b4bc, 0x6)   cmp(dl, memb_a32(ds, eax + 0x101c59d4)); /* cmp dl, [eax+0x101c59d4] */
    II(0x1012b4c2, 0x2)   jzd(0x1012b4ea, 0x26);                /* jz 0x1012b4ea */
    II(0x1012b4c4, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x1012b4c8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1012b4cb, 0x5)   calld(0x101485ad, 0x1d0dd);           /* call 0x101485ad */
    II(0x1012b4d0, 0x5)   cmp(eax, 0x7530);                     /* cmp eax, 0x7530 */
    II(0x1012b4d5, 0x2)   jbed(0x1012b4ea, 0x13);               /* jbe 0x1012b4ea */
    II(0x1012b4d7, 0x5)   mov(ebx, 0x4);                        /* mov ebx, 0x4 */
    II(0x1012b4dc, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1012b4e1, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x1012b4e5, 0x5)   calld(0x1012748f, -0x405b);           /* call 0x1012748f */
l_0x1012b4ea:
    II(0x1012b4ea, 0x2)   jmpd(0x1012b48a, -0x62);              /* jmp 0x1012b48a */
l_0x1012b4ec:
    II(0x1012b4ec, 0x5)   calld(/* sys */ 0x1016b208, 0x3fd17); /* call 0x1016b208 */
    II(0x1012b4f1, 0x3)   cmp(eax, 0x1b);                       /* cmp eax, 0x1b */
    II(0x1012b4f4, 0x2)   jnzd(0x1012b4fa, 0x4);                /* jnz 0x1012b4fa */
    II(0x1012b4f6, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
l_0x1012b4fa:
    II(0x1012b4fa, 0x5)   jmpd(0x1012b431, -0xce);              /* jmp 0x1012b431 */
l_0x1012b4ff:
    II(0x1012b4ff, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0x4);   /* mov dword [ebp-0x10], 0x4 */
l_0x1012b506:
    II(0x1012b506, 0x3)   dec(memd_a32(ss, ebp - 0x10));        /* dec dword [ebp-0x10] */
    II(0x1012b509, 0x5)   cmp(memw_a32(ss, ebp - 0x10), -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xff */
    II(0x1012b50e, 0x2)   jzd(0x1012b553, 0x43);                /* jz 0x1012b553 */
    II(0x1012b510, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x1012b514, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x1012b51a, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x1012b520, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1012b525, 0x3)   cmp(eax, 0x3);                        /* cmp eax, 0x3 */
    II(0x1012b528, 0x2)   jnzd(0x1012b551, 0x27);               /* jnz 0x1012b551 */
    II(0x1012b52a, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x1012b52e, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x1012b530, 0x7)   mov(ax, memw_a32(ds, eax + 0x101c59e4)); /* mov ax, [eax+0x101c59e4] */
    II(0x1012b537, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x4));     /* cmp ax, [ebp-0x4] */
    II(0x1012b53b, 0x2)   jzd(0x1012b546, 0x9);                 /* jz 0x1012b546 */
    II(0x1012b53d, 0x7)   cmp(memd_a32(ds, 0x101c5624), 0);     /* cmp dword [0x101c5624], 0x0 */
    II(0x1012b544, 0x2)   jnzd(0x1012b548, 0x2);                /* jnz 0x1012b548 */
l_0x1012b546:
    II(0x1012b546, 0x2)   jmpd(0x1012b551, 0x9);                /* jmp 0x1012b551 */
l_0x1012b548:
    II(0x1012b548, 0x7)   mov(memd_a32(ss, ebp - 0x20), 0);     /* mov dword [ebp-0x20], 0x0 */
    II(0x1012b54f, 0x2)   jmpd(0x1012b55a, 0x9);                /* jmp 0x1012b55a */
l_0x1012b551:
    II(0x1012b551, 0x2)   jmpd(0x1012b506, -0x4d);              /* jmp 0x1012b506 */
l_0x1012b553:
    II(0x1012b553, 0x7)   mov(memd_a32(ss, ebp - 0x20), 0x1);   /* mov dword [ebp-0x20], 0x1 */
l_0x1012b55a:
    II(0x1012b55a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x1012b55d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012b55f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012b560, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012b561, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012b562, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012b563, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012b564, 0x1)   retd();                               /* ret */
FUNC_END

