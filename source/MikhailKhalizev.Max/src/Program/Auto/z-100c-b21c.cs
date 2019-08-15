using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eb811c69-e74a-4aa5-9d68-e36224ac9d20")]
        public void Method_100c_b21c()
        {
            ii(0x100c_b21c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_b221, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ab2c); /* call 0x10165d52 */
            ii(0x100c_b226, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b227, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b228, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b229, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b22a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b22b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b22d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b233, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b236, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b239, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b23c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b23f, 5); calld(0x1013_a2ab, 0x6_f067);           /* call 0x1013a2ab */
            ii(0x100c_b244, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b246, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b247, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b248, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b249, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b24a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b24b, 1); retd(); return;                         /* ret */
        }
    }
}
