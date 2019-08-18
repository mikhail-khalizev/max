using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6065-5052")]
        public void Method_0000_6065()
        {
            ii(0x6065, 1);    popa();                                   /* popa */
            ii(0x6066, 1);    retw(); return;                           /* ret */
        }
    }
}
