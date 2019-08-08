using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a9030af-7009-4453-8884-61611852bda8")]
        public void Method_0000_702a()
        {
            ii(0x702a, 1);    popw(ax);                                 /* pop ax */
            ii(0x702b, 1);    int3();                                   /* int3 */
            ii(0x702c, 2);    add(memb_a16[ds, bx + di], al);           /* add [bx+di], al */
            ii(0x702e, 2);    add(memb_a16[ds, bx + di], al);           /* add [bx+di], al */
        }
    }
}
