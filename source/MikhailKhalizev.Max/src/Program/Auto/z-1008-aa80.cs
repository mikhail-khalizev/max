using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_aa80-950d42ea")]
        public void Method_1008_aa80()
        {
            ii(0x1008_aa80, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_aa85, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b2c8); /* call 0x10165d52 */
            ii(0x1008_aa8a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_aa8b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_aa8c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_aa8d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_aa8e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_aa8f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_aa90, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_aa92, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_aa98, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_aa9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_aa9e, 6); mov(eax, memd_a32[ds, eax + 0xdd]);     /* mov eax, [eax+0xdd] */
            ii(0x1008_aaa4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_aaa7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_aaaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_aaac, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_aaad, 1); popd(edi);                              /* pop edi */
            ii(0x1008_aaae, 1); popd(esi);                              /* pop esi */
            ii(0x1008_aaaf, 1); popd(edx);                              /* pop edx */
            ii(0x1008_aab0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_aab1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_aab2, 1); retd(); return;                         /* ret */
        }
    }
}
