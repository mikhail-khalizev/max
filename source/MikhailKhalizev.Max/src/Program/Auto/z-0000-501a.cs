using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x501a-568271c4")]
        public void Method_0000_501a()
        {
            ii(0x501a, 1);    pop(ax);                                  /* pop ax */
            ii(0x501b, 1);    int3();                                   /* int3 */
            ii(0x501c, 2);    add(memb[ds, bx + di], al);               /* add [bx+di], al */
            ii(0x501e, 2);    add(memb[ds, bx + di], al);               /* add [bx+di], al */
        }
    }
}
