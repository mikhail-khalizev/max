using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("36283421-2b87-4c4f-9f3e-eea68c1ed9f5")]
        public void Method_0013_488e()
        {
            ii(0x13_488e, 1); pushw(ds);                                /* push ds */
            ii(0x13_488f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_4892, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_4894, 4); dec(memw_a16[ds, 0xd8]);                  /* dec word [0xd8] */
            ii(0x13_4898, 1); popw(ds);                                 /* pop ds */
            ii(0x13_4899, 1); retfw(); return;                          /* retf */
        }
    }
}
