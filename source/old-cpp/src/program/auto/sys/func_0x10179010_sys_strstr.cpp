FUNC_BEGIN(sys_strstr, 0xf3ec5f36915a256c, 0x20, ({0x53, 0x51, 0x56, 0x57, 0x55, 0x83, 0xec, 0x4, 0x89, 0xc6, 0x89, 0xd3, 0x80, 0x3a, 0, 0x75, 0x7, 0x89, 0xf0, 0xe9, 0x9d, 0, 0, 0, 0x80, 0x7a, 0x1, 0, 0x75, 0x1c, 0x8a, 0x13, 0x8a, 0x6, 0x3a, 0xc2, 0x74, 0x12, 0x3c, 0, 0x74, 0xc, 0x46, 0x8a, 0x6, 0x3a, 0xc2, 0x74, 0x7, 0x46, 0x3c, 0, 0x75, 0xea, 0x2b, 0xf6, 0xeb, 0xd7, 0xb9, 0xff, 0xff, 0xff, 0xff, 0x89, 0xf7, 0x30, 0xc0, 0x6, 0xe3, 0xb, 0x8c, 0xda, 0x8e, 0xc2, 0xf2, 0xae, 0x75, 0x3, 0x4f, 0x66, 0xa9, 0x89, 0xcf, 0x7, 0x89, 0x3c, 0x24, 0x89, 0xdf, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x29, 0xc9, 0x49, 0x31, 0xc0, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x7, 0x89, 0xcd}))
    II(0x10179010, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10179011, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10179012, 0x1)   pushd(esi);                           /* push esi */
    II(0x10179013, 0x1)   pushd(edi);                           /* push edi */
    II(0x10179014, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10179015, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10179018, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1017901a, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x1017901c, 0x3)   cmp(memb_a32(ds, edx), 0);            /* cmp byte [edx], 0x0 */
    II(0x1017901f, 0x2)   jnzd(0x10179028, 0x7);                /* jnz 0x10179028 */
l_0x10179021:
    II(0x10179021, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x10179023, 0x5)   jmpd_func(0x101790c5, 0x9d);          /* jmp 0x101790c5 */
l_0x10179028:
    II(0x10179028, 0x4)   cmp(memb_a32(ds, edx + 0x1), 0);      /* cmp byte [edx+0x1], 0x0 */
    II(0x1017902c, 0x2)   jnzd(0x1017904a, 0x1c);               /* jnz 0x1017904a */
    II(0x1017902e, 0x2)   mov(dl, memb_a32(ds, ebx));           /* mov dl, [ebx] */
l_0x10179030:
    II(0x10179030, 0x2)   mov(al, memb_a32(ds, esi));           /* mov al, [esi] */
    II(0x10179032, 0x2)   cmp(al, dl);                          /* cmp al, dl */
    II(0x10179034, 0x2)   jzd(0x10179048, 0x12);                /* jz 0x10179048 */
    II(0x10179036, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x10179038, 0x2)   jzd(0x10179046, 0xc);                 /* jz 0x10179046 */
    II(0x1017903a, 0x1)   inc(esi);                             /* inc esi */
    II(0x1017903b, 0x2)   mov(al, memb_a32(ds, esi));           /* mov al, [esi] */
    II(0x1017903d, 0x2)   cmp(al, dl);                          /* cmp al, dl */
    II(0x1017903f, 0x2)   jzd(0x10179048, 0x7);                 /* jz 0x10179048 */
    II(0x10179041, 0x1)   inc(esi);                             /* inc esi */
    II(0x10179042, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x10179044, 0x2)   jnzd(0x10179030, -0x16);              /* jnz 0x10179030 */
l_0x10179046:
    II(0x10179046, 0x2)   sub(esi, esi);                        /* sub esi, esi */
l_0x10179048:
    II(0x10179048, 0x2)   jmpd(0x10179021, -0x29);              /* jmp 0x10179021 */
l_0x1017904a:
    II(0x1017904a, 0x5)   mov(ecx, 0xffffffff);                 /* mov ecx, 0xffffffff */
    II(0x1017904f, 0x2)   mov(edi, esi);                        /* mov edi, esi */
    II(0x10179051, 0x2)   xor_(al, al);                         /* xor al, al */
    II(0x10179053, 0x1)   pushd(es);                            /* push es */
    II(0x10179054, 0x2)   jecxzd_func(0x10179061, 0xb);         /* jecxz 0x10179061 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
    II(0x10179056, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x10179058, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x1017905a, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x1017905c, 0x2)   jnzd_func(0x10179061, 0x3);           /* jnz 0x10179061 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
    II(0x1017905e, 0x1)   dec(edi);                             /* dec edi */
    II(0x1017905f, 0x4)   test(ax, 0xcf89);                     /* test ax, 0xcf89 */
    II(0x10179063, 0x1)   popd(es);                             /* pop es */
    II(0x10179064, 0x3)   mov(memd_a32(ss, esp), edi);          /* mov [esp], edi */
    II(0x10179067, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x10179069, 0x1)   pushd(es);                            /* push es */
    II(0x1017906a, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x1017906c, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x1017906e, 0x2)   sub(ecx, ecx);                        /* sub ecx, ecx */
    II(0x10179070, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10179071, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10179073, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x10179075, 0x2)   not_(ecx);                            /* not ecx */
    II(0x10179077, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10179078, 0x1)   popd(es);                             /* pop es */
    II(0x10179079, 0x2)   mov(ebp, ecx);                        /* mov ebp, ecx */
    II(0x1017907b, 0)     jmpd_func(/* sys */ 0x1017907b, 0);   /* Принудительное завершение функции. */
FUNC_END

