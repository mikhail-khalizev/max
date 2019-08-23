using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b842-64234807")]
        public void Method_1013_b842()
        {
            ii(0x1013_b842, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_b847, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a506); /* call 0x10165d52 */
            ii(0x1013_b84c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b84d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b84e, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b84f, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b850, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b851, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b853, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b859, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b85c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b85f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b862, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_b865, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b868, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b86b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b86d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b86e, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b86f, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b870, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b871, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b872, 1); retd();                                 /* ret */
        }
    }
}
