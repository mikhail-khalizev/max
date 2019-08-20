using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f8e3-13e8c6")]
        public void /* sys_mve */ Method_1018_f8e3()
        {
            ii(0x1018_f8e3, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
        }
    }
}
