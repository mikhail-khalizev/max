using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a4c4-279a313c")]
        public void /* sys */ Method_1016_a4c4()
        {
            ii(0x1016_a4c4, 5); mov(eax, memd_a32[ds, 0x101c_f964]);    /* mov eax, [0x101cf964] */
            ii(0x1016_a4c9, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1016_a4cc, 1); retd(); return;                         /* ret */
        }
    }
}
