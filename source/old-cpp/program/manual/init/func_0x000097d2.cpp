FUNC_BEGIN(0x000097d2, 0xcdef09574d14d793, 0x10, ({0x32, 0xed, 0xe3, 0x6, 0xd1, 0xea, 0xd1, 0xd8, 0xe2, 0xfa, 0xc3}))
    II(0x000097d2, 0x2)   xor_(ch, ch);                         /* xor ch, ch */
    II(0x000097d4, 0x2)   jcxzw(0x000097dc, 0x6);               /* jcxz 0x97dc */
l_0x000097d6:
    II(0x000097d6, 0x2)   shr(dx, 0x1);                         /* shr dx, 1 */
    II(0x000097d8, 0x2)   rcr(ax, 0x1);                         /* rcr ax, 1 */
    II(0x000097da, 0x2)   loopw_a16(0x000097d6, -0x6);          /* loop 0x97d6 */
l_0x000097dc:
    II(0x000097dc, 0x1)   retw();                               /* ret  */
FUNC_END

