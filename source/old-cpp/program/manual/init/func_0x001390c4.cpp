FUNC_BEGIN(0x001390c4, 0x3d6a28a06b0bca88, 0x10, ({0x55, 0x8b, 0xec, 0x66, 0x57, 0x66, 0x53, 0xf, 0xa8, 0x8e, 0x2e, 0xaa, 0, 0x66, 0x8b, 0x7e, 0x4, 0x66, 0x8b, 0x5e, 0x8, 0x65, 0x67, 0x8b, 0x4, 0x5f, 0xf, 0xa9, 0x66, 0x5b, 0x66, 0x5f, 0x5d, 0xc3}))
    II(0x001390c4, 0x1)   pushw(bp);                            /* push bp */
    II(0x001390c5, 0x2)   mov(bp, sp);                          /* mov bp, sp */
    II(0x001390c7, 0x2)   pushd(edi);                           /* push edi */
    II(0x001390c9, 0x2)   pushd(ebx);                           /* push ebx */
    II(0x001390cb, 0x2)   pushw(gs);                            /* push gs */
    II(0x001390cd, 0x4)   mov(gs, memw_a16(ds, 0xaa));          /* mov gs, [0xaa] */
    II(0x001390d1, 0x4)   mov(edi, memd_a16(ss, bp + 0x4));     /* mov edi, [bp+0x4] */
    II(0x001390d5, 0x4)   mov(ebx, memd_a16(ss, bp + 0x8));     /* mov ebx, [bp+0x8] */
    II(0x001390d9, 0x5)   mov(ax, memw_a32(gs, edi + ebx * 0x2)); /* mov ax, [gs:edi+ebx*2] */
    II(0x001390de, 0x2)   popw(gs);                             /* pop gs */
    II(0x001390e0, 0x2)   popd(ebx);                            /* pop ebx */
    II(0x001390e2, 0x2)   popd(edi);                            /* pop edi */
    II(0x001390e4, 0x1)   popw(bp);                             /* pop bp */
    II(0x001390e5, 0x1)   retw();                               /* ret  */
FUNC_END

