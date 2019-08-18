using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5fbd5ed-b4cc-45a8-90d9-eaed8fc4e26c")]
        public void Method_0000_46cc()
        {
            ii(0x46cc, 1);    nop();                                    /* nop */
            ii(0x46cd, 4);    if(jmpw_abs(memw_a16[ds, 0x9bc])) return; /* jmp word [0x9bc] */
        }
    }
}
