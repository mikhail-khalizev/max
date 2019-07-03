FUNC_BEGIN(/* sys */ 0x1018d71d, 0x5535d562d6e85fd8, 0x20, ({0x53, 0x52, 0xbb, 0x1, 0, 0, 0, 0x31, 0xd2, 0xe8, 0x6c, 0xfa, 0xfe, 0xff, 0x5a, 0x5b, 0xc3}))
    II(0x1018d71d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1018d71e, 0x1)   pushd(edx);                           /* push edx */
    II(0x1018d71f, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x1018d724, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1018d726, 0x5)   calld(sys_lseek, -0x10594);           /* call 0x1017d197 */
    II(0x1018d72b, 0x1)   popd(edx);                            /* pop edx */
    II(0x1018d72c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1018d72d, 0x1)   retd();                               /* ret */
FUNC_END

