using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7e39-19e2273")]
        public void Method_0000_7e39()
        {
            ii(0x7e39, 3);    callw(0x66dc, -0x1760);                   /* call 0x66dc */
            ii(0x7e3c, 1);    retw(); return;                           /* ret */
        }
    }
}
