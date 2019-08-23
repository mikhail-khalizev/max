using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d86f-474366cc")]
        public void Method_0017_d86f()
        {
            ii(0x17_d86f, 1); pushw(bp);                                /* push bp */
            ii(0x17_d870, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d872, 1); pushw(di);                                /* push di */
            ii(0x17_d873, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_d876, 1); pushw(cs);                                /* push cs */
            ii(0x17_d877, 3); callw(0x17_d844, -0x36);                  /* call 0xd844 */
            ii(0x17_d87a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_d87c, 2); if(jzw(0x17_d89e, 0x20)) goto l_0x17_d89e; /* jz 0xd89e */
            ii(0x17_d87e, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x17_d87f, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_d881, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_d883, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_d886, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x17_d888, 2); not(cx);                                  /* not cx */
            ii(0x17_d88a, 1); dec(cx);                                  /* dec cx */
            ii(0x17_d88b, 3); mov(bx, 0x2);                             /* mov bx, 0x2 */
            ii(0x17_d88e, 6); cmp(memw_a16[ds, 0x1dac], 0xd6d6);        /* cmp word [0x1dac], 0xd6d6 */
            ii(0x17_d894, 2); if(jnzw(0x17_d89a, 0x4)) goto l_0x17_d89a; /* jnz 0xd89a */
            ii(0x17_d896, 4); callw_abs(memw_a16[ds, 0x1dae]);          /* call word [0x1dae] */
        l_0x17_d89a:
            ii(0x17_d89a, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x17_d89c, 2); @int(0x21);                               /* int 0x21 */
        l_0x17_d89e:
            ii(0x17_d89e, 1); popw(di);                                 /* pop di */
            ii(0x17_d89f, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_d8a1, 1); popw(bp);                                 /* pop bp */
            ii(0x17_d8a2, 3); retfw(0x2);                               /* retf 0x2 */
        }
    }
}
