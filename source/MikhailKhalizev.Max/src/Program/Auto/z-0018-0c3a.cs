using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0c3a-93eb0e43")]
        public void Method_0018_0c3a()
        {
            ii(0x18_0c3a, 1); pushw(bp);                                /* push bp */
            ii(0x18_0c3b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_0c3d, 1); pushw(ds);                                /* push ds */
            ii(0x18_0c3e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0c41, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0c43, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x18_0c46, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x18_0c49, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_0c4c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_0c4f, 3); callw(0x18_0bfe, -0x54);                  /* call 0xbfe */
            ii(0x18_0c52, 1); popw(ds);                                 /* pop ds */
            ii(0x18_0c53, 1); leavew();                                 /* leave */
            ii(0x18_0c54, 3); retfw(0x8);                               /* retf 0x8 */
        }
    }
}
