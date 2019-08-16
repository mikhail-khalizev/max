using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f69d2986-dca4-4557-833d-9d51667bb901")]
        public void Method_0013_d8a6()
        {
            ii(0x13_d8a6, 2); if(jbw_func(0x13_d8bd, 0x15)) return;     /* jb 0xd8bd */
        l_0x13_d8a8:
            ii(0x13_d8a8, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_d8aa, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_d8ac, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d8ad, 1); retfw(); return;                          /* retf */
        //    ii(0x13_d8ae, 2); if(jaew(0x13_d8a8, -0x8)) goto l_0x13_d8a8; /* jae 0xd8a8 */
        //    ii(0x13_d8b0, 1); pushw(ax);                                /* push ax */
        //    ii(0x13_d8b1, 3); callw(0x13_d8ce, 0x1a);                   /* call 0xd8ce */
        //    ii(0x13_d8b4, 1); popw(ax);                                 /* pop ax */
        //    ii(0x13_d8b5, 2); xor(ah, ah);                              /* xor ah, ah */
        //    ii(0x13_d8b7, 2); mov(sp, bp);                              /* mov sp, bp */
        //    ii(0x13_d8b9, 1); popw(bp);                                 /* pop bp */
        //    ii(0x13_d8ba, 1); retfw(); return;                          /* retf */
        }
    }
}
