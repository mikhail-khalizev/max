using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9b12-86dba3e4")]
        public void Method_0000_9b12()
        {
            ii(0x9b12, 4);    enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x9b16, 3);    callw(0x773a, -0x23df);                   /* call 0x773a */
            ii(0x9b19, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x9b1c, 3);    callw(0x7836, -0x22e9);                   /* call 0x7836 */
            ii(0x9b1f, 1);    popw(bx);                                 /* pop bx */
            ii(0x9b20, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x9b23, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0x9b26, 1);    pushw(ax);                                /* push ax */
            ii(0x9b27, 3);    callw(0x7836, -0x22f4);                   /* call 0x7836 */
            ii(0x9b2a, 1);    popw(bx);                                 /* pop bx */
            ii(0x9b2b, 3);    callw(0x6f71, -0x2bbd);                   /* call 0x6f71 */
            ii(0x9b2e, 1);    leavew();                                 /* leave */
            ii(0x9b2f, 1);    retw();                                   /* ret */
        }
    }
}
