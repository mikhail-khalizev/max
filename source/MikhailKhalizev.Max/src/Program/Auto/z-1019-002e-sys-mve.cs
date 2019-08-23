using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_002e-99ce")]
        public void /* sys_mve */ Method_1019_002e()
        {
            ii(0x1019_002e, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
        }
    }
}
