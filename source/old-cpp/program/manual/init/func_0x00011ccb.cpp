FUNC_BEGIN(0x00011ccb, 0x29b5537e9380d262, 0x10, ({0xf5, 0x1b, 0xdb, 0x23, 0xc3, 0xc3}))
    II(0x00011ccb, 0x1)   cmc();                                /* cmc  */
    II(0x00011ccc, 0x2)   sbb(bx, bx);                          /* sbb bx, bx */
    II(0x00011cce, 0x2)   and_(ax, bx);                         /* and ax, bx */
    II(0x00011cd0, 0x1)   retw();                               /* ret  */
FUNC_END

