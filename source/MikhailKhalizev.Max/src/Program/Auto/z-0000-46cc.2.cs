using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x46cc-2d8ed507")]
        public void Method_0000_46cc_v2()
        {
            ii(0x46cc, 1);    wait();                                   /* wait */
            ii(0x46cd, 4);    jmp_abs(memw[ds, 0x9bc]);                 /* jmp word [0x9bc] */
        }
    }
}
