FUNC_BEGIN(/* sys */ 0x10168de8, 0x8675eae7702900a0, 0x20, ({0x52, 0x83, 0x3d, 0xbc, 0xdd, 0x1b, 0x10, 0, 0x74, 0x1e, 0x31, 0xd2, 0xe8, 0x7, 0xf1, 0xff, 0xff, 0x85, 0xc0, 0x74, 0x15, 0xf6, 0x40, 0x4, 0x1, 0x74, 0xd, 0xf6, 0x40, 0x6, 0x2, 0x74, 0x7, 0xb8, 0x1, 0, 0, 0, 0x5a, 0xc3, 0x31, 0xc0, 0x5a, 0xc3}))
    II(0x10168de8, 0x1)   pushd(edx);                           /* push edx */
    II(0x10168de9, 0x7)   cmp(memd_a32(ds, 0x101bddbc), 0);     /* cmp dword [0x101bddbc], 0x0 */
    II(0x10168df0, 0x2)   jzd(0x10168e10, 0x1e);                /* jz 0x10168e10 */
    II(0x10168df2, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10168df4, 0x5)   calld(/* sys */ 0x10167f00, -0xef9);  /* call 0x10167f00 */
    II(0x10168df9, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10168dfb, 0x2)   jzd(0x10168e12, 0x15);                /* jz 0x10168e12 */
    II(0x10168dfd, 0x4)   test(memb_a32(ds, eax + 0x4), 0x1);   /* test byte [eax+0x4], 0x1 */
    II(0x10168e01, 0x2)   jzd(0x10168e10, 0xd);                 /* jz 0x10168e10 */
    II(0x10168e03, 0x4)   test(memb_a32(ds, eax + 0x6), 0x2);   /* test byte [eax+0x6], 0x2 */
    II(0x10168e07, 0x2)   jzd(0x10168e10, 0x7);                 /* jz 0x10168e10 */
    II(0x10168e09, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x10168e0e, 0x1)   popd(edx);                            /* pop edx */
    II(0x10168e0f, 0x1)   retd();                               /* ret */
l_0x10168e10:
    II(0x10168e10, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x10168e12:
    II(0x10168e12, 0x1)   popd(edx);                            /* pop edx */
    II(0x10168e13, 0x1)   retd();                               /* ret */
FUNC_END

