using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a36db31c-d383-4d3d-98ce-088cb0a37d87")]
        public void Method_0014_b046()
        {
            ii(0x14_b046, 4); or(memb_a16[ss, bp + 0x26], 0x1);         /* or byte [bp+0x26], 0x1 */
            ii(0x14_b04a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_b04c, 1); pushw(ss);                                /* push ss */
            ii(0x14_b04d, 1); pushw(bp);                                /* push bp */
            ii(0x14_b04e, 1); sti();                                    /* sti */
            ii(0x14_b04f, 3); callw(0x14_c85e, 0x180c);                 /* call 0xc85e */
            ii(0x14_b052, 1); popw(cx);                                 /* pop cx */
        }
    }
}
