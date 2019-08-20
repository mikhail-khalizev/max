using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f207-25a2c03")]
        public void /* sys_mve */ Method_1018_f207_v2()
        {
            ii(0x1018_f207, 4); mov(cx, memw_a32[ds, eax + 0x6]);       /* mov cx, [eax+0x6] */
        }
    }
}
