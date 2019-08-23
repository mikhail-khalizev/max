using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b58c-df90dad1")]
        public void Method_0018_b58c()
        {
            ii(0x18_b58c, 1); pusha();                                  /* pusha */
            ii(0x18_b58d, 3); mov(ax, memw_a16[ds, 0x9b4]);             /* mov ax, [0x9b4] */
            ii(0x18_b590, 1); pushw(ax);                                /* push ax */
            ii(0x18_b591, 1); pushw(ax);                                /* push ax */
            ii(0x18_b592, 2); mov(ax, sp);                              /* mov ax, sp */
            ii(0x18_b594, 1); pushw(ss);                                /* push ss */
            ii(0x18_b595, 1); pushw(ax);                                /* push ax */
            ii(0x18_b596, 1); pushw(ss);                                /* push ss */
            ii(0x18_b597, 1); pushw(ax);                                /* push ax */
            ii(0x18_b598, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x18_b59a, 4); callw_a16_far_ind(ds, 0x22);              /* call far word [0x22] */
            ii(0x18_b59e, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x18_b5a1, 1); popa();                                   /* popa */
            ii(0x18_b5a2, 1); retw();                                   /* ret */
        }
    }
}
