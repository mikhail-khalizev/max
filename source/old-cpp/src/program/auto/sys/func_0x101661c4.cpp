FUNC_BEGIN(/* sys */ 0x101661c4, 0x6692ed499b387d52, 0x20, ({0x51, 0x56, 0x57, 0x89, 0xd9, 0x89, 0xd7, 0x89, 0xc6, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x31, 0xc0, 0xf3, 0xa6, 0x74, 0x5, 0x19, 0xc0, 0x83, 0xd8, 0xff, 0x7, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x101661c4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101661c5, 0x1)   pushd(esi);                           /* push esi */
    II(0x101661c6, 0x1)   pushd(edi);                           /* push edi */
    II(0x101661c7, 0x2)   mov(ecx, ebx);                        /* mov ecx, ebx */
    II(0x101661c9, 0x2)   mov(edi, edx);                        /* mov edi, edx */
    II(0x101661cb, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x101661cd, 0x1)   pushd(es);                            /* push es */
    II(0x101661ce, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x101661d0, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x101661d2, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101661d4, 0x2)   repe_a32 cmpsb_a32();                 /* rep cmpsb */
    II(0x101661d6, 0x2)   jzd(0x101661dd, 0x5);                 /* jz 0x101661dd */
    II(0x101661d8, 0x2)   sbb(eax, eax);                        /* sbb eax, eax */
    II(0x101661da, 0x3)   sbb(eax, -0x1 /* 0xff */);            /* sbb eax, 0xff */
l_0x101661dd:
    II(0x101661dd, 0x1)   popd(es);                             /* pop es */
    II(0x101661de, 0x1)   popd(edi);                            /* pop edi */
    II(0x101661df, 0x1)   popd(esi);                            /* pop esi */
    II(0x101661e0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101661e1, 0x1)   retd();                               /* ret */
FUNC_END

