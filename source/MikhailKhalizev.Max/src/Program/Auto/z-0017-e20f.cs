using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bfd8d622-5cfd-4bf9-895f-bbdeae731b29")]
        public void Method_0017_e20f()
        {
            ii(0x17_e20f, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_e211, 1); retfw(); return;                          /* retf */
        }
    }
}
