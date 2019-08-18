using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a7bc-b70b8a0f")]
        public void Method_1008_a7bc()
        {
            ii(0x1008_a7bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a7bd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a7be, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a7bf, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a7c0, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a7c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a7c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a7c4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_a7ca, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1008_a7ce, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1008_a7d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a7d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a7d4, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a7d5, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a7d6, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a7d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a7d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a7d9, 1); retd(); return;                         /* ret */
        }
    }
}
