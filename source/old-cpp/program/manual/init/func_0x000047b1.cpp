FUNC_BEGIN(0x000047b1, 0x29b55378bbc365ff, 0x10, ({0xe, 0xe8, 0xbb, 0xfb, 0xfb, 0xc3}))
    II(0x000047b1, 0x1)   pushw(cs);                            /* push cs */
    II(0x000047b2, 0x3)   callw(0x00004370, -0x445);            /* call 0x4370 */
    II(0x000047b5, 0x1)   sti();                                /* sti  */
    II(0x000047b6, 0x1)   retw();                               /* ret  */
FUNC_END

