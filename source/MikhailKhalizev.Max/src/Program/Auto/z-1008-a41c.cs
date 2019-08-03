using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("19dd3828-1de4-4127-8900-f4ca807b9a37")]
        public void Method_1008_a41c()
        {
            ii(0x1008_a41c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_a421, 5); calld(Definitions.sys_check_available_stack_size, 0xdb92c); /* call 0x10165d52 */
            ii(0x1008_a426, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a427, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a428, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a429, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a42a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a42b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a42d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a433, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a436, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a439, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a43c, 5); calld(0x1008_b410, 0xfcf);              /* call 0x1008b410 */
            ii(0x1008_a441, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_a444, 5); calld(Definitions.my_3_get_count, 0x1037); /* call 0x1008b480 */
            ii(0x1008_a449, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1008_a44c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_a44f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a452, 5); calld(0x1008_a460, 0x9);                /* call 0x1008a460 */
            ii(0x1008_a457, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a459, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a45a, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a45b, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a45c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a45d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a45e, 1); retd(); return;                         /* ret */
        }
    }
}
