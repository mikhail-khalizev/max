using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("189f93d8-7d91-4068-9e2d-05b57a9d86d0")]
        public void Method_1011_dd56()
        {
            ii(0x1011_dd56, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_dd5b, 5); calld(Definitions.sys_check_available_stack_size, 0x47ff2); /* call 0x10165d52 */
            ii(0x1011_dd60, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_dd61, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_dd62, 1); pushd(esi);                             /* push esi */
            ii(0x1011_dd63, 1); pushd(edi);                             /* push edi */
            ii(0x1011_dd64, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_dd65, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_dd67, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_dd6d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_dd70, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_dd73, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_dd76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_dd79, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_dd7c, 5); calld(0x1012_0864, 0x2ae3);             /* call 0x10120864 */
            ii(0x1011_dd81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_dd83, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_dd84, 1); popd(edi);                              /* pop edi */
            ii(0x1011_dd85, 1); popd(esi);                              /* pop esi */
            ii(0x1011_dd86, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_dd87, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_dd88, 1); retd(); return;                         /* ret */
        }
    }
}
