FUNC_BEGIN(/* sys */ 0x1018dcc4, 0xe3dd6df56eb5c083, 0x20, ({0x53, 0xb9, 0, 0, 0, 0, 0x83, 0x3d, 0x20, 0xe4, 0x1b, 0x10, 0, 0x78, 0x7, 0xeb, 0x29, 0xb9, 0x1, 0, 0, 0, 0xb0, 0x80, 0xfa, 0xe6, 0x43, 0xe4, 0x42, 0x8a, 0xd8, 0xe4, 0x42, 0x8a, 0xe0, 0x8a, 0xc3, 0x33, 0xdb, 0x66, 0x8b, 0x1d, 0xd0, 0x9d, 0x20, 0x10, 0x66, 0x2b, 0xd8, 0x3, 0x1d, 0x20, 0xe4, 0x1b, 0x10, 0xfb, 0x78, 0xd7, 0x8b, 0xc1, 0x5b, 0xc3}))
    II(0x1018dcc4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1018dcc5, 0x5)   mov(ecx, 0);                          /* mov ecx, 0x0 */
    II(0x1018dcca, 0x7)   cmp(memd_a32(ds, 0x101be420), 0);     /* cmp dword [0x101be420], 0x0 */
    II(0x1018dcd1, 0x2)   jsd(0x1018dcda, 0x7);                 /* js 0x1018dcda */
    II(0x1018dcd3, 0x2)   jmpd(0x1018dcfe, 0x29);               /* jmp 0x1018dcfe */
l_0x1018dcd5:
    II(0x1018dcd5, 0x5)   mov(ecx, 0x1);                        /* mov ecx, 0x1 */
l_0x1018dcda:
    II(0x1018dcda, 0x2)   mov(al, 0x80);                        /* mov al, 0x80 */
    II(0x1018dcdc, 0x1)   cli();                                /* cli */
    II(0x1018dcdd, 0x2)   outb(0x43, al);                       /* out 0x43, al */
    II(0x1018dcdf, 0x2)   inb(al, 0x42);                        /* in al, 0x42 */
    II(0x1018dce1, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x1018dce3, 0x2)   inb(al, 0x42);                        /* in al, 0x42 */
    II(0x1018dce5, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x1018dce7, 0x2)   mov(al, bl);                          /* mov al, bl */
    II(0x1018dce9, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1018dceb, 0x7)   mov(bx, memw_a32(ds, 0x10209dd0));    /* mov bx, [0x10209dd0] */
    II(0x1018dcf2, 0x3)   sub(bx, ax);                          /* sub bx, ax */
    II(0x1018dcf5, 0x6)   add(ebx, memd_a32(ds, 0x101be420));   /* add ebx, [0x101be420] */
    II(0x1018dcfb, 0x1)   sti();                                /* sti */
    II(0x1018dcfc, 0x2)   jsd(0x1018dcd5, -0x29);               /* js 0x1018dcd5 */
l_0x1018dcfe:
    II(0x1018dcfe, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1018dd00, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1018dd01, 0x1)   retd();                               /* ret */
FUNC_END

