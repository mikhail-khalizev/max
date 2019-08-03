using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("31b241d1-4ac8-413d-8c4a-9ff12a499c42")]
        public void Method_1008_8b7c()
        {
            ii(0x1008_8b7c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8b81, 5); calld(Definitions.sys_check_available_stack_size, 0xdd1cc); /* call 0x10165d52 */
            ii(0x1008_8b86, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8b87, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8b88, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8b89, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8b8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8b8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8b8d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8b93, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8b96, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8b99, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8b9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8ba1, 5); calld(Definitions.my_dtor_0x101b6edc, 0xb209f); /* call 0x1013ac45 */
            ii(0x1008_8ba6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8ba9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8bac, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8baf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8bb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8bb4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8bb5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8bb6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8bb7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8bb8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8bb9, 1); retd(); return;                         /* ret */
        }
    }
}
