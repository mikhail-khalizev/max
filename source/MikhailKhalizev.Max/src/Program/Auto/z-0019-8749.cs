using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dc51bb24-a1ef-4d72-8ee9-9a0ac2cecb12")]
        public void Method_0019_8749()
        {
            ii(0x19_8749, 1); popw(si);                                 /* pop si */
            ii(0x19_874a, 1); popw(di);                                 /* pop di */
            ii(0x19_874b, 1); leavew();                                 /* leave */
            ii(0x19_874c, 1); retfw(); return;                          /* retf */
        }
    }
}
