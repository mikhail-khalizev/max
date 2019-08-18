using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b046-a5737d0")]
        public void Method_0018_b046()
        {
            ii(0x18_b046, 4); or(memb_a16[ss, bp + 0x26], 0x1);         /* or byte [bp+0x26], 0x1 */
            ii(0x18_b04a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_b04c, 1); pushw(ss);                                /* push ss */
            ii(0x18_b04d, 1); pushw(bp);                                /* push bp */
            ii(0x18_b04e, 1); sti();                                    /* sti */
            ii(0x18_b04f, 3); callw(0x18_c85e, 0x180c);                 /* call 0xc85e */
            ii(0x18_b052, 1); popw(cx);                                 /* pop cx */
            ii(0x18_b053, 1); popw(cx);                                 /* pop cx */
            ii(0x18_b054, 1); popw(cx);                                 /* pop cx */
            ii(0x18_b055, 3); if(jmpw_func(0x18_a838, -0x820)) return;  /* jmp 0xa838 */
        }
    }
}
