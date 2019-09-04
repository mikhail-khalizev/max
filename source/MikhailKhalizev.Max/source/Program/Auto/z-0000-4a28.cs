using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4a28-e6846d66")]
        public void Method_0000_4a28()
        {
            ii(0x4a28, 3);  mov(ax, memw[ds, 0xf88]);                  /* mov ax, [0xf88] */
            ii(0x4a2b, 2);  or(al, 1);                                 /* or al, 0x1 */
            ii(0x4a2d, 3);  lmsw(ax);                                  /* lmsw ax */
            ii(0x4a30, 1);  ret();                                     /* ret */
        }
    }
}
