FUNC_BEGIN(0x00161d09, 0x82ce1026bbe89f38, 0x10, ({0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0x1e, 0x68, 0x5a, 0x3b, 0x1e, 0x68, 0x4e, 0x3b, 0x6a, 0, 0xe, 0xe8, 0x66, 0xfe, 0x1f, 0xcb}))
    II(0x00161d09, 0x1)   pushw(ds);                            /* push ds */
    II(0x00161d0a, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x00161d0d, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00161d0f, 0x1)   pushw(ds);                            /* push ds */
    II(0x00161d10, 0x3)   pushw(0x3b5a);                        /* push word 0x3b5a */
    II(0x00161d13, 0x1)   pushw(ds);                            /* push ds */
    II(0x00161d14, 0x3)   pushw(0x3b4e);                        /* push word 0x3b4e */
    II(0x00161d17, 0x2)   pushw(0);                             /* push 0x0 */
    II(0x00161d19, 0x1)   pushw(cs);                            /* push cs */
    II(0x00161d1a, 0x3)   callw(0x00161b83, -0x19a);            /* call 0x161b83 */
    II(0x00161d1d, 0x1)   popw(ds);                             /* pop ds */
    II(0x00161d1e, 0x1)   retfw();                              /* retf  */
FUNC_END

