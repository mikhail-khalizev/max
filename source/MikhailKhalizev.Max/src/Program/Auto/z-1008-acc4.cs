using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_acc4-6616294d")]
        public void Method_1008_acc4()
        {
            ii(0x1008_acc4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_acc9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b084); /* call 0x10165d52 */
            ii(0x1008_acce, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_accf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_acd0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_acd1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_acd2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_acd3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_acd5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_acdb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_acde, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_ace1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_ace4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ace7, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_acea, 5); calld(0x1008_afe4, 0x2f5);              /* call 0x1008afe4 */
            ii(0x1008_acef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_acf1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_acf2, 1); popd(edi);                              /* pop edi */
            ii(0x1008_acf3, 1); popd(esi);                              /* pop esi */
            ii(0x1008_acf4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_acf5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_acf6, 1); retd();                                 /* ret */
        }
    }
}
