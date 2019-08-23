using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6ce4-18932700")]
        public void Method_0000_6ce4()
        {
            ii(0x6ce4, 1);    pushfw();                                 /* pushfw */
            ii(0x6ce5, 1);    cli();                                    /* cli */
            ii(0x6ce6, 1);    push(dx);                                 /* push dx */
            ii(0x6ce7, 2);    push(ebx);                                /* push ebx */
            ii(0x6ce9, 1);    push(bp);                                 /* push bp */
            ii(0x6cea, 1);    push(ds);                                 /* push ds */
            ii(0x6ceb, 3);    mov(dx, 0x1a2);                           /* mov dx, 0x1a2 */
            ii(0x6cee, 1);    push(es);                                 /* push es */
            ii(0x6cef, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x6cf1, 4);    mov(bp, memw[ds, 0x996]);                 /* mov bp, [0x996] */
            ii(0x6cf5, 3);    call(0x6040, -0xcb8);                     /* call 0x6040 */
            ii(0x6cf8, 1);    pop(dx);                                  /* pop dx */
            ii(0x6cf9, 5);    jmp_far_abs(0x70, 0x47c);                 /* jmp word 0x70:0x47c */
        }
    }
}
