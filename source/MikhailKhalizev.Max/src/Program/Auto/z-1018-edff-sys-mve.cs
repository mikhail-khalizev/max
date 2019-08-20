using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_edff-25a2c01")]
        public void /* sys_mve */ Method_1018_edff()
        {
            ii(0x1018_edff, 4); mov(cx, memw_a32[ds, eax + 0x4]);       /* mov cx, [eax+0x4] */
        }
    }
}
