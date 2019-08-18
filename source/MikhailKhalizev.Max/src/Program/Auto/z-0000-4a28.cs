using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("32d52e21-bfff-48cf-beb7-25f0eeba7bc0")]
        public void Method_0000_4a28()
        {
            ii(0x4a28, 3);    mov(ax, memw_a16[ds, 0xf88]);             /* mov ax, [0xf88] */
            ii(0x4a2b, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x4a2d, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x4a30, 1);    retw(); return;                           /* ret */
        }
    }
}
