using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_898c-2b55c61c")]
        public void Method_1009_898c()
        {
            ii(0x1009_898c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_8991, 5); calld(Definitions.sys_check_available_stack_size, 0xc_d3bc); /* call 0x10165d52 */
            ii(0x1009_8996, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_8997, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_8998, 1); pushd(edx);                             /* push edx */
            ii(0x1009_8999, 1); pushd(esi);                             /* push esi */
            ii(0x1009_899a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_899b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_899c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_899e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_89a4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_89a7, 4); mov(memb_a32[ss, ebp - 0x8], 0x8);      /* mov byte [ebp-0x8], 0x8 */
            ii(0x1009_89ab, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_89ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_89b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_89b1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_89b2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_89b3, 1); popd(edx);                              /* pop edx */
            ii(0x1009_89b4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_89b5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_89b6, 1); retd(); return;                         /* ret */
        }
    }
}
