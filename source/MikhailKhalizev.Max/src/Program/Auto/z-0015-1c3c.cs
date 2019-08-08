using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c585d969-3857-4510-86c9-3c50403d4152")]
        public void Method_0015_1c3c()
        {
            ii(0x15_1c3c, 1); pushw(ds);                                /* push ds */
            ii(0x15_1c3d, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_1c40, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_1c42, 1); pushw(ds);                                /* push ds */
            ii(0x15_1c43, 3); pushw(0x392a);                            /* push 0x392a */
            ii(0x15_1c46, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x15_1c49, 3); pushw(0x3b06);                            /* push 0x3b06 */
            ii(0x15_1c4c, 5); callw_far_abs(0x88, 0xa7f7);              /* call word 0x88:0xa7f7 */
            ii(0x15_1c51, 1); popw(ds);                                 /* pop ds */
            ii(0x15_1c52, 1); retfw(); return;                          /* retf */
        }
    }
}
