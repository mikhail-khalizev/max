using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9235-8b1d9d6a")]
        public void Method_0017_9235()
        {
            ii(0x17_9235, 1); pushw(bp);                                /* push bp */
            ii(0x17_9236, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_9238, 2); pushd(edi);                               /* push edi */
            ii(0x17_923a, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_923c, 2); pushw(gs);                                /* push gs */
            ii(0x17_923e, 4); mov(gs, memw_a16[ds, 0xaa]);              /* mov gs, [0xaa] */
            ii(0x17_9242, 4); mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0x17_9246, 4); mov(ebx, memd_a16[ss, bp + 0x8]);         /* mov ebx, [bp+0x8] */
            ii(0x17_924a, 4); mov(eax, memd_a16[ss, bp + 0xc]);         /* mov eax, [bp+0xc] */
            ii(0x17_924e, 6); mov(memd_a32[gs, edi + ebx * 4], eax);    /* mov [gs:edi+ebx*4], eax */
            ii(0x17_9254, 2); popw(gs);                                 /* pop gs */
            ii(0x17_9256, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_9258, 2); popd(edi);                                /* pop edi */
            ii(0x17_925a, 1); popw(bp);                                 /* pop bp */
            ii(0x17_925b, 1); retw(); return;                           /* ret */
        }
    }
}
