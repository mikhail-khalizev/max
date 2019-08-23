using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1b8c-de9b9692")]
        public void Method_0001_1b8c()
        {
            ii(0x1_1b8c, 2);  mov(bx, sp);                              /* mov bx, sp */
            ii(0x1_1b8e, 4);  mov(ax, memw_a16[ss, bx + 0x2]);          /* mov ax, [ss:bx+0x2] */
            ii(0x1_1b92, 4);  mov(dx, memw_a16[ss, bx + 0x4]);          /* mov dx, [ss:bx+0x4] */
            ii(0x1_1b96, 2);  shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x1_1b98, 2);  rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x1_1b9a, 2);  shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x1_1b9c, 2);  rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x1_1b9e, 2);  shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x1_1ba0, 2);  rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x1_1ba2, 2);  shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x1_1ba4, 2);  rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x1_1ba6, 1);  retw();                                   /* ret */
        }
    }
}
