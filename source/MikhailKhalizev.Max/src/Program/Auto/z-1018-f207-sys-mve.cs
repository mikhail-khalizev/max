using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f207-25a2c03")]
        public void /* sys_mve */ Method_1018_f207()
        {
            ii(0x1018_f207, 4); mov(cx, memw[ds, eax + 6]);             /* mov cx, [eax+0x6] */
        }
    }
}
