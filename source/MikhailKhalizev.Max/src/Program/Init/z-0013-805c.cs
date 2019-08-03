using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c53491c0-c5db-4869-a007-d80bf8b0002c")]
        public void Method_0013_805c()
        {
            ii(0x13_805c, 1); pushw(bp);                                /* push bp */
            ii(0x13_805d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_805f, 1); pushw(ds);                                /* push ds */
            ii(0x13_8060, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_8063, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_8065, 2); mov(ah, 0x34);                            /* mov ah, 0x34 */
            ii(0x13_8067, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_8069, 1); dec(bx);                                  /* dec bx */
            ii(0x13_806a, 4); mov(memw_a16[ds, 0xa26], bx);             /* mov [0xa26], bx */
            ii(0x13_806e, 4); mov(memw_a16[ds, 0xa28], es);             /* mov [0xa28], es */
            ii(0x13_8072, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x13_8074, 4); pushw(memw_a16[ds, 0xa28]);               /* push word [0xa28] */
            ii(0x13_8078, 4); pushw(memw_a16[ds, 0xa26]);               /* push word [0xa26] */
            ii(0x13_807c, 1); nop();                                    /* nop */
            ii(0x13_807d, 1); pushw(cs);                                /* push cs */
            ii(0x13_807e, 3); callw(0x13_ea1e, 0x699d);                 /* call 0xea1e */
            ii(0x13_8081, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_8084, 3); mov(memw_a16[ds, 0xa26], ax);             /* mov [0xa26], ax */
            ii(0x13_8087, 4); mov(memw_a16[ds, 0xa28], dx);             /* mov [0xa28], dx */
            ii(0x13_808b, 1); popw(ds);                                 /* pop ds */
            ii(0x13_808c, 1); leavew();                                 /* leave */
            ii(0x13_808d, 1); retfw(); return;                          /* retf */
        }
    }
}
