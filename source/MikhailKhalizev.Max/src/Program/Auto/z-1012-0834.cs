using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("00cf7c94-7363-4d0c-836b-7d4417c17379")]
        public void Method_1012_0834()
        {
            ii(0x1012_0834, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_0839, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5514); /* call 0x10165d52 */
            ii(0x1012_083e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_083f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0840, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0841, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0842, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0843, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0845, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_084b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_084e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0851, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_0854, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0857, 5); calld(0x1013_a369, 0x1_9b0d);           /* call 0x1013a369 */
            ii(0x1012_085c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_085e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_085f, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0860, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0861, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0862, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0863, 1); retd(); return;                         /* ret */
        }
    }
}
