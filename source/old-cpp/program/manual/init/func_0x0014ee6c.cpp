FUNC_BEGIN(0x0014ee6c, 0xe636cf41e0c88a65, 0x10, ({0xf6, 0x6, 0x82, 0x15, 0x1, 0x75, 0xd1, 0xb0, 0xb, 0xee, 0x1f, 0xeb, 0, 0xeb, 0, 0xec, 0x5a, 0x84, 0xc5, 0x58, 0x74, 0x2, 0xc3}))
    II(0x0014ee6c, 0x5)   test(memb_a16(ds, 0x1582), 0x1);      /* test byte [0x1582], 0x1 */
    II(0x0014ee71, 0x2)   jnzw_func(0x0014ee44, -0x2f);         /* jnz 0x14ee44 */
    II(0x0014ee73, 0x2)   mov(al, 0xb);                         /* mov al, 0xb */
    II(0x0014ee75, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x0014ee76, 0x1)   popw(ds);                             /* pop ds */
    II(0x0014ee77, 0x2)   jmpw(0x0014ee79, 0);                  /* jmp 0x14ee79 */
l_0x0014ee79:
    II(0x0014ee79, 0x2)   jmpw(0x0014ee7b, 0);                  /* jmp 0x14ee7b */
l_0x0014ee7b:
    II(0x0014ee7b, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x0014ee7c, 0x1)   popw(dx);                             /* pop dx */
    II(0x0014ee7d, 0x2)   test(ch, al);                         /* test ch, al */
    II(0x0014ee7f, 0x1)   popw(ax);                             /* pop ax */
    II(0x0014ee80, 0x2)   jzw_func(0x0014ee84, 0x2);            /* jz 0x14ee84 */
    II(0x0014ee82, 0x1)   retw();                               /* ret  */
FUNC_END

