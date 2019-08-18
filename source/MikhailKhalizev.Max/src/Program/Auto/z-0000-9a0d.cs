using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9a0d-6a81d78b")]
        public void Method_0000_9a0d()
        {
            ii(0x9a0d, 1);    pushw(bp);                                /* push bp */
            ii(0x9a0e, 1);    cli();                                    /* cli */
            ii(0x9a0f, 3);    callw(0x41d9, -0x5839);                   /* call 0x41d9 */
            ii(0x9a12, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x9a14, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x9a16, 4);    pushw(memw_a16[ds, 0]);                   /* push word [0x0] */
            ii(0x9a1a, 4);    pushw(memw_a16[ds, 0x2]);                 /* push word [0x2] */
            ii(0x9a1e, 4);    pushw(memw_a16[ds, 0x4]);                 /* push word [0x4] */
            ii(0x9a22, 5);    mov(memw_a16[ss, 0xf7a], sp);             /* mov [ss:0xf7a], sp */
            ii(0x9a27, 3);    mov(cx, 0x14);                            /* mov cx, 0x14 */
        l_0x9a2a:
            ii(0x9a2a, 1);    pushw(ax);                                /* push ax */
            ii(0x9a2b, 2);    if(loopw_a16(0x9a2a, -0x3)) goto l_0x9a2a; /* loop 0x9a2a */
            ii(0x9a2d, 4);    mov(memw_a16[ds, 0x469], ss);             /* mov [0x469], ss */
            ii(0x9a31, 4);    mov(memw_a16[ds, 0x467], sp);             /* mov [0x467], sp */
            ii(0x9a35, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x9a37, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x9a39, 5);    mov(memb_a16[ds, 0], 0xea);               /* mov byte [0x0], 0xea */
            ii(0x9a3e, 6);    mov(memw_a16[ds, 0x1], 0x6485);           /* mov word [0x1], 0x6485 */
            ii(0x9a44, 4);    mov(memw_a16[ds, 0x3], cs);               /* mov [0x3], cs */
            ii(0x9a48, 2);    mov(al, 0x9);                             /* mov al, 0x9 */
            ii(0x9a4a, 2);    outb(0x71, al);                           /* out 0x71, al */
            ii(0x9a4c, 6);    lgdtw_a16(ss, 0x8c8);                     /* lgdt [ss:0x8c8] */
            ii(0x9a52, 6);    lidtw_a16(ss, 0x8d0);                     /* lidt [ss:0x8d0] */
            ii(0x9a58, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x9a5b, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x9a5d, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x9a60, 5);    if(jmpw_far_abs(0x18, 0x6475)) return;    /* jmp word 0x18:0x6475 */
        }
    }
}
