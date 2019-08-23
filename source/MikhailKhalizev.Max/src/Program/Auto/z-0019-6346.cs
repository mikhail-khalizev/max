using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_6346-f3ecfa67")]
        public void Method_0019_6346()
        {
            ii(0x19_6346, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6349, 3); if(jmp_func(0x19_7817, 0x14cb)) return;   /* jmp 0x7817 */
        }
    }
}
