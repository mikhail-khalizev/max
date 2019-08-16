using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("39d88f7f-369e-482a-a822-02facef0ce8c")]
        public void Method_0000_f028()
        {
            ii(0xf028, 1);    pushw(bp);                                /* push bp */
            ii(0xf029, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xf02b, 3);    mov(bp, memw_a16[ss, bp + 0x4]);          /* mov bp, [bp+0x4] */
            ii(0xf02e, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0xf032, 4);    mov(memb_a16[ds, bx + 0x17], 0x48);       /* mov byte [bx+0x17], 0x48 */
            ii(0xf036, 3);    callw(0xe863, -0x7d6);                    /* call 0xe863 */
        }
    }
}
