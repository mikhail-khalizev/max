FUNC_BEGIN(/* sys */ 0x10196628, 0xcdf25c710612a04d, 0x20, ({0x53, 0x89, 0xd3, 0xe8, 0x2, 0, 0, 0, 0x5b, 0xc3}))
    II(0x10196628, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10196629, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x1019662b, 0x5)   calld(/* sys */ 0x10196632, 0x2);     /* call 0x10196632 */
    II(0x10196630, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10196631, 0x1)   retd();                               /* ret */
FUNC_END

