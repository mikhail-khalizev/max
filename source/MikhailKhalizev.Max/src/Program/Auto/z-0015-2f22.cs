using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e9c7c59-28a6-4966-b20e-655491fe0a95")]
        public void Method_0015_2f22()
        {
            ii(0x15_2f22, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_2f25, 1); pushw(ax);                                /* push ax */
            ii(0x15_2f26, 3); callw(0x15_2f2a, 0x1);                    /* call 0x2f2a */
            ii(0x15_2f29, 1); retfw(); return;                          /* retf */
        }
    }
}
