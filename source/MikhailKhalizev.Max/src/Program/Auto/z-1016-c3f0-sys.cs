using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b25d42b-7f41-4d8e-af74-5f39d313831a")]
        public void /* sys */ Method_1016_c3f0()
        {
            ii(0x1016_c3f0, 5); mov(eax, memd_a32[ds, 0x101c_fbe8]);    /* mov eax, [0x101cfbe8] */
            ii(0x1016_c3f5, 1); retd(); return;                         /* ret */
        }
    }
}
