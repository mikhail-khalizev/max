FUNC_BEGIN(0x0015549d, 0x116ff4b4b1bb7e65, 0x10, ({0xc8, 0, 0, 0, 0x57, 0x56, 0x1e, 0xb8, 0xa8, 0, 0x8e, 0xd8, 0xb8, 0x90, 0xd, 0x8c, 0xda, 0xe9, 0, 0, 0x1f, 0x5e, 0x5f, 0xc9, 0xcb}))
    II(0x0015549d, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x001554a1, 0x1)   pushw(di);                            /* push di */
    II(0x001554a2, 0x1)   pushw(si);                            /* push si */
    II(0x001554a3, 0x1)   pushw(ds);                            /* push ds */
    II(0x001554a4, 0x3)   mov(ax, 0xa8);                        /* mov ax, 0xa8 */
    II(0x001554a7, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x001554a9, 0x3)   mov(ax, 0xd90);                       /* mov ax, 0xd90 */
    II(0x001554ac, 0x2)   mov(dx, ds);                          /* mov dx, ds */
    II(0x001554ae, 0x3)   jmpw(0x001554b1, 0);                  /* jmp 0x1554b1 */
l_0x001554b1:
    II(0x001554b1, 0x1)   popw(ds);                             /* pop ds */
    II(0x001554b2, 0x1)   popw(si);                             /* pop si */
    II(0x001554b3, 0x1)   popw(di);                             /* pop di */
    II(0x001554b4, 0x1)   leavew();                             /* leave  */
    II(0x001554b5, 0x1)   retfw();                              /* retf  */
FUNC_END

