using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fff7-f5bfec6")]
        public void Method_0019_fff7()
        {
            ii(0x19_fff7, 1); push(bp);                                 /* push bp */
            ii(0x19_fff8, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_fffa, 1); push(ds);                                 /* push ds */
            ii(0x19_fffb, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fffe, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0000, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_0003, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_0006, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x1a_0009, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x1a_000c, 1); nop();                                    /* nop */
            ii(0x1a_000d, 1); push(cs);                                 /* push cs */
            ii(0x1a_000e, 3); call(0x1a_1376, 0x1365);                  /* call 0x1376 */
            ii(0x1a_0011, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_0012, 1); leave();                                  /* leave */
            ii(0x1a_0013, 3); ret(8);                                   /* ret 0x8 */
        }
    }
}
