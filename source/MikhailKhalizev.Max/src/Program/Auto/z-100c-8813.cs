using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bc18ba94-8363-4c06-b1a8-714c3cd1ca8e")]
        public void Method_100c_8813()
        {
            ii(0x100c_8813, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_8818, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d535); /* call 0x10165d52 */
            ii(0x100c_881d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_881e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_881f, 1); pushd(edx);                             /* push edx */
            ii(0x100c_8820, 1); pushd(esi);                             /* push esi */
            ii(0x100c_8821, 1); pushd(edi);                             /* push edi */
            ii(0x100c_8822, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_8823, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_8825, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_882b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_882e, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100c_8835, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_8838, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_883a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_883b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_883c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_883d, 1); popd(edx);                              /* pop edx */
            ii(0x100c_883e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_883f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_8840, 1); retd(); return;                         /* ret */
        }
    }
}
