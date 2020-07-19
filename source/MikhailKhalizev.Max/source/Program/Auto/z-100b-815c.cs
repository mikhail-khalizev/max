using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_815c-b6374c57")]
        public void Method_100b_815c()
        {
            ii(0x100b_815c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100b_8161, 5);  call(Definitions.sys_check_available_stack_size, 0xa_dbec);/* call 0x10165d52 */
            ii(0x100b_8166, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_8167, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_8168, 1);  push(esi);                            /* push esi */
            ii(0x100b_8169, 1);  push(edi);                            /* push edi */
            ii(0x100b_816a, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_816b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_816d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100b_8173, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_8176, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_8179, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_817c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_817f, 5);  call(0x1013_abc3, 0x8_2a3f);          /* call 0x1013abc3 */
            ii(0x100b_8184, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_8187, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_818a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_818d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8190, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_8193, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_8196, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_8198, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_8199, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_819a, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_819b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_819c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_819d, 1);  ret();                                /* ret */
        }
    }
}
