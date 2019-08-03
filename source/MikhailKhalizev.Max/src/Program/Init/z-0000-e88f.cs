using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f0941e73-ae76-4af9-b591-9160b9c34218")]
        public void Method_0000_e88f()
        {
            ii(0xe88f, 3);    mov(ax, memw_a16[ss, bp + 0x26]);         /* mov ax, [bp+0x26] */
            ii(0xe892, 3);    mov(memw_a16[ds, bx + 0x26], ax);         /* mov [bx+0x26], ax */
            ii(0xe895, 1);    retw(); return;                           /* ret */
        }
    }
}
