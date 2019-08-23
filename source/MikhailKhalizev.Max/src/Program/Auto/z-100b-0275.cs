using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0275-f4cda5db")]
        public void Method_100b_0275()
        {
            ii(0x100b_0275, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_027a, 5); calld(Definitions.sys_check_available_stack_size, 0xb_5ad3); /* call 0x10165d52 */
            ii(0x100b_027f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_0280, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0281, 1); pushd(edx);                             /* push edx */
            ii(0x100b_0282, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0283, 1); pushd(edi);                             /* push edi */
            ii(0x100b_0284, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_0285, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0287, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_028d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_0290, 4); mov(memb_a32[ss, ebp - 0x8], 0xe);      /* mov byte [ebp-0x8], 0xe */
            ii(0x100b_0294, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_0297, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0299, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_029a, 1); popd(edi);                              /* pop edi */
            ii(0x100b_029b, 1); popd(esi);                              /* pop esi */
            ii(0x100b_029c, 1); popd(edx);                              /* pop edx */
            ii(0x100b_029d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_029e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_029f, 1); retd();                                 /* ret */
        }
    }
}
