using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c07569e-044f-45d3-ae4e-7a2ccb8c5405")]
        public void Method_0018_a6c8()
        {
            ii(0x18_a6c8, 3); callw(0x18_ab2c, 0x461);                  /* call 0xab2c */
            ii(0x18_a6cb, 1); retw(); return;                           /* ret */
        }
    }
}
