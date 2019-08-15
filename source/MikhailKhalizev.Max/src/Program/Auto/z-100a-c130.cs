using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cbb5c494-3625-47e8-9218-2b37baa791e9")]
        public void Method_100a_c130()
        {
            ii(0x100a_c130, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_c135, 5); calld(Definitions.sys_check_available_stack_size, 0xb_9c18); /* call 0x10165d52 */
            ii(0x100a_c13a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_c13b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_c13c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_c13d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_c13e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_c13f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c141, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_c147, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_c14a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_c14d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_c150, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_c153, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c156, 5); calld(0x100b_7ea0, 0xbd45);             /* call 0x100b7ea0 */
            ii(0x100a_c15b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c15d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_c15e, 1); popd(edi);                              /* pop edi */
            ii(0x100a_c15f, 1); popd(esi);                              /* pop esi */
            ii(0x100a_c160, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_c161, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_c162, 1); retd(); return;                         /* ret */
        }
    }
}
