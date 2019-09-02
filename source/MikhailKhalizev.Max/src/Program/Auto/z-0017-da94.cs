using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_da94-fa5f5d2")]
        public void Method_0017_da94()
        {
            ii(0x17_da94, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x17_da97, 3); sub(ax, memw[ss, bp - 4]);                /* sub ax, [bp-0x4] */
        }
    }
}
