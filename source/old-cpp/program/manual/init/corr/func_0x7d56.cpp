FUNC_INFO_V4(0x00007d56, func_0x00007d56, 0x10, {0xe8, 0x83, 0xe9, 0x2e, 0x87, 0xe, 0xbb, 0x1f, 0x89, 0x4e, 0x14, 0xeb, 0, 0x58, 0x17, 0x94, 0x1f, 0x7, 0x66, 0x61, 0x9d, 0xff, 0xff, 0x9c, 0xfa, 0x2e, 0x8f, 0x6, 0xa4, 0x1f, 0x68, 0xa2, 0x1, 0x17, 0x36, 0x8b, 0x26, 0x96, 0x9, 0x66, 0x60, 0x6, 0x1e, 0x16, 0x1f, 0x8b, 0xec, 0x8b, 0x46, 0x38, 0x2e, 0xa3, 0xbb, 0x1f, 0xe8, 0xb1, 0xe2, 0x2e, 0xa1, 0xa4, 0x1f, 0xea, 0xf9, 0x4c, 0x70, 0})
{
    FUNC_START_V2(0x7d56, 0x10);
    II(0x7d56, 0x3)    callw(0x66dc, -0x167d);                    /* call 0x66dc */
    II(0x7d59, 0x5)    xchg(memw_a16(cs, 0x1fbb), cx);            /* xchg [cs:0x1fbb], cx */
    II(0x7d5e, 0x3)    mov(memw_a16(ss, bp + 0x14), cx);          /* mov [bp+0x14], cx */
    II(0x7d61, 0x2)                                               /* jmp 0x7d63 */
    II(0x7d63, 0x1)    popw(ax);                                  /* pop ax */
    II(0x7d64, 0x1)    popw(ss);                                  /* pop ss */
    II(0x7d65, 0x1)    xchg(sp, ax);                              /* xchg sp, ax */
    II(0x7d66, 0x1)    popw(ds);                                  /* pop ds */
    II(0x7d67, 0x1)    popw(es);                                  /* pop es */
    II(0x7d68, 0x2)    popad();                                   /* popad  */
    II(0x7d6a, 0x1)    popfw();                                   /* popfw  */

    II(0x7d6b, 0x2)

    if (memw_a16(cs, 0x1fbb) == 0x10cd)
    {
        int_(0x10);
    }
    else
    {
        invalid();                                 /* invalid  */
    }

    II(0x7d6d, 0x1)    pushfw();                                  /* pushfw  */
    II(0x7d6e, 0x1)    cli();                                     /* cli  */
    II(0x7d6f, 0x5)    popw(memw_a16(cs, 0x1fa4));                /* pop word [cs:0x1fa4] */
    II(0x7d74, 0x3)    pushw(0x1a2);                              /* push word 0x1a2 */
    II(0x7d77, 0x1)    popw(ss);                                  /* pop ss */
    II(0x7d78, 0x5)    mov(sp, memw_a16(ss, 0x996));              /* mov sp, [ss:0x996] */
    II(0x7d7d, 0x2)    pushad();                                  /* pushad  */
    II(0x7d7f, 0x1)    pushw(es);                                 /* push es */
    II(0x7d80, 0x1)    pushw(ds);                                 /* push ds */
    II(0x7d81, 0x1)    pushw(ss);                                 /* push ss */
    II(0x7d82, 0x1)    popw(ds);                                  /* pop ds */
    II(0x7d83, 0x2)    mov(bp, sp);                               /* mov bp, sp */
    II(0x7d85, 0x3)    mov(ax, memw_a16(ss, bp + 0x38));          /* mov ax, [bp+0x38] */
    II(0x7d88, 0x4)    mov(memw_a16(cs, 0x1fbb), ax);             /* mov [cs:0x1fbb], ax */
    II(0x7d8c, 0x3)    callw(0x6040, -0x1d4f);                    /* call 0x6040 */
    II(0x7d8f, 0x4)    mov(ax, memw_a16(cs, 0x1fa4));             /* mov ax, [cs:0x1fa4] */
    II(0x7d93, 0x5)    jmpw_far_abs(0x70, 0x4cf9);                /* jmp word 0x70:0x4cf9 */
}


