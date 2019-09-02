using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ac80-268986fd")]
        public void Method_100a_ac80()
        {
            ii(0x100a_ac80, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_ac85, 5); call(Definitions.sys_check_available_stack_size, 0xb_b0c8); /* call 0x10165d52 */
            ii(0x100a_ac8a, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ac8b, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ac8c, 1); push(esi);                              /* push esi */
            ii(0x100a_ac8d, 1); push(edi);                              /* push edi */
            ii(0x100a_ac8e, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ac8f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ac91, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_ac97, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_ac9a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_ac9d, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100a_aca1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_aca4, 5); call(0x1013_a854, 0x8_fbab);            /* call 0x1013a854 */
            ii(0x100a_aca9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_acac, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_acaf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_acb1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_acb2, 1); pop(edi);                               /* pop edi */
            ii(0x100a_acb3, 1); pop(esi);                               /* pop esi */
            ii(0x100a_acb4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_acb5, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_acb6, 1); ret();                                  /* ret */
        }
    }
}
