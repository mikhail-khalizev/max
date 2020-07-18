using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5d4a-78c4039e")]
        public void Method_1016_5d4a()
        {
            ii(0x1016_5d4a, 7);  mov(memw[ds, 0x101b_dd94], ss);       /* mov [0x101bdd94], ss */
            ii(0x1016_5d51, 1);  ret();                                /* ret */
        }
    }
}
