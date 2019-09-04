using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a786-9a4a4504")]
        public void Method_0018_a786()
        {
            ii(0x18_a786, 1); push(bp);                                 /* push bp */
            ii(0x18_a787, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_a789, 3); mov(es, memw[ss, bp + 4]);                /* mov es, [bp+0x4] */
            ii(0x18_a78c, 3); mov(al, memb[ss, bp + 6]);                /* mov al, [bp+0x6] */
            ii(0x18_a78f, 2); mov(ah, 0xff);                            /* mov ah, 0xff */
            ii(0x18_a791, 3); mov(dx, 0x1301);                          /* mov dx, 0x1301 */
            ii(0x18_a794, 1); push(cs);                                 /* push cs */
            ii(0x18_a795, 3); call(0x18_a366, -0x432);                  /* call 0xa366 */
            ii(0x18_a798, 1); cmc();                                    /* cmc */
            ii(0x18_a799, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x18_a79b, 1); pop(bp);                                  /* pop bp */
            ii(0x18_a79c, 1); ret();                                    /* ret */
        }
    }
}
