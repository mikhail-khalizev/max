using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f58e-13e8c6")]
        public void /* sys_mve */ Method_1018_f58e()
        {
            ii(0x1018_f58e, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
        }
    }
}
