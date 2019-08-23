using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a79c-b70b8a0f")]
        public void Method_1008_a79c()
        {
            ii(0x1008_a79c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a79d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a79e, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a79f, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a7a0, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a7a1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a7a2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a7a4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_a7aa, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1008_a7ae, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1008_a7b1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a7b3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a7b4, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a7b5, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a7b6, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a7b7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a7b8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a7b9, 1); retd();                                 /* ret */
        }
    }
}
