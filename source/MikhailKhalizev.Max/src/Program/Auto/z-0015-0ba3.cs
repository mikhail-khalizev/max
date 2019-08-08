using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c42383f2-9ff4-4cf4-a5ac-c5c684f9eb20")]
        public void Method_0015_0ba3()
        {
            ii(0x15_0ba3, 3); mov(eax, cr2);                            /* mov eax, cr2 */
            ii(0x15_0ba6, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x15_0ba9, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x15_0bad, 1); retfw(); return;                          /* retf */
        }
    }
}
