FUNC_BEGIN(/* sys */ 0x10194a3d, 0x19ee11442dae9bb5, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x83, 0x3d, 0x54, 0x1a, 0x1c, 0x10, 0, 0x74, 0x26, 0x90, 0x90, 0x90, 0x90, 0x66, 0xba, 0x21, 0, 0xec, 0xc, 0x1, 0xee, 0x66, 0xba, 0x43, 0, 0xb0, 0x36, 0xee, 0x66, 0xba, 0x40, 0, 0x8b, 0x45, 0x8, 0xee, 0x8a, 0xc4, 0xee, 0x66, 0xba, 0x21, 0, 0xec, 0x24, 0xfe, 0xee, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194a3d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194a3e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194a40, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194a41, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194a42, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194a43, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194a44, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194a46, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194a48, 0x1)   pushd(es);                            /* push es */
    II(0x10194a49, 0x7)   cmp(memd_a32(ds, 0x101c1a54), 0);     /* cmp dword [0x101c1a54], 0x0 */
    II(0x10194a50, 0x2)   jzd(0x10194a78, 0x26);                /* jz 0x10194a78 */
//    II(0x10194a52, 0x1)   nop();                                /* nop */
//    II(0x10194a53, 0x1)   nop();                                /* nop */
//    II(0x10194a54, 0x1)   nop();                                /* nop */
//    II(0x10194a55, 0x1)   nop();                                /* nop */
    II(0x10194a56, 0x4)   mov(dx, 0x21);                        /* mov dx, 0x21 */
    II(0x10194a5a, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x10194a5b, 0x2)   or_(al, 0x1);                         /* or al, 0x1 */
    II(0x10194a5d, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x10194a5e, 0x4)   mov(dx, 0x43);                        /* mov dx, 0x43 */
    II(0x10194a62, 0x2)   mov(al, 0x36);                        /* mov al, 0x36 */
    II(0x10194a64, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x10194a65, 0x4)   mov(dx, 0x40);                        /* mov dx, 0x40 */
    II(0x10194a69, 0x3)   mov(eax, memd_a32(ss, ebp + 0x8));    /* mov eax, [ebp+0x8] */
    II(0x10194a6c, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x10194a6d, 0x2)   mov(al, ah);                          /* mov al, ah */
    II(0x10194a6f, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x10194a70, 0x4)   mov(dx, 0x21);                        /* mov dx, 0x21 */
    II(0x10194a74, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x10194a75, 0x2)   and_(al, 0xfe);                       /* and al, 0xfe */
    II(0x10194a77, 0x1)   outb(dx, al);                         /* out dx, al */
l_0x10194a78:
    II(0x10194a78, 0x1)   popd(es);                             /* pop es */
    II(0x10194a79, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194a7b, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194a7d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194a7e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194a7f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194a80, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194a81, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194a82, 0x1)   retd();                               /* ret */
FUNC_END

