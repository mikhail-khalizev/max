FUNC_BEGIN(0x00134e9a, 0x81f90a0c7d963b9b, 0x10, ({0xc8, 0xe, 0, 0, 0x1e, 0xb8, 0x68, 0x3e, 0x8e, 0xd8, 0xc7, 0x46, 0xfc, 0x20, 0x2e, 0xc7, 0x46, 0xfe, 0x58, 0x3e, 0xb8, 0, 0x4, 0xcd, 0x31, 0xa3, 0x58, 0x1f, 0x89, 0x1e, 0x5a, 0x1f, 0x89, 0xe, 0x5c, 0x1f, 0x89, 0x16, 0x5e, 0x1f, 0xe8, 0x75, 0xfe, 0xb, 0xc0, 0x74, 0x11, 0x68, 0x46, 0x9, 0xe, 0xe8, 0xe4, 0x26, 0x83, 0xc4, 0x2, 0xb8, 0x1, 0, 0x1f, 0xc9, 0xcb, 0x90, 0x2b, 0xc0, 0x1f, 0xc9, 0xcb}))
    II(0x00134e9a, 0x4)   enterw(0xe, 0);                       /* enter 0xe, 0x0 */
    II(0x00134e9e, 0x1)   pushw(ds);                            /* push ds */
    II(0x00134e9f, 0x3)   mov(ax, 0x3e68);                      /* mov ax, 0x3e68 */
    II(0x00134ea2, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00134ea4, 0x5)   mov(memw_a16(ss, bp - 0x4), 0x2e20);  /* mov word [bp-0x4], 0x2e20 */
    II(0x00134ea9, 0x5)   mov(memw_a16(ss, bp - 0x2), 0x3e58);  /* mov word [bp-0x2], 0x3e58 */
    II(0x00134eae, 0x3)   mov(ax, 0x400);                       /* mov ax, 0x400 */
    II(0x00134eb1, 0x2)   int_(0x31);                           /* int 0x31 */
    II(0x00134eb3, 0x3)   mov(memw_a16(ds, 0x1f58), ax);        /* mov [0x1f58], ax */
    II(0x00134eb6, 0x4)   mov(memw_a16(ds, 0x1f5a), bx);        /* mov [0x1f5a], bx */
    II(0x00134eba, 0x4)   mov(memw_a16(ds, 0x1f5c), cx);        /* mov [0x1f5c], cx */
    II(0x00134ebe, 0x4)   mov(memw_a16(ds, 0x1f5e), dx);        /* mov [0x1f5e], dx */
    II(0x00134ec2, 0x3)   callw(0x00134d3a, -0x18b);            /* call 0x134d3a */
    II(0x00134ec5, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00134ec7, 0x2)   jzw(0x00134eda, 0x11);                /* jz 0x134eda */
    II(0x00134ec9, 0x3)   pushw(0x946);                         /* push word 0x946 */
    II(0x00134ecc, 0x1)   pushw(cs);                            /* push cs */
    II(0x00134ecd, 0x3)   callw(0x001375b4, 0x26e4);            /* call 0x1375b4 */
    II(0x00134ed0, 0x3)   add(sp, 0x2);                         /* add sp, 0x2 */
    II(0x00134ed3, 0x3)   mov(ax, 0x1);                         /* mov ax, 0x1 */
    II(0x00134ed6, 0x1)   popw(ds);                             /* pop ds */
    II(0x00134ed7, 0x1)   leavew();                             /* leave  */
    II(0x00134ed8, 0x1)   retfw();                              /* retf  */
//    II(0x00134ed9, 0x1)   /* Недостижимый код. */
l_0x00134eda:
    II(0x00134eda, 0x2)   sub(ax, ax);                          /* sub ax, ax */
    II(0x00134edc, 0x1)   popw(ds);                             /* pop ds */
    II(0x00134edd, 0x1)   leavew();                             /* leave  */
    II(0x00134ede, 0x1)   retfw();                              /* retf  */
FUNC_END

