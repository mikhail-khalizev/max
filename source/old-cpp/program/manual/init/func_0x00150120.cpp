FUNC_BEGIN(0x00150120, 0xa3b7dab664ec55, 0x10, ({0x1f, 0x5f, 0x5e, 0x5d, 0xcb}))
    II(0x00150120, 0x1)   popw(ds);                             /* pop ds */
    II(0x00150121, 0x1)   popw(di);                             /* pop di */
    II(0x00150122, 0x1)   popw(si);                             /* pop si */
    II(0x00150123, 0x1)   popw(bp);                             /* pop bp */
    II(0x00150124, 0x1)   retfw();                              /* retf  */
FUNC_END

