using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("70fd74fb-571e-4db3-9144-8c97fdd3df47")]
        public void Method_0013_8100()
        {
            ii(0x13_8100, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x13_8102, 1); popw(ds);                                 /* pop ds */
            ii(0x13_8103, 1); leavew();                                 /* leave */
            ii(0x13_8104, 1); retfw(); return;                          /* retf */
        }
    }
}
