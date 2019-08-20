using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ec67-13d357")]
        public void /* sys_mve */ Method_1018_ec67()
        {
            ii(0x1018_ec67, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
        }
    }
}
