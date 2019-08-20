using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_0040-25a2ddf")]
        public void /* sys_mve */ Method_1019_0040()
        {
            ii(0x1019_0040, 4); mov(bx, memw_a32[ds, esi + 0xc]);       /* mov bx, [esi+0xc] */
        }
    }
}
