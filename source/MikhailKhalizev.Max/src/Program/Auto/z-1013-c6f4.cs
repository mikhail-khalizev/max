using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2f9a61fa-4ef3-4f87-b06f-ded5a49c70d5")]
        public void Method_1013_c6f4()
        {
            ii(0x1013_c6f4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_c6f9, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9654); /* call 0x10165d52 */
            ii(0x1013_c6fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c6ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c700, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c701, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c702, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c703, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c705, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c70b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c70e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c711, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_c714, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c717, 5); calld(0x1013_a2ab, -0x2471);            /* call 0x1013a2ab */
            ii(0x1013_c71c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c71e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c71f, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c720, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c721, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c722, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c723, 1); retd(); return;                         /* ret */
        }
    }
}
