using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9eb9-995586ef")]
        public void Method_100a_9eb9()
        {
            ii(0x100a_9eb9, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_9ebe, 5);  call(Definitions.sys_check_available_stack_size, 0xb_be8f);/* call 0x10165d52 */
            ii(0x100a_9ec3, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_9ec4, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_9ec5, 1);  push(edx);                            /* push edx */
            ii(0x100a_9ec6, 1);  push(esi);                            /* push esi */
            ii(0x100a_9ec7, 1);  push(edi);                            /* push edi */
            ii(0x100a_9ec8, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_9ec9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_9ecb, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_9ed1, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_9ed4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9ed7, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100a_9edc, 5);  call(0x100a_4550, -0x5991);           /* call 0x100a4550 */
            ii(0x100a_9ee1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_9ee3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_9ee4, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_9ee5, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_9ee6, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_9ee7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_9ee8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_9ee9, 1);  ret();                                /* ret */
        }
    }
}
