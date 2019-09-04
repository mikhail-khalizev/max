using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_909e-113e5744")]
        public void Method_0017_909e()
        {
            ii(0x17_909e, 1);  push(bp);                               /* push bp */
            ii(0x17_909f, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_90a1, 2);  push(eax);                              /* push eax */
            ii(0x17_90a3, 4);  mov(eax, memd[ss, bp + 6]);             /* mov eax, [bp+0x6] */
            ii(0x17_90a7, 3);  mov(cr3, eax);                          /* mov cr3, eax */
            ii(0x17_90aa, 2);  pop(eax);                               /* pop eax */
            ii(0x17_90ac, 1);  pop(bp);                                /* pop bp */
            ii(0x17_90ad, 1);  retf();                                 /* retf */
        }
    }
}
