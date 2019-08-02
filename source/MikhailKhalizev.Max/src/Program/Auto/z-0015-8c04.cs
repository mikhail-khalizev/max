using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("916a4d34-1b51-410c-9392-ae4795378a17")]
        public void Method_0015_8c04()
        {
            ii(0x15_8c04, 1); pushw(bp);                                /* push bp */
            ii(0x15_8c05, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_8c07, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_8c0a, 4); mov(ax, memw_a16[es, bx + 0x36]);         /* mov ax, [es:bx+0x36] */
            ii(0x15_8c0e, 4); mov(memw_a16[es, bx + 0x10], ax);         /* mov [es:bx+0x10], ax */
            ii(0x15_8c12, 6); mov(memw_a16[es, bx + 0x12], 0);          /* mov word [es:bx+0x12], 0x0 */
            ii(0x15_8c18, 1); leavew();                                 /* leave */
            ii(0x15_8c19, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
