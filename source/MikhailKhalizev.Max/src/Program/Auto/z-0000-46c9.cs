using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x46c9-a84c5")]
        public void Method_0000_46c9()
        {
            ii(0x46c9, 2);    push(0x20);                               /* push 0x20 */
            ii(0x46cb, 1);    pop(ds);                                  /* pop ds */
        }
    }
}
