using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a8e6d2b7-d229-4a7c-9c67-6f1d7c205c4f")]
        public void /* sys */ Method_1016_c9d0()
        {
            ii(0x1016_c9d0, 8); mov(ds, memw_a32[cs, /* sys */ 0x1016_c9d9]); /* mov ds, [cs:0x1016c9d9] */
            ii(0x1016_c9d8, 1); retd(); return;                         /* ret */
        }
    }
}
