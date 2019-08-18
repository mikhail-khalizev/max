using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4804053b-0df9-486d-96c0-8353c0fece0c")]
        public void Method_0018_eded()
        {
            ii(0x18_eded, 2); pushd(ebx);                               /* push ebx */
            ii(0x18_edef, 1); pushw(ds);                                /* push ds */
            ii(0x18_edf0, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x18_edf2, 4); lar(ebx, bx);                             /* lar ebx, bx */
            ii(0x18_edf6, 4); shr(ebx, 0x17);                           /* shr ebx, 0x17 */
            ii(0x18_edfa, 2); if(jaew_func(0x18_edfd, 0x1)) return;     /* jae 0xedfd */
        }
    }
}
