using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_0011-99ce")]
        public void /* sys_mve */ Method_1019_0011()
        {
            ii(0x1019_0011, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
        }
    }
}
