using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("42f51921-5567-4a84-ac09-c6d40f3b0968")]
        public void Method_0019_464a()
        {
            ii(0x19_464a, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x19_464e, 1); pushw(ds);                                /* push ds */
            ii(0x19_464f, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_4652, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_4654, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_4657, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_465a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_465c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_465e, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_4661, 1); pushw(ss);                                /* push ss */
            ii(0x19_4662, 1); pushw(ax);                                /* push ax */
            ii(0x19_4663, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x19_4665, 1); nop();                                    /* nop */
            ii(0x19_4666, 1); pushw(cs);                                /* push cs */
            ii(0x19_4667, 3); callw(0x19_4188, -0x4e2);                 /* call 0x4188 */
            ii(0x19_466a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_466d, 3); mov(ah, memb_a16[ss, bp - 0x2]);          /* mov ah, [bp-0x2] */
            ii(0x19_4670, 2); sub(al, al);                              /* sub al, al */
            ii(0x19_4672, 3); sar(ax, 0x8);                             /* sar ax, 0x8 */
            ii(0x19_4675, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4676, 1); leavew();                                 /* leave */
            ii(0x19_4677, 1); retfw(); return;                          /* retf */
        }
    }
}
