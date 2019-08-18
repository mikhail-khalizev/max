using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_40b7-c1642391")]
        public void Method_0019_40b7()
        {
            ii(0x19_40b7, 1); pushw(ax);                                /* push ax */
            ii(0x19_40b8, 1); pushw(es);                                /* push es */
            ii(0x19_40b9, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x19_40bc, 1); popw(es);                                 /* pop es */
            ii(0x19_40bd, 5); pushw(memw_a16[es, 0x3b78]);              /* push word [es:0x3b78] */
            ii(0x19_40c2, 1); popw(es);                                 /* pop es */
            ii(0x19_40c3, 4); mov(al, memb_a16[es, 0x2f]);              /* mov al, [es:0x2f] */
            ii(0x19_40c7, 2); sub(al, 0x2);                             /* sub al, 0x2 */
            ii(0x19_40c9, 1); popw(es);                                 /* pop es */
            ii(0x19_40ca, 1); popw(ax);                                 /* pop ax */
            ii(0x19_40cb, 1); retw(); return;                           /* ret */
        }
    }
}
