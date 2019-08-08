using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7f1a6400-61b8-4de1-bf25-561e4ffcc070")]
        public void Method_0014_d9ca()
        {
            ii(0x14_d9ca, 1); pushw(bp);                                /* push bp */
            ii(0x14_d9cb, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_d9cd, 1); pushw(si);                                /* push si */
            ii(0x14_d9ce, 1); pushw(di);                                /* push di */
            ii(0x14_d9cf, 1); pushw(ds);                                /* push ds */
            ii(0x14_d9d0, 3); callw(0x14_db82, 0x1af);                  /* call 0xdb82 */
            ii(0x14_d9d3, 2); xor(si, si);                              /* xor si, si */
            ii(0x14_d9d5, 2); xor(di, di);                              /* xor di, di */
            ii(0x14_d9d7, 3); lsl(cx, bx);                              /* lsl cx, bx */
            ii(0x14_d9da, 2); if(jcxzw(0x14_da01, 0x25)) goto l_0x14_da01; /* jcxz 0xda01 */
            ii(0x14_d9dc, 1); pushw(ds);                                /* push ds */
            ii(0x14_d9dd, 1); popw(es);                                 /* pop es */
            ii(0x14_d9de, 1); pushw(bx);                                /* push bx */
            ii(0x14_d9df, 1); popw(ds);                                 /* pop ds */
            ii(0x14_d9e0, 3); add(cx, 0x1);                             /* add cx, 0x1 */
            ii(0x14_d9e3, 2); rcr(cx, 0x1);                             /* rcr cx, 1 */
            ii(0x14_d9e5, 1); cld();                                    /* cld */
            ii(0x14_d9e6, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x14_d9e8, 2); if(jaew(0x14_d9eb, 0x1)) goto l_0x14_d9eb; /* jae 0xd9eb */
            ii(0x14_d9ea, 1); movsb_a16();                              /* movsb */
        l_0x14_d9eb:
            ii(0x14_d9eb, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x14_d9ed, 3); cmp(bx, memw_a16[ss, bp + 0x8]);          /* cmp bx, [bp+0x8] */
            ii(0x14_d9f0, 2); if(jnzw(0x14_da01, 0xf)) goto l_0x14_da01; /* jnz 0xda01 */
            ii(0x14_d9f2, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x14_d9f5, 3); mov(dx, memw_a16[ss, bp + 0x4]);          /* mov dx, [bp+0x4] */
            ii(0x14_d9f8, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x14_d9fb, 1); pushw(cs);                                /* push cs */
            ii(0x14_d9fc, 3); callw(0x14_a3b9, -0x3646);                /* call 0xa3b9 */
            ii(0x14_d9ff, 1); pushw(ss);                                /* push ss */
            ii(0x14_da00, 1); popw(ss);                                 /* pop ss */
        l_0x14_da01:
            ii(0x14_da01, 1); popw(ds);                                 /* pop ds */
            ii(0x14_da02, 1); popw(di);                                 /* pop di */
            ii(0x14_da03, 1); popw(si);                                 /* pop si */
            ii(0x14_da04, 1); popw(bp);                                 /* pop bp */
            ii(0x14_da05, 1); retw(); return;                           /* ret */
        }
    }
}
