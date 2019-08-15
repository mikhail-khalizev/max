using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("51f615f8-4157-4fcf-8a46-b9e41e4787f3")]
        public void Method_1016_4870()
        {
            ii(0x1016_4870, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_4875, 5); calld(Definitions.sys_check_available_stack_size, 0x14d8); /* call 0x10165d52 */
            ii(0x1016_487a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_487b, 1); pushd(esi);                             /* push esi */
            ii(0x1016_487c, 1); pushd(edi);                             /* push edi */
            ii(0x1016_487d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_487e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4880, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_4886, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4889, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1016_488c, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1016_488f, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1016_4893, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_4896, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_4899, 5); calld(0x1013_b0f9, -0x2_97a5);          /* call 0x1013b0f9 */
            ii(0x1016_489e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_48a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_48a1, 1); popd(edi);                              /* pop edi */
            ii(0x1016_48a2, 1); popd(esi);                              /* pop esi */
            ii(0x1016_48a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_48a4, 1); retd(); return;                         /* ret */
        }
    }
}
