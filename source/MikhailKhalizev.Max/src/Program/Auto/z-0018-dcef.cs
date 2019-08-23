using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dcef-7b39420c")]
        public void Method_0018_dcef()
        {
            ii(0x18_dcef, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_dcf1, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x18_dcf3, 4); mov(cx, memw_a16[ss, bx + 0x2]);          /* mov cx, [ss:bx+0x2] */
            ii(0x18_dcf7, 1); pushw(cs);                                /* push cs */
            ii(0x18_dcf8, 3); callw(0x18_a3b9, -0x3942);                /* call 0xa3b9 */
            ii(0x18_dcfb, 1); cmc();                                    /* cmc */
            ii(0x18_dcfc, 2); sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x18_dcfe, 2); and(ax, bx);                              /* and ax, bx */
            ii(0x18_dd00, 1); retw();                                   /* ret */
        }
    }
}
