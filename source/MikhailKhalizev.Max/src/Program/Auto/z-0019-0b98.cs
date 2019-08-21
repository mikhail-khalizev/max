using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0b98-30c54534")]
        public void Method_0019_0b98()
        {
            ii(0x19_0b98, 3); mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x19_0b9b, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x19_0b9e, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x19_0ba2, 1); retfw(); return;                          /* retf */
        }
    }
}
