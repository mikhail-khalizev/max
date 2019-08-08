using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("335f3274-9007-463e-a9fb-49383e863c69")]
        public void Method_1009_ca40()
        {
            ii(0x1009_ca40, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_ca45, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9308); /* call 0x10165d52 */
            ii(0x1009_ca4a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_ca4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ca4c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ca4d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ca4e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ca4f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ca51, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_ca57, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ca5a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ca5d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_ca60, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ca63, 5); calld(0x1013_a2ab, 0x9_d843);           /* call 0x1013a2ab */
            ii(0x1009_ca68, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ca6a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ca6b, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ca6c, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ca6d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ca6e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ca6f, 1); retd(); return;                         /* ret */
        }
    }
}
