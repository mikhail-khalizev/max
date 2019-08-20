using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ee51-25a2c0d")]
        public void /* sys_mve */ Method_1018_ee51()
        {
            ii(0x1018_ee51, 4); mov(cx, memw_a32[ds, eax + 0x8]);       /* mov cx, [eax+0x8] */
        }
    }
}
