using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_8850-27d73eb8")]
        public void Method_1014_8850()
        {
            ii(0x1014_8850, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_8855, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d4f8); /* call 0x10165d52 */
            ii(0x1014_885a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_885b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_885c, 1); pushd(esi);                             /* push esi */
            ii(0x1014_885d, 1); pushd(edi);                             /* push edi */
            ii(0x1014_885e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_885f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8861, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_8867, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_886a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_886d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_8870, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8873, 5); calld(0x1013_a112, -0xe766);            /* call 0x1013a112 */
            ii(0x1014_8878, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_887b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_887e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_8881, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8884, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_8887, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_888a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_888c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_888d, 1); popd(edi);                              /* pop edi */
            ii(0x1014_888e, 1); popd(esi);                              /* pop esi */
            ii(0x1014_888f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8890, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_8891, 1); retd(); return;                         /* ret */
        }
    }
}
