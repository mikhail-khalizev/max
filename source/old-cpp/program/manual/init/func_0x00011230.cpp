FUNC_BEGIN(0x00011230, 0x2c585f156404a6fc, 0x10, ({0x51, 0x8b, 0xe, 0xee, 0xd, 0x49, 0x75, 0x43, 0xb8, 0x4, 0xde, 0x66, 0xff, 0x1e, 0x5a, 0xd, 0xfa, 0xa, 0xe4, 0xb8, 0, 0, 0x75, 0x31, 0x66, 0x3b, 0xfb, 0x73, 0x2c, 0x26, 0x67, 0xf6, 0x47, 0x1, 0x8, 0x74, 0x6, 0x66, 0x83, 0xc7, 0x4, 0xeb, 0xed, 0x66, 0x92, 0x66, 0xba, 0, 0x10, 0, 0, 0xd, 0x7, 0x8, 0x67, 0x66, 0xab, 0x67, 0x66, 0x3, 0xc2, 0xff, 0x6, 0xf6, 0xd, 0x66, 0x1, 0x16, 0xa8, 0xa, 0x49, 0x79, 0xed, 0x59, 0xcb, 0xb8, 0, 0xdf, 0xeb, 0xbb}))
    II(0x00011230, 0x1)   pushw(cx);                            /* push cx */
    II(0x00011231, 0x4)   mov(cx, memw_a16(ds, 0xdee));         /* mov cx, [0xdee] */
    II(0x00011235, 0x1)   dec(cx);                              /* dec cx */
    II(0x00011236, 0x2)   jnzw(0x0001127b, 0x43);               /* jnz 0x1127b */
    II(0x00011238, 0x3)   mov(ax, 0xde04);                      /* mov ax, 0xde04 */
l_0x0001123b:
    II(0x0001123b, 0x5)   calld_a16_far_ind(ds, 0xd5a);         /* call dword far [0xd5a] */
    II(0x00011240, 0x1)   cli();                                /* cli  */
    II(0x00011241, 0x2)   or_(ah, ah);                          /* or ah, ah */
    II(0x00011243, 0x3)   mov(ax, 0);                           /* mov ax, 0x0 */
    II(0x00011246, 0x2)   jnzw(0x00011279, 0x31);               /* jnz 0x11279 */
l_0x00011248:
    II(0x00011248, 0x3)   cmp(edi, ebx);                        /* cmp edi, ebx */
    II(0x0001124b, 0x2)   jaew(0x00011279, 0x2c);               /* jae 0x11279 */
    II(0x0001124d, 0x6)   test(memb_a32(es, edi + 0x1), 0x8);   /* test byte [es:edi+0x1], 0x8 */
    II(0x00011253, 0x2)   jzw(0x0001125b, 0x6);                 /* jz 0x1125b */
    II(0x00011255, 0x4)   add(edi, 0x4);                        /* add edi, 0x4 */
    II(0x00011259, 0x2)   jmpw(0x00011248, -0x13);              /* jmp 0x11248 */
l_0x0001125b:
    II(0x0001125b, 0x2)   xchg(edx, eax);                       /* xchg edx, eax */
    II(0x0001125d, 0x6)   mov(edx, 0x1000);                     /* mov edx, 0x1000 */
    II(0x00011263, 0x3)   or_(ax, 0x807);                       /* or ax, 0x807 */
l_0x00011266:
    II(0x00011266, 0x3)   stosd_a32();                          /* a32 stosd  */
    II(0x00011269, 0x4)   add(eax, edx);                        /* add eax, edx */
    II(0x0001126d, 0x4)   inc(memw_a16(ds, 0xdf6));             /* inc word [0xdf6] */
    II(0x00011271, 0x5)   add(memd_a16(ds, 0xaa8), edx);        /* add [0xaa8], edx */
    II(0x00011276, 0x1)   dec(cx);                              /* dec cx */
    II(0x00011277, 0x2)   jnsw(0x00011266, -0x13);              /* jns 0x11266 */
l_0x00011279:
    II(0x00011279, 0x1)   popw(cx);                             /* pop cx */
    II(0x0001127a, 0x1)   retfw();                              /* retf  */
l_0x0001127b:
    II(0x0001127b, 0x3)   mov(ax, 0xdf00);                      /* mov ax, 0xdf00 */
    II(0x0001127e, 0x2)   jmpw(0x0001123b, -0x45);              /* jmp 0x1123b */
FUNC_END

