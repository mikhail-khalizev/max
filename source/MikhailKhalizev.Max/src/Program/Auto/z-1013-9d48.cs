using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9d48-2716f091")]
        public void Method_1013_9d48()
        {
            ii(0x1013_9d48, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_9d4d, 5);  call(Definitions.sys_check_available_stack_size, 0x2_c000);/* call 0x10165d52 */
            ii(0x1013_9d52, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_9d53, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_9d54, 1);  push(esi);                            /* push esi */
            ii(0x1013_9d55, 1);  push(edi);                            /* push edi */
            ii(0x1013_9d56, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_9d57, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_9d59, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_9d5f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_9d62, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_9d65, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_9d6a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9d6d, 5);  call(0x1013_9ccc, -0xa6);             /* call 0x10139ccc */
            ii(0x1013_9d72, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_9d75, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9d78, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_9d7b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_9d7e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_9d80, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_9d81, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_9d82, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_9d83, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_9d84, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_9d85, 1);  ret();                                /* ret */
        }
    }
}
