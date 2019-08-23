using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9b84-4ef9303b")]
        public void Method_0019_9b84()
        {
            ii(0x19_9b84, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_9b88, 1); push(ds);                                 /* push ds */
            ii(0x19_9b89, 3); push(0x1f04);                             /* push 0x1f04 */
            ii(0x19_9b8c, 5); call_far_abs(0x80, 0x5aca);               /* call word 0x80:0x5aca */
            ii(0x19_9b91, 1); pop(bx);                                  /* pop bx */
            ii(0x19_9b92, 1); pop(bx);                                  /* pop bx */
            ii(0x19_9b93, 3); push(0x2000);                             /* push 0x2000 */
            ii(0x19_9b96, 5); call_far_abs(0x80, 0x51e8);               /* call word 0x80:0x51e8 */
            ii(0x19_9b9b, 1); pop(bx);                                  /* pop bx */
            ii(0x19_9b9c, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_9b9f, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_9ba2, 1); push(dx);                                 /* push dx */
            ii(0x19_9ba3, 1); push(ax);                                 /* push ax */
            ii(0x19_9ba4, 3); call(0x19_fa6b, 0x5ec4);                  /* call 0xfa6b */
            ii(0x19_9ba7, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x19_9baa, 3); mov(memw[ds, 0x19e0], ax);                /* mov [0x19e0], ax */
            ii(0x19_9bad, 6); mov(memw[ds, 0x19e2], 0x1ffc);            /* mov word [0x19e2], 0x1ffc */
            ii(0x19_9bb3, 1); leave();                                  /* leave */
            ii(0x19_9bb4, 1); retf();                                   /* retf */
        }
    }
}
