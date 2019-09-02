using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a8c4-f9562827")]
        public void Method_100a_a8c4()
        {
            ii(0x100a_a8c4, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_a8c9, 5); call(Definitions.sys_check_available_stack_size, 0xb_b484); /* call 0x10165d52 */
            ii(0x100a_a8ce, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a8cf, 1); push(esi);                              /* push esi */
            ii(0x100a_a8d0, 1); push(edi);                              /* push edi */
            ii(0x100a_a8d1, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a8d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a8d4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a8da, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_a8dd, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_a8e0, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100a_a8e3, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_a8e7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_a8ea, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_a8ed, 5); call(0x1013_b0f9, 0x9_0807);            /* call 0x1013b0f9 */
            ii(0x100a_a8f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a8f4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a8f5, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a8f6, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a8f7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a8f8, 1); ret();                                  /* ret */
        }
    }
}
