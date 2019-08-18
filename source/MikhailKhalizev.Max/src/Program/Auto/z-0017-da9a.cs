using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("43794457-26e2-4617-b5b5-7d2f6ea52ec8")]
        public void Method_0017_da9a()
        {
            ii(0x17_da9a, 3); mov(sp, memw_a16[ss, bp - 0x8]);          /* mov sp, [bp-0x8] */
            ii(0x17_da9d, 1); popw(si);                                 /* pop si */
            ii(0x17_da9e, 1); popw(di);                                 /* pop di */
        }
    }
}
