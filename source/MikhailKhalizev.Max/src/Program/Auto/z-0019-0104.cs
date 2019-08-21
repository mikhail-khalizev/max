using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0104-c09bd6ff")]
        public void Method_0019_0104()
        {
            ii(0x19_0104, 2); pushd(edx);                               /* push edx */
            ii(0x19_0106, 2); pushd(eax);                               /* push eax */
            ii(0x19_0108, 2); retfd(); return;                          /* o32 retf */
        }
    }
}
