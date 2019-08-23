using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8ed0-df5c4f62")]
        public void Method_0017_8ed0()
        {
            ii(0x17_8ed0, 1); push(bp);                                 /* push bp */
            ii(0x17_8ed1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_8ed3, 1); push(es);                                 /* push es */
            ii(0x17_8ed4, 1); push(di);                                 /* push di */
            ii(0x17_8ed5, 1); push(cx);                                 /* push cx */
            ii(0x17_8ed6, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x17_8ed9, 3); mov(es, memw[ss, bp + 0x8]);              /* mov es, [bp+0x8] */
            ii(0x17_8edc, 3); mov(di, memw[ss, bp + 0x6]);              /* mov di, [bp+0x6] */
            ii(0x17_8edf, 2); xor(al, al);                              /* xor al, al */
            ii(0x17_8ee1, 2); rep(() => stosb());                       /* rep stosb */
            ii(0x17_8ee3, 1); pop(cx);                                  /* pop cx */
            ii(0x17_8ee4, 1); pop(di);                                  /* pop di */
            ii(0x17_8ee5, 1); pop(es);                                  /* pop es */
            ii(0x17_8ee6, 1); pop(bp);                                  /* pop bp */
            ii(0x17_8ee7, 1); retf();                                   /* retf */
        }
    }
}
