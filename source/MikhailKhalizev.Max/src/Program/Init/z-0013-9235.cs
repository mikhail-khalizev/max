using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fef123d6-a28e-422b-be67-daf9b684e97a")]
        public void Method_0013_9235()
        {
            ii(0x13_9235, 1); pushw(bp);                                /* push bp */
            ii(0x13_9236, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_9238, 2); pushd(edi);                               /* push edi */
            ii(0x13_923a, 2); pushd(ebx);                               /* push ebx */
            ii(0x13_923c, 2); pushw(gs);                                /* push gs */
            ii(0x13_923e, 4); mov(gs, memw_a16[ds, 0xaa]);              /* mov gs, [0xaa] */
            ii(0x13_9242, 4); mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0x13_9246, 4); mov(ebx, memd_a16[ss, bp + 0x8]);         /* mov ebx, [bp+0x8] */
            ii(0x13_924a, 4); mov(eax, memd_a16[ss, bp + 0xc]);         /* mov eax, [bp+0xc] */
            ii(0x13_924e, 6); mov(memd_a32[gs, edi + ebx * 4], eax);    /* mov [gs:edi+ebx*4], eax */
            ii(0x13_9254, 2); popw(gs);                                 /* pop gs */
            ii(0x13_9256, 2); popd(ebx);                                /* pop ebx */
            ii(0x13_9258, 2); popd(edi);                                /* pop edi */
            ii(0x13_925a, 1); popw(bp);                                 /* pop bp */
            ii(0x13_925b, 1); retw(); return;                           /* ret */
        }
    }
}
