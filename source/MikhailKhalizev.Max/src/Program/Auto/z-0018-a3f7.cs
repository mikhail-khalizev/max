using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a3f7-1419559f")]
        public void Method_0018_a3f7()
        {
            ii(0x18_a3f7, 3); mov(memw[ss, bp + 0x16], ax);             /* mov [bp+0x16], ax */
            ii(0x18_a3fa, 3); if(jmp_func(0x18_a838, 0x43b)) return;    /* jmp 0xa838 */
        }
    }
}
