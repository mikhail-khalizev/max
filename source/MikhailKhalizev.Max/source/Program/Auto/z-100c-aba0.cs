using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aba0-99085cb6")]
        public void Method_100c_aba0()
        {
            ii(0x100c_aba0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_aba5, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b1a8);/* call 0x10165d52 */
            ii(0x100c_abaa, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_abab, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_abac, 1);  push(edx);                            /* push edx */
            ii(0x100c_abad, 1);  push(esi);                            /* push esi */
            ii(0x100c_abae, 1);  push(edi);                            /* push edi */
            ii(0x100c_abaf, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_abb0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_abb2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_abb8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_abbb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_abbe, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x100c_abc1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_abc4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_abc7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_abc9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_abca, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_abcb, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_abcc, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_abcd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_abce, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_abcf, 1);  ret();                                /* ret */
        }
    }
}
