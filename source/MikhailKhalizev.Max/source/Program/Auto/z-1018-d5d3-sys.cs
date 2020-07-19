using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d5d3-84b72e80")]
        public void /* sys */ Method_1018_d5d3()
        {
            ii(0x1018_d5d3, 5);  mov(eax, memd[ds, 0x101b_e56c]);      /* mov eax, [0x101be56c] */
            ii(0x1018_d5d8, 1);  ret();                                /* ret */
        }
    }
}
