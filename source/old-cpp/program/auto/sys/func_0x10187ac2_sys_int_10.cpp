FUNC_BEGIN(sys_int_10, 0xa16fb5874ab, 0x20, ({0xcd, 0x10, 0xc3}))
    II(0x10187ac2, 0x2)   int_(0x10);                           /* int 0x10 */
    II(0x10187ac4, 0x1)   retd();                               /* ret */
FUNC_END

