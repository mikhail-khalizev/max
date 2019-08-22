using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ffd7-99ce")]
        public void /* sys_mve */ Method_1018_ffd7()
        {
            ii(0x1018_ffd7, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
        }
    }
}