using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4055-5052")]
        public void Method_0000_4055()
        {
            ii(0x4055, 1);    popa();                                   /* popa */
            ii(0x4056, 1);    retw(); return;                           /* ret */
        }
    }
}
