using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1d8a-a2a5d5ff")]
        public void Method_0019_1d8a()
        {
            ii(0x19_1d8a, 4); dec(memw_a16[ds, 0x3af0]);                /* dec word [0x3af0] */
            ii(0x19_1d8e, 2); if(jnsw_func(0x19_1d7e, -0x12)) return;   /* jns 0x1d7e */
            ii(0x19_1d90, 1); retw(); return;                           /* ret */
        }
    }
}
