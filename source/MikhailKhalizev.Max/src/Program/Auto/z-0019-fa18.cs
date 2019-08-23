using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fa18-a7c9a570")]
        public void Method_0019_fa18()
        {
            ii(0x19_fa18, 1); pushw(ds);                                /* push ds */
            ii(0x19_fa19, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fa1c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fa1e, 4); mov(es, memw_a16[ds, 0x3fe0]);            /* mov es, [0x3fe0] */
            ii(0x19_fa22, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x19_fa26, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x19_fa28, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_fa2a, 4); mov(al, memb_a16[es, bx + 0x47]);         /* mov al, [es:bx+0x47] */
            ii(0x19_fa2e, 3); and(ax, 0x80);                            /* and ax, 0x80 */
            ii(0x19_fa31, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fa32, 1); retw();                                   /* ret */
        }
    }
}
