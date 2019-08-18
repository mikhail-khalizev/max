using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ab80-24ba296c")]
        public void Method_100a_ab80()
        {
            ii(0x100a_ab80, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_ab85, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b1c8); /* call 0x10165d52 */
            ii(0x100a_ab8a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ab8b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ab8c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ab8d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ab8e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ab8f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ab91, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_ab97, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ab9a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_ab9d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_aba0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_aba3, 5); calld(0x1007_6c98, -0x3_3f10);          /* call 0x10076c98 */
            ii(0x100a_aba8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_abab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_abae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_abb0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_abb1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_abb2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_abb3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_abb4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_abb5, 1); retd(); return;                         /* ret */
        }
    }
}
