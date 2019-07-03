FUNC_BEGIN(/* sys */ 0x1019026c, 0x2fe90a9f2cfb8101, 0x20, ({0x8a, 0x1e, 0x46, 0x8a, 0xfb, 0x8b, 0xc3, 0xc1, 0xe0, 0x10, 0x66, 0x8b, 0xc3, 0x8b, 0xd8, 0xeb, 0x17}))
    II(0x1019026c, 0x2)   mov(bl, memb_a32(ds, esi));           /* mov bl, [esi] */
    II(0x1019026e, 0x1)   inc(esi);                             /* inc esi */
    II(0x1019026f, 0x2)   mov(bh, bl);                          /* mov bh, bl */
    II(0x10190271, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10190273, 0x3)   shl(eax, 0x10);                       /* shl eax, 0x10 */
    II(0x10190276, 0x3)   mov(ax, bx);                          /* mov ax, bx */
    II(0x10190279, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1019027b, 0x2)   jmpd_func(0x10190294, 0x17);          /* jmp 0x10190294 */
FUNC_END

