using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7cf759a0-7a8a-4d32-ac5c-6e16d69845bc")]
        public void Method_0000_46cc_v2()
        {
            ii(0x46cc, 1);    wait();                                   /* wait */
            ii(0x46cd, 4);    if(jmpw_abs(memw_a16[ds, 0x9bc])) return; /* jmp word [0x9bc] */
        }
    }
}
