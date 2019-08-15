using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("aad64e9a-8dd2-4c0f-9534-cea414749d14")]
        public void Method_0014_eded()
        {
            ii(0x14_eded, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_edef, 1); pushw(ds);                                /* push ds */
            ii(0x14_edf0, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x14_edf2, 4); lar(ebx, bx);                             /* lar ebx, bx */
            ii(0x14_edf6, 4); shr(ebx, 0x17);                           /* shr ebx, 0x17 */
            ii(0x14_edfa, 2); if(jaew_func(0x14_edfd, 0x1)) return;     /* jae 0xedfd */
        }
    }
}
