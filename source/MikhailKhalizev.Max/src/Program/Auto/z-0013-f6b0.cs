using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e0575b7c-0854-47fb-a8a0-47eca0e8d232")]
        public void Method_0013_f6b0()
        {
            ii(0x13_f6b0, 1); pushw(bp);                                /* push bp */
            ii(0x13_f6b1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_f6b3, 1); pushw(ds);                                /* push ds */
            ii(0x13_f6b4, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_f6b7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_f6b9, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_f6bc, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x13_f6bf, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_f6c2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_f6c5, 1); nop();                                    /* nop */
            ii(0x13_f6c6, 1); pushw(cs);                                /* push cs */
            ii(0x13_f6c7, 3); callw(0x13_e020, -0x16aa);                /* call 0xe020 */
            ii(0x13_f6ca, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_f6cd, 1); popw(ds);                                 /* pop ds */
            ii(0x13_f6ce, 1); leavew();                                 /* leave */
            ii(0x13_f6cf, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
