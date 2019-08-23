using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3b68-5c47ced")]
        public void Method_0019_3b68()
        {
            ii(0x19_3b68, 1); pushw(bp);                                /* push bp */
            ii(0x19_3b69, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3b6b, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x19_3b6d, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x19_3b70, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3b72, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_3b75, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_3b77, 2); not(cx);                                  /* not cx */
            ii(0x19_3b79, 1); dec(cx);                                  /* dec cx */
            ii(0x19_3b7a, 1); xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x19_3b7b, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x19_3b7d, 1); popw(bp);                                 /* pop bp */
            ii(0x19_3b7e, 1); retfw();                                  /* retf */
        }
    }
}
