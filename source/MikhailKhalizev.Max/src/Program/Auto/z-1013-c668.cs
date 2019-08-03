using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6474b1b6-2dea-4409-9aeb-e30eb5a31334")]
        public void Method_1013_c668()
        {
            ii(0x1013_c668, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_c66d, 5); calld(Definitions.sys_check_available_stack_size, 0x296e0); /* call 0x10165d52 */
            ii(0x1013_c672, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c673, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c674, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c675, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c676, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c677, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c679, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_c67f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c682, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c685, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_c689, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c68c, 5); calld(0x1013_b052, -0x163f);            /* call 0x1013b052 */
            ii(0x1013_c691, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c694, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_c697, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c69a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c69d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_c6a0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_c6a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c6a5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c6a6, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c6a7, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c6a8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c6a9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c6aa, 1); retd(); return;                         /* ret */
        }
    }
}
