using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fd97-99ce")]
        public void /* sys_mve */ Method_1018_fd97()
        {
            ii(0x1018_fd97, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
        }
    }
}
