using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e76704e-d5e4-460c-927a-d6963ba88fb9")]
        public void Method_0014_dcef()
        {
            ii(0x14_dcef, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x14_dcf1, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x14_dcf3, 4); mov(cx, memw_a16[ss, bx + 0x2]);          /* mov cx, [ss:bx+0x2] */
            ii(0x14_dcf7, 1); pushw(cs);                                /* push cs */
            ii(0x14_dcf8, 3); callw(0x14_a3b9, -0x3942);                /* call 0xa3b9 */
        }
    }
}
