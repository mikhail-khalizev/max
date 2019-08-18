using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da12d145-e44b-40da-831c-d34c00e899fc")]
        public void Method_0000_b02b()
        {
            ii(0xb02b, 2);    pushw(0x1f);                              /* push 0x1f */
            ii(0xb02d, 3);    callw(0x604d, -0x4fe3);                   /* call 0x604d */
        }
    }
}
