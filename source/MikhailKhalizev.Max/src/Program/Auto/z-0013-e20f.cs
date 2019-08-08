using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bcb8f621-beb5-4d56-8658-a4f4353dcfc9")]
        public void Method_0013_e20f()
        {
            ii(0x13_e20f, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_e211, 1); retfw(); return;                          /* retf */
        }
    }
}
