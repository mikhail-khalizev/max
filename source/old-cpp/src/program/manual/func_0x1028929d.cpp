FUNC_BEGIN(0x1028929d, 0x1c41fc284dce50f3, 0x20, ({0x51, 0xb9, 0xff, 0xff, 0, 0, 0x90, 0xe2, 0xfd, 0x59, 0xc3}))
//    II(0x1028929d, 0x1)   pushd(ecx);                           /* push ecx */
//    II(0x1028929e, 0x5)   mov(ecx, 0xffff);                     /* mov ecx, 0xffff */
//l_0x102892a3:
//    II(0x102892a3, 0x1)   nop();                                /* nop  */
//    II(0x102892a4, 0x2)   loopd_a32(0x102892a3, -0x3);          /* loop 0x102892a3 */
//    II(0x102892a6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x102892a7, 0x1)   retd();                               /* ret  */
FUNC_END

