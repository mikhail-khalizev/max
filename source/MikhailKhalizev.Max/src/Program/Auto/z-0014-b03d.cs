using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d20340eb-42eb-4169-9b5c-3c36d430c779")]
        public void Method_0014_b03d()
        {
            ii(0x14_b03d, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x14_b040, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x14_b043, 3); if(jmpw_func(0x14_a82f, -0x817)) return;  /* jmp 0xa82f */
        }
    }
}
