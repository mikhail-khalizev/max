using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e7ed648-15f3-43f1-83b0-0a4109cf53fb")]
        public void Method_0019_febc()
        {
            ii(0x19_febc, 1); pushw(bp);                                /* push bp */
            ii(0x19_febd, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_febf, 1); pushw(ds);                                /* push ds */
            ii(0x19_fec0, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fec3, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fec5, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_fec8, 1); nop();                                    /* nop */
            ii(0x19_fec9, 1); pushw(cs);                                /* push cs */
            ii(0x19_feca, 3); callw(0x1a_10f7, 0x122a);                 /* call 0x10f7 */
            ii(0x19_fecd, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fece, 1); leavew();                                 /* leave */
            ii(0x19_fecf, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
