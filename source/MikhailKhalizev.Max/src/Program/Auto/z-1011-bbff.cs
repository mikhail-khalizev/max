using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bbff-e5411df3")]
        public void Method_1011_bbff()
        {
            ii(0x1011_bbff, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_bc04, 5); call(Definitions.sys_check_available_stack_size, 0x4_a149); /* call 0x10165d52 */
            ii(0x1011_bc09, 1); push(ecx);                              /* push ecx */
            ii(0x1011_bc0a, 1); push(esi);                              /* push esi */
            ii(0x1011_bc0b, 1); push(edi);                              /* push edi */
            ii(0x1011_bc0c, 1); push(ebp);                              /* push ebp */
            ii(0x1011_bc0d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bc0f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_bc15, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_bc18, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1011_bc1b, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_bc1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bc20, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_bc21, 1); pop(edi);                               /* pop edi */
            ii(0x1011_bc22, 1); pop(esi);                               /* pop esi */
            ii(0x1011_bc23, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_bc24, 1); ret();                                  /* ret */
        }
    }
}
