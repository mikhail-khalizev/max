using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d3f77744-4489-483a-a279-71e000ac82b0")]
        public void Method_0018_0a10()
        {
            ii(0x18_0a10, 1); pushw(bp);                                /* push bp */
            ii(0x18_0a11, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_0a13, 1); pushw(ds);                                /* push ds */
            ii(0x18_0a14, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0a17, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0a19, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_0a1c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_0a1f, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x18_0a22, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x18_0a25, 1); nop();                                    /* nop */
            ii(0x18_0a26, 1); pushw(cs);                                /* push cs */
            ii(0x18_0a27, 3); callw(0x17_e12c, -0x28fe);                /* call 0xe12c */
            ii(0x18_0a2a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x18_0a2d, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x18_0a30, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x18_0a33, 1); nop();                                    /* nop */
            ii(0x18_0a34, 1); pushw(cs);                                /* push cs */
            ii(0x18_0a35, 3); callw(0x17_e0f0, -0x2948);                /* call 0xe0f0 */
            ii(0x18_0a38, 1); popw(bx);                                 /* pop bx */
            ii(0x18_0a39, 1); popw(bx);                                 /* pop bx */
            ii(0x18_0a3a, 1); popw(ds);                                 /* pop ds */
            ii(0x18_0a3b, 1); leavew();                                 /* leave */
            ii(0x18_0a3c, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
