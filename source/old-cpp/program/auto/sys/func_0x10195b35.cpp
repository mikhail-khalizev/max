FUNC_BEGIN(/* sys */ 0x10195b35, 0x126fea541cb13fe1, 0x20, ({0x56, 0x57, 0x1e, 0x6, 0x50, 0x66, 0x8e, 0xc2, 0x66, 0x8e, 0xd9, 0x8b, 0xf3, 0x8b, 0xf8, 0x8a, 0x6, 0x26, 0x88, 0x7, 0x3c, 0, 0x74, 0x11, 0x8a, 0x46, 0x1, 0x83, 0xc6, 0x2, 0x26, 0x88, 0x47, 0x1, 0x83, 0xc7, 0x2, 0x3c, 0, 0x75, 0xe6, 0x58, 0x7, 0x1f, 0x5f, 0x5e, 0xc3}))
    II(0x10195b35, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195b36, 0x1)   pushd(edi);                           /* push edi */
    II(0x10195b37, 0x1)   pushd(ds);                            /* push ds */
    II(0x10195b38, 0x1)   pushd(es);                            /* push es */
    II(0x10195b39, 0x1)   pushd(eax);                           /* push eax */
    II(0x10195b3a, 0x3)   mov(es, dx);                          /* mov es, dx */
    II(0x10195b3d, 0x3)   mov(ds, cx);                          /* mov ds, cx */
    II(0x10195b40, 0x2)   mov(esi, ebx);                        /* mov esi, ebx */
    II(0x10195b42, 0x2)   mov(edi, eax);                        /* mov edi, eax */
l_0x10195b44:
    II(0x10195b44, 0x2)   mov(al, memb_a32(ds, esi));           /* mov al, [esi] */
    II(0x10195b46, 0x3)   mov(memb_a32(es, edi), al);           /* mov [es:edi], al */
    II(0x10195b49, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x10195b4b, 0x2)   jzd(0x10195b5e, 0x11);                /* jz 0x10195b5e */
    II(0x10195b4d, 0x3)   mov(al, memb_a32(ds, esi + 0x1));     /* mov al, [esi+0x1] */
    II(0x10195b50, 0x3)   add(esi, 0x2);                        /* add esi, 0x2 */
    II(0x10195b53, 0x4)   mov(memb_a32(es, edi + 0x1), al);     /* mov [es:edi+0x1], al */
    II(0x10195b57, 0x3)   add(edi, 0x2);                        /* add edi, 0x2 */
    II(0x10195b5a, 0x2)   cmp(al, 0);                           /* cmp al, 0x0 */
    II(0x10195b5c, 0x2)   jnzd(0x10195b44, -0x1a);              /* jnz 0x10195b44 */
l_0x10195b5e:
    II(0x10195b5e, 0x1)   popd(eax);                            /* pop eax */
    II(0x10195b5f, 0x1)   popd(es);                             /* pop es */
    II(0x10195b60, 0x1)   popd(ds);                             /* pop ds */
    II(0x10195b61, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195b62, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195b63, 0x1)   retd();                               /* ret */
FUNC_END

