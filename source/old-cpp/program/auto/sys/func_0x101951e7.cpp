FUNC_BEGIN(/* sys */ 0x101951e7, 0xf831c6bcf57143ac, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x1e, 0x1e, 0x7, 0xbf, 0x60, 0x1a, 0x1c, 0x10, 0x8b, 0x5d, 0x8, 0xc5, 0x35, 0xb0, 0x1a, 0x1c, 0x10, 0x8b, 0x34, 0x9e, 0x83, 0xfe, 0xff, 0x75, 0xc, 0x90, 0x90, 0x90, 0x90, 0x33, 0xc0, 0x1f, 0xeb, 0x11, 0x90, 0x90, 0x90, 0xb9, 0x50, 0, 0, 0, 0xfc, 0xf2, 0xa4, 0x1f, 0xb8, 0x60, 0x1a, 0x1c, 0x10, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x101951e7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101951e8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101951ea, 0x1)   pushd(esi);                           /* push esi */
    II(0x101951eb, 0x1)   pushd(edi);                           /* push edi */
    II(0x101951ec, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101951ed, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101951ee, 0x2)   pushd(fs);                            /* push fs */
    II(0x101951f0, 0x2)   pushd(gs);                            /* push gs */
    II(0x101951f2, 0x1)   pushd(es);                            /* push es */
    II(0x101951f3, 0x1)   pushd(ds);                            /* push ds */
    II(0x101951f4, 0x1)   pushd(ds);                            /* push ds */
    II(0x101951f5, 0x1)   popd(es);                             /* pop es */
    II(0x101951f6, 0x5)   mov(edi, 0x101c1a60);                 /* mov edi, 0x101c1a60 */
    II(0x101951fb, 0x3)   mov(ebx, memd_a32(ss, ebp + 0x8));    /* mov ebx, [ebp+0x8] */
    II(0x101951fe, 0x6)   lds(esi, ds, 0x101c1ab0);             /* lds esi, [0x101c1ab0] */
    II(0x10195204, 0x3)   mov(esi, memd_a32(ds, esi + ebx * 0x4)); /* mov esi, [esi+ebx*4] */
    II(0x10195207, 0x3)   cmp(esi, -0x1 /* 0xff */);            /* cmp esi, 0xff */
    II(0x1019520a, 0x2)   jnzd(0x10195218, 0xc);                /* jnz 0x10195218 */
//    II(0x1019520c, 0x1)   nop();                                /* nop */
//    II(0x1019520d, 0x1)   nop();                                /* nop */
//    II(0x1019520e, 0x1)   nop();                                /* nop */
//    II(0x1019520f, 0x1)   nop();                                /* nop */
    II(0x10195210, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10195212, 0x1)   popd(ds);                             /* pop ds */
    II(0x10195213, 0x2)   jmpd(0x10195226, 0x11);               /* jmp 0x10195226 */
//  II(0x10195215, 0x3)   /* Недостижимый код. */
l_0x10195218:
    II(0x10195218, 0x5)   mov(ecx, 0x50);                       /* mov ecx, 0x50 */
    II(0x1019521d, 0x1)   cld();                                /* cld */
    II(0x1019521e, 0x2)   repne_a32 movsb_a32();                /* repne movsb */
    II(0x10195220, 0x1)   popd(ds);                             /* pop ds */
    II(0x10195221, 0x5)   mov(eax, 0x101c1a60);                 /* mov eax, 0x101c1a60 */
l_0x10195226:
    II(0x10195226, 0x1)   popd(es);                             /* pop es */
    II(0x10195227, 0x2)   popd(gs);                             /* pop gs */
    II(0x10195229, 0x2)   popd(fs);                             /* pop fs */
    II(0x1019522b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019522c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019522d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1019522e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019522f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10195230, 0x1)   retd();                               /* ret */
FUNC_END

