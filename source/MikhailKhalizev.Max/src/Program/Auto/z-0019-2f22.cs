using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fbe6820a-9877-45b8-8174-81f6b424eb73")]
        public void Method_0019_2f22()
        {
            ii(0x19_2f22, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_2f25, 1); pushw(ax);                                /* push ax */
            ii(0x19_2f26, 3); callw(0x19_2f2a, 0x1);                    /* call 0x2f2a */
            ii(0x19_2f29, 1); retfw(); return;                          /* retf */
        }
    }
}
