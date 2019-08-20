using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fb81-25a2dcb")]
        public void /* sys_mve */ Method_1018_fb81()
        {
            ii(0x1018_fb81, 4); mov(bx, memw_a32[ds, esi + 0x18]);      /* mov bx, [esi+0x18] */
        }
    }
}
