FUNC_BEGIN(sys_display_draw_0, 0xb9fd4e23a3868cd8, 0x20, ({0x53, 0x52, 0xe8, 0x21, 0x9, 0, 0, 0x83, 0x3d, 0xbc, 0xdd, 0x1b, 0x10, 0, 0x74, 0xe, 0x85, 0xc0, 0x74, 0xa, 0x8d, 0x50, 0x8, 0x31, 0xdb, 0xe8, 0x5e, 0, 0, 0, 0x5a, 0x5b, 0xc3}))
    II(0x10167484, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10167485, 0x1)   pushd(edx);                           /* push edx */
    II(0x10167486, 0x5)   calld(/* sys */ 0x10167dac, 0x921);   /* call 0x10167dac */
    II(0x1016748b, 0x7)   cmp(memd_a32(ds, 0x101bddbc), 0);     /* cmp dword [0x101bddbc], 0x0 */
    II(0x10167492, 0x2)   jzd(0x101674a2, 0xe);                 /* jz 0x101674a2 */
    II(0x10167494, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10167496, 0x2)   jzd(0x101674a2, 0xa);                 /* jz 0x101674a2 */
    II(0x10167498, 0x3)   lea(edx, eax + 0x8);                  /* lea edx, [eax+0x8] */
    II(0x1016749b, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1016749d, 0x5)   calld(/* sys */ 0x10167500, 0x5e);    /* call 0x10167500 */
l_0x101674a2:
    II(0x101674a2, 0x1)   popd(edx);                            /* pop edx */
    II(0x101674a3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101674a4, 0x1)   retd();                               /* ret */
FUNC_END

