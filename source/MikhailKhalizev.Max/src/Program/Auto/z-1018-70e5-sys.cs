using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_70e5-1165d2")]
        public void /* sys */ Method_1018_70e5()
        {
            ii(0x1018_70e5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_70e7, 1); retd(); return;                         /* ret */
        }
    }
}
