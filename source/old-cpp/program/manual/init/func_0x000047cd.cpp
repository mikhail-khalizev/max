FUNC_BEGIN(0x000047cd, 0x8c43c86355be0481, 0x10, ({0x8b, 0xdc, 0x36, 0x8b, 0x47, 0x2, 0x5, 0x10, 0, 0xd1, 0xd8, 0xb1, 0x3, 0xd3, 0xe8, 0xc3}))
    II(0x000047cd, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x000047cf, 0x4)   mov(ax, memw_a16(ss, bx + 0x2));      /* mov ax, [ss:bx+0x2] */
    II(0x000047d3, 0x3)   add(ax, 0x10);                        /* add ax, 0x10 */
    II(0x000047d6, 0x2)   rcr(ax, 0x1);                         /* rcr ax, 1 */
    II(0x000047d8, 0x2)   mov(cl, 0x3);                         /* mov cl, 0x3 */
    II(0x000047da, 0x2)   shr(ax, cl);                          /* shr ax, cl */
    II(0x000047dc, 0x1)   retw();                               /* ret  */
FUNC_END

