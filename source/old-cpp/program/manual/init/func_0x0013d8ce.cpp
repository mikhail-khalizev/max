FUNC_BEGIN(0x0013d8ce, 0xe811e193ca107c91, 0x10, ({0xa2, 0x59, 0x1c, 0xa, 0xe4, 0x75, 0x22, 0x80, 0x3e, 0x56, 0x1c, 0x3, 0x72, 0xc, 0x3c, 0x22, 0x73, 0xc, 0x3c, 0x20, 0x72, 0x4, 0xb0, 0x5, 0xeb, 0x6, 0x3c, 0x13, 0x76, 0x2, 0xb0, 0x13, 0xbb, 0x8c, 0x1c, 0xd7, 0x98, 0xa3, 0x4e, 0x1c, 0xc3, 0x8a, 0xc4, 0xeb, 0xf7}))
    II(0x0013d8ce, 0x3)   mov(memb_a16(ds, 0x1c59), al);        /* mov [0x1c59], al */
    II(0x0013d8d1, 0x2)   or_(ah, ah);                          /* or ah, ah */
    II(0x0013d8d3, 0x2)   jnzw(0x0013d8f7, 0x22);               /* jnz 0x13d8f7 */
    II(0x0013d8d5, 0x5)   cmp(memb_a16(ds, 0x1c56), 0x3);       /* cmp byte [0x1c56], 0x3 */
    II(0x0013d8da, 0x2)   jbw(0x0013d8e8, 0xc);                 /* jb 0x13d8e8 */
    II(0x0013d8dc, 0x2)   cmp(al, 0x22);                        /* cmp al, 0x22 */
    II(0x0013d8de, 0x2)   jaew(0x0013d8ec, 0xc);                /* jae 0x13d8ec */
    II(0x0013d8e0, 0x2)   cmp(al, 0x20);                        /* cmp al, 0x20 */
    II(0x0013d8e2, 0x2)   jbw(0x0013d8e8, 0x4);                 /* jb 0x13d8e8 */
    II(0x0013d8e4, 0x2)   mov(al, 0x5);                         /* mov al, 0x5 */
    II(0x0013d8e6, 0x2)   jmpw(0x0013d8ee, 0x6);                /* jmp 0x13d8ee */
l_0x0013d8e8:
    II(0x0013d8e8, 0x2)   cmp(al, 0x13);                        /* cmp al, 0x13 */
    II(0x0013d8ea, 0x2)   jbew(0x0013d8ee, 0x2);                /* jbe 0x13d8ee */
l_0x0013d8ec:
    II(0x0013d8ec, 0x2)   mov(al, 0x13);                        /* mov al, 0x13 */
l_0x0013d8ee:
    II(0x0013d8ee, 0x3)   mov(bx, 0x1c8c);                      /* mov bx, 0x1c8c */
    II(0x0013d8f1, 0x1)   xlatb_a16();                          /* xlatb  */
l_0x0013d8f2:
    II(0x0013d8f2, 0x1)   cbw();                                /* cbw  */
    II(0x0013d8f3, 0x3)   mov(memw_a16(ds, 0x1c4e), ax);        /* mov [0x1c4e], ax */
    II(0x0013d8f6, 0x1)   retw();                               /* ret  */
l_0x0013d8f7:
    II(0x0013d8f7, 0x2)   mov(al, ah);                          /* mov al, ah */
    II(0x0013d8f9, 0x2)   jmpw(0x0013d8f2, -0x9);               /* jmp 0x13d8f2 */
FUNC_END

