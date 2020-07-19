using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_da9a-2ef489c4")]
        public void Method_0017_da9a()
        {
            ii(0x17_da9a, 3);  mov(sp, memw[ss, bp - 8]);              /* mov sp, [bp-0x8] */
            ii(0x17_da9d, 1);  pop(si);                                /* pop si */
            ii(0x17_da9e, 1);  pop(di);                                /* pop di */
        }
    }
}
