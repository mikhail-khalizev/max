using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a728-dd8b412c")]
        public void Method_1008_a728()
        {
            ii(0x1008_a728, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a72d, 5); call(Definitions.sys_check_available_stack_size, 0xd_b620); /* call 0x10165d52 */
            ii(0x1008_a732, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a733, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a734, 1); push(esi);                              /* push esi */
            ii(0x1008_a735, 1); push(edi);                              /* push edi */
            ii(0x1008_a736, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a737, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a739, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a73f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_a742, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_a745, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1008_a749, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1008_a74c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_a74e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_a751, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_a753, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_a755, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_a757, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_a75a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_a75d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a75f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a760, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a761, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a762, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a763, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a764, 1); ret();                                  /* ret */
        }
    }
}
