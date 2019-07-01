FUNC_BEGIN(0x00004885, 0xa16fb5ea229, 0x10, ({0x16, 0x1f, 0xc3}))
    II(0x00004885, 0x1)   pushw(ss);                            /* push ss */
    II(0x00004886, 0x1)   popw(ds);                             /* pop ds */
    II(0x00004887, 0x1)   retw();                               /* ret  */
FUNC_END

