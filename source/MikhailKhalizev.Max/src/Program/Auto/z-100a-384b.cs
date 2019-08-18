using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90f1f3e4-3814-4277-ba72-6c6f8bd2a48b")]
        public void Method_100a_384b()
        {
            ii(0x100a_384b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_3850, 5); calld(Definitions.sys_check_available_stack_size, 0xc_24fd); /* call 0x10165d52 */
            ii(0x100a_3855, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3856, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3857, 1); pushd(edx);                             /* push edx */
            ii(0x100a_3858, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3859, 1); pushd(edi);                             /* push edi */
            ii(0x100a_385a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_385b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_385d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_3863, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_3866, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_386d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3870, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3872, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3873, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3874, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3875, 1); popd(edx);                              /* pop edx */
            ii(0x100a_3876, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3877, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3878, 1); retd(); return;                         /* ret */
        }
    }
}
