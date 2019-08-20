using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_faf0-25a2ddb")]
        public void /* sys_mve */ Method_1018_faf0()
        {
            ii(0x1018_faf0, 4); mov(bx, memw_a32[ds, esi + 0x8]);       /* mov bx, [esi+0x8] */
        }
    }
}
