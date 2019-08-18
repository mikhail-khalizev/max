using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d54f-a8e718c9")]
        public void Method_0017_d54f()
        {
            ii(0x17_d54f, 1); pushw(bp);                                /* push bp */
            ii(0x17_d550, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d552, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x17_d554, 2); if(jmpw_func(0x17_d570, 0x1a)) return;    /* jmp 0xd570 */
        }
    }
}
