using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9cf4ed2f-fd29-4144-a47f-fc96b0a680a2")]
        public void Method_0000_7aab()
        {
            ii(0x7aab, 1);    pushw(bp);                                /* push bp */
            ii(0x7aac, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7aae, 3);    pushw(0x92);                              /* push 0x92 */
            ii(0x7ab1, 3);    pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x7ab4, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x7ab6, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x7ab9, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x7abc, 3);    callw(0x7a5a, -0x65);                     /* call 0x7a5a */
            ii(0x7abf, 1);    leavew();                                 /* leave */
            ii(0x7ac0, 1);    retw(); return;                           /* ret */
        }
    }
}
