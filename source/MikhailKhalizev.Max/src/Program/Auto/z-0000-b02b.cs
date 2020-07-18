using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb02b-2cc6e6e0")]
        public void Method_0000_b02b()
        {
            ii(0xb02b, 2);  push(0x1f);                                /* push 0x1f */
            ii(0xb02d, 3);  call(0x604d, -0x4fe3);                     /* call 0x604d */
        }
    }
}
