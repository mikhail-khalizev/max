FUNC_BEGIN(/* sys */ 0x10167dd4, 0x48df7e20385dcc03, 0x20, ({0xe8, 0xd3, 0xff, 0xff, 0xff, 0x83, 0x3d, 0xbc, 0xdd, 0x1b, 0x10, 0, 0x74, 0x4, 0x85, 0xc0, 0x75, 0x3, 0x31, 0xc0, 0xc3, 0x8b, 0x40, 0x2c, 0xc3}))
    II(0x10167dd4, 0x5)   calld(/* sys */ 0x10167dac, -0x2d);   /* call 0x10167dac */
    II(0x10167dd9, 0x7)   cmp(memd_a32(ds, 0x101bddbc), 0);     /* cmp dword [0x101bddbc], 0x0 */
    II(0x10167de0, 0x2)   jzd(0x10167de6, 0x4);                 /* jz 0x10167de6 */
    II(0x10167de2, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10167de4, 0x2)   jnzd(0x10167de9, 0x3);                /* jnz 0x10167de9 */
l_0x10167de6:
    II(0x10167de6, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10167de8, 0x1)   retd();                               /* ret */
l_0x10167de9:
    II(0x10167de9, 0x3)   mov(eax, memd_a32(ds, eax + 0x2c));   /* mov eax, [eax+0x2c] */
    II(0x10167dec, 0x1)   retd();                               /* ret */
FUNC_END

