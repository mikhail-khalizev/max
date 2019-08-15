using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("88ea6aad-ac0a-46a6-acc6-a0db9964c853")]
        public void Method_100a_7557()
        {
            ii(0x100a_7557, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_755c, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e7f1); /* call 0x10165d52 */
            ii(0x100a_7561, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_7562, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_7563, 1); pushd(esi);                             /* push esi */
            ii(0x100a_7564, 1); pushd(edi);                             /* push edi */
            ii(0x100a_7565, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_7566, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7568, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_756e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_7571, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_7574, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_7577, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_757a, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_757d, 5); calld(0x100a_aa64, 0x34e2);             /* call 0x100aaa64 */
            ii(0x100a_7582, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7584, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7585, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7586, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7587, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_7588, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_7589, 1); retd(); return;                         /* ret */
        }
    }
}
