using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9c64-ba13dda6")]
        public void Method_1009_9c64()
        {
            ii(0x1009_9c64, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_9c69, 5);  call(Definitions.sys_check_available_stack_size, 0xc_c0e4);/* call 0x10165d52 */
            ii(0x1009_9c6e, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_9c6f, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_9c70, 1);  push(esi);                            /* push esi */
            ii(0x1009_9c71, 1);  push(edi);                            /* push edi */
            ii(0x1009_9c72, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_9c73, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_9c75, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_9c7b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9c7e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_9c81, 5);  mov(edx, StringDefinitions.PowerAssistant);/* mov edx, 0x101a068e */
            ii(0x1009_9c86, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9c89, 5);  call(Definitions.sys_strcpy, 0xc_c241);/* call 0x10165ecf */
            ii(0x1009_9c8e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9c91, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_9c94, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_9c97, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_9c99, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_9c9a, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_9c9b, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_9c9c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_9c9d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_9c9e, 1);  ret();                                /* ret */
        }
    }
}
