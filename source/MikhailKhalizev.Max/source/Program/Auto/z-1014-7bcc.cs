using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7bcc-4b329d8b")]
        public void Method_1014_7bcc()
        {
            ii(0x1014_7bcc, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_7bd1, 5);  call(Definitions.sys_check_available_stack_size, 0x1_e17c);/* call 0x10165d52 */
            ii(0x1014_7bd6, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7bd7, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7bd8, 1);  push(esi);                            /* push esi */
            ii(0x1014_7bd9, 1);  push(edi);                            /* push edi */
            ii(0x1014_7bda, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7bdb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7bdd, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_7be3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7be6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_7be9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_7bec, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7bef, 5);  call(0x1013_abc3, -0xd031);           /* call 0x1013abc3 */
            ii(0x1014_7bf4, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7bf7, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1014_7bfa, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_7bfd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7c00, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_7c03, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_7c06, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_7c08, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7c09, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7c0a, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7c0b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7c0c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_7c0d, 1);  ret();                                /* ret */
        }
    }
}
