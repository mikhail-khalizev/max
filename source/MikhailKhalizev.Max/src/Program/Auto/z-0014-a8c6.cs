using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16a19055-c2ab-422c-a145-ab4dd21038ae")]
        public void Method_0014_a8c6()
        {
            ii(0x14_a8c6, 3); callw(0x14_a8f3, 0x2a);                   /* call 0xa8f3 */
            ii(0x14_a8c9, 3); callw(0x14_a893, -0x39);                  /* call 0xa893 */
            ii(0x14_a8cc, 3); if(jmpw_func(0x14_b03d, 0x76e)) return;   /* jmp 0xb03d */
        }
    }
}
