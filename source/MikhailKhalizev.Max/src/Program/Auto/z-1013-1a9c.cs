using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("35f082ab-15e9-49be-b32d-f832028b28fd")]
        public void Method_1013_1a9c()
        {
            ii(0x1013_1a9c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_1aa1, 5); calld(Definitions.sys_check_available_stack_size, 0x3_42ac); /* call 0x10165d52 */
            ii(0x1013_1aa6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1aa7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1aa8, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1aa9, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1aaa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1aab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1aad, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1ab3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1ab6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_1ab9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_1abc, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1013_1abf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1ac2, 5); calld(0x1007_5e64, -0xb_bc63);          /* call 0x10075e64 */
            ii(0x1013_1ac7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1aca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1acc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1acd, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1ace, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1acf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1ad0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1ad1, 1); retd(); return;                         /* ret */
        }
    }
}
