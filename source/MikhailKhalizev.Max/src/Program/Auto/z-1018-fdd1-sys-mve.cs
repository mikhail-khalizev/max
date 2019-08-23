using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fdd1-25a2ddf")]
        public void /* sys_mve */ Method_1018_fdd1()
        {
            ii(0x1018_fdd1, 4); mov(bx, memw[ds, esi + 0xc]);           /* mov bx, [esi+0xc] */
        }
    }
}
