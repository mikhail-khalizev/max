using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7cbc-d73a31b4")]
        public void Method_100b_7cbc()
        {
            ii(0x100b_7cbc, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100b_7cc1, 5);  call(Definitions.sys_check_available_stack_size, 0xa_e08c);/* call 0x10165d52 */
            ii(0x100b_7cc6, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7cc7, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7cc8, 1);  push(edx);                            /* push edx */
            ii(0x100b_7cc9, 1);  push(esi);                            /* push esi */
            ii(0x100b_7cca, 1);  push(edi);                            /* push edi */
            ii(0x100b_7ccb, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7ccc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7cce, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_7cd4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7cd7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7cda, 5);  call(0x1013_a0af, 0x8_23d0);          /* call 0x1013a0af */
            ii(0x100b_7cdf, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7ce2, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100b_7ce5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7ce8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7ceb, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_7cee, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_7cf1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7cf3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7cf4, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7cf5, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7cf6, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_7cf7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7cf8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7cf9, 1);  ret();                                /* ret */
        }
    }
}
