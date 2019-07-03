FUNC_BEGIN(/* sys */ 0x10180f0b, 0xc5ac172aa84c04f0, 0x20, ({0x51, 0x56, 0x89, 0xc6, 0xb9, 0xf8, 0xe, 0x18, 0x10, 0xe8, 0xcb, 0x1, 0, 0, 0xc6, 0x4, 0x6, 0, 0x5e, 0x59, 0xc3}))
    II(0x10180f0b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10180f0c, 0x1)   pushd(esi);                           /* push esi */
    II(0x10180f0d, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10180f0f, 0x5)   mov(ecx, /* sys */ 0x10180ef8);       /* mov ecx, 0x10180ef8 */
    II(0x10180f14, 0x5)   calld(/* sys */ 0x101810e4, 0x1cb);   /* call 0x101810e4 */
    II(0x10180f19, 0x4)   mov(memb_a32(ds, esi + eax), 0);      /* mov byte [esi+eax], 0x0 */
    II(0x10180f1d, 0x1)   popd(esi);                            /* pop esi */
    II(0x10180f1e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10180f1f, 0x1)   retd();                               /* ret */
FUNC_END

