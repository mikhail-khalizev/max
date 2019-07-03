FUNC_BEGIN(0x00011303, 0x332df5a99325585, 0x10, ({0x8f, 0x46, 0xfc, 0xf, 0xa9, 0xf, 0xa1, 0x66, 0x61, 0x5d, 0xcb}))
    II(0x00011303, 0x3)   popw(memw_a16(ss, bp - 0x4));         /* pop word [bp-0x4] */
    II(0x00011306, 0x2)   popw(gs);                             /* pop gs */
    II(0x00011308, 0x2)   popw(fs);                             /* pop fs */
    II(0x0001130a, 0x2)   popad();                              /* popad  */
    II(0x0001130c, 0x1)   popw(bp);                             /* pop bp */
    II(0x0001130d, 0x1)   retfw();                              /* retf  */
FUNC_END

