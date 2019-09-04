using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_91e3-53a4128a")]
        public void Method_0017_91e3()
        {
            ii(0x17_91e3, 1); push(bp);                                 /* push bp */
            ii(0x17_91e4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_91e6, 2); push(edi);                                /* push edi */
            ii(0x17_91e8, 2); push(ebx);                                /* push ebx */
            ii(0x17_91ea, 2); push(gs);                                 /* push gs */
            ii(0x17_91ec, 4); mov(gs, memw[ds, 0xaa]);                  /* mov gs, [0xaa] */
            ii(0x17_91f0, 4); mov(edi, memd[ss, bp + 4]);               /* mov edi, [bp+0x4] */
            ii(0x17_91f4, 4); mov(ebx, memd[ss, bp + 8]);               /* mov ebx, [bp+0x8] */
            ii(0x17_91f8, 3); mov(ax, memw[ss, bp + 12]);               /* mov ax, [bp+0xc] */
            ii(0x17_91fb, 5); mov(memw_a32[gs, edi + ebx * 2], ax);     /* mov [gs:edi+ebx*2], ax */
            ii(0x17_9200, 2); pop(gs);                                  /* pop gs */
            ii(0x17_9202, 2); pop(ebx);                                 /* pop ebx */
            ii(0x17_9204, 2); pop(edi);                                 /* pop edi */
            ii(0x17_9206, 1); pop(bp);                                  /* pop bp */
            ii(0x17_9207, 1); ret();                                    /* ret */
        }
    }
}
