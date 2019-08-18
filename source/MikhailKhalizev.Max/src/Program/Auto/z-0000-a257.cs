using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa257-a677d889")]
        public void Method_0000_a257()
        {
            ii(0xa257, 1);    pushw(bp);                                /* push bp */
            ii(0xa258, 1);    cli();                                    /* cli */
            ii(0xa259, 3);    callw(0x4989, -0x58d3);                   /* call 0x4989 */
            ii(0xa25c, 2);    inb(al, 0x21);                            /* in al, 0x21 */
            ii(0xa25e, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0xa260, 2);    mov(al, 0xff);                            /* mov al, 0xff */
            ii(0xa262, 2);    outb(0x21, al);                           /* out 0x21, al */
            ii(0xa264, 2);    inb(al, 0xa1);                            /* in al, 0xa1 */
            ii(0xa266, 1);    pushw(ax);                                /* push ax */
            ii(0xa267, 2);    not(al);                                  /* not al */
            ii(0xa269, 2);    outb(0xa1, al);                           /* out 0xa1, al */
            ii(0xa26b, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa26d, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0xa26f, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0xa271, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0xa273, 4);    mov(memw_a16[ds, 0x469], cs);             /* mov [0x469], cs */
            ii(0xa277, 6);    mov(memw_a16[ds, 0x467], 0x6506);         /* mov word [0x467], 0x6506 */
            ii(0xa27d, 2);    mov(al, 0xa);                             /* mov al, 0xa */
            ii(0xa27f, 2);    outb(0x71, al);                           /* out 0x71, al */
            ii(0xa281, 5);    mov(memw_a16[ss, 0xf7a], sp);             /* mov [ss:0xf7a], sp */
            ii(0xa286, 6);    lgdtw_a16(ss, 0x8c8);                     /* lgdt [ss:0x8c8] */
            ii(0xa28c, 6);    lidtw_a16(ss, 0x8d0);                     /* lidt [ss:0x8d0] */
            ii(0xa292, 3);    smsw(ax);                                 /* smsw ax */
            ii(0xa295, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0xa297, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0xa29a, 5);    if(jmpw_far_abs(0x18, 0x64ff)) return;    /* jmp word 0x18:0x64ff */
        }
    }
}
