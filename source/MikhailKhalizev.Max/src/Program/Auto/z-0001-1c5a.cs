using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("216db54a-6837-47e6-a5de-9ba95b0760e6")]
        public void Method_0001_1c5a()
        {
            ii(0x1_1c5a, 1);  popw(si);                                 /* pop si */
            ii(0x1_1c5b, 2);  xor(ax, ax);                              /* xor ax, ax */
            ii(0x1_1c5d, 1);  retw(); return;                           /* ret */
        }
    }
}
