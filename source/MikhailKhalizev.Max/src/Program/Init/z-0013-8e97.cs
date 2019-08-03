using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5a61b9f-046a-4581-aa91-87f03aced19a")]
        public void Method_0013_8e97()
        {
            ii(0x13_8e97, 2); pushd(eax);                               /* push eax */
            ii(0x13_8e99, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x13_8e9c, 3); mov(cr3, eax);                            /* mov cr3, eax */
            ii(0x13_8e9f, 2); popd(eax);                                /* pop eax */
            ii(0x13_8ea1, 1); retfw(); return;                          /* retf */
        }
    }
}
