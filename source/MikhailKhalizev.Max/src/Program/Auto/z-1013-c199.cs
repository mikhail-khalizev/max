using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("526fa29e-e23b-4bc2-abce-4423854bd52b")]
        public void Method_1013_c199()
        {
            ii(0x1013_c199, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_c19e, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9baf); /* call 0x10165d52 */
            ii(0x1013_c1a3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c1a4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c1a5, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c1a6, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c1a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c1a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c1aa, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c1b0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c1b3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c1b6, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1013_c1bb, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x1013_c1be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c1c1, 5); calld(0x1013_c055, -0x171);             /* call 0x1013c055 */
            ii(0x1013_c1c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c1c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c1c9, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c1ca, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c1cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c1cc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c1cd, 1); retd(); return;                         /* ret */
        }
    }
}
