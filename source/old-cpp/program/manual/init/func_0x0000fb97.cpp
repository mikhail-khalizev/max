FUNC_BEGIN(0x0000fb97, 0xda0ada3db8f9574f, 0x10, ({0x8b, 0xdc, 0x36, 0x8b, 0x47, 0x2, 0x36, 0x8b, 0x57, 0x4, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xd1, 0xe0, 0xd1, 0xd2, 0xc3}))
    II(0x0000fb97, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x0000fb99, 0x4)   mov(ax, memw_a16(ss, bx + 0x2));      /* mov ax, [ss:bx+0x2] */
    II(0x0000fb9d, 0x4)   mov(dx, memw_a16(ss, bx + 0x4));      /* mov dx, [ss:bx+0x4] */
    II(0x0000fba1, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0000fba3, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0000fba5, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0000fba7, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0000fba9, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0000fbab, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0000fbad, 0x2)   shl(ax, 0x1);                         /* shl ax, 1 */
    II(0x0000fbaf, 0x2)   rcl(dx, 0x1);                         /* rcl dx, 1 */
    II(0x0000fbb1, 0x1)   retw();                               /* ret  */
FUNC_END

