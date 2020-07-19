using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_bd92-6ce9c693")]
        public void Method_1010_bd92()
        {
            ii(0x1010_bd92, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_bd97, 5);  call(Definitions.sys_check_available_stack_size, 0x5_9fb6);/* call 0x10165d52 */
            ii(0x1010_bd9c, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_bd9d, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_bd9e, 1);  push(edx);                            /* push edx */
            ii(0x1010_bd9f, 1);  push(esi);                            /* push esi */
            ii(0x1010_bda0, 1);  push(edi);                            /* push edi */
            ii(0x1010_bda1, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_bda2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_bda4, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_bdaa, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_bdad, 5);  call(0x100d_4e6c, -0x3_6f46);         /* call 0x100d4e6c */
            ii(0x1010_bdb2, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_bdb4, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1010_bdb6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_bdb8, 5);  mov(eax, 0x1c);                       /* mov eax, 0x1c */
            ii(0x1010_bdbd, 5);  call(0x1010_5b00, -0x62c2);           /* call 0x10105b00 */
            ii(0x1010_bdc2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_bdc4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_bdc5, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_bdc6, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_bdc7, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_bdc8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_bdc9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_bdca, 1);  ret();                                /* ret */
        }
    }
}
