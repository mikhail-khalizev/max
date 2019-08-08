using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c6c0a42-d532-4aed-98e3-948abc5d9b82")]
        public void Method_1013_a854()
        {
            ii(0x1013_a854, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_a859, 5); calld(Definitions.sys_check_available_stack_size, 0x2_b4f4); /* call 0x10165d52 */
            ii(0x1013_a85e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_a85f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a860, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a861, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a862, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a863, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a865, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_a86b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a86e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_a871, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_a875, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a878, 5); calld(0x1013_a893, 0x16);               /* call 0x1013a893 */
            ii(0x1013_a87d, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a880, 5); calld(0x1007_6dd0, -0xc_3ab5);          /* call 0x10076dd0 */
            ii(0x1013_a885, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_a888, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_a88b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a88d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a88e, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a88f, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a890, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a891, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_a892, 1); retd(); return;                         /* ret */
        }
    }
}
