using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1d09-5cf0d7bc")]
        public void Method_001a_1d09()
        {
            ii(0x1a_1d09, 1); pushw(ds);                                /* push ds */
            ii(0x1a_1d0a, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_1d0d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_1d0f, 1); pushw(ds);                                /* push ds */
            ii(0x1a_1d10, 3); pushw(0x3b5a);                            /* push 0x3b5a */
            ii(0x1a_1d13, 1); pushw(ds);                                /* push ds */
            ii(0x1a_1d14, 3); pushw(0x3b4e);                            /* push 0x3b4e */
            ii(0x1a_1d17, 2); pushw(0);                                 /* push 0x0 */
            ii(0x1a_1d19, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1d1a, 3); callw(0x1a_1b83, -0x19a);                 /* call 0x1b83 */
            ii(0x1a_1d1d, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_1d1e, 1); retfw(); return;                          /* retf */
        }
    }
}
