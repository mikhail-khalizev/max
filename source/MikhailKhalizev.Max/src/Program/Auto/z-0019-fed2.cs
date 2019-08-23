using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fed2-7dfef4cb")]
        public void Method_0019_fed2()
        {
            ii(0x19_fed2, 1); push(bp);                                 /* push bp */
            ii(0x19_fed3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_fed5, 1); push(ds);                                 /* push ds */
            ii(0x19_fed6, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fed9, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fedb, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_fede, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_fee1, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_fee4, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_fee7, 1); nop();                                    /* nop */
            ii(0x19_fee8, 1); push(cs);                                 /* push cs */
            ii(0x19_fee9, 3); call(0x1a_1135, 0x1249);                  /* call 0x1135 */
            ii(0x19_feec, 1); pop(ds);                                  /* pop ds */
            ii(0x19_feed, 1); leave();                                  /* leave */
            ii(0x19_feee, 3); ret(0x8);                                 /* ret 0x8 */
        }
    }
}
