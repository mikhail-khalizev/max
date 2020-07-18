using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ace3-73a27b82")]
        public void Method_1011_ace3()
        {
            ii(0x1011_ace3, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_ace8, 5);  call(Definitions.sys_check_available_stack_size, 0x4_b065);/* call 0x10165d52 */
            ii(0x1011_aced, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_acee, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_acef, 1);  push(esi);                            /* push esi */
            ii(0x1011_acf0, 1);  push(edi);                            /* push edi */
            ii(0x1011_acf1, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_acf2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_acf4, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_acfa, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_acfd, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_ad00, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_ad02, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_ad03, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_ad04, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_ad05, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_ad06, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_ad07, 1);  ret();                                /* ret */
        }
    }
}
