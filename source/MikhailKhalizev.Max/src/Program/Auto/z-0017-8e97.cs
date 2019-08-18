using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("359aca30-2c1c-43fc-8af9-41c12edb102f")]
        public void Method_0017_8e97()
        {
            ii(0x17_8e97, 2); pushd(eax);                               /* push eax */
            ii(0x17_8e99, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x17_8e9c, 3); mov(cr3, eax);                            /* mov cr3, eax */
            ii(0x17_8e9f, 2); popd(eax);                                /* pop eax */
            ii(0x17_8ea1, 1); retfw(); return;                          /* retf */
        }
    }
}
