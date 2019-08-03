using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fbefe90-d0ad-4542-97c5-74d7495d10b8")]
        public void Method_0013_da94()
        {
            ii(0x13_da94, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x13_da97, 3); sub(ax, memw_a16[ss, bp - 0x4]);          /* sub ax, [bp-0x4] */
        }
    }
}
