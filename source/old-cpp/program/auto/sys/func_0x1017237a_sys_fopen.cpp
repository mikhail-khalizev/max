FUNC_BEGIN(sys_fopen, 0xe700c60d2f8e2618, 0x20, ({0x53, 0x31, 0xdb, 0xe8, 0xbf, 0xff, 0xff, 0xff, 0x5b, 0xc3}))
    II(0x1017237a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017237b, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1017237d, 0x5)   calld(/* sys */ 0x10172341, -0x41);   /* call 0x10172341 */
    II(0x10172382, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10172383, 0x1)   retd();                               /* ret */
FUNC_END

