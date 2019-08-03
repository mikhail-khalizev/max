using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5deb6d47-28a1-469d-bae4-8841f5a4ae40")]
        public void Method_100a_b36c()
        {
            ii(0x100a_b36c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_b371, 5); calld(Definitions.sys_check_available_stack_size, 0xba9dc); /* call 0x10165d52 */
            ii(0x100a_b376, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b377, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b378, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b379, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b37a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b37b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b37d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_b383, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b386, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_b389, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_b38c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b38f, 5); calld(0x1013_ac03, 0x8f86f);            /* call 0x1013ac03 */
            ii(0x100a_b394, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b397, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_b39a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_b39d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b3a0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_b3a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_b3a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b3a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b3a9, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b3aa, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b3ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b3ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b3ad, 1); retd(); return;                         /* ret */
        }
    }
}
