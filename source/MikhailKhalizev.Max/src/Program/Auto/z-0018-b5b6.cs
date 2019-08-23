using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b5b6-ed95c8f5")]
        public void Method_0018_b5b6()
        {
            ii(0x18_b5b6, 2); cmp(al, 0x4);                             /* cmp al, 0x4 */
            ii(0x18_b5b8, 2); if(jae_func(0x18_b5b2, -0x8)) return;     /* jae 0xb5b2 */
            ii(0x18_b5ba, 1); pusha();                                  /* pusha */
            ii(0x18_b5bb, 1); push(es);                                 /* push es */
            ii(0x18_b5bc, 1); push(ds);                                 /* push ds */
            ii(0x18_b5bd, 5); mov(ds, memw[cs, 0x5680]);                /* mov ds, [cs:0x5680] */
            ii(0x18_b5c2, 2); mov(si, bp);                              /* mov si, bp */
            ii(0x18_b5c4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_b5c6, 2); cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0x18_b5c8, 2); if(jb(0x18_b5cc, 0x2)) goto l_0x18_b5cc;  /* jb 0xb5cc */
            ii(0x18_b5ca, 2); shl(cx, 0x1);                             /* shl cx, 1 */
        l_0x18_b5cc:
            ii(0x18_b5cc, 3); mov(es, memw[ss, bp + 0x2]);              /* mov es, [bp+0x2] */
            ii(0x18_b5cf, 3); call(0x18_b55c, -0x76);                   /* call 0xb55c */
            ii(0x18_b5d2, 2); mov(bp, di);                              /* mov bp, di */
            ii(0x18_b5d4, 3); call(0x18_b58c, -0x4b);                   /* call 0xb58c */
            ii(0x18_b5d7, 1); pop(ds);                                  /* pop ds */
            ii(0x18_b5d8, 1); pop(es);                                  /* pop es */
            ii(0x18_b5d9, 1); popa();                                   /* popa */
            ii(0x18_b5da, 2); iretd();                                  /* iretd */
        }
    }
}
