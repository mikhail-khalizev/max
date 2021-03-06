using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ab8c-fa2fa1a0")]
        public void Method_1008_ab8c()
        {
            ii(0x1008_ab8c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_ab91, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b1bc);/* call 0x10165d52 */
            ii(0x1008_ab96, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_ab97, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_ab98, 1);  push(edx);                            /* push edx */
            ii(0x1008_ab99, 1);  push(esi);                            /* push esi */
            ii(0x1008_ab9a, 1);  push(edi);                            /* push edi */
            ii(0x1008_ab9b, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_ab9c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_ab9e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_aba4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_aba7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_abaa, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_abac, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_abaf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_abb2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_abb4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_abb5, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_abb6, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_abb7, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_abb8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_abb9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_abba, 1);  ret();                                /* ret */
        }
    }
}
