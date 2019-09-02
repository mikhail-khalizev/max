using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9aa7-a677d889")]
        public void Method_0000_9aa7()
        {
            ii(0x9aa7, 1);    push(bp);                                 /* push bp */
            ii(0x9aa8, 1);    cli();                                    /* cli */
            ii(0x9aa9, 3);    call(0x41d9, -0x58d3);                    /* call 0x41d9 */
            ii(0x9aac, 2);    inb(al, 0x21);                            /* in al, 0x21 */
            ii(0x9aae, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x9ab0, 2);    mov(al, 0xff);                            /* mov al, 0xff */
            ii(0x9ab2, 2);    outb(0x21, al);                           /* out 0x21, al */
            ii(0x9ab4, 2);    inb(al, 0xa1);                            /* in al, 0xa1 */
            ii(0x9ab6, 1);    push(ax);                                 /* push ax */
            ii(0x9ab7, 2);    not(al);                                  /* not al */
            ii(0x9ab9, 2);    outb(0xa1, al);                           /* out 0xa1, al */
            ii(0x9abb, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x9abd, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x9abf, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x9ac1, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x9ac3, 4);    mov(memw[ds, 0x469], cs);                 /* mov [0x469], cs */
            ii(0x9ac7, 6);    mov(memw[ds, 0x467], 0x6506);             /* mov word [0x467], 0x6506 */
            ii(0x9acd, 2);    mov(al, 0xa);                             /* mov al, 0xa */
            ii(0x9acf, 2);    outb(0x71, al);                           /* out 0x71, al */
            ii(0x9ad1, 5);    mov(memw[ss, 0xf7a], sp);                 /* mov [ss:0xf7a], sp */
            ii(0x9ad6, 6);    lgdt(memw[ss, 0x8c8]);                    /* lgdt [ss:0x8c8] */
            ii(0x9adc, 6);    lidt(memw[ss, 0x8d0]);                    /* lidt [ss:0x8d0] */
            ii(0x9ae2, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x9ae5, 2);    or(al, 1);                                /* or al, 0x1 */
            ii(0x9ae7, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x9aea, 5);    jmp_far_abs(0x18, 0x64ff);                /* jmp word 0x18:0x64ff */
        }
    }
}
