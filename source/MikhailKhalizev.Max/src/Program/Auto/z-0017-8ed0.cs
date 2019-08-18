using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c792927-5f94-4bcf-93f7-9772ab021c1a")]
        public void Method_0017_8ed0()
        {
            ii(0x17_8ed0, 1); pushw(bp);                                /* push bp */
            ii(0x17_8ed1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_8ed3, 1); pushw(es);                                /* push es */
            ii(0x17_8ed4, 1); pushw(di);                                /* push di */
            ii(0x17_8ed5, 1); pushw(cx);                                /* push cx */
            ii(0x17_8ed6, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x17_8ed9, 3); mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0x17_8edc, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x17_8edf, 2); xor(al, al);                              /* xor al, al */
            ii(0x17_8ee1, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x17_8ee3, 1); popw(cx);                                 /* pop cx */
            ii(0x17_8ee4, 1); popw(di);                                 /* pop di */
            ii(0x17_8ee5, 1); popw(es);                                 /* pop es */
            ii(0x17_8ee6, 1); popw(bp);                                 /* pop bp */
            ii(0x17_8ee7, 1); retfw(); return;                          /* retf */
        }
    }
}
