FUNC_BEGIN(0x00009fb7, 0xea7cdac9a69cc378, 0x10, ({0xe8, 0x43, 0xa2, 0x80, 0xf9, 0x1, 0x1b, 0xd2, 0xe4, 0x92, 0x8b, 0xd8, 0x83, 0xe3, 0x2, 0x80, 0xfb, 0x2, 0x1b, 0xdb, 0x33, 0xda, 0xb, 0xf3, 0xc3}))
    II(0x00009fb7, 0x3)   callw(0x000041fd, -0x5dbd);           /* call 0x41fd */
    II(0x00009fba, 0x3)   cmp(cl, 0x1);                         /* cmp cl, 0x1 */
    II(0x00009fbd, 0x2)   sbb(dx, dx);                          /* sbb dx, dx */
    II(0x00009fbf, 0x2)   inb(al, 0x92);                        /* in al, 0x92 */
    II(0x00009fc1, 0x2)   mov(bx, ax);                          /* mov bx, ax */
    II(0x00009fc3, 0x3)   and_(bx, 0x2);                        /* and bx, 0x2 */
    II(0x00009fc6, 0x3)   cmp(bl, 0x2);                         /* cmp bl, 0x2 */
    II(0x00009fc9, 0x2)   sbb(bx, bx);                          /* sbb bx, bx */
    II(0x00009fcb, 0x2)   xor_(bx, dx);                         /* xor bx, dx */
    II(0x00009fcd, 0x2)   or_(si, bx);                          /* or si, bx */
    II(0x00009fcf, 0x1)   retw();                               /* ret  */
FUNC_END

