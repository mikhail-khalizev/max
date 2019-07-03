FUNC_BEGIN(0x00155e4b, 0x4287a373df6511b4, 0x10, ({0xc8, 0, 0, 0, 0x57, 0x56, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0xb8, 0xba, 0xa, 0x8c, 0xda, 0xe9, 0, 0, 0x1f, 0x5e, 0x5f, 0xc9, 0xcb}))
    II(0x00155e4b, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x00155e4f, 0x1)   pushw(di);                            /* push di */
    II(0x00155e50, 0x1)   pushw(si);                            /* push si */
    II(0x00155e51, 0x1)   pushw(ds);                            /* push ds */
    II(0x00155e52, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x00155e55, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00155e57, 0x3)   mov(ax, 0xaba);                       /* mov ax, 0xaba */
    II(0x00155e5a, 0x2)   mov(dx, ds);                          /* mov dx, ds */
    II(0x00155e5c, 0x3)   jmpw(0x00155e5f, 0);                  /* jmp 0x155e5f */
l_0x00155e5f:
    II(0x00155e5f, 0x1)   popw(ds);                             /* pop ds */
    II(0x00155e60, 0x1)   popw(si);                             /* pop si */
    II(0x00155e61, 0x1)   popw(di);                             /* pop di */
    II(0x00155e62, 0x1)   leavew();                             /* leave  */
    II(0x00155e63, 0x1)   retfw();                              /* retf  */
FUNC_END

