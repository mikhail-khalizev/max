using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_633b-19cd52ec")]
        public void Method_0019_633b()
        {
            ii(0x19_633b, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x19_633e, 1); pushw(ss);                                /* push ss */
            ii(0x19_633f, 1); pushw(ax);                                /* push ax */
            ii(0x19_6340, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_6343, 3); callw(0x19_61c1, -0x185);                 /* call 0x61c1 */
            ii(0x19_6346, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6349, 3); if(jmpw_func(0x19_7817, 0x14cb)) return;  /* jmp 0x7817 */
        }
    }
}
