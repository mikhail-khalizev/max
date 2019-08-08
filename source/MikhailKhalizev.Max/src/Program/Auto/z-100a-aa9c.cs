using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d9080b5-98b3-490b-875f-979c2e65f79c")]
        public void Method_100a_aa9c()
        {
            ii(0x100a_aa9c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_aaa1, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b2ac); /* call 0x10165d52 */
            ii(0x100a_aaa6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_aaa7, 1); pushd(esi);                             /* push esi */
            ii(0x100a_aaa8, 1); pushd(edi);                             /* push edi */
            ii(0x100a_aaa9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_aaaa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_aaac, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_aab2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_aab5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_aab8, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_aabb, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_aabf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_aac2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_aac5, 5); calld(0x100c_d990, 0x2_2ec6);           /* call 0x100cd990 */
            ii(0x100a_aaca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_aacc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_aacd, 1); popd(edi);                              /* pop edi */
            ii(0x100a_aace, 1); popd(esi);                              /* pop esi */
            ii(0x100a_aacf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_aad0, 1); retd(); return;                         /* ret */
        }
    }
}
