using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4adcc6e1-1ea6-4ffd-868a-d072f561d00b")]
        public void Method_0018_0af1()
        {
            ii(0x18_0af1, 1); pushw(bp);                                /* push bp */
            ii(0x18_0af2, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_0af4, 1); pushw(ds);                                /* push ds */
            ii(0x18_0af5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0af8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0afa, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_0afd, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_0b00, 3); callw(0x18_0a8e, -0x75);                  /* call 0xa8e */
            ii(0x18_0b03, 1); popw(ds);                                 /* pop ds */
            ii(0x18_0b04, 1); leavew();                                 /* leave */
            ii(0x18_0b05, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
