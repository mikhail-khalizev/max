using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_f719-9968b5e1")]
        public void Method_0017_f719()
        {
            ii(0x17_f719, 1); push(bp);                                 /* push bp */
            ii(0x17_f71a, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_f71c, 1); push(ds);                                 /* push ds */
            ii(0x17_f71d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_f720, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_f722, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_f725, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x17_f728, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x17_f72b, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x17_f72e, 1); nop();                                    /* nop */
            ii(0x17_f72f, 1); push(cs);                                 /* push cs */
            ii(0x17_f730, 3); call(0x18_0a10, 0x12dd);                  /* call 0xa10 */
            ii(0x17_f733, 1); pop(ds);                                  /* pop ds */
            ii(0x17_f734, 1); leave();                                  /* leave */
            ii(0x17_f735, 3); ret(0x8);                                 /* ret 0x8 */
        }
    }
}
