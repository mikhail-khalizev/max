FUNC_BEGIN(/* sys */ 0x10185944, 0x40c92b7d294e0bbd, 0x20, ({0xb8, 0x8, 0x5b, 0x18, 0x10, 0xe8, 0xde, 0x5a, 0xfe, 0xff, 0x83, 0x3d, 0xa4, 0xa2, 0x20, 0x10, 0xff, 0x74, 0xe, 0xe8, 0, 0x2, 0, 0, 0x83, 0x3d, 0xa4, 0xa2, 0x20, 0x10, 0xff, 0x75, 0xf2, 0xc3}))
    II(0x10185944, 0x5)   mov(eax, /* sys */ 0x10185b08);       /* mov eax, 0x10185b08 */
    II(0x10185949, 0x5)   calld(/* sys */ 0x1016b42c, -0x1a522); /* call 0x1016b42c */
    II(0x1018594e, 0x7)   cmp(memd_a32(ds, 0x1020a2a4), -0x1 /* 0xff */); /* cmp dword [0x1020a2a4], 0xff */
    II(0x10185955, 0x2)   jzd(0x10185965, 0xe);                 /* jz 0x10185965 */
l_0x10185957:
    II(0x10185957, 0x5)   calld(/* sys */ 0x10185b5c, 0x200);   /* call 0x10185b5c */
    II(0x1018595c, 0x7)   cmp(memd_a32(ds, 0x1020a2a4), -0x1 /* 0xff */); /* cmp dword [0x1020a2a4], 0xff */
    II(0x10185963, 0x2)   jnzd(0x10185957, -0xe);               /* jnz 0x10185957 */
l_0x10185965:
    II(0x10185965, 0x1)   retd();                               /* ret */
FUNC_END

