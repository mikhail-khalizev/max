using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f8f3-13d357")]
        public void /* sys_mve */ Method_1018_f8f3()
        {
            ii(0x1018_f8f3, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
        }
    }
}
