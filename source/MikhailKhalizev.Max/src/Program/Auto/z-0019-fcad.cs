using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fcad-13a52d48")]
        public void Method_0019_fcad()
        {
            ii(0x19_fcad, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x19_fcb1, 1); pushw(ds);                                /* push ds */
            ii(0x19_fcb2, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fcb5, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fcb7, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_fcb9, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_fcbc, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_fcbf, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_fcc2, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_fcc5, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_fcc8, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_fccb, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_fcce, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_fcd1, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x19_fcd4, 1); pushw(ss);                                /* push ss */
            ii(0x19_fcd5, 1); pushw(ax);                                /* push ax */
            ii(0x19_fcd6, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x19_fcd9, 1); pushw(ss);                                /* push ss */
            ii(0x19_fcda, 1); pushw(ax);                                /* push ax */
            ii(0x19_fcdb, 3); callw(0x19_fc34, -0xaa);                  /* call 0xfc34 */
            ii(0x19_fcde, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x19_fce1, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x19_fce4, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fce5, 1); leavew();                                 /* leave */
            ii(0x19_fce6, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
