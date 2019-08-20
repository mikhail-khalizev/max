using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fb41-25a2bd1")]
        public void /* sys_mve */ Method_1018_fb41()
        {
            ii(0x1018_fb41, 4); mov(cx, memw_a32[ds, esi + 0x12]);      /* mov cx, [esi+0x12] */
        }
    }
}
