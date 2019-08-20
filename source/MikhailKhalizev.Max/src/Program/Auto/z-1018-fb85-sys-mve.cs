using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fb85-25a2bd9")]
        public void /* sys_mve */ Method_1018_fb85()
        {
            ii(0x1018_fb85, 4); mov(cx, memw_a32[ds, esi + 0x1a]);      /* mov cx, [esi+0x1a] */
        }
    }
}
