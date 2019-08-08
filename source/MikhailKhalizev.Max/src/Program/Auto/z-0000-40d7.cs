using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("516aa3d3-5778-454a-a618-c24081e45b7f")]
        public void Method_0000_40d7()
        {
            ii(0x40d7, 5);    if(jmpw_abs(memw_a16[cs, 0x2fa])) return; /* jmp word [cs:0x2fa] */
        }
    }
}
