using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7f7fc7a-2334-49d0-8b2a-37ec77f99e7d")]
        public void Method_1009_875f()
        {
            ii(0x1009_875f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_8764, 5); calld(Definitions.sys_check_available_stack_size, 0xc_d5e9); /* call 0x10165d52 */
            ii(0x1009_8769, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_876a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_876b, 1); pushd(esi);                             /* push esi */
            ii(0x1009_876c, 1); pushd(edi);                             /* push edi */
            ii(0x1009_876d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_876e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_8770, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_8776, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_8779, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_877c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_877f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_8782, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_8785, 5); calld(0x1008_aab4, -0xdcd6);            /* call 0x1008aab4 */
            ii(0x1009_878a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_878c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_878d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_878e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_878f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_8790, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_8791, 1); retd(); return;                         /* ret */
        }
    }
}
