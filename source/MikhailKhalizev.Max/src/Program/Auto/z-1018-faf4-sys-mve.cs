using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_faf4-25a2bc9")]
        public void /* sys_mve */ Method_1018_faf4()
        {
            ii(0x1018_faf4, 4); mov(cx, memw_a32[ds, esi + 0xa]);       /* mov cx, [esi+0xa] */
        }
    }
}
