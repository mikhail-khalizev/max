FUNC_BEGIN(0x0000ea68, 0xd25a08772befd61f, 0x10, ({0x80, 0x7e, 0x12, 0xff, 0x75, 0xdd, 0xe8, 0x1e, 0xfe, 0xe8, 0xda, 0xff, 0x75, 0x7, 0x80, 0x4f, 0x26, 0x40, 0xe9, 0x90, 0x5, 0xe8, 0xe3, 0xfd, 0xf6, 0x47, 0x26, 0x40, 0x75, 0xf4, 0xfe, 0xe, 0xed, 0x10, 0xeb, 0xee}))
    II(0x0000ea68, 0x4)   cmp(memb_a16(ss, bp + 0x12), -0x1 /* 0xff */); /* cmp byte [bp+0x12], 0xff */
    II(0x0000ea6c, 0x2)   jnzw_func(0x0000ea4b, -0x23);         /* jnz 0xea4b */
    II(0x0000ea6e, 0x3)   callw(0x0000e88f, -0x1e2);            /* call 0xe88f */
    II(0x0000ea71, 0x3)   callw(0x0000ea4e, -0x26);             /* call 0xea4e */
    II(0x0000ea74, 0x2)   jnzw(0x0000ea7d, 0x7);                /* jnz 0xea7d */
    II(0x0000ea76, 0x4)   or_(memb_a16(ds, bx + 0x26), 0x40);   /* or byte [bx+0x26], 0x40 */
l_0x0000ea7a:
    II(0x0000ea7a, 0x3)   jmpw_func(0x0000f00d, 0x590);         /* jmp 0xf00d */
l_0x0000ea7d:
    II(0x0000ea7d, 0x3)   callw(0x0000e863, -0x21d);            /* call 0xe863 */
    II(0x0000ea80, 0x4)   test(memb_a16(ds, bx + 0x26), 0x40);  /* test byte [bx+0x26], 0x40 */
    II(0x0000ea84, 0x2)   jnzw(0x0000ea7a, -0xc);               /* jnz 0xea7a */
    II(0x0000ea86, 0x4)   dec(memb_a16(ds, 0x10ed));            /* dec byte [0x10ed] */
    II(0x0000ea8a, 0x2)   jmpw(0x0000ea7a, -0x12);              /* jmp 0xea7a */
FUNC_END

