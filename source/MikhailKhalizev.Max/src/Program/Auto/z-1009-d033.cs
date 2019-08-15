using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("86b0ebe3-190f-4747-8c14-bf6e42c4ca4b")]
        public void Method_1009_d033()
        {
            ii(0x1009_d033, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_d038, 5); calld(Definitions.sys_check_available_stack_size, 0xc_8d15); /* call 0x10165d52 */
            ii(0x1009_d03d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_d03e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_d03f, 1); pushd(esi);                             /* push esi */
            ii(0x1009_d040, 1); pushd(edi);                             /* push edi */
            ii(0x1009_d041, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_d042, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d044, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_d04a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_d04d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_d050, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_d053, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_d056, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_d059, 5); calld(0x1008_aab4, -0x1_25aa);          /* call 0x1008aab4 */
            ii(0x1009_d05e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d060, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_d061, 1); popd(edi);                              /* pop edi */
            ii(0x1009_d062, 1); popd(esi);                              /* pop esi */
            ii(0x1009_d063, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_d064, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_d065, 1); retd(); return;                         /* ret */
        }
    }
}
