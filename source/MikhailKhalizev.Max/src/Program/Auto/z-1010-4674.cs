using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a3c29177-2a7a-4d3b-9d34-cde56a5c8721")]
        public void Method_1010_4674()
        {
            ii(0x1010_4674, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_4679, 5); calld(Definitions.sys_check_available_stack_size, 0x616d4); /* call 0x10165d52 */
            ii(0x1010_467e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_467f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4680, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4681, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4682, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4683, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4685, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_468b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_468e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_4691, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_4694, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4697, 5); calld(0x1013_a2ab, 0x35c0f);            /* call 0x1013a2ab */
            ii(0x1010_469c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_469e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_469f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_46a0, 1); popd(esi);                              /* pop esi */
            ii(0x1010_46a1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_46a2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_46a3, 1); retd(); return;                         /* ret */
        }
    }
}
