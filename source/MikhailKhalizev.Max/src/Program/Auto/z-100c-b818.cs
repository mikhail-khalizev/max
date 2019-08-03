using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d88a3555-e508-41d2-a1ef-adf26304eef5")]
        public void Method_100c_b818()
        {
            ii(0x100c_b818, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_b81d, 5); calld(Definitions.sys_check_available_stack_size, 0x9a530); /* call 0x10165d52 */
            ii(0x100c_b822, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b823, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b824, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b825, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b826, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b827, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b829, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b82f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b832, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100c_b835, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_b83a, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x100c_b83d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b840, 5); calld(0x1013_c055, 0x70810);            /* call 0x1013c055 */
            ii(0x100c_b845, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b847, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b848, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b849, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b84a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b84b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b84c, 1); retd(); return;                         /* ret */
        }
    }
}
