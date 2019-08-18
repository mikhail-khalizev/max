using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9927c86b-9a8b-4835-b751-e4288b44bc9d")]
        public void Method_0000_4cd4()
        {
            ii(0x4cd4, 1);    pushfw();                                 /* pushfw */
            ii(0x4cd5, 1);    cli();                                    /* cli */
            ii(0x4cd6, 1);    pushw(dx);                                /* push dx */
            ii(0x4cd7, 2);    pushd(ebx);                               /* push ebx */
            ii(0x4cd9, 1);    pushw(bp);                                /* push bp */
            ii(0x4cda, 1);    pushw(ds);                                /* push ds */
            ii(0x4cdb, 3);    mov(dx, 0x1a2);                           /* mov dx, 0x1a2 */
            ii(0x4cde, 1);    pushw(es);                                /* push es */
            ii(0x4cdf, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x4ce1, 4);    mov(bp, memw_a16[ds, 0x996]);             /* mov bp, [0x996] */
            ii(0x4ce5, 3);    callw(0x4030, -0xcb8);                    /* call 0x4030 */
            ii(0x4ce8, 1);    popw(dx);                                 /* pop dx */
            ii(0x4ce9, 5);    if(jmpw_far_abs(0x70, 0x47c)) return;     /* jmp word 0x70:0x47c */
        }
    }
}
