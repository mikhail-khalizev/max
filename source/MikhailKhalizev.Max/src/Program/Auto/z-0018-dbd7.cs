using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dbd7-f6cc0e92")]
        public void Method_0018_dbd7()
        {
            ii(0x18_dbd7, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x18_dbd9, 4); mov(ax, memw_a16[ss, bx + 0x2]);          /* mov ax, [ss:bx+0x2] */
            ii(0x18_dbdd, 4); mov(dx, memw_a16[ss, bx + 0x4]);          /* mov dx, [ss:bx+0x4] */
            ii(0x18_dbe1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x18_dbe3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x18_dbe5, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x18_dbe7, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x18_dbe9, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x18_dbeb, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x18_dbed, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x18_dbef, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x18_dbf1, 1); retw(); return;                           /* ret */
        }
    }
}
