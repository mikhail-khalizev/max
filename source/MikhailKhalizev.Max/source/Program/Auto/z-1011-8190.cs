using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8190-c81b5714")]
        public void Method_1011_8190()
        {
            ii(0x1011_8190, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_8195, 5);  call(Definitions.sys_check_available_stack_size, 0x4_dbb8);/* call 0x10165d52 */
            ii(0x1011_819a, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_819b, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_819c, 1);  push(esi);                            /* push esi */
            ii(0x1011_819d, 1);  push(edi);                            /* push edi */
            ii(0x1011_819e, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_819f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_81a1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_81a7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_81aa, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_81ad, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_81af, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_81b0, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_81b1, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_81b2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_81b3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_81b4, 1);  ret();                                /* ret */
        }
    }
}
