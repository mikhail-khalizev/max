using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_952d-473193ca")]
        public void Method_1015_952d()
        {
            ii(0x1015_952d, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_9532, 5);  call(Definitions.sys_check_available_stack_size, 0xc81b);/* call 0x10165d52 */
            ii(0x1015_9537, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_9538, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_9539, 1);  push(esi);                            /* push esi */
            ii(0x1015_953a, 1);  push(edi);                            /* push edi */
            ii(0x1015_953b, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_953c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_953e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_9544, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9547, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_954a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_954d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_9550, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_9555, 5);  call(0x100f_448c, -0x6_50ce);         /* call 0x100f448c */
            ii(0x1015_955a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_955d, 5);  call(0x100f_3f62, -0x6_5600);         /* call 0x100f3f62 */
            ii(0x1015_9562, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_9565, 5);  call(0x100f_fa70, -0x5_9afa);         /* call 0x100ffa70 */
            ii(0x1015_956a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_956c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_956d, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_956e, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_956f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_9570, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_9571, 1);  ret();                                /* ret */
        }
    }
}
