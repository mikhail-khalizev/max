using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_168b-3f57ca1d")]
        public void Method_0019_168b()
        {
            ii(0x19_168b, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_168e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_1690, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_1693, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_1696, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_1699, 1); leavew();                                 /* leave */
            ii(0x19_169a, 1); retfw(); return;                          /* retf */
        }
    }
}
