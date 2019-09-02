using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a774-ac555fad")]
        public void Method_100a_a774()
        {
            ii(0x100a_a774, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_a779, 5); call(Definitions.sys_check_available_stack_size, 0xb_b5d4); /* call 0x10165d52 */
            ii(0x100a_a77e, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a77f, 1); push(esi);                              /* push esi */
            ii(0x100a_a780, 1); push(edi);                              /* push edi */
            ii(0x100a_a781, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a782, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a784, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a78a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_a78d, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_a790, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100a_a793, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_a797, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_a79a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_a79d, 5); call(0x100c_d990, 0x2_31ee);            /* call 0x100cd990 */
            ii(0x100a_a7a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a7a4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a7a5, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a7a6, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a7a7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a7a8, 1); ret();                                  /* ret */
        }
    }
}
