using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_90c4-66f498c9")]
        public void Method_0017_90c4()
        {
            ii(0x17_90c4, 1); pushw(bp);                                /* push bp */
            ii(0x17_90c5, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_90c7, 2); pushd(edi);                               /* push edi */
            ii(0x17_90c9, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_90cb, 2); pushw(gs);                                /* push gs */
            ii(0x17_90cd, 4); mov(gs, memw_a16[ds, 0xaa]);              /* mov gs, [0xaa] */
            ii(0x17_90d1, 4); mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0x17_90d5, 4); mov(ebx, memd_a16[ss, bp + 0x8]);         /* mov ebx, [bp+0x8] */
            ii(0x17_90d9, 5); mov(ax, memw_a32[gs, edi + ebx * 2]);     /* mov ax, [gs:edi+ebx*2] */
            ii(0x17_90de, 2); popw(gs);                                 /* pop gs */
            ii(0x17_90e0, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_90e2, 2); popd(edi);                                /* pop edi */
            ii(0x17_90e4, 1); popw(bp);                                 /* pop bp */
            ii(0x17_90e5, 1); retw(); return;                           /* ret */
        }
    }
}