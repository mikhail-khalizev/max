using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90ba8bad-8865-4085-941d-9ff9ead10df8")]
        public void Method_0000_7b02()
        {
            ii(0x7b02, 4);    enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x7b06, 3);    callw(0x572a, -0x23df);                   /* call 0x572a */
            ii(0x7b09, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x7b0c, 3);    callw(0x5826, -0x22e9);                   /* call 0x5826 */
            ii(0x7b0f, 1);    popw(bx);                                 /* pop bx */
            ii(0x7b10, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x7b13, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0x7b16, 1);    pushw(ax);                                /* push ax */
            ii(0x7b17, 3);    callw(0x5826, -0x22f4);                   /* call 0x5826 */
            ii(0x7b1a, 1);    popw(bx);                                 /* pop bx */
            ii(0x7b1b, 3);    callw(0x4f61, -0x2bbd);                   /* call 0x4f61 */
            ii(0x7b1e, 1);    leavew();                                 /* leave */
            ii(0x7b1f, 1);    retw(); return;                           /* ret */
        }
    }
}
