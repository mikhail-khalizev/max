using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09a64600-4b3a-4679-b23e-a72ba6f94ec3")]
        public void Method_0015_e398()
        {
            ii(0x15_e398, 3); lldt(ax);                                 /* lldt ax */
            ii(0x15_e39b, 1); retfw(); return;                          /* retf */
        }
    }
}
