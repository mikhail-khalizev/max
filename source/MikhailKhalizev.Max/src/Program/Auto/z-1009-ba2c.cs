using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f9fbb282-9086-460b-b848-0fcfb8ab3181")]
        public void Method_1009_ba2c()
        {
            ii(0x1009_ba2c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_ba31, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a31c); /* call 0x10165d52 */
            ii(0x1009_ba36, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_ba37, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ba38, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ba39, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ba3a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ba3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ba3d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ba43, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ba46, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ba49, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_ba4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ba51, 5); calld(0x1013_a1be, 0x9_e768);           /* call 0x1013a1be */
            ii(0x1009_ba56, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ba59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ba5c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_ba5f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ba62, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ba64, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ba65, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ba66, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ba67, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ba68, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ba69, 1); retd(); return;                         /* ret */
        }
    }
}
