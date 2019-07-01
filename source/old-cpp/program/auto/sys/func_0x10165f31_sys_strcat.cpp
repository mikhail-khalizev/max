FUNC_BEGIN(sys_strcat, 0x86e719ce489595a3, 0x20, ({0x51, 0x56, 0x57, 0x89, 0xd6, 0x89, 0xc7, 0x6, 0x1e, 0x7, 0x57, 0x2b, 0xc9, 0x49, 0xb0, 0, 0xf2, 0xae, 0x4f, 0x8a, 0x6, 0x88, 0x7, 0x3c, 0, 0x74, 0x10, 0x8a, 0x46, 0x1, 0x83, 0xc6, 0x2, 0x88, 0x47, 0x1, 0x83, 0xc7, 0x2, 0x3c, 0, 0x75, 0xe8, 0x5f, 0x7, 0x89, 0xf8, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10165f31, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10165f32, 0x1)   pushd(esi);                           /* push esi */
    II(0x10165f33, 0x1)   pushd(edi);                           /* push edi */
    II(0x10165f34, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10165f36, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x10165f38, 0x1)   pushd(es);                            /* push es */
    II(0x10165f39, 0x1)   pushd(ds);                            /* push ds */
    II(0x10165f3a, 0x1)   popd(es);                             /* pop es */
    II(0x10165f3b, 0x1)   pushd(edi);                           /* push edi */
    II(0x10165f3c, 0x2)   sub(ecx, ecx);                        /* sub ecx, ecx */
    II(0x10165f3e, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10165f3f, 0x2)   mov(al, 0);                           /* mov al, 0x0 */
    II(0x10165f41, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x10165f43, 0x1)   dec(edi);                             /* dec edi */
l_0x10165f44:
    II(0x10165f44, 0x2)   mov(al, memb_a32(ds, esi));           /* mov al, [esi] */
    II(0x10165f46, 0x2)   mov(memb_a32(ds, edi), al);           /* mov [edi], al */
    II(0x10165f48, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x10165f4a, 0x2)   jzd(0x10165f5c, 0x10);                /* jz 0x10165f5c */
    II(0x10165f4c, 0x3)   mov(al, memb_a32(ds, esi + 0x1));     /* mov al, [esi+0x1] */
    II(0x10165f4f, 0x3)   add(esi, 0x2);                        /* add esi, 0x2 */
    II(0x10165f52, 0x3)   mov(memb_a32(ds, edi + 0x1), al);     /* mov [edi+0x1], al */
    II(0x10165f55, 0x3)   add(edi, 0x2);                        /* add edi, 0x2 */
    II(0x10165f58, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x10165f5a, 0x2)   jnzd(0x10165f44, -0x18);              /* jnz 0x10165f44 */
l_0x10165f5c:
    II(0x10165f5c, 0x1)   popd(edi);                            /* pop edi */
    II(0x10165f5d, 0x1)   popd(es);                             /* pop es */
    II(0x10165f5e, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x10165f60, 0x1)   popd(edi);                            /* pop edi */
    II(0x10165f61, 0x1)   popd(esi);                            /* pop esi */
    II(0x10165f62, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10165f63, 0x1)   retd();                               /* ret */
FUNC_END

