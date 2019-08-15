using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1740e17b-8c25-401f-8c24-feeca0703b86")]
        public void Method_0014_b58c()
        {
            ii(0x14_b58c, 1); pusha();                                  /* pusha */
            ii(0x14_b58d, 3); mov(ax, memw_a16[ds, 0x9b4]);             /* mov ax, [0x9b4] */
            ii(0x14_b590, 1); pushw(ax);                                /* push ax */
            ii(0x14_b591, 1); pushw(ax);                                /* push ax */
            ii(0x14_b592, 2); mov(ax, sp);                              /* mov ax, sp */
            ii(0x14_b594, 1); pushw(ss);                                /* push ss */
            ii(0x14_b595, 1); pushw(ax);                                /* push ax */
            ii(0x14_b596, 1); pushw(ss);                                /* push ss */
            ii(0x14_b597, 1); pushw(ax);                                /* push ax */
            ii(0x14_b598, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x14_b59a, 4); callw_a16_far_ind(ds, 0x22);              /* call far word [0x22] */
            ii(0x14_b59e, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x14_b5a1, 1); popa();                                   /* popa */
            ii(0x14_b5a2, 1); retw(); return;                           /* ret */
        }
    }
}
