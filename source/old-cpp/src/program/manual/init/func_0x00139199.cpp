FUNC_BEGIN(0x00139199, 0xa16fb5e3c39, 0x10, ({0x1e, 0x58, 0xcb}))
    II(0x00139199, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013919a, 0x1)   popw(ax);                             /* pop ax */
    II(0x0013919b, 0x1)   retfw();                              /* retf  */
FUNC_END

