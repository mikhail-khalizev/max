using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("310b916f-12c7-4e39-ab1e-51c9d6b91940")]
        public void Method_1008_a768()
        {
            ii(0x1008_a768, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a76d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b5e0); /* call 0x10165d52 */
            ii(0x1008_a772, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a773, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a774, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a775, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a776, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a777, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a778, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a77a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a780, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a783, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a786, 5); calld(0x1008_aef4, 0x769);              /* call 0x1008aef4 */
            ii(0x1008_a78b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a78e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a791, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a793, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a794, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a795, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a796, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a797, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a798, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a799, 1); retd(); return;                         /* ret */
        }
    }
}
