using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0e76-6b6fb42f")]
        public void Method_0018_0e76()
        {
            ii(0x18_0e76, 1); pushw(ds);                                /* push ds */
            ii(0x18_0e77, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0e7a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0e7c, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x18_0e7f, 3); pushw(0xc676);                            /* push 0xc676 */
            ii(0x18_0e82, 1); nop();                                    /* nop */
            ii(0x18_0e83, 1); pushw(cs);                                /* push cs */
            ii(0x18_0e84, 3); callw(0x18_0af1, -0x396);                 /* call 0xaf1 */
            ii(0x18_0e87, 1); pushw(ds);                                /* push ds */
            ii(0x18_0e88, 3); pushw(0x1b5e);                            /* push 0x1b5e */
            ii(0x18_0e8b, 1); pushw(ds);                                /* push ds */
            ii(0x18_0e8c, 3); pushw(0x1ba8);                            /* push 0x1ba8 */
            ii(0x18_0e8f, 1); nop();                                    /* nop */
            ii(0x18_0e90, 1); pushw(cs);                                /* push cs */
            ii(0x18_0e91, 3); callw(0x18_0c3a, -0x25a);                 /* call 0xc3a */
            ii(0x18_0e94, 1); popw(ds);                                 /* pop ds */
            ii(0x18_0e95, 1); retfw();                                  /* retf */
        }
    }
}
