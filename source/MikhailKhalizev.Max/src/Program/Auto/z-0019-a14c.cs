using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("418e11a3-88ed-4111-95ab-8fd41e97cc4f")]
        public void Method_0019_a14c()
        {
            ii(0x19_a14c, 1); pushw(bp);                                /* push bp */
            ii(0x19_a14d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_a14f, 4); cmp(memw_a16[ss, bp + 0x4], 0x10);        /* cmp word [bp+0x4], 0x10 */
            ii(0x19_a153, 2); if(jbw(0x19_a15a, 0x5)) goto l_0x19_a15a; /* jb 0xa15a */
            ii(0x19_a155, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_a157, 1); cwd();                                    /* cwd */
            ii(0x19_a158, 2); jmpw(0x19_a16a, 0x10); goto l_0x19_a16a;  /* jmp 0xa16a */
        l_0x19_a15a:
            ii(0x19_a15a, 5); imul(ax, memw_a16[ss, bp + 0x4], 0x134);  /* imul ax, [bp+0x4], 0x134 */
            ii(0x19_a15f, 4); add(ax, memw_a16[ds, 0x1f1a]);            /* add ax, [0x1f1a] */
            ii(0x19_a163, 4); mov(dx, memw_a16[ds, 0x1f1c]);            /* mov dx, [0x1f1c] */
            ii(0x19_a167, 3); add(ax, 0x12);                            /* add ax, 0x12 */
        l_0x19_a16a:
            ii(0x19_a16a, 1); leavew();                                 /* leave */
            ii(0x19_a16b, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
