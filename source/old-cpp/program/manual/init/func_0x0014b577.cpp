FUNC_BEGIN(0x0014b577, 0xdbe25bdb27f6604c, 0x10, ({0x60, 0xa1, 0xe, 0, 0x3b, 0xc8, 0x76, 0x2, 0x8b, 0xc8, 0x8b, 0xfe, 0x8b, 0x36, 0xa, 0, 0xfc, 0xf3, 0xa4, 0x61, 0xc3}))
    II(0x0014b577, 0x1)   pusha();                              /* pusha  */
    II(0x0014b578, 0x3)   mov(ax, memw_a16(ds, 0xe));           /* mov ax, [0xe] */
    II(0x0014b57b, 0x2)   cmp(cx, ax);                          /* cmp cx, ax */
    II(0x0014b57d, 0x2)   jbew(0x0014b581, 0x2);                /* jbe 0x14b581 */
    II(0x0014b57f, 0x2)   mov(cx, ax);                          /* mov cx, ax */
l_0x0014b581:
    II(0x0014b581, 0x2)   mov(di, si);                          /* mov di, si */
    II(0x0014b583, 0x4)   mov(si, memw_a16(ds, 0xa));           /* mov si, [0xa] */
    II(0x0014b587, 0x1)   cld();                                /* cld  */
    II(0x0014b588, 0x2)   rep_a16 movsb_a16();                  /* rep movsb  */
    II(0x0014b58a, 0x1)   popa();                               /* popa  */
    II(0x0014b58b, 0x1)   retw();                               /* ret  */
FUNC_END

