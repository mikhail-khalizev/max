using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e398-129a624")]
        public void Method_0019_e398()
        {
            ii(0x19_e398, 3); lldt(ax);                                 /* lldt ax */
            ii(0x19_e39b, 1); retf();                                   /* retf */
        }
    }
}
