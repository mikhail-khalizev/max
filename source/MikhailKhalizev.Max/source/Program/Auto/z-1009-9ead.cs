using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9ead-aba84de5")]
        public void Method_1009_9ead()
        {
            ii(0x1009_9ead, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_9eb2, 5);  call(Definitions.sys_check_available_stack_size, 0xc_be9b);/* call 0x10165d52 */
            ii(0x1009_9eb7, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_9eb8, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_9eb9, 1);  push(edx);                            /* push edx */
            ii(0x1009_9eba, 1);  push(esi);                            /* push esi */
            ii(0x1009_9ebb, 1);  push(edi);                            /* push edi */
            ii(0x1009_9ebc, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_9ebd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_9ebf, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_9ec5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_9ec8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9ecb, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_9ece, 5);  call(0x1009_c3c0, 0x24ed);            /* call 0x1009c3c0 */
            ii(0x1009_9ed3, 5);  call(0x1009_3ce2, -0x61f6);           /* call 0x10093ce2 */
            ii(0x1009_9ed8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_9eda, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_9edb, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_9edc, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_9edd, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_9ede, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_9edf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_9ee0, 1);  ret();                                /* ret */
        }
    }
}
