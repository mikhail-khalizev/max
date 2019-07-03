FUNC_BEGIN(0x00138e80, 0x48739f138e95a35a, 0x10, ({0x53, 0x66, 0x52, 0xf, 0x20, 0xda, 0x8b, 0xc2, 0x25, 0, 0xf0, 0x66, 0xc1, 0xea, 0x10, 0x8b, 0xda, 0x66, 0x5a, 0x8b, 0xd3, 0x5b, 0xcb}))
    II(0x00138e80, 0x1)   pushw(bx);                            /* push bx */
    II(0x00138e81, 0x2)   pushd(edx);                           /* push edx */
    II(0x00138e83, 0x3)   mov(edx, cr3);                        /* mov edx, cr3 */
    II(0x00138e86, 0x2)   mov(ax, dx);                          /* mov ax, dx */
    II(0x00138e88, 0x3)   and_(ax, 0xf000);                     /* and ax, 0xf000 */
    II(0x00138e8b, 0x4)   shr(edx, 0x10);                       /* shr edx, 0x10 */
    II(0x00138e8f, 0x2)   mov(bx, dx);                          /* mov bx, dx */
    II(0x00138e91, 0x2)   popd(edx);                            /* pop edx */
    II(0x00138e93, 0x2)   mov(dx, bx);                          /* mov dx, bx */
    II(0x00138e95, 0x1)   popw(bx);                             /* pop bx */
    II(0x00138e96, 0x1)   retfw();                              /* retf  */
FUNC_END

