FUNC_BEGIN(0x00009aa7, 0x1527c100ae48d35c, 0x10, ({0x55, 0xfa, 0xe8, 0x2d, 0xa7, 0xe4, 0x21, 0x8a, 0xe0, 0xb0, 0xff, 0xe6, 0x21, 0xe4, 0xa1, 0x50, 0xf6, 0xd0, 0xe6, 0xa1, 0x33, 0xc0, 0x8e, 0xd8, 0xb0, 0xf, 0xe6, 0x70, 0x8c, 0xe, 0x69, 0x4, 0xc7, 0x6, 0x67, 0x4, 0x6, 0x65, 0xb0, 0xa, 0xe6, 0x71, 0x36, 0x89, 0x26, 0x7a, 0xf, 0x36, 0xf, 0x1, 0x16, 0xc8, 0x8, 0x36, 0xf, 0x1, 0x1e, 0xd0, 0x8, 0xf, 0x1, 0xe0, 0xc, 0x1, 0xf, 0x1, 0xf0, 0xea, 0xff, 0x64, 0x18, 0}))
    II(0x00009aa7, 0x1)   pushw(bp);                            /* push bp */
    II(0x00009aa8, 0x1)   cli();                                /* cli  */
    II(0x00009aa9, 0x3)   callw(0x000041d9, -0x58d3);           /* call 0x41d9 */
    II(0x00009aac, 0x2)   inb(al, 0x21);                        /* in al, 0x21 */
    II(0x00009aae, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x00009ab0, 0x2)   mov(al, 0xff);                        /* mov al, 0xff */
    II(0x00009ab2, 0x2)   outb(0x21, al);                       /* out 0x21, al */
    II(0x00009ab4, 0x2)   inb(al, 0xa1);                        /* in al, 0xa1 */
    II(0x00009ab6, 0x1)   pushw(ax);                            /* push ax */
    II(0x00009ab7, 0x2)   not_(al);                             /* not al */
    II(0x00009ab9, 0x2)   outb(0xa1, al);                       /* out 0xa1, al */
    II(0x00009abb, 0x2)   xor_(ax, ax);                         /* xor ax, ax */
    II(0x00009abd, 0x2)   mov(ds, ax);                          /* mov ds, ax */
    II(0x00009abf, 0x2)   mov(al, 0xf);                         /* mov al, 0xf */
    II(0x00009ac1, 0x2)   outb(0x70, al);                       /* out 0x70, al */
    II(0x00009ac3, 0x4)   mov(memw_a16(ds, 0x469), cs);         /* mov [0x469], cs */
    II(0x00009ac7, 0x6)   mov(memw_a16(ds, 0x467), 0x6506);     /* mov word [0x467], 0x6506 */
    II(0x00009acd, 0x2)   mov(al, 0xa);                         /* mov al, 0xa */
    II(0x00009acf, 0x2)   outb(0x71, al);                       /* out 0x71, al */
    II(0x00009ad1, 0x5)   mov(memw_a16(ss, 0xf7a), sp);         /* mov [ss:0xf7a], sp */
    II(0x00009ad6, 0x6)   lgdtw_a16(ss, 0x8c8);                 /* lgdt [ss:0x8c8] */
    II(0x00009adc, 0x6)   lidtw_a16(ss, 0x8d0);                 /* lidt [ss:0x8d0] */
    II(0x00009ae2, 0x3)   smsw(ax);
    II(0x00009ae5, 0x2)   or_(al, 0x1);                         /* or al, 0x1 */
    II(0x00009ae7, 0x3)   lmsw(ax);
    II(0x00009aea, 0x5)   jmpw_far_abs(0x18, 0x64ff);           /* jmp word 0x18:0x64ff */
FUNC_END

