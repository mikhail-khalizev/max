FUNC_BEGIN(0x00153808, 0xcdef09574d14d79b, 0x10, ({0x32, 0xed, 0xe3, 0x6, 0xd1, 0xea, 0xd1, 0xd8, 0xe2, 0xfa, 0xcb}))
    II(0x00153808, 0x2)   xor_(ch, ch);                         /* xor ch, ch */
    II(0x0015380a, 0x2)   jcxzw(0x00153812, 0x6);               /* jcxz 0x153812 */
l_0x0015380c:
    II(0x0015380c, 0x2)   shr(dx, 0x1);                         /* shr dx, 1 */
    II(0x0015380e, 0x2)   rcr(ax, 0x1);                         /* rcr ax, 1 */
    II(0x00153810, 0x2)   loopw_a16(0x0015380c, -0x6);          /* loop 0x15380c */
l_0x00153812:
    II(0x00153812, 0x1)   retfw();                              /* retf  */
FUNC_END

