using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a267-592ac263")]
        public void Method_1009_a267()
        {
            ii(0x1009_a267, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_a26c, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bae1); /* call 0x10165d52 */
            ii(0x1009_a271, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a272, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a273, 1); pushd(edx);                             /* push edx */
            ii(0x1009_a274, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a275, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a276, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a277, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a279, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_a27f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_a282, 4); mov(memb_a32[ss, ebp - 0x8], 0x23);     /* mov byte [ebp-0x8], 0x23 */
            ii(0x1009_a286, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_a289, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a28b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a28c, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a28d, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a28e, 1); popd(edx);                              /* pop edx */
            ii(0x1009_a28f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a290, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a291, 1); retd(); return;                         /* ret */
        }
    }
}
