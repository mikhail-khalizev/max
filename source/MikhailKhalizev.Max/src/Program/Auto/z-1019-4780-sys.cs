using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4780-3d60b141")]
        public void /* sys */ Method_1019_4780()
        {
            ii(0x1019_4780, 3); mov(eax, memd_a32[ds, eax - 0x4]);      /* mov eax, [eax-0x4] */
            ii(0x1019_4783, 2); and(al, 0xfe);                          /* and al, 0xfe */
            ii(0x1019_4785, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1019_4788, 1); retd(); return;                         /* ret */
        }
    }
}
