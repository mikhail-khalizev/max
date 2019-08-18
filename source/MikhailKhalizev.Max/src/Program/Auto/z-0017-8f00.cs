using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("05ea9e86-0899-47d2-8ef0-080ad6424f66")]
        public void Method_0017_8f00()
        {
            ii(0x17_8f00, 1); pushw(ss);                                /* push ss */
            ii(0x17_8f01, 1); popw(ax);                                 /* pop ax */
            ii(0x17_8f02, 1); retfw(); return;                          /* retf */
        }
    }
}
