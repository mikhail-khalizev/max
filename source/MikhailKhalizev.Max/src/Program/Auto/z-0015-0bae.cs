using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d522c4a-55ec-490c-bb06-77c44dd3d93a")]
        public void Method_0015_0bae()
        {
            ii(0x15_0bae, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x15_0bb1, 3); mov(edx, eax);                            /* mov edx, eax */
            ii(0x15_0bb4, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x15_0bb8, 1); retfw(); return;                          /* retf */
        }
    }
}
