using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_0044-25a2bcd")]
        public void /* sys_mve */ Method_1019_0044()
        {
            ii(0x1019_0044, 4); mov(cx, memw_a32[ds, esi + 0xe]);       /* mov cx, [esi+0xe] */
        }
    }
}
