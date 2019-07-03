FUNC_BEGIN(/* sys */ 0x1017d4f2, 0x61ad1bf32842ab76, 0x20, ({0x51, 0x56, 0x57, 0x55, 0x89, 0xc5, 0x89, 0xd6, 0xb9, 0xff, 0xff, 0xff, 0xff, 0x89, 0xef, 0x30, 0xc0, 0x6, 0xe3, 0xb, 0x8c, 0xda, 0x8e, 0xc2, 0xf2, 0xae, 0x75, 0x3, 0x4f, 0x66, 0xa9, 0x89, 0xcf, 0x7, 0x89, 0xf8, 0x85, 0xdb, 0x74, 0xd, 0x8a, 0x16, 0x88, 0x10, 0x84, 0xd2, 0x74, 0x5, 0x40, 0x46, 0x4b, 0xeb, 0xef, 0xc6, 0, 0, 0x89, 0xe8, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1017d4f2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017d4f3, 0x1)   pushd(esi);                           /* push esi */
    II(0x1017d4f4, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017d4f5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017d4f6, 0x2)   mov(ebp, eax);                        /* mov ebp, eax */
    II(0x1017d4f8, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x1017d4fa, 0x5)   mov(ecx, 0xffffffff);                 /* mov ecx, 0xffffffff */
    II(0x1017d4ff, 0x2)   mov(edi, ebp);                        /* mov edi, ebp */
    II(0x1017d501, 0x2)   xor_(al, al);                         /* xor al, al */
    II(0x1017d503, 0x1)   pushd(es);                            /* push es */
    II(0x1017d504, 0x2)   jecxzd_func(0x1017d511, 0xb);         /* jecxz 0x1017d511 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
    II(0x1017d506, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x1017d508, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x1017d50a, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x1017d50c, 0x2)   jnzd_func(0x1017d511, 0x3);           /* jnz 0x1017d511 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
    II(0x1017d50e, 0x1)   dec(edi);                             /* dec edi */
    II(0x1017d50f, 0x4)   test(ax, 0xcf89);                     /* test ax, 0xcf89 */
    II(0x1017d513, 0x1)   popd(es);                             /* pop es */
    II(0x1017d514, 0x2)   mov(eax, edi);                        /* mov eax, edi */
l_0x1017d516:
    II(0x1017d516, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x1017d518, 0x2)   jzd(0x1017d527, 0xd);                 /* jz 0x1017d527 */
    II(0x1017d51a, 0x2)   mov(dl, memb_a32(ds, esi));           /* mov dl, [esi] */
    II(0x1017d51c, 0x2)   mov(memb_a32(ds, eax), dl);           /* mov [eax], dl */
    II(0x1017d51e, 0x2)   test(dl, dl);                         /* test dl, dl */
    II(0x1017d520, 0x2)   jzd(0x1017d527, 0x5);                 /* jz 0x1017d527 */
    II(0x1017d522, 0x1)   inc(eax);                             /* inc eax */
    II(0x1017d523, 0x1)   inc(esi);                             /* inc esi */
    II(0x1017d524, 0x1)   dec(ebx);                             /* dec ebx */
    II(0x1017d525, 0x2)   jmpd(0x1017d516, -0x11);              /* jmp 0x1017d516 */
l_0x1017d527:
    II(0x1017d527, 0x3)   mov(memb_a32(ds, eax), 0);            /* mov byte [eax], 0x0 */
    II(0x1017d52a, 0x2)   mov(eax, ebp);                        /* mov eax, ebp */
    II(0x1017d52c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1017d52d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017d52e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017d52f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017d530, 0x1)   retd();                               /* ret */
FUNC_END

