using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d9d0-cf548906")]
        public void Method_0019_d9d0()
        {
            ii(0x19_d9d0, 1); push(bp);                                 /* push bp */
            ii(0x19_d9d1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d9d3, 3); mov(ax, 0x507);                           /* mov ax, 0x507 */
            ii(0x19_d9d6, 2); if(jmp_func(0x19_d9ad, -0x2b)) return;    /* jmp 0xd9ad */
        }
    }
}
