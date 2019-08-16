using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("68eef73c-5376-44c1-aaea-f72a2ed44364")]
        public void Method_0015_3229()
        {
            ii(0x15_3229, 3); mov(sp, memw_a16[ss, bp - 0x8]);          /* mov sp, [bp-0x8] */
            ii(0x15_322c, 1); popw(si);                                 /* pop si */
            ii(0x15_322d, 1); popw(di);                                 /* pop di */
            ii(0x15_322e, 3); mov(ds, memw_a16[ss, bp - 0x6]);          /* mov ds, [bp-0x6] */
        }
    }
}
