using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("aebf8ef8-d89f-43ce-8f67-353e1677f7d3")]
        public void /* sys */ Method_1016_c3f0()
        {
            ii(0x1016_c3f0, 5); mov(eax, memd_a32[ds, 0x101c_fbe8]);    /* mov eax, [0x101cfbe8] */
            ii(0x1016_c3f5, 1); retd(); return;                         /* ret */
        }
    }
}
