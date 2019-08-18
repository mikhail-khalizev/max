using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2dab70b0-e84b-42ff-8b99-31d5a73cb2e5")]
        public void Method_0000_501a()
        {
            ii(0x501a, 1);    popw(ax);                                 /* pop ax */
            ii(0x501b, 1);    int3();                                   /* int3 */
            ii(0x501c, 2);    add(memb_a16[ds, bx + di], al);           /* add [bx+di], al */
            ii(0x501e, 2);    add(memb_a16[ds, bx + di], al);           /* add [bx+di], al */
        }
    }
}
