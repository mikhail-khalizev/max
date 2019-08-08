using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("57b8cc6a-752f-4f17-9f79-de27e888d5c2")]
        public void Method_1013_aaa8()
        {
            ii(0x1013_aaa8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_aaad, 5); calld(Definitions.sys_check_available_stack_size, 0x2_b2a0); /* call 0x10165d52 */
            ii(0x1013_aab2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_aab3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_aab4, 1); pushd(edx);                             /* push edx */
            ii(0x1013_aab5, 1); pushd(esi);                             /* push esi */
            ii(0x1013_aab6, 1); pushd(edi);                             /* push edi */
            ii(0x1013_aab7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_aab8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_aaba, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_aac0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_aac3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_aac6, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_6ec4); /* mov dword [eax+0x2], 0x101b6ec4 */
            ii(0x1013_aacd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_aad0, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x1013_aad5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_aad8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_aadb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_aade, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_aae0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_aae1, 1); popd(edi);                              /* pop edi */
            ii(0x1013_aae2, 1); popd(esi);                              /* pop esi */
            ii(0x1013_aae3, 1); popd(edx);                              /* pop edx */
            ii(0x1013_aae4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_aae5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_aae6, 1); retd(); return;                         /* ret */
        }
    }
}
