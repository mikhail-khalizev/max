using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f4b08913-fad5-4c24-b481-d9f1ddfc25ee")]
        public void Method_0018_dc8a()
        {
            ii(0x18_dc8a, 1); popw(si);                                 /* pop si */
            ii(0x18_dc8b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_dc8d, 1); retw(); return;                           /* ret */
        }
    }
}
