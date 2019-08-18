using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5d2380a7-91a8-43e2-bf54-a65b9eaa190e")]
        public void /* sys */ sys_malloc_internal()
        {
            ii(0x1018_22f0, 6); calld_abs(memd_a32[ds, 0x101b_e818]);   /* call dword [0x101be818] */ /* Вызов '0x1018_22f8'. */
            ii(0x1018_22f6, 1); retd(); return;                         /* ret */
        }
    }
}
