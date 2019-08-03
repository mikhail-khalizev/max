using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cfd1ddb0-267b-42ef-8549-0845f8e9daaf")]
        public void Method_1014_7b94()
        {
            ii(0x1014_7b94, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7b99, 5); calld(Definitions.sys_check_available_stack_size, 0x1e1b4); /* call 0x10165d52 */
            ii(0x1014_7b9e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7b9f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7ba0, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7ba1, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7ba2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7ba3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7ba5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7bab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7bae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7bb1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_7bb4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7bb7, 5); calld(0x1013_ac7d, -0xcf3f);            /* call 0x1013ac7d */
            ii(0x1014_7bbc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7bbf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7bc2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7bc4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7bc5, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7bc6, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7bc7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7bc8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7bc9, 1); retd(); return;                         /* ret */
        }
    }
}
