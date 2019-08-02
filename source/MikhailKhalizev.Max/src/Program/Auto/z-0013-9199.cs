using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f13aaf79-d5fa-4b92-a193-90a94bd8138e")]
        public void Method_0013_9199()
        {
            ii(0x13_9199, 1); pushw(ds);                                /* push ds */
            ii(0x13_919a, 1); popw(ax);                                 /* pop ax */
            ii(0x13_919b, 1); retfw(); return;                          /* retf */
        }
    }
}
