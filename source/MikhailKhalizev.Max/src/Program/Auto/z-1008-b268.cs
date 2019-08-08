using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c49a7275-c3ef-40e1-8016-ae62e558347a")]
        public void Method_1008_b268()
        {
            ii(0x1008_b268, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_b26d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_aae0); /* call 0x10165d52 */
            ii(0x1008_b272, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b273, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b274, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b275, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b276, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b277, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b279, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_b27f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b282, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b285, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_b288, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b28b, 5); calld(0x1008_b410, 0x180);              /* call 0x1008b410 */
            ii(0x1008_b290, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_b293, 5); calld(0x100c_dba5, 0x4_290d);           /* call 0x100cdba5 */
            ii(0x1008_b298, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_b29b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_b29e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b2a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b2a1, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b2a2, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b2a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b2a4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b2a5, 1); retd(); return;                         /* ret */
        }
    }
}
