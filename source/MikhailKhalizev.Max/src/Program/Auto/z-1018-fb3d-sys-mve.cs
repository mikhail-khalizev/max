using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fb3d-25a2dc3")]
        public void /* sys_mve */ Method_1018_fb3d()
        {
            ii(0x1018_fb3d, 4); mov(bx, memw_a32[ds, esi + 0x10]);      /* mov bx, [esi+0x10] */
        }
    }
}
