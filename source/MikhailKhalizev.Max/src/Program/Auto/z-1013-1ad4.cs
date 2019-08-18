using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1ad4-a7697fdd")]
        public void Method_1013_1ad4()
        {
            ii(0x1013_1ad4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1ad9, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4274); /* call 0x10165d52 */
            ii(0x1013_1ade, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1adf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1ae0, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1ae1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1ae2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1ae3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1ae4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1ae6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1aec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1aef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1af2, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1013_1af5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1af8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1afb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1afd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1afe, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1aff, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1b00, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1b01, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1b02, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1b03, 1); retd(); return;                         /* ret */
        }
    }
}
