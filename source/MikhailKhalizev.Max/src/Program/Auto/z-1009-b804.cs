using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ec540392-a0da-4463-bf6e-7f63eedf91de")]
        public void Method_1009_b804()
        {
            ii(0x1009_b804, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b809, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a544); /* call 0x10165d52 */
            ii(0x1009_b80e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b80f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b810, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b811, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b812, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b813, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b815, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b81b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b81e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b821, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b824, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_b827, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b82a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b82c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b82d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b82e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b82f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b830, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b831, 1); retd(); return;                         /* ret */
        }
    }
}
