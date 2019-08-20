using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c36-33cc4da0")]
        public void Method_0000_5c36()
        {
            ii(0x5c36, 3);    pushw(0x3e8f);                            /* push 0x3e8f */
            ii(0x5c39, 4);    if(jmpw_a16_far_ind(ds, 0xaf2)) return;   /* jmp far word [0xaf2] */
        }
    }
}
