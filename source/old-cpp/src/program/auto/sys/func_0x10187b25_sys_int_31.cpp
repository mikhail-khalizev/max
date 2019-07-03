FUNC_BEGIN(sys_int_31, 0xa16fb587c82, 0x20, ({0xcd, 0x31, 0xc3}))
    II(0x10187b25, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x10187b27, 0x1)   retd();                               /* ret */
FUNC_END

