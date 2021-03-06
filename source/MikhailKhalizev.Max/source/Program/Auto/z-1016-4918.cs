using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4918-c09c137c")]
        public void Method_1016_4918()
        {
            ii(0x1016_4918, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1016_491d, 5);  call(Definitions.sys_check_available_stack_size, 0x1430);/* call 0x10165d52 */
            ii(0x1016_4922, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_4923, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_4924, 1);  push(esi);                            /* push esi */
            ii(0x1016_4925, 1);  push(edi);                            /* push edi */
            ii(0x1016_4926, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_4927, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_4929, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_492f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4932, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_4935, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1016_4939, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_493c, 5);  call(0x1013_b052, -0x2_98ef);         /* call 0x1013b052 */
            ii(0x1016_4941, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4944, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1016_4947, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_494a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_494d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_4950, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_4953, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_4955, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_4956, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_4957, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_4958, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_4959, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_495a, 1);  ret();                                /* ret */
        }
    }
}
