using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2018-26a7bcf9")]
        public void Method_1007_2018()
        {
            ii(0x1007_2018, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_fffd); /* mov dword [ebp-0xc], 0xfffffffd */
            ii(0x1007_201f, 2); if(jmpd_func(0x1007_2067, 0x46)) return; /* jmp 0x10072067 */
        }
    }
}
