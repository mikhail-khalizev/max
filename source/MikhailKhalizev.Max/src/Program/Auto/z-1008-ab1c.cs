using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45099d82-61c9-4726-98e0-e7c69f6f4690")]
        public void Method_1008_ab1c()
        {
            ii(0x1008_ab1c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_ab21, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b22c); /* call 0x10165d52 */
            ii(0x1008_ab26, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_ab27, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_ab28, 1); pushd(esi);                             /* push esi */
            ii(0x1008_ab29, 1); pushd(edi);                             /* push edi */
            ii(0x1008_ab2a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_ab2b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ab2d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_ab33, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_ab36, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_ab39, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_ab3c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_ab3f, 5); calld(0x1013_a2ab, 0xa_f767);           /* call 0x1013a2ab */
            ii(0x1008_ab44, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ab46, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_ab47, 1); popd(edi);                              /* pop edi */
            ii(0x1008_ab48, 1); popd(esi);                              /* pop esi */
            ii(0x1008_ab49, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_ab4a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_ab4b, 1); retd(); return;                         /* ret */
        }
    }
}
