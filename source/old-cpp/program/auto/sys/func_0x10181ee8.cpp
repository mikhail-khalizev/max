FUNC_BEGIN(/* sys */ 0x10181ee8, 0xe700c62248eea307, 0x20, ({0x53, 0x31, 0xdb, 0xe8, 0xc8, 0xfe, 0xff, 0xff, 0x5b, 0xc3}))
    II(0x10181ee8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10181ee9, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10181eeb, 0x5)   calld(/* sys */ 0x10181db8, -0x138);  /* call 0x10181db8 */
    II(0x10181ef0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10181ef1, 0x1)   retd();                               /* ret */
FUNC_END

