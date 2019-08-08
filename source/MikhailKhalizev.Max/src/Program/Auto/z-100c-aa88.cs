using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c7d9f03-99e7-4563-b9cd-401279bf888b")]
        public void Method_100c_aa88()
        {
            ii(0x100c_aa88, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_aa8d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b2c0); /* call 0x10165d52 */
            ii(0x100c_aa92, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_aa93, 1); pushd(esi);                             /* push esi */
            ii(0x100c_aa94, 1); pushd(edi);                             /* push edi */
            ii(0x100c_aa95, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_aa96, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_aa98, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_aa9e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_aaa1, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_aaa4, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_aaa7, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_aaab, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_aaae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_aab1, 5); calld(0x1008_b410, -0x3_f6a6);          /* call 0x1008b410 */
            ii(0x100c_aab6, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_aab9, 5); calld(0x100c_d990, 0x2ed2);             /* call 0x100cd990 */
            ii(0x100c_aabe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_aac0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_aac1, 1); popd(edi);                              /* pop edi */
            ii(0x100c_aac2, 1); popd(esi);                              /* pop esi */
            ii(0x100c_aac3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_aac4, 1); retd(); return;                         /* ret */
        }
    }
}
