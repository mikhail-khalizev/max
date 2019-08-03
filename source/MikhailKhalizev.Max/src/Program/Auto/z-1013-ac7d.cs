using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f084dee4-cbfc-44a2-90e8-3e54fd65b481")]
        public void Method_1013_ac7d()
        {
            ii(0x1013_ac7d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_ac82, 5); calld(Definitions.sys_check_available_stack_size, 0x2b0cb); /* call 0x10165d52 */
            ii(0x1013_ac87, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_ac88, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_ac89, 1); pushd(esi);                             /* push esi */
            ii(0x1013_ac8a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_ac8b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_ac8c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ac8e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_ac94, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_ac97, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_ac9a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ac9d, 5); calld(0x1013_ae28, 0x186);              /* call 0x1013ae28 */
            ii(0x1013_aca2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_aca5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_aca7, 5); calld(0x1013_add4, 0x128);              /* call 0x1013add4 */
            ii(0x1013_acac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_acaf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_acb2, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1013_acb4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_acb7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_acba, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_acbd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_acbf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_acc0, 1); popd(edi);                              /* pop edi */
            ii(0x1013_acc1, 1); popd(esi);                              /* pop esi */
            ii(0x1013_acc2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_acc3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_acc4, 1); retd(); return;                         /* ret */
        }
    }
}
