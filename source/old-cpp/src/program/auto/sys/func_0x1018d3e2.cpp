FUNC_BEGIN(/* sys */ 0x1018d3e2, 0x90a7931bdd917ea6, 0x20, ({0x52, 0x89, 0xc2, 0xe8, 0xbe, 0x3, 0, 0, 0x89, 0x10, 0x5a, 0xc3}))
    II(0x1018d3e2, 0x1)   pushd(edx);                           /* push edx */
    II(0x1018d3e3, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1018d3e5, 0x5)   calld(/* sys */ 0x1018d7a8, 0x3be);   /* call 0x1018d7a8 */
    II(0x1018d3ea, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x1018d3ec, 0x1)   popd(edx);                            /* pop edx */
    II(0x1018d3ed, 0x1)   retd();                               /* ret */
FUNC_END

