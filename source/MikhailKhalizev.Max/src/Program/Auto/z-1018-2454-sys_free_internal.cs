using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_2454-c4255caa")]
        public void /* sys */ sys_free_internal()
        {
            ii(0x1018_2454, 6);  call_abs(memd[ds, 0x101b_e820]);      /* call dword [0x101be820] */ /* Вызов 'Definitions.sys_free_with_check_memory_corrupt'. */
            ii(0x1018_245a, 1);  ret();                                /* ret */
        }
    }
}
