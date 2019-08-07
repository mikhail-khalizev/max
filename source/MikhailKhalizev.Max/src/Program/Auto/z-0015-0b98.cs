using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3db8be65-8e47-465d-bf5f-f549fc0f02e1")]
        public void Method_0015_0b98()
        {
            ii(0x15_0b98, 3); mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x15_0b9b, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x15_0b9e, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x15_0ba2, 1); retfw(); return;                          /* retf */
        }
    }
}
