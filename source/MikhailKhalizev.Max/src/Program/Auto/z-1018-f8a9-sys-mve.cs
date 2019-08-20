using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f8a9-13d357")]
        public void /* sys_mve */ Method_1018_f8a9()
        {
            ii(0x1018_f8a9, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
        }
    }
}
