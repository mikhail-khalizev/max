using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ff4a-a36fe5ec")]
        public void Method_0019_ff4a()
        {
            ii(0x19_ff4a, 1); push(bp);                                 /* push bp */
            ii(0x19_ff4b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_ff4d, 1); push(ds);                                 /* push ds */
            ii(0x19_ff4e, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_ff51, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_ff53, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_ff56, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_ff59, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_ff5c, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_ff5f, 5); call_far_abs(0x80, 0x457a);               /* call word 0x80:0x457a */
            ii(0x19_ff64, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_ff67, 1); pop(ds);                                  /* pop ds */
            ii(0x19_ff68, 1); leave();                                  /* leave */
            ii(0x19_ff69, 3); ret(8);                                   /* ret 0x8 */
        }
    }
}
