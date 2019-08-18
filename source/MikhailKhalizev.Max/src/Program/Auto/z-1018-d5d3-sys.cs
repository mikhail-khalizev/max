using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ee76c39-ea4c-4761-8bc1-5846cd0a62df")]
        public void /* sys */ Method_1018_d5d3()
        {
            ii(0x1018_d5d3, 5); mov(eax, memd_a32[ds, 0x101b_e56c]);    /* mov eax, [0x101be56c] */
            ii(0x1018_d5d8, 1); retd(); return;                         /* ret */
        }
    }
}
