using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0af1-d0adb64e")]
        public void Method_0018_0af1()
        {
            ii(0x18_0af1, 1); push(bp);                                 /* push bp */
            ii(0x18_0af2, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_0af4, 1); push(ds);                                 /* push ds */
            ii(0x18_0af5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0af8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0afa, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x18_0afd, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x18_0b00, 3); call(0x18_0a8e, -0x75);                   /* call 0xa8e */
            ii(0x18_0b03, 1); pop(ds);                                  /* pop ds */
            ii(0x18_0b04, 1); leave();                                  /* leave */
            ii(0x18_0b05, 3); retf(0x4);                                /* retf 0x4 */
        }
    }
}
