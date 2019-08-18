using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_2767-90e68")]
        public void Method_0019_2767()
        {
            ii(0x19_2767, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_2769, 1); retfw(); return;                          /* retf */
        }
    }
}
