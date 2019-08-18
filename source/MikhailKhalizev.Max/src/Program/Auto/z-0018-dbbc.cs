using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dbbc-de9b9692")]
        public void Method_0018_dbbc()
        {
            ii(0x18_dbbc, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x18_dbbe, 4); mov(ax, memw_a16[ss, bx + 0x2]);          /* mov ax, [ss:bx+0x2] */
            ii(0x18_dbc2, 4); mov(dx, memw_a16[ss, bx + 0x4]);          /* mov dx, [ss:bx+0x4] */
            ii(0x18_dbc6, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x18_dbc8, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x18_dbca, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x18_dbcc, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x18_dbce, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x18_dbd0, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x18_dbd2, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x18_dbd4, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x18_dbd6, 1); retw(); return;                           /* ret */
        }
    }
}
