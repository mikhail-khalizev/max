using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b67c-d6364a3")]
        public void Method_100c_b67c()
        {
            ii(0x100c_b67c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b681, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a6cc); /* call 0x10165d52 */
            ii(0x100c_b686, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b687, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b688, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b689, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b68a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b68b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b68c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b68e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b694, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b697, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b69a, 4); mov(ax, memw_a32[ds, eax + 0x6]);       /* mov ax, [eax+0x6] */
            ii(0x100c_b69e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b6a1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b6a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b6a6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b6a7, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b6a8, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b6a9, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b6aa, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b6ab, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b6ac, 1); retd(); return;                         /* ret */
        }
    }
}
