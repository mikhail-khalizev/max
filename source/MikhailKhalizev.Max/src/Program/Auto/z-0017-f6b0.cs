using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_f6b0-95a42b3e")]
        public void Method_0017_f6b0()
        {
            ii(0x17_f6b0, 1); push(bp);                                 /* push bp */
            ii(0x17_f6b1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_f6b3, 1); push(ds);                                 /* push ds */
            ii(0x17_f6b4, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_f6b7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_f6b9, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x17_f6bc, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x17_f6bf, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_f6c2, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x17_f6c5, 1); nop();                                    /* nop */
            ii(0x17_f6c6, 1); push(cs);                                 /* push cs */
            ii(0x17_f6c7, 3); call(0x17_e020, -0x16aa);                 /* call 0xe020 */
            ii(0x17_f6ca, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_f6cd, 1); pop(ds);                                  /* pop ds */
            ii(0x17_f6ce, 1); leave();                                  /* leave */
            ii(0x17_f6cf, 3); ret(0x8);                                 /* ret 0x8 */
        }
    }
}
