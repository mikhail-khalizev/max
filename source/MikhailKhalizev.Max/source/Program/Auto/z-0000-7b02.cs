using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7b02-86dba3e4")]
        public void Method_0000_7b02()
        {
            ii(0x7b02, 4);  enter(0x16, 0);                            /* enter 0x16, 0x0 */
            ii(0x7b06, 3);  call(0x572a, -0x23df);                     /* call 0x572a */
            ii(0x7b09, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x7b0c, 3);  call(0x5826, -0x22e9);                     /* call 0x5826 */
            ii(0x7b0f, 1);  pop(bx);                                   /* pop bx */
            ii(0x7b10, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x7b13, 3);  sub(ax, 8);                                /* sub ax, 0x8 */
            ii(0x7b16, 1);  push(ax);                                  /* push ax */
            ii(0x7b17, 3);  call(0x5826, -0x22f4);                     /* call 0x5826 */
            ii(0x7b1a, 1);  pop(bx);                                   /* pop bx */
            ii(0x7b1b, 3);  call(0x4f61, -0x2bbd);                     /* call 0x4f61 */
            ii(0x7b1e, 1);  leave();                                   /* leave */
            ii(0x7b1f, 1);  ret();                                     /* ret */
        }
    }
}
