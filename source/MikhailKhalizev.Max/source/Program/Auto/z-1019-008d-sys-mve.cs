using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_008d-99ce")]
        public void /* sys_mve */ Method_1019_008d()
        {
            ii(0x1019_008d, 2);  mov(memd[ds, edi], eax);              /* mov [edi], eax */
        }
    }
}