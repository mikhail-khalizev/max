using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eb0a2f1f-71f3-49bc-b52a-22545fa072b1")]
        public void Method_0015_c4ae()
        {
            ii(0x15_c4ae, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x15_c4b2, 5); mov(memw_a16[ss, bp - 0x12], 0);          /* mov word [bp-0x12], 0x0 */
            ii(0x15_c4b7, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_c4ba, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_c4bd, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_c4c0, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_c4c3, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_c4c6, 1); pushw(ss);                                /* push ss */
            ii(0x15_c4c7, 1); pushw(ax);                                /* push ax */
            ii(0x15_c4c8, 3); pushw(0x3d00);                            /* push 0x3d00 */
            ii(0x15_c4cb, 5); callw_far_abs(0x80, 0x4c9f);              /* call word 0x80:0x4c9f */
            ii(0x15_c4d0, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_c4d3, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_c4d5, 2); if(jzw(0x15_c4dc, 0x5)) goto l_0x15_c4dc; /* jz 0xc4dc */
            ii(0x15_c4d7, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_c4da, 2); jmpw(0x15_c4df, 0x3); goto l_0x15_c4df;   /* jmp 0xc4df */
        l_0x15_c4dc:
            ii(0x15_c4dc, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x15_c4df:
            ii(0x15_c4df, 1); leavew();                                 /* leave */
            ii(0x15_c4e0, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
