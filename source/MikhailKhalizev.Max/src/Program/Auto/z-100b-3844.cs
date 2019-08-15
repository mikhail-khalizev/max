using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a44ad5f-0a44-4da2-b49e-faec14738d56")]
        public void Method_100b_3844()
        {
            ii(0x100b_3844, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_3849, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2504); /* call 0x10165d52 */
            ii(0x100b_384e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_384f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3850, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3851, 1); pushd(edi);                             /* push edi */
            ii(0x100b_3852, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3853, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3855, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_385b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_385e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_3861, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_3864, 5); calld(0x100b_375b, -0x10e);             /* call 0x100b375b */
            ii(0x100b_3869, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_386b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_386c, 1); popd(edi);                              /* pop edi */
            ii(0x100b_386d, 1); popd(esi);                              /* pop esi */
            ii(0x100b_386e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_386f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_3870, 1); retd(); return;                         /* ret */
        }
    }
}
