using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d3d7a84a-345b-4937-9f88-4f9a81e18519")]
        public void Method_0000_486a()
        {
            ii(0x486a, 1);    popw(ax);                                 /* pop ax */
            ii(0x486b, 1);    int3();                                   /* int3 */
            ii(0x486c, 2);    add(memb_a16[ds, bx + di], al);           /* add [bx+di], al */
            ii(0x486e, 2);    add(memb_a16[ds, bx + di], al);           /* add [bx+di], al */
        }
    }
}
