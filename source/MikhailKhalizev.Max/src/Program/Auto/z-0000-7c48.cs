using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c48-26f7cda7")]
        public void Method_0000_7c48()
        {
            ii(0x7c48, 5);    jmpw_a16_far_ind(ds, 0xaf2);              /* jmp far word [ds:0xaf2] */
        }
    }
}
