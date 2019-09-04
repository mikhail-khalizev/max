using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfb7c-de9b9692")]
        public void Method_0000_fb7c()
        {
            ii(0xfb7c, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xfb7e, 4);    mov(ax, memw[ss, bx + 2]);                /* mov ax, [ss:bx+0x2] */
            ii(0xfb82, 4);    mov(dx, memw[ss, bx + 4]);                /* mov dx, [ss:bx+0x4] */
            ii(0xfb86, 2);    shr(dx, 1);                               /* shr dx, 1 */
            ii(0xfb88, 2);    rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0xfb8a, 2);    shr(dx, 1);                               /* shr dx, 1 */
            ii(0xfb8c, 2);    rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0xfb8e, 2);    shr(dx, 1);                               /* shr dx, 1 */
            ii(0xfb90, 2);    rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0xfb92, 2);    shr(dx, 1);                               /* shr dx, 1 */
            ii(0xfb94, 2);    rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0xfb96, 1);    ret();                                    /* ret */
        }
    }
}
