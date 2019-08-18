using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("50250dde-fd76-4ee0-adbe-07adc1e8f196")]
        public void Method_0018_d0fa()
        {
            ii(0x18_d0fa, 1); pushw(bp);                                /* push bp */
            ii(0x18_d0fb, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_d0fd, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x18_d100, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_d103, 3); callw(0x18_d0ac, -0x5a);                  /* call 0xd0ac */
            ii(0x18_d106, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d107, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d108, 1); leavew();                                 /* leave */
            ii(0x18_d109, 1); retw(); return;                           /* ret */
        }
    }
}
