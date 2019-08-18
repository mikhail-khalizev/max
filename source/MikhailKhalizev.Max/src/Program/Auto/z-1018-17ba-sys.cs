using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_17ba-bf2c32fe")]
        public void /* sys */ Method_1018_17ba()
        {
            ii(0x1018_17ba, 6); calld_abs(memd_a32[ds, 0x101c_1b60]);   /* call dword [0x101c1b60] */ /* Вызов '0x1019_5b8a'. */
            ii(0x1018_17c0, 1); retd(); return;                         /* ret */
        }
    }
}
