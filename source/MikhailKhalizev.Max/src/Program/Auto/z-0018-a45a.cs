using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("36d7c414-e6ca-4215-8629-ccb7dc58e9ce")]
        public void Method_0018_a45a()
        {
            ii(0x18_a45a, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x18_a45d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_a460, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x18_a463, 3); callw(0x18_d1cb, 0x2d65);                 /* call 0xd1cb */
            ii(0x18_a466, 1); popw(cx);                                 /* pop cx */
            ii(0x18_a467, 1); popw(cx);                                 /* pop cx */
            ii(0x18_a468, 2); if(jmpw_func(0x18_a42e, -0x3c)) return;   /* jmp 0xa42e */
        }
    }
}
