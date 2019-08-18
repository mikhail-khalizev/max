using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c868-940b551a")]
        public void Method_1013_c868()
        {
            ii(0x1013_c868, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_c86d, 5); calld(Definitions.sys_check_available_stack_size, 0x2_94e0); /* call 0x10165d52 */
            ii(0x1013_c872, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c873, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c874, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c875, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c876, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c877, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c879, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c87f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c882, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c885, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c888, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_c88b, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x1013_c88f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c891, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c892, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c893, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c894, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c895, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c896, 1); retd(); return;                         /* ret */
        }
    }
}
