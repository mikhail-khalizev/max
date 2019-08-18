using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb19c-42b6a536")]
        public void Method_0000_b19c()
        {
            ii(0xb19c, 1);    pushw(dx);                                /* push dx */
            ii(0xb19d, 3);    callw(0x53e7, -0x5db9);                   /* call 0x53e7 */
            ii(0xb1a0, 1);    popw(dx);                                 /* pop dx */
            ii(0xb1a1, 1);    retw(); return;                           /* ret */
        }
    }
}
