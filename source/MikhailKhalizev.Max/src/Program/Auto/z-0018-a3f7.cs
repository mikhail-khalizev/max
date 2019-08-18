using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("925703bd-aa64-4f20-8550-4f73484f3303")]
        public void Method_0018_a3f7()
        {
            ii(0x18_a3f7, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x18_a3fa, 3); if(jmpw_func(0x18_a838, 0x43b)) return;   /* jmp 0xa838 */
        }
    }
}
