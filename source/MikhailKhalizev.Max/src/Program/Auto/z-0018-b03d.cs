using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b03d-858a1c4")]
        public void Method_0018_b03d()
        {
            ii(0x18_b03d, 3);  mov(ax, memw[ds, bx + 22]);             /* mov ax, [bx+0x16] */
            ii(0x18_b040, 3);  mov(memw[ss, bp + 22], ax);             /* mov [bp+0x16], ax */
            ii(0x18_b043, 3);  jmp_func(0x18_a82f, -0x817);            /* jmp 0xa82f */
        }
    }
}
