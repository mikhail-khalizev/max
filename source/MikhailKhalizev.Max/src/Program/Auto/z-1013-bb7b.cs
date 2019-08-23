using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bb7b-81f66bb8")]
        public void Method_1013_bb7b()
        {
            ii(0x1013_bb7b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_bb80, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a1cd); /* call 0x10165d52 */
            ii(0x1013_bb85, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bb86, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_bb87, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bb88, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bb89, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bb8a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bb8c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_bb92, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_bb95, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_bb98, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1013_bb9d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_bba0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bba3, 5); calld(0x1013_ba86, -0x122);             /* call 0x1013ba86 */
            ii(0x1013_bba8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bbaa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bbab, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bbac, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bbad, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bbae, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bbaf, 1); retd();                                 /* ret */
        }
    }
}
