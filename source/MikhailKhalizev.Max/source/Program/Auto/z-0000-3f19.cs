using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3f19-a84c5")]
        public void Method_0000_3f19()
        {
            ii(0x3f19, 2);  push(0x20);                                /* push 0x20 */
            ii(0x3f1b, 1);  pop(ds);                                   /* pop ds */
        }
    }
}
