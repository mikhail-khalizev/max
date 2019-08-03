using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cedfcd1e-1040-4531-9c13-62a618148ca0")]
        public void Method_0013_91e3()
        {
            ii(0x13_91e3, 1); pushw(bp);                                /* push bp */
            ii(0x13_91e4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_91e6, 2); pushd(edi);                               /* push edi */
            ii(0x13_91e8, 2); pushd(ebx);                               /* push ebx */
            ii(0x13_91ea, 2); pushw(gs);                                /* push gs */
            ii(0x13_91ec, 4); mov(gs, memw_a16[ds, 0xaa]);              /* mov gs, [0xaa] */
            ii(0x13_91f0, 4); mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0x13_91f4, 4); mov(ebx, memd_a16[ss, bp + 0x8]);         /* mov ebx, [bp+0x8] */
            ii(0x13_91f8, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x13_91fb, 5); mov(memw_a32[gs, edi + ebx * 2], ax);     /* mov [gs:edi+ebx*2], ax */
            ii(0x13_9200, 2); popw(gs);                                 /* pop gs */
            ii(0x13_9202, 2); popd(ebx);                                /* pop ebx */
            ii(0x13_9204, 2); popd(edi);                                /* pop edi */
            ii(0x13_9206, 1); popw(bp);                                 /* pop bp */
            ii(0x13_9207, 1); retw(); return;                           /* ret */
        }
    }
}