using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c46-33cc4da0")]
        public void Method_0000_7c46()
        {
            ii(0x7c46, 3);  push(0x3e8f);                              /* push 0x3e8f */
            ii(0x7c49, 4);  jmp_far_ind(memw[ds, 0xaf2]);              /* jmp far word [0xaf2] */
        }
    }
}
