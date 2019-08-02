using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("89061621-c138-4160-a6c0-e8d80963810e")]
        public void Method_0013_925c()
        {
            ii(0x13_925c, 1); pushw(bp);                                /* push bp */
            ii(0x13_925d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_925f, 1); pushw(es);                                /* push es */
            ii(0x13_9260, 2); pushd(edi);                               /* push edi */
            ii(0x13_9262, 2); pushd(ecx);                               /* push ecx */
            ii(0x13_9264, 4); mov(ecx, memd_a16[ss, bp + 0xc]);         /* mov ecx, [bp+0xc] */
            ii(0x13_9268, 3); mov(es, memw_a16[ss, bp + 0x6]);          /* mov es, [bp+0x6] */
            ii(0x13_926b, 4); mov(edi, memd_a16[ss, bp + 0x8]);         /* mov edi, [bp+0x8] */
            ii(0x13_926f, 1); cli();                                    /* cli */
            ii(0x13_9270, 2); mov(al, 0);                               /* mov al, 0x0 */
            ii(0x13_9272, 4); rep_a32(() => stosb_a32());               /* o32 a32 rep stosb */
            ii(0x13_9276, 2); sti();                                    /* a32 sti */
            ii(0x13_9278, 2); popd(ecx);                                /* pop ecx */
            ii(0x13_927a, 2); popd(edi);                                /* pop edi */
            ii(0x13_927c, 1); popw(es);                                 /* pop es */
            ii(0x13_927d, 1); popw(bp);                                 /* pop bp */
            ii(0x13_927e, 1); retfw(); return;                          /* retf */
        }
    }
}
