using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8fb40197-7d98-483e-a9b4-0e1115b179f4")]
        public void Method_1013_c12f()
        {
            ii(0x1013_c12f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_c134, 5); calld(Definitions.sys_check_available_stack_size, 0x29c19); /* call 0x10165d52 */
            ii(0x1013_c139, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c13a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c13b, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c13c, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c13d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c13e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c140, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c146, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c149, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c14c, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1013_c151, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x1013_c154, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c157, 5); calld(0x1013_c055, -0x107);             /* call 0x1013c055 */
            ii(0x1013_c15c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c15e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c15f, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c160, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c161, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c162, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c163, 1); retd(); return;                         /* ret */
        }
    }
}