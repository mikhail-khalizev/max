using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9a8ee739-105d-49ed-9aa5-231f26eff763")]
        public void Method_1007_ab97()
        {
            ii(0x1007_ab97, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_ab9c, 5); calld(Definitions.sys_check_available_stack_size, 0xe_b1b1); /* call 0x10165d52 */
            ii(0x1007_aba1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_aba2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_aba3, 1); pushd(esi);                             /* push esi */
            ii(0x1007_aba4, 1); pushd(edi);                             /* push edi */
            ii(0x1007_aba5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_aba6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_aba8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_abae, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_abb1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_abb4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_abb7, 5); calld(0x1015_09a6, 0xd_5dea);           /* call 0x101509a6 */
            ii(0x1007_abbc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_abbe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_abc1, 4); sub(memw_a32[ds, eax + 0x21], dx);      /* sub [eax+0x21], dx */
            ii(0x1007_abc5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_abc8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_abcb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_abce, 5); calld(0x1008_aab4, 0xfee1);             /* call 0x1008aab4 */
            ii(0x1007_abd3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_abd5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_abd6, 1); popd(edi);                              /* pop edi */
            ii(0x1007_abd7, 1); popd(esi);                              /* pop esi */
            ii(0x1007_abd8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_abd9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_abda, 1); retd(); return;                         /* ret */
        }
    }
}
