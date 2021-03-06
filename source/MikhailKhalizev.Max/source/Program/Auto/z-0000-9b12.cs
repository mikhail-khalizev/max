using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9b12-86dba3e4")]
        public void Method_0000_9b12()
        {
            ii(0x9b12, 4);  enter(0x16, 0);                            /* enter 0x16, 0x0 */
            ii(0x9b16, 3);  call(0x773a, -0x23df);                     /* call 0x773a */
            ii(0x9b19, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x9b1c, 3);  call(0x7836, -0x22e9);                     /* call 0x7836 */
            ii(0x9b1f, 1);  pop(bx);                                   /* pop bx */
            ii(0x9b20, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x9b23, 3);  sub(ax, 8);                                /* sub ax, 0x8 */
            ii(0x9b26, 1);  push(ax);                                  /* push ax */
            ii(0x9b27, 3);  call(0x7836, -0x22f4);                     /* call 0x7836 */
            ii(0x9b2a, 1);  pop(bx);                                   /* pop bx */
            ii(0x9b2b, 3);  call(0x6f71, -0x2bbd);                     /* call 0x6f71 */
            ii(0x9b2e, 1);  leave();                                   /* leave */
            ii(0x9b2f, 1);  ret();                                     /* ret */
        }
    }
}
