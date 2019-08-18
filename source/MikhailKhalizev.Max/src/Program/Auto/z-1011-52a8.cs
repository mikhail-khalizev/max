using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7edf16d7-46a6-4bb6-8609-08ef34371332")]
        public void Method_1011_52a8()
        {
            ii(0x1011_52a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_52a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_52aa, 1); pushd(edx);                             /* push edx */
            ii(0x1011_52ab, 1); pushd(esi);                             /* push esi */
            ii(0x1011_52ac, 1); pushd(edi);                             /* push edi */
            ii(0x1011_52ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_52ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_52b0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_52b6, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1011_52ba, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_52bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_52bf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_52c0, 1); popd(edi);                              /* pop edi */
            ii(0x1011_52c1, 1); popd(esi);                              /* pop esi */
            ii(0x1011_52c2, 1); popd(edx);                              /* pop edx */
            ii(0x1011_52c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_52c4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_52c5, 1); retd(); return;                         /* ret */
        }
    }
}
