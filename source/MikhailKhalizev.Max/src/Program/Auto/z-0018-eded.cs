using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_eded-f541669d")]
        public void Method_0018_eded()
        {
            ii(0x18_eded, 2);  push(ebx);                              /* push ebx */
            ii(0x18_edef, 1);  push(ds);                               /* push ds */
            ii(0x18_edf0, 2);  mov(bx, ss);                            /* mov bx, ss */
            ii(0x18_edf2, 4);  lar(ebx, bx);                           /* lar ebx, bx */
            ii(0x18_edf6, 4);  shr(ebx, 0x17);                         /* shr ebx, 0x17 */
            ii(0x18_edfa, 2);  jae_func(0x18_edfd, 1);                 /* jae 0xedfd */
        }
    }
}
