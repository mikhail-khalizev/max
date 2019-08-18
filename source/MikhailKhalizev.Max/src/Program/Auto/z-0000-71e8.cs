using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d59cfda-510e-4316-a275-bc814ded3838")]
        public void Method_0000_71e8()
        {
            ii(0x71e8, 3);    mov(ax, memw_a16[ds, 0xf88]);             /* mov ax, [0xf88] */
            ii(0x71eb, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x71ed, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x71f0, 1);    retw(); return;                           /* ret */
        }
    }
}
