using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_acf0-8b9b6382")]
        public void Method_100a_acf0()
        {
            ii(0x100a_acf0, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_acf5, 5); call(Definitions.sys_check_available_stack_size, 0xb_b058); /* call 0x10165d52 */
            ii(0x100a_acfa, 1); push(ebx);                              /* push ebx */
            ii(0x100a_acfb, 1); push(ecx);                              /* push ecx */
            ii(0x100a_acfc, 1); push(esi);                              /* push esi */
            ii(0x100a_acfd, 1); push(edi);                              /* push edi */
            ii(0x100a_acfe, 1); push(ebp);                              /* push ebp */
            ii(0x100a_acff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ad01, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_ad07, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_ad0a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_ad0d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_ad10, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_ad13, 5); call(0x1013_a2ab, 0x8_f593);            /* call 0x1013a2ab */
            ii(0x100a_ad18, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ad1a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ad1b, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ad1c, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ad1d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_ad1e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_ad1f, 1); ret();                                  /* ret */
        }
    }
}
