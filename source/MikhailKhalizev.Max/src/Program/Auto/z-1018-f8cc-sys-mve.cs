using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f8cc-99ce")]
        public void /* sys_mve */ Method_1018_f8cc()
        {
            ii(0x1018_f8cc, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
        }
    }
}
