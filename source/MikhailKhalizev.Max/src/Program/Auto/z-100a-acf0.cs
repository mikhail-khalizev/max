using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("40285e8c-db6c-421e-b187-5f5186eb4278")]
        public void Method_100a_acf0()
        {
            ii(0x100a_acf0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_acf5, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b058); /* call 0x10165d52 */
            ii(0x100a_acfa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_acfb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_acfc, 1); pushd(esi);                             /* push esi */
            ii(0x100a_acfd, 1); pushd(edi);                             /* push edi */
            ii(0x100a_acfe, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_acff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ad01, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_ad07, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ad0a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_ad0d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_ad10, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ad13, 5); calld(0x1013_a2ab, 0x8_f593);           /* call 0x1013a2ab */
            ii(0x100a_ad18, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ad1a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ad1b, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ad1c, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ad1d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ad1e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ad1f, 1); retd(); return;                         /* ret */
        }
    }
}
