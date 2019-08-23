using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e212-325ab19f")]
        public void Method_0017_e212()
        {
            ii(0x17_e212, 3); mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x17_e215, 3); if(jmp_func(0x17_d16b, -0x10ad)) return;  /* jmp 0xd16b */
        }
    }
}
