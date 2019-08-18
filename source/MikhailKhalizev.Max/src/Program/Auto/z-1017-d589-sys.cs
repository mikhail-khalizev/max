using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d589-f79c508a")]
        public void /* sys */ Method_1017_d589()
        {
            ii(0x1017_d589, 1); pushd(edi);                             /* push edi */
            ii(0x1017_d58a, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_d58c, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1017_d58e, 1); pushd(es);                              /* push es */
            ii(0x1017_d58f, 1); pushd(edi);                             /* push edi */
            ii(0x1017_d590, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1017_d592, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1017_d594, 2); shr(ecx, 0x1);                          /* shr ecx, 1 */
            ii(0x1017_d596, 3); repne_a32(() => stosw_a32());           /* repne stosw */
            ii(0x1017_d599, 2); adc(ecx, ecx);                          /* adc ecx, ecx */
            ii(0x1017_d59b, 2); repne_a32(() => stosb_a32());           /* repne stosb */
            ii(0x1017_d59d, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d59e, 1); popd(es);                               /* pop es */
            ii(0x1017_d59f, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_d5a1, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d5a2, 1); retd(); return;                         /* ret */
        }
    }
}
