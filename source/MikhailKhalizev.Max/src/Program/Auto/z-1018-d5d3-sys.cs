using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("95df7ce5-c6e0-46fa-8e6f-2912fbdccf0a")]
        public void /* sys */ Method_1018_d5d3()
        {
            ii(0x1018_d5d3, 5); mov(eax, memd_a32[ds, 0x101b_e56c]);    /* mov eax, [0x101be56c] */
            ii(0x1018_d5d8, 1); retd(); return;                         /* ret */
        }
    }
}