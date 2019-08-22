using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa1bd-6a81d78b")]
        public void Method_0000_a1bd()
        {
            ii(0xa1bd, 1);    pushw(bp);                                /* push bp */
            ii(0xa1be, 1);    cli();                                    /* cli */
            ii(0xa1bf, 3);    callw(0x4989, -0x5839);                   /* call 0x4989 */
            ii(0xa1c2, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa1c4, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0xa1c6, 4);    pushw(memw_a16[ds, 0]);                   /* push word [0x0] */
            ii(0xa1ca, 4);    pushw(memw_a16[ds, 0x2]);                 /* push word [0x2] */
            ii(0xa1ce, 4);    pushw(memw_a16[ds, 0x4]);                 /* push word [0x4] */
            ii(0xa1d2, 5);    mov(memw_a16[ss, 0xf7a], sp);             /* mov [ss:0xf7a], sp */
            ii(0xa1d7, 3);    mov(cx, 0x14);                            /* mov cx, 0x14 */
        l_0xa1da:
            ii(0xa1da, 1);    pushw(ax);                                /* push ax */
            ii(0xa1db, 2);    if(loopw_a16(0xa1da, -0x3)) goto l_0xa1da; /* loop 0xa1da */
            ii(0xa1dd, 4);    mov(memw_a16[ds, 0x469], ss);             /* mov [0x469], ss */
            ii(0xa1e1, 4);    mov(memw_a16[ds, 0x467], sp);             /* mov [0x467], sp */
            ii(0xa1e5, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0xa1e7, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0xa1e9, 5);    mov(memb_a16[ds, 0], 0xea);               /* mov byte [0x0], 0xea */
            ii(0xa1ee, 6);    mov(memw_a16[ds, 0x1], 0x6485);           /* mov word [0x1], 0x6485 */
            ii(0xa1f4, 4);    mov(memw_a16[ds, 0x3], cs);               /* mov [0x3], cs */
            ii(0xa1f8, 2);    mov(al, 0x9);                             /* mov al, 0x9 */
            ii(0xa1fa, 2);    outb(0x71, al);                           /* out 0x71, al */
            ii(0xa1fc, 6);    lgdtw_a16(ss, 0x8c8);                     /* lgdt [ss:0x8c8] */
            ii(0xa202, 6);    lidtw_a16(ss, 0x8d0);                     /* lidt [ss:0x8d0] */
            ii(0xa208, 3);    smsw(ax);                                 /* smsw ax */
            ii(0xa20b, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0xa20d, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0xa210, 5);    if(jmpw_far_abs(0x18, 0x6475)) return;    /* jmp word 0x18:0x6475 */
        }
    }
}