using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("db4be66f-3381-4963-957c-587060e8aed1")]
        public void Method_0013_da9a()
        {
            ii(0x13_da9a, 3); mov(sp, memw_a16[ss, bp - 0x8]);          /* mov sp, [bp-0x8] */
            ii(0x13_da9d, 1); popw(si);                                 /* pop si */
            ii(0x13_da9e, 1); popw(di);                                 /* pop di */
        }
    }
}
