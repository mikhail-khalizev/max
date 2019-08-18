using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e54a58e7-3a90-48b5-9f5c-8fdf6b2d939a")]
        public void Method_0017_908b()
        {
            ii(0x17_908b, 1); cli();                                    /* cli */
            ii(0x17_908c, 2); pushd(eax);                               /* push eax */
            ii(0x17_908e, 3); mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x17_9091, 6); and(eax, 0x7fff_ffff);                    /* and eax, 0x7fffffff */
            ii(0x17_9097, 3); mov(cr0, eax);                            /* mov cr0, eax */
            ii(0x17_909a, 2); popd(eax);                                /* pop eax */
            ii(0x17_909c, 1); sti();                                    /* sti */
            ii(0x17_909d, 1); retfw(); return;                          /* retf */
        }
    }
}
