using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13faf315-e1cf-446f-afe6-ae45d9a7376c")]
        public void Method_0019_0ba3()
        {
            ii(0x19_0ba3, 3); mov(eax, cr2);                            /* mov eax, cr2 */
            ii(0x19_0ba6, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x19_0ba9, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x19_0bad, 1); retfw(); return;                          /* retf */
        }
    }
}
