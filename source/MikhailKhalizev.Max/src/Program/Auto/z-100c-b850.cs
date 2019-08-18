using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3036e200-efb9-45b4-aa3f-954a67d47dfc")]
        public void Method_100c_b850()
        {
            ii(0x100c_b850, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b855, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a4f8); /* call 0x10165d52 */
            ii(0x100c_b85a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b85b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b85c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b85d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b85e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b85f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b861, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b867, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b86a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b86d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b870, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b873, 5); calld(0x1013_acc5, 0x6_f44d);           /* call 0x1013acc5 */
            ii(0x100c_b878, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b87b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b87e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b880, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b881, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b882, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b883, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b884, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b885, 1); retd(); return;                         /* ret */
        }
    }
}
