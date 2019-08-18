using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ac94-e1f978ae")]
        public void Method_1008_ac94()
        {
            ii(0x1008_ac94, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_ac99, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b0b4); /* call 0x10165d52 */
            ii(0x1008_ac9e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_ac9f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_aca0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_aca1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_aca2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_aca3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_aca5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_acab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_acae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_acb1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_acb4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_acb7, 4); mov(memw_a32[ds, edx + 0xd], ax);       /* mov [edx+0xd], ax */
            ii(0x1008_acbb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_acbd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_acbe, 1); popd(edi);                              /* pop edi */
            ii(0x1008_acbf, 1); popd(esi);                              /* pop esi */
            ii(0x1008_acc0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_acc1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_acc2, 1); retd(); return;                         /* ret */
        }
    }
}
