using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_0060-13cb4a")]
        public void /* sys_mve */ Method_1019_0060()
        {
            ii(0x1019_0060, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
        }
    }
}
