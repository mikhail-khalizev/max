FUNC_BEGIN(/* sys */ 0x1018d3bf, 0x90a6f6b099eab546, 0x20, ({0x52, 0x89, 0xc2, 0xe8, 0xdb, 0x3, 0, 0, 0x89, 0x10, 0x5a, 0xc3}))
    II(0x1018d3bf, 0x1)   pushd(edx);                           /* push edx */
    II(0x1018d3c0, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1018d3c2, 0x5)   calld(/* sys */ 0x1018d7a2, 0x3db);   /* call 0x1018d7a2 */
    II(0x1018d3c7, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x1018d3c9, 0x1)   popd(edx);                            /* pop edx */
    II(0x1018d3ca, 0x1)   retd();                               /* ret */
FUNC_END

