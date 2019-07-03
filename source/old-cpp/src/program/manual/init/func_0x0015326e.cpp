FUNC_BEGIN(0x0015326e, 0xe689230d9212cfd0, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0xb3, 0x1, 0xe9, 0xca, 0x9}))
    II(0x0015326e, 0x1)   pushw(bp);                            /* push bp */
    II(0x0015326f, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x00153271, 0x1)   pushw(si);                            /* push si */
    II(0x00153272, 0x1)   pushw(di);                            /* push di */
    II(0x00153273, 0x2)   mov(bl, 0x1);                         /* mov bl, 0x1 */
    II(0x00153275, 0x3)   jmpw_func(0x00153c42, 0x9ca);         /* jmp 0x153c42 */
FUNC_END

