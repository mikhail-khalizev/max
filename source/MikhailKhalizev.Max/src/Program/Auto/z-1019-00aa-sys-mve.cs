using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_00aa-99ce")]
        public void /* sys_mve */ Method_1019_00aa()
        {
            ii(0x1019_00aa, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
        }
    }
}