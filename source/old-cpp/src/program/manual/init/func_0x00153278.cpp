FUNC_BEGIN(0x00153278, 0xe689230d9227669c, 0x10, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0xb3, 0, 0xe9, 0xc0, 0x9}))
    II(0x00153278, 0x1)   pushw(bp);                            /* push bp */
    II(0x00153279, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0015327b, 0x1)   pushw(si);                            /* push si */
    II(0x0015327c, 0x1)   pushw(di);                            /* push di */
    II(0x0015327d, 0x2)   mov(bl, 0);                           /* mov bl, 0x0 */
    II(0x0015327f, 0x3)   jmpw_func(0x00153c42, 0x9c0);         /* jmp 0x153c42 */
FUNC_END

