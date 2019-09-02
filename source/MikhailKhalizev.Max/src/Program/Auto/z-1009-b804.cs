using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b804-fe62bb8a")]
        public void Method_1009_b804()
        {
            ii(0x1009_b804, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_b809, 5); call(Definitions.sys_check_available_stack_size, 0xc_a544); /* call 0x10165d52 */
            ii(0x1009_b80e, 1); push(ebx);                              /* push ebx */
            ii(0x1009_b80f, 1); push(ecx);                              /* push ecx */
            ii(0x1009_b810, 1); push(esi);                              /* push esi */
            ii(0x1009_b811, 1); push(edi);                              /* push edi */
            ii(0x1009_b812, 1); push(ebp);                              /* push ebp */
            ii(0x1009_b813, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b815, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b81b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_b81e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_b821, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_b824, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_b827, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_b82a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b82c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_b82d, 1); pop(edi);                               /* pop edi */
            ii(0x1009_b82e, 1); pop(esi);                               /* pop esi */
            ii(0x1009_b82f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_b830, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_b831, 1); ret();                                  /* ret */
        }
    }
}
