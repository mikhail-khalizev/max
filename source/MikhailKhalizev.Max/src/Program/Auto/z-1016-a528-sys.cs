using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a528-ac955e2a")]
        public void /* sys */ Method_1016_a528()
        {
            ii(0x1016_a528, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_a529, 1); pushd(edx);                             /* push edx */
            ii(0x1016_a52a, 1); pushd(edi);                             /* push edi */
            ii(0x1016_a52b, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_a52d, 6); calld_abs(memd_a32[ds, 0x101b_de08]);   /* call dword [0x101bde08] */ /* Вызов '0x1016_a568'. */
            ii(0x1016_a533, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_a535, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1016_a537, 1); dec(ecx);                               /* dec ecx */
            ii(0x1016_a538, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_a53a, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1016_a53c, 2); not(ecx);                               /* not ecx */
            ii(0x1016_a53e, 1); dec(ecx);                               /* dec ecx */
            ii(0x1016_a53f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_a541, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1016_a544, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a545, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a546, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a547, 1); retd();                                 /* ret */
        }
    }
}
