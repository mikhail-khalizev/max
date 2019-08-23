using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e5ec-e4f696e6")]
        public void Method_0019_e5ec()
        {
            ii(0x19_e5ec, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_e5f0, 1); push(di);                                 /* push di */
            ii(0x19_e5f1, 1); push(si);                                 /* push si */
            ii(0x19_e5f2, 3); mov(ax, memw[ds, 0x48f6]);                /* mov ax, [0x48f6] */
            ii(0x19_e5f5, 3); add(ax, 0x48b6);                          /* add ax, 0x48b6 */
            ii(0x19_e5f8, 1); push(ds);                                 /* push ds */
            ii(0x19_e5f9, 1); push(ax);                                 /* push ax */
            ii(0x19_e5fa, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_e5fd, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_e600, 3); call(0x19_ff6c, 0x1969);                  /* call 0xff6c */
            ii(0x19_e603, 1); pop(si);                                  /* pop si */
            ii(0x19_e604, 1); pop(di);                                  /* pop di */
            ii(0x19_e605, 1); leave();                                  /* leave */
            ii(0x19_e606, 1); retf();                                   /* retf */
        }
    }
}
