FUNC_BEGIN(0x00009c45, 0xab513706b6d87326, 0x10, ({0xb8, 0, 0x33, 0xcd, 0x21, 0x8a, 0xca, 0x8b, 0xdc, 0x8a, 0x57, 0x2, 0x40, 0xcd, 0x21, 0x91, 0x98, 0xc3}))
    II(0x00009c45, 0x3)   mov(ax, 0x3300);                      /* mov ax, 0x3300 */
    II(0x00009c48, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x00009c4a, 0x2)   mov(cl, dl);                          /* mov cl, dl */
    II(0x00009c4c, 0x2)   mov(bx, sp);                          /* mov bx, sp */
    II(0x00009c4e, 0x3)   mov(dl, memb_a16(ds, bx + 0x2));      /* mov dl, [bx+0x2] */
    II(0x00009c51, 0x1)   inc(ax);                              /* inc ax */
    II(0x00009c52, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x00009c54, 0x1)   xchg(cx, ax);                         /* xchg cx, ax */
    II(0x00009c55, 0x1)   cbw();                                /* cbw  */
    II(0x00009c56, 0x1)   retw();                               /* ret  */
FUNC_END

