FUNC_BEGIN(sys_int_16, 0xa16fb58773f, 0x20, ({0xcd, 0x16, 0xc3}))
    II(0x10187ad4, 0x2)   int_(0x16);                           /* int 0x16 */
    II(0x10187ad6, 0x1)   retd();                               /* ret */
FUNC_END

