using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c5f8-f4142ffc")]
        public void Method_1013_c5f8()
        {
            ii(0x1013_c5f8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_c5fd, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9750);/* call 0x10165d52 */
            ii(0x1013_c602, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_c603, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_c604, 1);  push(esi);                            /* push esi */
            ii(0x1013_c605, 1);  push(edi);                            /* push edi */
            ii(0x1013_c606, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_c607, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_c609, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_c60f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c612, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_c615, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_c619, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c61c, 5);  call(0x1013_c630, 0xf);               /* call 0x1013c630 */
            ii(0x1013_c621, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_c624, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_c627, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_c629, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_c62a, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_c62b, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_c62c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_c62d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_c62e, 1);  ret();                                /* ret */
        }
    }
}
