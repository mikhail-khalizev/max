using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f6f4-5433c553")]
        public void /* sys_mve */ Method_1018_f6f4_v2()
        {
            ii(0x1018_f6f4, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_f6f7, 2); add(edi, edx);                          /* add edi, edx */
        }
    }
}
