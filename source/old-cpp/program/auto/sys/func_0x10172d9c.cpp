FUNC_BEGIN(/* sys */ 0x10172d9c, 0xa9a346fd189a5b7a, 0x20, ({0x60, 0x1e, 0x6, 0xf, 0xa0, 0xf, 0xa8, 0x89, 0xe5, 0xfc, 0xe8, 0x25, 0x9c, 0xff, 0xff, 0xba, 0x60, 0, 0, 0, 0x29, 0xc0, 0xec, 0x8b, 0x1d, 0xe4, 0xe1, 0x1b, 0x10, 0x89, 0xc2, 0x85, 0xdb, 0x75, 0x33, 0x83, 0x3d, 0x5c, 0xe8, 0x1b, 0x10, 0x1, 0xf, 0x94, 0xc0, 0x25, 0xff, 0, 0, 0, 0x74, 0x1a, 0xf6, 0x5, 0x68, 0xe8, 0x1b, 0x10, 0x1, 0x74, 0x19, 0xc7, 0x5, 0x6c, 0xe8, 0x1b, 0x10, 0x2, 0, 0, 0, 0xe8, 0xfc, 0x34, 0x1, 0, 0x31, 0xc0, 0x66, 0x89, 0xd0, 0xe8, 0x12, 0, 0, 0, 0xb0, 0x20, 0xba, 0x20, 0, 0, 0, 0xee, 0xf, 0xa9, 0xf, 0xa1, 0x7, 0x1f, 0x61, 0xcf}))
    II(0x10172d9c, 0x1)   pushad();                             /* pushad */
    II(0x10172d9d, 0x1)   pushd(ds);                            /* push ds */
    II(0x10172d9e, 0x1)   pushd(es);                            /* push es */
    II(0x10172d9f, 0x2)   pushd(fs);                            /* push fs */
    II(0x10172da1, 0x2)   pushd(gs);                            /* push gs */
    II(0x10172da3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10172da5, 0x1)   cld();                                /* cld */
    II(0x10172da6, 0x5)   calld(/* sys */ 0x1016c9d0, -0x63db); /* call 0x1016c9d0 */
    II(0x10172dab, 0x5)   mov(edx, 0x60);                       /* mov edx, 0x60 */
    II(0x10172db0, 0x2)   sub(eax, eax);                        /* sub eax, eax */
    II(0x10172db2, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x10172db3, 0x6)   mov(ebx, memd_a32(ds, 0x101be1e4));   /* mov ebx, [0x101be1e4] */
    II(0x10172db9, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10172dbb, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x10172dbd, 0x2)   jnzd(0x10172df2, 0x33);               /* jnz 0x10172df2 */
    II(0x10172dbf, 0x7)   cmp(memd_a32(ds, 0x101be85c), 0x1);   /* cmp dword [0x101be85c], 0x1 */
    II(0x10172dc6, 0x3)   setz(al);                             /* setz al */
    II(0x10172dc9, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10172dce, 0x2)   jzd(0x10172dea, 0x1a);                /* jz 0x10172dea */
    II(0x10172dd0, 0x7)   test(memb_a32(ds, 0x101be868), 0x1);  /* test byte [0x101be868], 0x1 */
    II(0x10172dd7, 0x2)   jzd(0x10172df2, 0x19);                /* jz 0x10172df2 */
    II(0x10172dd9, 0xa)   mov(memd_a32(ds, 0x101be86c), 0x2);   /* mov dword [0x101be86c], 0x2 */
    II(0x10172de3, 0x5)   calld(/* sys */ 0x101862e4, 0x134fc); /* call 0x101862e4 */
    II(0x10172de8, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x10172dea:
    II(0x10172dea, 0x3)   mov(ax, dx);                          /* mov ax, dx */
    II(0x10172ded, 0x5)   calld(/* sys */ 0x10172e04, 0x12);    /* call 0x10172e04 */
l_0x10172df2:
    II(0x10172df2, 0x2)   mov(al, 0x20);                        /* mov al, 0x20 */
    II(0x10172df4, 0x5)   mov(edx, 0x20);                       /* mov edx, 0x20 */
    II(0x10172df9, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x10172dfa, 0x2)   popd(gs);                             /* pop gs */
    II(0x10172dfc, 0x2)   popd(fs);                             /* pop fs */
    II(0x10172dfe, 0x1)   popd(es);                             /* pop es */
    II(0x10172dff, 0x1)   popd(ds);                             /* pop ds */
    II(0x10172e00, 0x1)   popad();                              /* popad */
    II(0x10172e01, 0x1)   iretd();                              /* iretd */
FUNC_END

