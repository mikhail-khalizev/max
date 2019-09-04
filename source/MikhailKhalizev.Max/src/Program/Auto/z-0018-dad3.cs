using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dad3-11b33d54")]
        public void Method_0018_dad3()
        {
            ii(0x18_dad3, 1); push(bp);                                 /* push bp */
            ii(0x18_dad4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_dad6, 1); push(es);                                 /* push es */
            ii(0x18_dad7, 1); push(di);                                 /* push di */
            ii(0x18_dad8, 3); mov(es, memw[ss, bp + 4]);                /* mov es, [bp+0x4] */
            ii(0x18_dadb, 3); mov(di, memw[ss, bp + 6]);                /* mov di, [bp+0x6] */
            ii(0x18_dade, 3); mov(cx, memw[ss, bp + 8]);                /* mov cx, [bp+0x8] */
            ii(0x18_dae1, 3); mov(al, memb[ss, bp + 10]);               /* mov al, [bp+0xa] */
            ii(0x18_dae4, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x18_dae6, 1); cld();                                    /* cld */
            ii(0x18_dae7, 3); sub(cx, 1);                               /* sub cx, 0x1 */
            ii(0x18_daea, 1); inc(cx);                                  /* inc cx */
            ii(0x18_daeb, 2); rcr(cx, 1);                               /* rcr cx, 1 */
            ii(0x18_daed, 2); rep(() => stosw());                       /* rep stosw */
            ii(0x18_daef, 2); rcl(cx, 1);                               /* rcl cx, 1 */
            ii(0x18_daf1, 2); rep(() => stosb());                       /* rep stosb */
            ii(0x18_daf3, 1); pop(di);                                  /* pop di */
            ii(0x18_daf4, 1); pop(es);                                  /* pop es */
            ii(0x18_daf5, 1); pop(bp);                                  /* pop bp */
            ii(0x18_daf6, 1); ret();                                    /* ret */
        }
    }
}
