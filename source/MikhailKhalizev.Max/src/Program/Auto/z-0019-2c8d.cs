using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_2c8d-7273e04c")]
        public void Method_0019_2c8d()
        {
            ii(0x19_2c8d, 1); pushw(bp);                                /* push bp */
            ii(0x19_2c8e, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_2c90, 1); pushw(di);                                /* push di */
            ii(0x19_2c91, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_2c94, 1); pushw(cs);                                /* push cs */
            ii(0x19_2c95, 3); callw(0x19_2c62, -0x36);                  /* call 0x2c62 */
            ii(0x19_2c98, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_2c9a, 2); if(jzw(0x19_2cbc, 0x20)) goto l_0x19_2cbc; /* jz 0x2cbc */
            ii(0x19_2c9c, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x19_2c9d, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x19_2c9f, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_2ca1, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_2ca4, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_2ca6, 2); not(cx);                                  /* not cx */
            ii(0x19_2ca8, 1); dec(cx);                                  /* dec cx */
            ii(0x19_2ca9, 3); mov(bx, 0x2);                             /* mov bx, 0x2 */
            ii(0x19_2cac, 6); cmp(memw_a16[ds, 0x3f68], 0xd6d6);        /* cmp word [0x3f68], 0xd6d6 */
            ii(0x19_2cb2, 2); if(jnzw(0x19_2cb8, 0x4)) goto l_0x19_2cb8; /* jnz 0x2cb8 */
            ii(0x19_2cb4, 4); callw_abs(memw_a16[ds, 0x3f6a]);          /* call word [0x3f6a] */
        l_0x19_2cb8:
            ii(0x19_2cb8, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x19_2cba, 2); @int(0x21);                               /* int 0x21 */
        l_0x19_2cbc:
            ii(0x19_2cbc, 1); popw(di);                                 /* pop di */
            ii(0x19_2cbd, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_2cbf, 1); popw(bp);                                 /* pop bp */
            ii(0x19_2cc0, 3); retfw(0x2); return;                       /* retf 0x2 */
        }
    }
}
