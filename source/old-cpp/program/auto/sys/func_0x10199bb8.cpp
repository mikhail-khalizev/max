FUNC_BEGIN(/* sys */ 0x10199bb8, 0x18544d009ba4bad6, 0x20, ({0x66, 0x50, 0x9b, 0xdb, 0xe3, 0xd9, 0xe8, 0xd9, 0xee, 0xde, 0xf9, 0xd9, 0xc0, 0xd9, 0xe0, 0xde, 0xd9, 0xdf, 0xe0, 0xb0, 0x2, 0x9e, 0x74, 0x2, 0xb0, 0x3, 0x9b, 0xdb, 0xe3, 0xd9, 0x2c, 0x24, 0x66, 0x87, 0x4, 0x24, 0x66, 0x58, 0xc3}))
    II(0x10199bb8, 0x2)   pushw(ax);                            /* push ax */
    II(0x10199bba, 0x1)   wait();                               /* wait */
    II(0x10199bbb, 0x2)   fninit();                             /* fninit */
    II(0x10199bbd, 0x2)   fld1();                               /* fld1 */
    II(0x10199bbf, 0x2)   fldz();                               /* fldz */
    II(0x10199bc1, 0x2)   fdivp(0x1 /* st1 */, 0 /* st0 */);    /* fdivp st1, st0 */
    II(0x10199bc3, 0x2)   fld(0 /* st0 */, 0 /* st0 */);        /* fld st0, st0 */
    II(0x10199bc5, 0x2)   fchs();                               /* fchs */
    II(0x10199bc7, 0x2)   fcompp();                             /* fcompp */
    II(0x10199bc9, 0x2)   fnstsw(ax);                           /* fnstsw ax */
    II(0x10199bcb, 0x2)   mov(al, 0x2);                         /* mov al, 0x2 */
    II(0x10199bcd, 0x1)   sahf();                               /* sahf */
    II(0x10199bce, 0x2)   jzd(0x10199bd2, 0x2);                 /* jz 0x10199bd2 */
    II(0x10199bd0, 0x2)   mov(al, 0x3);                         /* mov al, 0x3 */
l_0x10199bd2:
    II(0x10199bd2, 0x1)   wait();                               /* wait */
    II(0x10199bd3, 0x2)   fninit();                             /* fninit */
    II(0x10199bd5, 0x3)   fldcw(memw_a32(ss, esp));             /* fldcw word [esp] */
    II(0x10199bd8, 0x4)   xchg(memw_a32(ss, esp), ax);          /* xchg [esp], ax */
    II(0x10199bdc, 0x2)   popw(ax);                             /* pop ax */
    II(0x10199bde, 0x1)   retd();                               /* ret */
FUNC_END

