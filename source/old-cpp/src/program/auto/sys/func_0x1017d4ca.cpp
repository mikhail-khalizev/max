FUNC_BEGIN(/* sys */ 0x1017d4ca, 0xe08f7aaec2fadbf4, 0x20, ({0x56, 0x57, 0x89, 0xc7, 0x8b, 0x44, 0x24, 0xc, 0x89, 0xde, 0x1e, 0x6, 0x57, 0x91, 0x8e, 0xd8, 0x8e, 0xc2, 0x89, 0xc8, 0xc1, 0xe9, 0x2, 0xf2, 0xa5, 0x8a, 0xc8, 0x80, 0xe1, 0x3, 0xf2, 0xa4, 0x58, 0x7, 0x1f, 0x5f, 0x5e, 0xc2, 0x4, 0}))
    II(0x1017d4ca, 0x1)   pushd(esi);                           /* push esi */
    II(0x1017d4cb, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017d4cc, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1017d4ce, 0x4)   mov(eax, memd_a32(ss, esp + 0xc));    /* mov eax, [esp+0xc] */
    II(0x1017d4d2, 0x2)   mov(esi, ebx);                        /* mov esi, ebx */
    II(0x1017d4d4, 0x1)   pushd(ds);                            /* push ds */
    II(0x1017d4d5, 0x1)   pushd(es);                            /* push es */
    II(0x1017d4d6, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017d4d7, 0x1)   xchg(ecx, eax);                       /* xchg ecx, eax */
    II(0x1017d4d8, 0x2)   mov(ds, eax);                         /* mov ds, eax */
    II(0x1017d4da, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x1017d4dc, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1017d4de, 0x3)   shr(ecx, 0x2);                        /* shr ecx, 0x2 */
    II(0x1017d4e1, 0x2)   repne_a32 movsd_a32();                /* repne movsd */
    II(0x1017d4e3, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x1017d4e5, 0x3)   and_(cl, 0x3);                        /* and cl, 0x3 */
    II(0x1017d4e8, 0x2)   repne_a32 movsb_a32();                /* repne movsb */
    II(0x1017d4ea, 0x1)   popd(eax);                            /* pop eax */
    II(0x1017d4eb, 0x1)   popd(es);                             /* pop es */
    II(0x1017d4ec, 0x1)   popd(ds);                             /* pop ds */
    II(0x1017d4ed, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017d4ee, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017d4ef, 0x3)   retd(0x4);                            /* ret 0x4 */
FUNC_END

