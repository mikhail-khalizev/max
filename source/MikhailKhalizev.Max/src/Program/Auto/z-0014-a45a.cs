using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8d773599-f8fd-4be2-8c71-baba25a88982")]
        public void Method_0014_a45a()
        {
            ii(0x14_a45a, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x14_a45d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_a460, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x14_a463, 3); callw(0x14_d1cb, 0x2d65);                 /* call 0xd1cb */
            ii(0x14_a466, 1); popw(cx);                                 /* pop cx */
            ii(0x14_a467, 1); popw(cx);                                 /* pop cx */
            ii(0x14_a468, 2); if(jmpw_func(0x14_a42e, -0x3c)) return;   /* jmp 0xa42e */
        }
    }
}
