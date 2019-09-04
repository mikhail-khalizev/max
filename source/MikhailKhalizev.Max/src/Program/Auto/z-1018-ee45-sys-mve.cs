using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ee45-e8bc76ff")]
        public void /* sys_mve */ Method_1018_ee45()
        {
            ii(0x1018_ee45, 7); lea(eax, memd[ds, esi * 8 - 4]);        /* lea eax, [esi*8-0x4] */
        }
    }
}
