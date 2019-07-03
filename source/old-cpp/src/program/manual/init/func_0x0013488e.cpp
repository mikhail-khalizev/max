FUNC_BEGIN(0x0013488e, 0xcef5aff26ef03047, 0x10, ({0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0xff, 0xe, 0xd8, 0, 0x1f, 0xcb}))
    II(0x0013488e, 0x1)   pushw(ds);                            /* push ds */
    II(0x0013488f, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x00134892, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00134894, 0x4)   dec(memw_a16(ds, 0xd8));              /* dec word [0xd8] */
    II(0x00134898, 0x1)   popw(ds);                             /* pop ds */
    II(0x00134899, 0x1)   retfw();                              /* retf  */
FUNC_END

