using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("98afe8f4-a52e-4ba1-b7b5-a7d860ef4074")]
        public void Method_1028_929d()
        {
            ii(0x1028_929d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1028_929e, 5); mov(ecx, 0xffff);                       /* mov ecx, 0xffff */
        l_0x1028_92a3:
            ii(0x1028_92a3, 1); nop();                                  /* nop */
            ii(0x1028_92a4, 2); if(loopd_a32(0x1028_92a3, -0x3)) goto l_0x1028_92a3; /* loop 0x102892a3 */
            ii(0x1028_92a6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1028_92a7, 1); retd(); return;                         /* ret */
        }
    }
}
