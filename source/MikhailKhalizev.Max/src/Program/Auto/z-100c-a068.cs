using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b5c9cc4b-48be-498a-919f-5da4cb6b1084")]
        public void Method_100c_a068()
        {
            ii(0x100c_a068, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a06d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_bce0); /* call 0x10165d52 */
            ii(0x100c_a072, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a073, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a074, 1); pushd(edx);                             /* push edx */
            ii(0x100c_a075, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a076, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a077, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a078, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a07a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_a080, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_a083, 5); calld(0x100a_ab28, -0x1_f560);          /* call 0x100aab28 */
            ii(0x100c_a088, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_a08b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_a08e, 5); calld(0x100a_aad4, -0x1_f5bf);          /* call 0x100aaad4 */
            ii(0x100c_a093, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a096, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a099, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a09b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a09c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a09d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a09e, 1); popd(edx);                              /* pop edx */
            ii(0x100c_a09f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a0a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a0a1, 1); retd(); return;                         /* ret */
        }
    }
}
