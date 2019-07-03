FUNC_BEGIN(/* sys */ 0x10181fae, 0x361d3a92dc93a228, 0x20, ({0x6, 0x51, 0x53, 0x52, 0xdb, 0xe3, 0x50, 0xd9, 0x3c, 0x24, 0x58, 0x80, 0xfc, 0x3, 0x74, 0x1, 0x45, 0x9, 0xed, 0x74, 0x5, 0xe8, 0x16, 0, 0, 0, 0x9b, 0xdb, 0xe3, 0xd9, 0x2d, 0x44, 0x1c, 0x1c, 0x10, 0xd9, 0xee, 0xd9, 0xee, 0xd9, 0xee, 0xd9, 0xee, 0x5a, 0x5b, 0x59, 0x7, 0xc3}))
    II(0x10181fae, 0x1)   pushd(es);                            /* push es */
    II(0x10181faf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10181fb0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10181fb1, 0x1)   pushd(edx);                           /* push edx */
    II(0x10181fb2, 0x2)   fninit();                             /* fninit */
    II(0x10181fb4, 0x1)   pushd(eax);                           /* push eax */
    II(0x10181fb5, 0x3)   fnstcw(memw_a32(ss, esp));            /* fnstcw word [esp] */
    II(0x10181fb8, 0x1)   popd(eax);                            /* pop eax */
    II(0x10181fb9, 0x3)   cmp(ah, 0x3);                         /* cmp ah, 0x3 */
    II(0x10181fbc, 0x2)   jzd(0x10181fbf, 0x1);                 /* jz 0x10181fbf */
    II(0x10181fbe, 0x1)   inc(ebp);                             /* inc ebp */
l_0x10181fbf:
    II(0x10181fbf, 0x2)   or_(ebp, ebp);                        /* or ebp, ebp */
    II(0x10181fc1, 0x2)   jzd(0x10181fc8, 0x5);                 /* jz 0x10181fc8 */
    II(0x10181fc3, 0x5)   calld(/* sys */ 0x10181fde, 0x16);    /* call 0x10181fde */
l_0x10181fc8:
    II(0x10181fc8, 0x1)   wait();                               /* wait */
    II(0x10181fc9, 0x2)   fninit();                             /* fninit */
    II(0x10181fcb, 0x6)   fldcw(memw_a32(ds, 0x101c1c44));      /* fldcw word [0x101c1c44] */
    II(0x10181fd1, 0x2)   fldz();                               /* fldz */
    II(0x10181fd3, 0x2)   fldz();                               /* fldz */
    II(0x10181fd5, 0x2)   fldz();                               /* fldz */
    II(0x10181fd7, 0x2)   fldz();                               /* fldz */
    II(0x10181fd9, 0x1)   popd(edx);                            /* pop edx */
    II(0x10181fda, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10181fdb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10181fdc, 0x1)   popd(es);                             /* pop es */
    II(0x10181fdd, 0x1)   retd();                               /* ret */
FUNC_END

