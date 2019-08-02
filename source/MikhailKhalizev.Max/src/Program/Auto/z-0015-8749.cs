using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("39e2d976-33d2-4b70-a76e-222df79ecb67")]
        public void Method_0015_8749()
        {
            ii(0x15_8749, 1); popw(si);                                 /* pop si */
            ii(0x15_874a, 1); popw(di);                                 /* pop di */
            ii(0x15_874b, 1); leavew();                                 /* leave */
            ii(0x15_874c, 1); retfw(); return;                          /* retf */
        }
    }
}
