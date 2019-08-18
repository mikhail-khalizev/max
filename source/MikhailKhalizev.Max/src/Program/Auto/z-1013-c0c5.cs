using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("41a05907-5546-4777-9d1b-1404eae1b867")]
        public void Method_1013_c0c5()
        {
            ii(0x1013_c0c5, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_c0ca, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9c83); /* call 0x10165d52 */
            ii(0x1013_c0cf, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c0d0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c0d1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c0d2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c0d3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c0d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c0d6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c0dc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c0df, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_c0e2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_c0e7, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x1013_c0ea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c0ed, 5); calld(0x1013_c055, -0x9d);              /* call 0x1013c055 */
            ii(0x1013_c0f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c0f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c0f5, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c0f6, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c0f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c0f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c0f9, 1); retd(); return;                         /* ret */
        }
    }
}
