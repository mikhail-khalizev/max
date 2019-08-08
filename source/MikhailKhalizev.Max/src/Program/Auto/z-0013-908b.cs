using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e3d8976-2f54-47f9-bb8e-71aef613c480")]
        public void Method_0013_908b()
        {
            ii(0x13_908b, 1); cli();                                    /* cli */
            ii(0x13_908c, 2); pushd(eax);                               /* push eax */
            ii(0x13_908e, 3); mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x13_9091, 6); and(eax, 0x7fff_ffff);                    /* and eax, 0x7fffffff */
            ii(0x13_9097, 3); mov(cr0, eax);                            /* mov cr0, eax */
            ii(0x13_909a, 2); popd(eax);                                /* pop eax */
            ii(0x13_909c, 1); sti();                                    /* sti */
            ii(0x13_909d, 1); retfw(); return;                          /* retf */
        }
    }
}
