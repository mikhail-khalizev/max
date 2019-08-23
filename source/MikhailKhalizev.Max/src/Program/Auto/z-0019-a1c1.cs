using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_a1c1-6db1e4ae")]
        public void Method_0019_a1c1()
        {
            ii(0x19_a1c1, 1); pushw(bp);                                /* push bp */
            ii(0x19_a1c2, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_a1c4, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_a1c7, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_a1ca, 1); pushw(ds);                                /* push ds */
            ii(0x19_a1cb, 3); pushw(0x1fb7);                            /* push 0x1fb7 */
            ii(0x19_a1ce, 3); callw(0x1a_1066, 0x6e95);                 /* call 0x1066 */
            ii(0x19_a1d1, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_a1d3, 3); mov(ax, memw_a16[ds, 0x329e]);            /* mov ax, [0x329e] */
            ii(0x19_a1d6, 4); or(ax, memw_a16[ds, 0x329c]);             /* or ax, [0x329c] */
            ii(0x19_a1da, 2); if(jzw(0x19_a1ea, 0xe)) goto l_0x19_a1ea; /* jz 0xa1ea */
            ii(0x19_a1dc, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_a1df, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_a1e2, 4); callw_a16_far_ind(ds, 0x329c);            /* call far word [0x329c] */
            ii(0x19_a1e6, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a1e7, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a1e8, 2); jmpw(0x19_a1f3, 0x9); goto l_0x19_a1f3;   /* jmp 0xa1f3 */
        l_0x19_a1ea:
            ii(0x19_a1ea, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_a1ed, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_a1f0, 3); callw(0x19_c9e7, 0x27f4);                 /* call 0xc9e7 */
        l_0x19_a1f3:
            ii(0x19_a1f3, 1); leavew();                                 /* leave */
            ii(0x19_a1f4, 3); retw(0x4);                                /* ret 0x4 */
        }
    }
}
