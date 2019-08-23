using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a8bf-1314b70")]
        public void Method_0018_a8bf()
        {
            ii(0x18_a8bf, 3); mov(ax, memw[ss, bp + 0x26]);             /* mov ax, [bp+0x26] */
            ii(0x18_a8c2, 3); mov(memw[ds, bx + 0x26], ax);             /* mov [bx+0x26], ax */
            ii(0x18_a8c5, 1); ret();                                    /* ret */
        }
    }
}
