using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5d65-18d0aa23")]
        public void /* sys */ Method_1016_5d65()
        {
            ii(0x1016_5d65, 2); cmp(eax, esp);                          /* cmp eax, esp */
            ii(0x1016_5d67, 2); if(jae(0x1016_5d76, 0xd)) goto l_0x1016_5d76; /* jae 0x10165d76 */
            ii(0x1016_5d69, 2); sub(eax, esp);                          /* sub eax, esp */
            ii(0x1016_5d6b, 2); neg(eax);                               /* neg eax */
            ii(0x1016_5d6d, 6); cmp(eax, memd[ds, 0x101b_e570]);        /* cmp eax, [0x101be570] */
            ii(0x1016_5d73, 2); if(jbe(0x1016_5d76, 1)) goto l_0x1016_5d76; /* jbe 0x10165d76 */
            ii(0x1016_5d75, 1); ret(); return;                          /* ret */
        l_0x1016_5d76:
            ii(0x1016_5d76, 3); mov(ax, ss);                            /* mov ax, ss */
            ii(0x1016_5d79, 7); cmp(ax, memw[ds, 0x101b_dd94]);         /* cmp ax, [0x101bdd94] */
            ii(0x1016_5d80, 2); if(jz_func(0x1016_5d83, 1)) return;     /* jz 0x10165d83 */
            ii(0x1016_5d82, 1); ret();                                  /* ret */
        }
    }
}
