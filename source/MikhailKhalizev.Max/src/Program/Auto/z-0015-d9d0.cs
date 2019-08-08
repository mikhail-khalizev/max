using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5cceadfd-0627-4d22-b3e3-ae5896ffede3")]
        public void Method_0015_d9d0()
        {
            ii(0x15_d9d0, 1); pushw(bp);                                /* push bp */
            ii(0x15_d9d1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_d9d3, 3); mov(ax, 0x507);                           /* mov ax, 0x507 */
            ii(0x15_d9d6, 2); if(jmpw_func(0x15_d9ad, -0x2b)) return;   /* jmp 0xd9ad */
        }
    }
}
