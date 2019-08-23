using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2fe6-3e1f7870")]
        public void Method_100a_2fe6()
        {
            ii(0x100a_2fe6, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_2feb, 5); call(Definitions.sys_check_available_stack_size, 0xc_2d62); /* call 0x10165d52 */
            ii(0x100a_2ff0, 1); push(ebx);                              /* push ebx */
            ii(0x100a_2ff1, 1); push(ecx);                              /* push ecx */
            ii(0x100a_2ff2, 1); push(esi);                              /* push esi */
            ii(0x100a_2ff3, 1); push(edi);                              /* push edi */
            ii(0x100a_2ff4, 1); push(ebp);                              /* push ebp */
            ii(0x100a_2ff5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2ff7, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2ffd, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_3000, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_3003, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3005, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3006, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3007, 1); pop(esi);                               /* pop esi */
            ii(0x100a_3008, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_3009, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_300a, 1); ret();                                  /* ret */
        }
    }
}
