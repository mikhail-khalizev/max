using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4ca39a89-78d4-4cdd-b4d3-eb3d857f24ff")]
        public void Method_0014_0a40()
        {
            ii(0x14_0a40, 1); pushw(ds);                                /* push ds */
            ii(0x14_0a41, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_0a44, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_0a46, 3); mov(ax, memw_a16[ds, 0x1418]);            /* mov ax, [0x1418] */
            ii(0x14_0a49, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x14_0a4b, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x14_0a4d, 4); mov(al, memb_a16[es, bx + 0x47]);         /* mov al, [es:bx+0x47] */
            ii(0x14_0a51, 3); and(ax, 0x80);                            /* and ax, 0x80 */
            ii(0x14_0a54, 1); popw(ds);                                 /* pop ds */
            ii(0x14_0a55, 1); retw(); return;                           /* ret */
        }
    }
}
