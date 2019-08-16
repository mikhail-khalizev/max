using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0a4903ea-ece6-4ce1-8694-6784d8871543")]
        public void /* sys */ Method_1016_c9d0()
        {
            ii(0x1016_c9d0, 8); mov(ds, memw_a32[cs, /* sys */ 0x1016_c9d9]); /* mov ds, [cs:0x1016c9d9] */
            ii(0x1016_c9d8, 1); retd(); return;                         /* ret */
        }
    }
}
