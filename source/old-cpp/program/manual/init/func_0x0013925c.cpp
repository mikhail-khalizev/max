FUNC_BEGIN(0x0013925c, 0xd3f48c8ab68a4ae, 0x10, ({0x55, 0x8b, 0xec, 0x6, 0x66, 0x57, 0x66, 0x51, 0x66, 0x8b, 0x4e, 0xc, 0x8e, 0x46, 0x6, 0x66, 0x8b, 0x7e, 0x8, 0xfa, 0xb0, 0, 0x67, 0x66, 0xf3, 0xaa, 0x67, 0xfb, 0x66, 0x59, 0x66, 0x5f, 0x7, 0x5d, 0xcb}))
    II(0x0013925c, 0x1)   pushw(bp);                            /* push bp */
    II(0x0013925d, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x0013925f, 0x1)   pushw(es);                            /* push es */
    II(0x00139260, 0x2)   pushd(edi);                           /* push edi */
    II(0x00139262, 0x2)   pushd(ecx);                           /* push ecx */
    II(0x00139264, 0x4)   mov(ecx, memd_a16(ss, bp + 0xc));     /* mov ecx, [bp+0xc] */
    II(0x00139268, 0x3)   mov(es, memw_a16(ss, bp + 0x6));      /* mov es, [bp+0x6] */
    II(0x0013926b, 0x4)   mov(edi, memd_a16(ss, bp + 0x8));     /* mov edi, [bp+0x8] */
    II(0x0013926f, 0x1)   cli();                                /* cli  */
    II(0x00139270, 0x2)   mov(al, 0);                           /* mov al, 0x0 */
    II(0x00139272, 0x4)   rep_a32 stosb_a32();                  /* o32 a32 rep stosb  */
    II(0x00139276, 0x2)   sti();                                /* a32 sti  */
    II(0x00139278, 0x2)   popd(ecx);                            /* pop ecx */
    II(0x0013927a, 0x2)   popd(edi);                            /* pop edi */
    II(0x0013927c, 0x1)   popw(es);                             /* pop es */
    II(0x0013927d, 0x1)   popw(bp);                             /* pop bp */
    II(0x0013927e, 0x1)   retfw();                              /* retf  */
FUNC_END

