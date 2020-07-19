using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_22f0-c6de1692")]
        public void /* sys */ sys_malloc_internal()
        {
            ii(0x1018_22f0, 6);  call_abs(memd[ds, 0x101b_e818]);      /* call dword [0x101be818] */ /* Вызов '0x1018_22f8'. */
            ii(0x1018_22f6, 1);  ret();                                /* ret */
        }
    }
}
