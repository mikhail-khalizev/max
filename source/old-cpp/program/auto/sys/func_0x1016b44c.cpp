FUNC_BEGIN(/* sys */ 0x1016b44c, 0x81d78fae85a1ccc4, 0x20, ({0x52, 0x31, 0xd2, 0x89, 0x15, 0x7c, 0xfb, 0x1c, 0x10, 0x5a, 0xc3}))
    II(0x1016b44c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016b44d, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1016b44f, 0x6)   mov(memd_a32(ds, 0x101cfb7c), edx);   /* mov [0x101cfb7c], edx */
    II(0x1016b455, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016b456, 0x1)   retd();                               /* ret */
FUNC_END

