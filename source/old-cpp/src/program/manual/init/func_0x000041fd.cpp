FUNC_BEGIN(0x000041fd, 0xce13cc0b52558b8e, 0x10, ({0xfa, 0x33, 0xc9, 0x1e, 0x8e, 0xd9, 0x56, 0xbe, 0x20, 0, 0x49, 0x8e, 0xc1, 0x57, 0xbf, 0x30, 0, 0xfc, 0xb9, 0x4, 0, 0xf3, 0xa7, 0x5f, 0x5e, 0x1f, 0xc3}))
    II(0x000041fd, 0x1)   cli();                                /* cli  */
    II(0x000041fe, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x00004200, 0x1)   pushw(ds);                            /* push ds */
    II(0x00004201, 0x2)   mov(ds, cx);                          /* mov ds, cx */
    II(0x00004203, 0x1)   pushw(si);                            /* push si */
    II(0x00004204, 0x3)   mov(si, 0x20);                        /* mov si, 0x20 */
    II(0x00004207, 0x1)   dec(cx);                              /* dec cx */
    II(0x00004208, 0x2)   mov(es, cx);                          /* mov es, cx */
    II(0x0000420a, 0x1)   pushw(di);                            /* push di */
    II(0x0000420b, 0x3)   mov(di, 0x30);                        /* mov di, 0x30 */
    II(0x0000420e, 0x1)   cld();                                /* cld  */
    II(0x0000420f, 0x3)   mov(cx, 0x4);                         /* mov cx, 0x4 */
    II(0x00004212, 0x2)   repe_a16 cmpsw_a16();                 /* rep cmpsw  */
    II(0x00004214, 0x1)   popw(di);                             /* pop di */
    II(0x00004215, 0x1)   popw(si);                             /* pop si */
    II(0x00004216, 0x1)   popw(ds);                             /* pop ds */
    II(0x00004217, 0x1)   retw();                               /* ret  */
FUNC_END

