using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1ba7-f6cc0e92")]
        public void Method_0001_1ba7()
        {
            ii(0x1_1ba7, 2);  mov(bx, sp);                              /* mov bx, sp */
            ii(0x1_1ba9, 4);  mov(ax, memw[ss, bx + 2]);                /* mov ax, [ss:bx+0x2] */
            ii(0x1_1bad, 4);  mov(dx, memw[ss, bx + 4]);                /* mov dx, [ss:bx+0x4] */
            ii(0x1_1bb1, 2);  shl(ax, 1);                               /* shl ax, 1 */
            ii(0x1_1bb3, 2);  rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x1_1bb5, 2);  shl(ax, 1);                               /* shl ax, 1 */
            ii(0x1_1bb7, 2);  rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x1_1bb9, 2);  shl(ax, 1);                               /* shl ax, 1 */
            ii(0x1_1bbb, 2);  rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x1_1bbd, 2);  shl(ax, 1);                               /* shl ax, 1 */
            ii(0x1_1bbf, 2);  rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x1_1bc1, 1);  ret();                                    /* ret */
        }
    }
}
