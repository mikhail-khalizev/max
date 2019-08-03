using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("50a6ce36-a754-491c-bf2f-6a9c6edd6442")]
        public void Method_0013_9208()
        {
            ii(0x13_9208, 1); pushw(bp);                                /* push bp */
            ii(0x13_9209, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_920b, 2); pushd(edi);                               /* push edi */
            ii(0x13_920d, 2); pushd(ebx);                               /* push ebx */
            ii(0x13_920f, 2); pushw(gs);                                /* push gs */
            ii(0x13_9211, 4); mov(gs, memw_a16[ds, 0xaa]);              /* mov gs, [0xaa] */
            ii(0x13_9215, 4); mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0x13_9219, 4); mov(ebx, memd_a16[ss, bp + 0x8]);         /* mov ebx, [bp+0x8] */
            ii(0x13_921d, 6); mov(eax, memd_a32[gs, edi + ebx * 4]);    /* mov eax, [gs:edi+ebx*4] */
            ii(0x13_9223, 2); popw(gs);                                 /* pop gs */
            ii(0x13_9225, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_9227, 4); rol(eax, 0x10);                           /* rol eax, 0x10 */
            ii(0x13_922b, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_922d, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x13_922f, 2); popd(ebx);                                /* pop ebx */
            ii(0x13_9231, 2); popd(edi);                                /* pop edi */
            ii(0x13_9233, 1); popw(bp);                                 /* pop bp */
            ii(0x13_9234, 1); retw(); return;                           /* ret */
        }
    }
}
