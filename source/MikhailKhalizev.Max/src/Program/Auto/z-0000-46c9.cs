using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x46c9-1bed5")]
        public void Method_0000_46c9()
        {
            ii(0x46c9, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x46cb, 1);    popw(ds);                                 /* pop ds */
        }
    }
}
