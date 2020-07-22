using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8c04-75b6fc83")]
        public void Method_0019_8c04()
        {
            ii(0x19_8c04, 1);  push(bp);                               /* push bp */
            ii(0x19_8c05, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_8c07, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_8c0a, 4);  mov(ax, memw[es, bx + 54]);             /* mov ax, [es:bx+0x36] */
            ii(0x19_8c0e, 4);  mov(memw[es, bx + 16], ax);             /* mov [es:bx+0x10], ax */
            ii(0x19_8c12, 6);  mov(memw[es, bx + 18], 0);              /* mov word [es:bx+0x12], 0x0 */
            ii(0x19_8c18, 1);  leave();                                /* leave */
            ii(0x19_8c19, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
