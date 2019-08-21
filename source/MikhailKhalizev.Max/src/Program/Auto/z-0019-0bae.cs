using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0bae-5f63452c")]
        public void Method_0019_0bae()
        {
            ii(0x19_0bae, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x19_0bb1, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x19_0bb4, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x19_0bb8, 1); retfw(); return;                          /* retf */
        }
    }
}
