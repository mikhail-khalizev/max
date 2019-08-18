using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b834-7b04914b")]
        public void Method_1009_b834()
        {
            ii(0x1009_b834, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b839, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a514); /* call 0x10165d52 */
            ii(0x1009_b83e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b83f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b840, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b841, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b842, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b843, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b845, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b84b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b84e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b851, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_b856, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b859, 5); calld(0x1013_a1be, 0x9_e960);           /* call 0x1013a1be */
            ii(0x1009_b85e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b861, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b864, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_b867, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b86a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b86c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b86d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b86e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b86f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b870, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b871, 1); retd(); return;                         /* ret */
        }
    }
}
