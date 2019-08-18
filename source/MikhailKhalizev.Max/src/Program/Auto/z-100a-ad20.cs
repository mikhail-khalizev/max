using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ad20-9fdcf5f8")]
        public void Method_100a_ad20()
        {
            ii(0x100a_ad20, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_ad25, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b028); /* call 0x10165d52 */
            ii(0x100a_ad2a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ad2b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ad2c, 1); pushd(edx);                             /* push edx */
            ii(0x100a_ad2d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ad2e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ad2f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ad30, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ad32, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_ad38, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_ad3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ad3e, 5); calld(0x1007_6b58, -0x3_41eb);          /* call 0x10076b58 */
            ii(0x100a_ad43, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ad46, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ad49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ad4b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ad4c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ad4d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ad4e, 1); popd(edx);                              /* pop edx */
            ii(0x100a_ad4f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ad50, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ad51, 1); retd(); return;                         /* ret */
        }
    }
}
