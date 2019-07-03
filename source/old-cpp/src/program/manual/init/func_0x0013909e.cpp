FUNC_BEGIN(0x0013909e, 0x57e22de5f6f25628, 0x10, ({0x55, 0x8b, 0xec, 0x66, 0x50, 0x66, 0x8b, 0x46, 0x6, 0xf, 0x22, 0xd8, 0x66, 0x58, 0x5d, 0xcb}))
    II(0x0013909e, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013909f, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x001390a1, 0x2)   pushd(eax);                           /* push eax */
    II(0x001390a3, 0x4)   mov(eax, memd_a16(ss, bp + 0x6));     /* mov eax, [bp+0x6] */
    II(0x001390a7, 0x3)   mov(cr3, eax);                        /* mov cr3, eax */
    II(0x001390aa, 0x2)   popd(eax);                            /* pop eax */
    II(0x001390ac, 0x1)   popw(bp);                             /* pop bp */
    II(0x001390ad, 0x1)   retfw();                              /* retf  */
FUNC_END

