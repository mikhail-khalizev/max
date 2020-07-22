using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c41c-10705259")]
        public void Method_1009_c41c()
        {
            ii(0x1009_c41c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_c421, 5);  call(Definitions.sys_check_available_stack_size, 0xc_992c);/* call 0x10165d52 */
            ii(0x1009_c426, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c427, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c428, 1);  push(edx);                            /* push edx */
            ii(0x1009_c429, 1);  push(esi);                            /* push esi */
            ii(0x1009_c42a, 1);  push(edi);                            /* push edi */
            ii(0x1009_c42b, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c42c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c42e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_c434, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c437, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c43a, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_c43c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c43f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c442, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c444, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c445, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c446, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c447, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_c448, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c449, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c44a, 1);  ret();                                /* ret */
        }
    }
}
