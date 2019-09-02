using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f420-13cb4a")]
        public void /* sys_mve */ Method_1018_f420()
        {
            ii(0x1018_f420, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
        }
    }
}
