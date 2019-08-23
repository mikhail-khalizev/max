using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c38-26f7cda7")]
        public void Method_0000_5c38()
        {
            ii(0x5c38, 5);    jmp_far_ind(ds, 0xaf2);                   /* jmp far word [ds:0xaf2] */
        }
    }
}
