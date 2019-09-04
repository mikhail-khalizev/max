using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_90c4-66f498c9")]
        public void Method_0017_90c4()
        {
            ii(0x17_90c4, 1); push(bp);                                 /* push bp */
            ii(0x17_90c5, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_90c7, 2); push(edi);                                /* push edi */
            ii(0x17_90c9, 2); push(ebx);                                /* push ebx */
            ii(0x17_90cb, 2); push(gs);                                 /* push gs */
            ii(0x17_90cd, 4); mov(gs, memw[ds, 0xaa]);                  /* mov gs, [0xaa] */
            ii(0x17_90d1, 4); mov(edi, memd[ss, bp + 4]);               /* mov edi, [bp+0x4] */
            ii(0x17_90d5, 4); mov(ebx, memd[ss, bp + 8]);               /* mov ebx, [bp+0x8] */
            ii(0x17_90d9, 5); mov(ax, memw_a32[gs, edi + ebx * 2]);     /* mov ax, [gs:edi+ebx*2] */
            ii(0x17_90de, 2); pop(gs);                                  /* pop gs */
            ii(0x17_90e0, 2); pop(ebx);                                 /* pop ebx */
            ii(0x17_90e2, 2); pop(edi);                                 /* pop edi */
            ii(0x17_90e4, 1); pop(bp);                                  /* pop bp */
            ii(0x17_90e5, 1); ret();                                    /* ret */
        }
    }
}
