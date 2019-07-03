FUNC_BEGIN(/* sys */ 0x10194b71, 0x1fad3439da3c9975, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x83, 0x3d, 0x54, 0x1a, 0x1c, 0x10, 0, 0x74, 0xc, 0x90, 0x90, 0x90, 0x90, 0x66, 0xba, 0x21, 0, 0xec, 0x24, 0xfe, 0xee, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194b71, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194b72, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194b74, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194b75, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194b76, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194b77, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194b78, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194b7a, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194b7c, 0x1)   pushd(es);                            /* push es */
    II(0x10194b7d, 0x7)   cmp(memd_a32(ds, 0x101c1a54), 0);     /* cmp dword [0x101c1a54], 0x0 */
    II(0x10194b84, 0x2)   jzd(0x10194b92, 0xc);                 /* jz 0x10194b92 */
//    II(0x10194b86, 0x1)   nop();                                /* nop */
//    II(0x10194b87, 0x1)   nop();                                /* nop */
//    II(0x10194b88, 0x1)   nop();                                /* nop */
//    II(0x10194b89, 0x1)   nop();                                /* nop */
    II(0x10194b8a, 0x4)   mov(dx, 0x21);                        /* mov dx, 0x21 */
    II(0x10194b8e, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x10194b8f, 0x2)   and_(al, 0xfe);                       /* and al, 0xfe */
    II(0x10194b91, 0x1)   outb(dx, al);                         /* out dx, al */
l_0x10194b92:
    II(0x10194b92, 0x1)   popd(es);                             /* pop es */
    II(0x10194b93, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194b95, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194b97, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194b98, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194b99, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194b9a, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194b9b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194b9c, 0x1)   retd();                               /* ret */
FUNC_END

