FUNC_BEGIN(/* sys */ 0x1017cee0, 0x3e5b0653fd15b946, 0x20, ({0x51, 0x52, 0x56, 0x57, 0x89, 0xc6, 0x89, 0xc7, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x29, 0xc9, 0x49, 0x31, 0xc0, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x7, 0x41, 0x89, 0xc8, 0xe8, 0xde, 0xe0, 0xfe, 0xff, 0x89, 0xc2, 0x85, 0xc0, 0x74, 0x18, 0x89, 0xc7, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x57, 0x89, 0xc8, 0xc1, 0xe9, 0x2, 0xf2, 0xa5, 0x8a, 0xc8, 0x80, 0xe1, 0x3, 0xf2, 0xa4, 0x5f, 0x7, 0x89, 0xd0, 0x5f, 0x5e, 0x5a, 0x59, 0xc3}))
    II(0x1017cee0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017cee1, 0x1)   pushd(edx);                           /* push edx */
    II(0x1017cee2, 0x1)   pushd(esi);                           /* push esi */
    II(0x1017cee3, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017cee4, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1017cee6, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1017cee8, 0x1)   pushd(es);                            /* push es */
    II(0x1017cee9, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x1017ceeb, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x1017ceed, 0x2)   sub(ecx, ecx);                        /* sub ecx, ecx */
    II(0x1017ceef, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x1017cef0, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1017cef2, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x1017cef4, 0x2)   not_(ecx);                            /* not ecx */
    II(0x1017cef6, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x1017cef7, 0x1)   popd(es);                             /* pop es */
    II(0x1017cef8, 0x1)   inc(ecx);                             /* inc ecx */
    II(0x1017cef9, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1017cefb, 0x5)   calld(sys_malloc, -0x11f22);          /* call 0x1016afde */
    II(0x1017cf00, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1017cf02, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1017cf04, 0x2)   jzd(0x1017cf1e, 0x18);                /* jz 0x1017cf1e */
    II(0x1017cf06, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1017cf08, 0x1)   pushd(es);                            /* push es */
    II(0x1017cf09, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x1017cf0b, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x1017cf0d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017cf0e, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1017cf10, 0x3)   shr(ecx, 0x2);                        /* shr ecx, 0x2 */
    II(0x1017cf13, 0x2)   repne_a32 movsd_a32();                /* repne movsd */
    II(0x1017cf15, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x1017cf17, 0x3)   and_(cl, 0x3);                        /* and cl, 0x3 */
    II(0x1017cf1a, 0x2)   repne_a32 movsb_a32();                /* repne movsb */
    II(0x1017cf1c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017cf1d, 0x1)   popd(es);                             /* pop es */
l_0x1017cf1e:
    II(0x1017cf1e, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1017cf20, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017cf21, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017cf22, 0x1)   popd(edx);                            /* pop edx */
    II(0x1017cf23, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017cf24, 0x1)   retd();                               /* ret */
FUNC_END

