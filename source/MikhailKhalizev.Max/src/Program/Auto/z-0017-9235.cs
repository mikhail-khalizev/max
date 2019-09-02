using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9235-8b1d9d6a")]
        public void Method_0017_9235()
        {
            ii(0x17_9235, 1); push(bp);                                 /* push bp */
            ii(0x17_9236, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_9238, 2); push(edi);                                /* push edi */
            ii(0x17_923a, 2); push(ebx);                                /* push ebx */
            ii(0x17_923c, 2); push(gs);                                 /* push gs */
            ii(0x17_923e, 4); mov(gs, memw[ds, 0xaa]);                  /* mov gs, [0xaa] */
            ii(0x17_9242, 4); mov(edi, memd[ss, bp + 4]);               /* mov edi, [bp+0x4] */
            ii(0x17_9246, 4); mov(ebx, memd[ss, bp + 8]);               /* mov ebx, [bp+0x8] */
            ii(0x17_924a, 4); mov(eax, memd[ss, bp + 0xc]);             /* mov eax, [bp+0xc] */
            ii(0x17_924e, 6); mov(memd_a32[gs, edi + ebx * 4], eax);    /* mov [gs:edi+ebx*4], eax */
            ii(0x17_9254, 2); pop(gs);                                  /* pop gs */
            ii(0x17_9256, 2); pop(ebx);                                 /* pop ebx */
            ii(0x17_9258, 2); pop(edi);                                 /* pop edi */
            ii(0x17_925a, 1); pop(bp);                                  /* pop bp */
            ii(0x17_925b, 1); ret();                                    /* ret */
        }
    }
}
