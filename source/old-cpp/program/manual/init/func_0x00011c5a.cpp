FUNC_BEGIN(0x00011c5a, 0x28253ca1ccca1, 0x10, ({0x5e, 0x33, 0xc0, 0xc3}))
    II(0x00011c5a, 0x1)   popw(si);                             /* pop si */
    II(0x00011c5b, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00011c5d, 0x1)   retw();                               /* ret  */
FUNC_END

