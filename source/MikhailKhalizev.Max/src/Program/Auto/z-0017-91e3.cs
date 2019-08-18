using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("16c21335-8c91-4608-8ae1-a90adda8c611")]
        public void Method_0017_91e3()
        {
            ii(0x17_91e3, 1); pushw(bp);                                /* push bp */
            ii(0x17_91e4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_91e6, 2); pushd(edi);                               /* push edi */
            ii(0x17_91e8, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_91ea, 2); pushw(gs);                                /* push gs */
            ii(0x17_91ec, 4); mov(gs, memw_a16[ds, 0xaa]);              /* mov gs, [0xaa] */
            ii(0x17_91f0, 4); mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0x17_91f4, 4); mov(ebx, memd_a16[ss, bp + 0x8]);         /* mov ebx, [bp+0x8] */
            ii(0x17_91f8, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x17_91fb, 5); mov(memw_a32[gs, edi + ebx * 2], ax);     /* mov [gs:edi+ebx*2], ax */
            ii(0x17_9200, 2); popw(gs);                                 /* pop gs */
            ii(0x17_9202, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_9204, 2); popd(edi);                                /* pop edi */
            ii(0x17_9206, 1); popw(bp);                                 /* pop bp */
            ii(0x17_9207, 1); retw(); return;                           /* ret */
        }
    }
}
