using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_daf7-53327d29")]
        public void Method_0018_daf7()
        {
            ii(0x18_daf7, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x18_daf9, 4); mov(ax, memw[ss, bx + 0x2]);              /* mov ax, [ss:bx+0x2] */
            ii(0x18_dafd, 3); add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x18_db00, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x18_db02, 2); mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x18_db04, 2); shr(ax, cl);                              /* shr ax, cl */
            ii(0x18_db06, 1); ret();                                    /* ret */
        }
    }
}
