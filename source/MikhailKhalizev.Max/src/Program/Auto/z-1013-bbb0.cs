using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dda5f795-03f6-4384-854d-e039420055b5")]
        public void Method_1013_bbb0()
        {
            ii(0x1013_bbb0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_bbb5, 5); calld(Definitions.sys_check_available_stack_size, 0x2a198); /* call 0x10165d52 */
            ii(0x1013_bbba, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bbbb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_bbbc, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bbbd, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bbbe, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bbbf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bbc1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_bbc7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_bbca, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_bbcd, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1013_bbd2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_bbd5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bbd8, 5); calld(0x1013_ba86, -0x157);             /* call 0x1013ba86 */
            ii(0x1013_bbdd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bbdf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bbe0, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bbe1, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bbe2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bbe3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bbe4, 1); retd(); return;                         /* ret */
        }
    }
}