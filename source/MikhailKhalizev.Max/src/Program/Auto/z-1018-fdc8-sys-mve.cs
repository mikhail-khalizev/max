using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fdc8-eaddb71f")]
        public void /* sys_mve */ Method_1018_fdc8()
        {
            ii(0x1018_fdc8, 7); lea(eax, memd[ds, edx * 8 - 4]);        /* lea eax, [edx*8-0x4] */
        }
    }
}
