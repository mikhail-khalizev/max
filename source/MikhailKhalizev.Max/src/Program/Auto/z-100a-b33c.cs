using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b33c-a52a30ad")]
        public void Method_100a_b33c()
        {
            ii(0x100a_b33c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_b341, 5); calld(Definitions.sys_check_available_stack_size, 0xb_aa0c); /* call 0x10165d52 */
            ii(0x100a_b346, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b347, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b348, 1); pushd(edx);                             /* push edx */
            ii(0x100a_b349, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b34a, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b34b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b34c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b34e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_b354, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_b357, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_b35a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_b35c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b35f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b362, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b364, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b365, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b366, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b367, 1); popd(edx);                              /* pop edx */
            ii(0x100a_b368, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b369, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b36a, 1); retd(); return;                         /* ret */
        }
    }
}
